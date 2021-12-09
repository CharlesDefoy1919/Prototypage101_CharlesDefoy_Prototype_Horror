using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Projectiles : MonoBehaviour
{
	#region  Variables

	public GameObject Projectile;
	public float Speed;
	public float RotationSpeed;
	public float RotationSpeedr;
	public Transform FlareSpawn;
	public float Lightr = 0.1f;
	public int NbrOfFlares;
	public Text FlareNbr;

	private Text fn;
	Camera myCam;

	#endregion

	#region Variables

	// Start is called before the first frame update
	void Start()
	{
		myCam = transform.parent.GetComponentInChildren<Camera>();

		NbrOfFlares = 1;

		fn = FlareNbr.GetComponent<Text>();
	}

	// Update is called once per frame
	void Update()
	{
		// shows int on canvas (UI)
		fn.text = NbrOfFlares.ToString();
			
		//left click throws projectiles
		if (Input.GetKeyDown(KeyCode.Mouse0))
		{
			//restricted by number of picked up item
			if (NbrOfFlares >= 1)
			{
				ProjectileThrow();
			}
		}
	}

	#endregion

	#region Functions

	// throw function
	public void ProjectileThrow()
	{
		//insantiate and forces
		var instance = Instantiate(Projectile, FlareSpawn.position, Quaternion.identity);
		instance.GetComponent<Rigidbody>().AddForce((myCam.transform.forward * Speed));
		instance.GetComponent<Rigidbody>().AddTorque(transform.forward * RotationSpeed);
		instance.GetComponent<Rigidbody>().AddTorque(transform.right * RotationSpeedr);

		//lose one projectile
		NbrOfFlares -= 1;
	}

	#endregion
}


