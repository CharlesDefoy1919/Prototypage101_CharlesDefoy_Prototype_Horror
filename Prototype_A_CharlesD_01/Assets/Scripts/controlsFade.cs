using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class controlsFade : MonoBehaviour
{

    public Image controlsPng;

    // Start is called before the first frame update
    void Start()
    {
        controlsPng = GetComponent<Image>();

        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        { 
            controlsPng.CrossFadeAlpha(0, 2, true);
        }
    }
}
