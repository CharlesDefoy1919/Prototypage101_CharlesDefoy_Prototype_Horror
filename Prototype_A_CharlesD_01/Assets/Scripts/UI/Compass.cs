using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Compass : MonoBehaviour
{
	#region Variables

	public Vector3 NorthDirection;
    public Transform Player;
	public RectTransform NorthLayer;

	#endregion

	#region Messages

	// Update is called once per frame
	void Update()
    {
		ChangeNorthDirection();
    }

	#endregion

	#region Functions

	public void ChangeNorthDirection() // Points sprites towards players front
	{
		NorthDirection.z = -Player.eulerAngles.y;
		NorthLayer.localEulerAngles = NorthDirection;
	}

	#endregion
}
