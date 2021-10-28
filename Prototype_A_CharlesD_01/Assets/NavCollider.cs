using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NavCollider : MonoBehaviour
{

	CapsuleCollider NavCol;

	float Radius;

	// Start is called before the first frame update
	void Start()
	{
		NavCol = GetComponent<CapsuleCollider>();
		Radius = NavCol.radius;
	}

	// Update is called once per frame
	void Update()
	{

	}
}
