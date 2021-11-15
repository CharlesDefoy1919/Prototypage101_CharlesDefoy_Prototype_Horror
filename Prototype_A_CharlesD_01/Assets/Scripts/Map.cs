using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map : MonoBehaviour
{
	#region variables

	public float MapHeightUp = 2;
	public float MapHeightDown = -2;

	public Component Mrender;

	#endregion


	// Start is called before the first frame update
	void Start()
	{
		Mrender = GetComponent<MeshRenderer>(); 
	}
	// Update is called once per frame
	void Update()
	{
		// Map positon up to appear on screen gradually
		if(Input.GetKeyDown(KeyCode.M))
		{
			if (gameObject.GetComponent<MeshRenderer>() != null)
			{
				//gameObject.GetComponent<MeshRenderer>() = null;

				Debug.Log("Map Appeared");
			}
		}
	}
}







