using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

	public float Speed = 10f;

	public Vector3 jump = new Vector3(0, 5f, 0);

	private Rigidbody rbPLayer;

	public bool IsJumping = false;


	// Start is called before the first frame update
	void Start()
	{

		//ref to the players' rigidbody
		rbPLayer = this.GetComponent<Rigidbody>();

	}

	// Update is called once per frame
	void Update()
	{
		// control left and right

		if (Input.GetKey(KeyCode.D))
		{


			transform.Translate(Vector3.right * Speed * Time.deltaTime);

		}
		Debug.Log("Move Right");

		if (Input.GetKey(KeyCode.A))
		{


			transform.Translate(Vector3.right * Speed * Time.deltaTime * -1);

		}
		Debug.Log("Move Left");

		//control forward and backward

		if (Input.GetKey(KeyCode.W))
		{

			transform.Translate(Vector3.forward * Speed * Time.deltaTime);

			Debug.Log("Move Forward");
		}


		if (Input.GetKey(KeyCode.S))
		{


			transform.Translate(Vector3.forward * Speed * Time.deltaTime * -1);
		}
		Debug.Log("Move Back");

		//Jump


		if (Input.GetKeyDown(KeyCode.Space))
		{

			if (!IsJumping)
				rbPLayer.AddForce(jump, ForceMode.Impulse);
			IsJumping = true;


			Debug.Log("Jumped");

		}



	}

	//makes sure the player is on ground befor letting it jump again (no double jump)

	private void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.tag == "Ground")
		{
			IsJumping = false;
		}
	}


}
