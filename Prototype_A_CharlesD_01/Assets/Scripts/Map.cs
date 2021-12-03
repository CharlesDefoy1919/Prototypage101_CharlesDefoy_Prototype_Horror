using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map : MonoBehaviour
{
	#region variables

	public float MapHeightUp = 2;
	public float MapHeightDown = -2;

	private MeshRenderer mRender;

	private MeshRenderer bRender;

	public GameObject map;

	public GameObject Boussole;


	#endregion


	// Start is called before the first frame update
	void Start()
	{
		mRender = map.GetComponentInChildren<MeshRenderer>();

		bRender = Boussole.GetComponentInChildren<MeshRenderer>();
	}
	// Update is called once per frame
	void Update()
	{
		// Map positon up to appear on screen gradually
		if(Input.GetKeyDown(KeyCode.M))
		{
			MapAppears();
		}

		if (Input.GetKeyDown(KeyCode.B))
		{
			BoussoleAppears();
		}

		if (mRender.enabled && Input.GetKeyDown(KeyCode.B))
		{
			BoussoleAppears();
		}

		if (bRender.enabled && Input.GetKeyDown(KeyCode.M))
		{
			MapAppears();
		}

	}

	void MapAppears()
	{
		mRender.enabled = !mRender.enabled;
	}

	void BoussoleAppears()
	{
		bRender.enabled = !bRender.enabled;
	}
}







