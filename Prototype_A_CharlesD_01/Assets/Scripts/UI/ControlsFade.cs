using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlsFade : MonoBehaviour
{
	#region Variables

	public Image controlsPng;

	#endregion

	#region Messages

	// Start is called before the first frame update
	void Start()
    {
        // Refers to the UI Image

        controlsPng = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        // Fades Out Image when player goes forward

        if (Input.GetKeyDown(KeyCode.W))
        { 
            controlsPng.CrossFadeAlpha(0, 2, true);
        }
    }

	#endregion
}
