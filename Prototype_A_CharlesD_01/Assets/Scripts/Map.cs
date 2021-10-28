using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map : MonoBehaviour
{
	#region variables

	public float MapHeightUp = 2;
	public float MapHeightDown = -2;

	#endregion


	// Start is called before the first frame update
	void Start()
	{
		//mrender = GetComponent<MeshRenderer>(); ------ I'm trying to make the object disappear

	}
	// Update is called once per frame
	void Update()
	{
		// Map positon up to appear on screen gradually

		if (Input.GetKeyDown(KeyCode.M) && transform.position.y != 2)
		{
			transform.position = new Vector3(gameObject.transform.position.x, MapHeightUp, gameObject.transform.position.z);

			Debug.Log("Map Appeared");
		}



		// if "m" is pressed again while map is showed hide it

		else if (Input.GetKeyDown(KeyCode.M))
		{
			transform.position = new Vector3(gameObject.transform.position.x, MapHeightDown, gameObject.transform.position.z);

			Debug.Log("Map Disappeared");
		}

		// code works when you spam "M" Im not sure I unserstand...

	}

}






