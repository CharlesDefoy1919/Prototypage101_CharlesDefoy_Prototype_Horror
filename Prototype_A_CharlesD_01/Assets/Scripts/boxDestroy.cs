using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class boxDestroy : MonoBehaviour
{
	private Rigidbody rb;
	private Rigidbody[] parts;
	private bool sleeping;

	public Projectiles projectileScript;

	public JayScript scriptFuel;
	//public int MaxBarF;

	private bool flaresGiven;



	// The box can have a list of gameobject that spawn randomly between the two pickups (fuel and flares) do with scriptable objects?

	private void Awake()
	{
		parts = this.gameObject.GetComponentsInChildren<Rigidbody>();
		foreach (var item in parts)
		{
			item.isKinematic = true;
		}
	}




	// Start is called before the first frame update
	void Start()
	{
		projectileScript = GameObject.Find("Flare").GetComponent<Projectiles>();
		scriptFuel = GameObject.Find("PlayerReal").GetComponent<JayScript>();

		rb = gameObject.GetComponent<Rigidbody>();
		sleeping = false;
	}

	// Update is called once per frame
	void Update()
	{
		//scriptFuel.MaxBar = MaxBarF;

	}

	private void OnTriggerEnter(Collider collider)
	{
		if (collider.gameObject.tag == "Player") 
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

	public void GiveFlares()
	{
		projectileScript.nbrOfFlares += 5;
	}

	public void GiveGas()
	{ 
		//Part of Jay's Script gives fuel back

		scriptFuel.UiBar.SetMaxFuel(scriptFuel.MaxBar);
		scriptFuel.CurrentBar = scriptFuel.MaxBar;

		Debug.Log("Here's your Gas Homie");
	} 

}


