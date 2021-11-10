using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box_destroy : MonoBehaviour
{
	private Rigidbody rb;
	private bool sleeping;
	private Rigidbody[] parts;


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


		rb = gameObject.GetComponent<Rigidbody>();
		sleeping = false;
	}

	// Update is called once per frame
	void Update()
	{

	}

	private void OnTriggerEnter(Collider collider)
	{
		if (collider.gameObject.tag == "Player") 
		{
			Rigidbody[] parts = this.gameObject.GetComponentsInChildren<Rigidbody>();

			foreach (var item in parts)
			{
				item.isKinematic = false;
			}
		}

	}

}


