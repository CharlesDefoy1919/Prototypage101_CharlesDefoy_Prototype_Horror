using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallLight : MonoBehaviour
{
	Light Lt;

	float originalIntensity;

	public bool LightOn = false;

	// Start is called before the first frame update
	void Start()
	{
		Lt = GetComponent<Light>();
		originalIntensity = Lt.intensity;



	}

	private void OnTriggerStay(Collider collider)
	{

		if ((collider.gameObject.tag == "Player") && Input.GetKeyDown(KeyCode.R))
		{
			LightOn = true;



		}
	}


	private void Update()
	{
		if (LightOn == true)

			Lt.intensity = 2000f;
	}

}
