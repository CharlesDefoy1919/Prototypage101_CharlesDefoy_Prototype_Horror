using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unused : MonoBehaviour
{

	public bool Croissant = true;
	public int CrNbr = 0;

	float CrsDelisious;

	// Start is called before the first frame update
	void Start()
	{
		while (Croissant == true)
		{


			CrNbr++;
			Debug.Log("Croissant Number" + CrNbr.ToString());

			if (CrNbr >= 26)
			{
				Debug.Log("Many Croissants");

				break;
			}

			switch (CrNbr)
			{
				case 5:

					Debug.Log("5 croissants");
					break;

				case 20:

					Debug.Log("20 croissants");
					break;

				default:
					break;


			}

		}

		for (float CrsDelicious = 40; CrsDelicious >= 20; CrsDelicious -= 2)
		{
			Debug.Log("Croissant Deliciousness Factor " + CrsDelicious.ToString());

			if (CrsDelicious == 20)
			{
				Debug.Log("Croissant Deliciousness back to normal");

			}








		}



	}

	// Update is called once per frame
	void Update()
	{

	}
}
