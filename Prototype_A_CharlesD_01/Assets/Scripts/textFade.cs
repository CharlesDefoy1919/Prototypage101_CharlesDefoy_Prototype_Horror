using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class textFade : MonoBehaviour
{
    public Text Text;

    // Start is called before the first frame update
    void Start()
    {
        Text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.W))
        {
            Text.CrossFadeAlpha(0, 2, true);
        }

    }
}
