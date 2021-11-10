using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectiles : MonoBehaviour
{
	#region  Variables

	public GameObject projectile;

	//public Rigidbody rbflare;

	//public Vector3 pf = new Vector3(10f, 3f, 0);

	public float speed;

	public float rotationspeed;

	public float rotationspeedr;

	//public Vector3 CamPos;

	//private Vector3 CameraPos;

	Camera myCam;

	public Transform flareSpawn;

	#endregion

	// Start is called before the first frame update
	void Start()
	{
		//CameraPos = GameObject.FindGameObjectWithTag("Camera").transform.position;

		//CamPos = new Vector3;

		myCam = transform.parent.GetComponentInChildren<Camera>();

	}

	// Update is called once per frame
	void Update()
	{

		if (Input.GetKeyDown(KeyCode.Mouse0))
		{

			var instance = Instantiate(projectile, flareSpawn.position, Quaternion.identity);
			instance.GetComponent<Rigidbody>().AddForce((myCam.transform.forward * speed));
			instance.GetComponent<Rigidbody>().AddTorque(transform.forward * rotationspeed);
			instance.GetComponent<Rigidbody>().AddTorque(transform.right * rotationspeedr);
			

			//ProjectileThrow();
		}
	}

	void ProjectileThrow()
	{
		//Rigidbody rbflare;

		//rbflare = Instantiate(projectile, transform.position, Quaternion.identity) as Rigidbody;
		//rbflare.AddForce(pf, ForceMode.Impulse);
	}
}
