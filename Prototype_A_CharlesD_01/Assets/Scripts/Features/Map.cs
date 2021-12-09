using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map : MonoBehaviour
{
	#region variables

	public GameObject MapGO;

	private MeshRenderer mRender;

	#endregion

	#region Messages

	// Start is called before the first frame update
	void Start()
	{
		mRender = MapGO.GetComponentInChildren<MeshRenderer>();
	}
	// Update is called once per frame
	void Update()
	{
		if(Input.GetKeyDown(KeyCode.M))
		{
			MapAppears();
		}
	}

	#endregion

	#region Function

	void MapAppears() // shows and hides map
	{
		mRender.enabled = !mRender.enabled;
	}

	#endregion
}







