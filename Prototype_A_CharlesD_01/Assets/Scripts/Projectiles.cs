using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectiles : MonoBehaviour
{
	#region  Variables

	public GameObject projectile;

	public float speed;

	public float rotationspeed;

	public float rotationspeedr;

	Camera myCam;

	public Transform flareSpawn;

	#endregion

	// Start is called before the first frame update
	void Start()
	{
		myCam = transform.parent.GetComponentInChildren<Camera>();
	}

	// Update is called once per frame
	void Update()
	{
		if (Input.GetKeyDown(KeyCode.Mouse0))
		{
			ProjectileThrow();
		}
	}

	void ProjectileThrow()
	{
		var instance = Instantiate(projectile, flareSpawn.position, Quaternion.identity);
		instance.GetComponent<Rigidbody>().AddForce((myCam.transform.forward * speed));
		instance.GetComponent<Rigidbody>().AddTorque(transform.forward * rotationspeed);
		instance.GetComponent<Rigidbody>().AddTorque(transform.right * rotationspeedr);

	}
}
