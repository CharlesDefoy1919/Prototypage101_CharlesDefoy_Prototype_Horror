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

	// Start is called before the first frame update
	void Start()
	{
		Lt = GetComponent<Light>();
		originalRange = Lt.range;

		LightCol = GetComponent<CapsuleCollider>();
		Radius = LightCol.radius;

	}

	// Update is called once per frame
	void Update()
	{



		if ((Lt.range <= 30) && Input.GetKeyDown(KeyCode.E))
		{

			Lt.range += 3;

			Debug.Log("Expend_Light");
		}




		if (Input.GetKeyDown(KeyCode.Q))
		{

			Lt.range -= 3;

			Debug.Log("Retract_Light");
		}


		LightCol.radius = Lt.range;


		// var amplitude = Mathf.PingPong(Time.time, duration);


		// amplitude = amplitude / duration * 0.5f + 0.5f;

		// Lt.range = originalRange * amplitude; 


	}
}
