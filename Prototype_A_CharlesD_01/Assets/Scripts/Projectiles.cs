using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Projectiles : MonoBehaviour
{
	#region  Variables

	public GameObject projectile;

	public float speed;

	public float rotationspeed;

	public float rotationspeedr;

	Camera myCam;

	public Transform flareSpawn;

	public float lightr = 0.1f;

	public int nbrOfFlares;

	public Text flareNbr;

	private Text fn;

	#endregion

	// Start is called before the first frame update
	void Start()
	{
		myCam = transform.parent.GetComponentInChildren<Camera>();

		nbrOfFlares = 1;

		fn = flareNbr.GetComponent<Text>();
	}

	// Update is called once per frame
	void Update()
	{
		// shows int on canvas (UI)
		fn.text = nbrOfFlares.ToString();
			
		//left click throws projectiles
		if (Input.GetKeyDown(KeyCode.Mouse0))
		{
			//restricted by number of picked up item
			if (nbrOfFlares >= 1)
			{
				ProjectileThrow();
			}
		}
	}

	// throw function
	public void ProjectileThrow()
	{

		//insantiate and forces
		var instance = Instantiate(projectile, flareSpawn.position, Quaternion.identity);
		instance.GetComponent<Rigidbody>().AddForce((myCam.transform.forward * speed));
		instance.GetComponent<Rigidbody>().AddTorque(transform.forward * rotationspeed);
		instance.GetComponent<Rigidbody>().AddTorque(transform.right * rotationspeedr);

		//lose one projectile
		nbrOfFlares -= 1;
	}
}
	
	
