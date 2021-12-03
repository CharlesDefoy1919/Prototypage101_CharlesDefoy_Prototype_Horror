using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JayScript : MonoBehaviour
{
	#region Variables
	public int MaxBar = 100;
	public int CurrentBar;
	public fuelBar UiBar;
	public float FuelRate = 0.08f;
	public Lantern LanternScript;
	public int FuelLost = 1;

	private bool canTake = true;
	private Rigidbody rbPlayer;




	#endregion

	void Start()
	{
		//Bar max en commancant le jeu
		CurrentBar = MaxBar;
		UiBar.SetMaxFuel(MaxBar);
		rbPlayer = this.GetComponent<Rigidbody>();
		LanternScript = GetComponentInChildren<Lantern>();
	}

	private void Update()
	{
		// Perde du fuel par seconde
		// (1/3)
		if (canTake == true)
		{
			TakeDamage(FuelLost * ((int)LanternScript.Lt.range) / 4);
			canTake = false;
			StartCoroutine(WaitToTake());
		}
	}
	IEnumerator WaitToTake()
	{
		// (2/3)
		yield return new WaitForSeconds(FuelRate);
		canTake = true;
	}

	void TakeDamage(int damage)
	{
		// (3/3)
		CurrentBar -= damage;
		UiBar.SetFuel(CurrentBar);
	}
}