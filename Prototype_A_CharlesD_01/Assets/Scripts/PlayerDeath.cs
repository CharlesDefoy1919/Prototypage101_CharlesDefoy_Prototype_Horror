using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeath : MonoBehaviour
{

	public bool playerDefeated = false;

	// Start is called before the first frame update
	void Start()
	{
		
	}

	// Update is called once per frame
	void Update()
	{
		if (playerDefeated)
		{
			Defeated();
		}
	}

	private void OnCollisionEnter(Collision collision)
	{
		if (gameObject.tag == "Enemy")
		{
			playerDefeated = true;
		}
	}

	private void Defeated()
	{
		Destroy(GameObject.FindGameObjectWithTag("Player"));

		Debug.Log("Defeated");
	}

}
