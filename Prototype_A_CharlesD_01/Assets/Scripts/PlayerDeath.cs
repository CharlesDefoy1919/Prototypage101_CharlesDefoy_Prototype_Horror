using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerDeath : MonoBehaviour
{
	#region Variables

	public bool playerDefeated = false;

	GameObject player;

	#endregion
	// Start is called before the first frame update
	void Start()
	{
		player = GameObject.FindGameObjectWithTag("Player");
	}

	// Update is called once per frame
	void Update()
	{
		if (playerDefeated)
		{
			Defeated();
		}
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Player")
		{
			playerDefeated = true;
		}
	}

	private void Defeated()
	{
		Destroy(player);

		Debug.Log("Defeated");
	}

}
