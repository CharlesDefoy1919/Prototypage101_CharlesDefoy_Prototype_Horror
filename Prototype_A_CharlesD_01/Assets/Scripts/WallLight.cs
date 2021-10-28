using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallLight : MonoBehaviour
{
	Light Lt;

	float originalIntensity;

	public bool LightOn = false;

	public float lightintensity = 2000f;

	// Start is called before the first frame update
	void Start()
	{
		//refer to the light on which the script is on

		Lt = GetComponent<Light>();
		originalIntensity = Lt.intensity;



	}

	private void OnTriggerStay(Collider collider)
	{
		// if the player in in the collider range and presses "R" then the lights turns on

		if ((collider.gameObject.tag == "Player") && Input.GetKeyDown(KeyCode.R))
		{
			LightOn = true;
		}
	}


	private void Update()
	{

		// sets the linght intensity :)

		if (LightOn == true)

		Lt.intensity = lightintensity;
	}

}
