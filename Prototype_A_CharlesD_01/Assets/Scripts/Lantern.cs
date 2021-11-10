using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lantern : MonoBehaviour
{
	float duration = 3.0f;
	float originalRange;

	Light Lt;

	CapsuleCollider LightCol;
	float Radius;

	public float Lightr = 3.0f;

	// Start is called before the first frame update
	void Start()
	{
		//refer to the light on which the script is on and its component settings

		Lt = GetComponent<Light>();
		originalRange = Lt.range;

		//refer to the collider on the player which is used for the light detection on the ai
		LightCol = GetComponent<CapsuleCollider>();
		Radius = LightCol.radius;

	}

	// Update is called once per frame
	void Update()
	{

		//let's the player expend the radius of the light up to a maximum of 30

		if ((Lt.range <= 30) && Input.GetKeyDown(KeyCode.E))
		{

			Lt.range += Lightr;

			Debug.Log("Expend_Light");
		}


		//let's the player decrease the light radius

		if (Input.GetKeyDown(KeyCode.Q))
		{

			Lt.range -= Lightr;

			Debug.Log("Retract_Light");
		}

		//the light radius matches the collider 

		LightCol.radius = Lt.range;


		//------ test to make light flicker -->

		// var amplitude = Mathf.PingPong(Time.time, duration);


		// amplitude = amplitude / duration * 0.5f + 0.5f;

		// Lt.range = originalRange * amplitude; 


	}
}
