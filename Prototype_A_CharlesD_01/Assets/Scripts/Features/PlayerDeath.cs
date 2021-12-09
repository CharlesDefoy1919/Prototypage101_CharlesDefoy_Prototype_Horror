using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerDeath : MonoBehaviour
{
	#region Variables

	public bool playerDefeated = false;

	GameObject player;

	public GameObject Gm;

	public Text YouDied;

	private Text deathText;

	#endregion

	#region Messages

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

	#endregion

	#region Functions

	public void Defeated()
	{
		Gm.GetComponent<GameManager1>().AddGameplayed();
		SceneManager.LoadScene(0);

		Debug.Log("Defeated");
	}

	#endregion
}
