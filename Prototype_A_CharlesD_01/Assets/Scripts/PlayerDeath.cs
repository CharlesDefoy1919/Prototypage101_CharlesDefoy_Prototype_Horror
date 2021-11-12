using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeath : MonoBehaviour
{

	public bool playerDefeated = false;
	public GameObject Enemy;

	private Collider Enemycol;

	// Start is called before the first frame update
	void Start()
	{
		Enemycol = Enemy.GetComponent<Collider>();
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

		if (other = Enemycol)
		{
			playerDefeated = true;
		}
	}

	private void Defeated()
	{
		Destroy(gameObject);

		Debug.Log("Defeated");
	}

}
