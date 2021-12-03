using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Door : MonoBehaviour
{
    #region Variables

    public bool insideDoorRange;

    public bool keyOwned = false;

    GameObject key;

    public GameObject Prompt;

    private Text K;

	#endregion
	// Start is called before the first frame update
	void Start()
    {
        key = GameObject.FindGameObjectWithTag("Key");

        K = Prompt.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (key == null)
        {
            keyOwned = true;
        } 

        if (Input.GetKeyDown(KeyCode.K))
        {
            if (insideDoorRange && keyOwned)
            {
                Destroy(gameObject);

                K.text = "";

                Debug.Log("Door Opened");
            }
        }
    }

	private void OnTriggerStay(Collider collider)
	{
        if (collider.gameObject.tag == "Player" && keyOwned)
        {
            insideDoorRange = true;

            K.text = "Press K to open";
        }
        else if (collider.gameObject.tag == "Player")
        {
            insideDoorRange = true;

            K.text = "Need Key";

            Debug.Log("InsideDoorRange");
        }
        else 
        {
            insideDoorRange = false;

            K.text = "";
        }
	}
}
