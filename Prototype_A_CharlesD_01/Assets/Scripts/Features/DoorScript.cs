using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoorScript : MonoBehaviour
{
    #region Variables

    public bool InsideDoorRange;
    public GameObject Prompt;
    public bool KeyOwned;

    private Text K;

	#endregion

	#region Messages

	// Start is called before the first frame update
	void Start()
    {
        // refers to UI Text
        K = Prompt.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            if (InsideDoorRange && KeyOwned == true)   //If Player is in door range and picked up the key, then destroy door and remove text
            {
                Destroy(gameObject);

                K.text = "";

                Debug.Log("Door Opened");
            }
        }
    }

	private void OnTriggerStay(Collider collider)
	{
        if (collider.gameObject.tag == "Player" && KeyOwned == true)  // if the player is in the door collider and has key write this
        {
            InsideDoorRange = true;

            K.text = "Press K to open";
        }
        else if (collider.gameObject.tag == "Player" && KeyOwned == false)  // if the player is in the door collider and doesn't have key write this
        {
            InsideDoorRange = true;

            K.text = "Need Key";

            Debug.Log("InsideDoorRange");
        }
        else  // player in not in door collider so don't write anything
        {
            InsideDoorRange = false;

            K.text = "";
        }
	}

	#endregion 
}
