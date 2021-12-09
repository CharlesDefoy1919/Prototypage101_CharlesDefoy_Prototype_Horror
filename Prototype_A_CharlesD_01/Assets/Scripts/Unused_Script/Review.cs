using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))] // makes sure you have a rigidbody
[RequireComponent(typeof(BoxCollider))]
public class Review : MonoBehaviour
{
    // one line comment
    /*
     multi line comment
    */

    #region Variables or Fields

    //public ----------------------------------

    public int MyInteger = 2;
    public float MyFloat = 3.5f;
    public Rigidbody rb;

    // private --------------------------------

    private string myString = "Hello world";
    private bool myBool = false;
    private char myCharacter = 'A';
    private float speed = 3;
    private int[] myArray = { 0, 5, 15 };  // this is for a list --- entry in order = 0,1,2

    [SerializeField] // private appears in engine

    private double myDouble = 10.00000;

	#endregion

	#region Messages

    // Called when the script is being loaded
	private void Awake()
	{
        rb = GetComponent<Rigidbody>();
	}


	// Start is called before the first frame update
	void Start()
    {
        Print(Multiply(MyInteger, 2).ToString(), 2);

        if (MyInteger == 2)
        {

        }
        else if (MyFloat == 3.0f)
        { 
            // Do another thing
        }
        else
        {
            // do something else
        }

        if (MyInteger != 0)
        {
            //anything else than 0
        }

        if (MyInteger == 2 && MyFloat == 3.5f)
        { 
            //need both true
        }

        if (MyInteger == 2 || MyFloat == 3.5f)
        {
            //Need at least one true
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            rb.velocity = new Vector3(transform.position.x, (transform.position.y * speed) * Time.deltaTime, transform.position.z);
        }


    }

    //Use for things related to physics ( but never for input) can skip frames
	private void FixedUpdate()
	{
		
	}

	#endregion

	#region Method or Functions

	// function doesn't return value ------------------- Loop exemple
	public void Print(string message, int count)
    {
        for (var i = 0; i < count; i++)
        {
            Debug.Log(message);
        }

        foreach (var item in myArray)
        {
            Debug.Log("item");
        
        }

    }

    // returns a value and is private which hides it from others
    private int Multiply(int first, int second)
    {
        int result;

        result = first * second;

        return result;
    }

    #endregion
}
