using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouselook : MonoBehaviour
{
	#region Variables

	public float MouseSensitivity = 150f;

	public Transform PlayerBody;

	float xRotation = 0f;

	#endregion

	#region Messages

	// Start is called before the first frame update
	void Start()
	{
		//makes sure the cursor is locked on camera when entering play mode

		Cursor.lockState = CursorLockMode.Locked;
	}

	// Update is called once per frame
	void Update()
	{
		float mouseX = Input.GetAxis("Mouse X") * MouseSensitivity * Time.deltaTime;
		float mouseY = Input.GetAxis("Mouse Y") * MouseSensitivity * Time.deltaTime;

		xRotation -= mouseY;
		xRotation = Mathf.Clamp(xRotation, -90f, 90f);

		transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
		PlayerBody.Rotate(Vector3.up * mouseX);
	}

	#endregion
}
