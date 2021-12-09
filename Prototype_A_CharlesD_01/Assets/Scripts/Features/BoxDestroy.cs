using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BoxDestroy : MonoBehaviour
{
	#region Variables

	public Projectiles ProjectileScript;
	public JayScript ScriptFuel;

	private bool flaresGiven;
	private Rigidbody rb;
	private Rigidbody[] parts; //list of Rigidbody components of each parts of the box
	private bool sleeping;

	#endregion

	#region Messages

	private void Awake()
	{
		//On script call set all rigidbody component for each part of the box to kinematic so it stay frozen in place until interaction

		parts = this.gameObject.GetComponentsInChildren<Rigidbody>();
		foreach (var item in parts)
		{
			item.isKinematic = true;
		}
	}

	// Start is called before the first frame update
	void Start()
	{
		ProjectileScript = GameObject.Find("Flare").GetComponent<Projectiles>();
		ScriptFuel = GameObject.Find("PlayerReal").GetComponent<JayScript>();

		rb = gameObject.GetComponent<Rigidbody>();
		sleeping = false;
	}

	private void OnTriggerEnter(Collider collider)
	{
		if (collider.gameObject.tag == "Player")  // on collision with the player give him the gas and flare (Only give 5 flare once) and let the  box part fall (Kinematic to false)
		{
			if (flaresGiven == false)
			{
				Debug.Log("YOU GOT YOUR FLARES OK?");

				GiveFlares();

				GiveGas();

				flaresGiven = true;      
			}

			Rigidbody[] parts = this.gameObject.GetComponentsInChildren<Rigidbody>();

			foreach (var item in parts)
			{
				item.isKinematic = false;
			}
		}

	}

#endregion

	#region Functions

	public void GiveFlares()  // gives the player 5 flares
	{
		ProjectileScript.NbrOfFlares += 5;
	}

	public void GiveGas()
	{ 
		//Part of Jay's Script gives fuel back

		ScriptFuel.UiBar.SetMaxFuel(ScriptFuel.MaxBar);
		ScriptFuel.CurrentBar = ScriptFuel.MaxBar;

		Debug.Log("Here's your Gas Homie");
	}

	#endregion
}


