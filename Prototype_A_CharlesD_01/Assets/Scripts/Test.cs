using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    #region Variables

    public int MyNumber = 5;

    [SerializeField]
    private bool What = true;

    #endregion

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Scene Started");
    }

    // Update is called once per frame
    void Update()
    {
        if (MyNumber > 0)
        {
            Debug.Log("1st condition true");
        }
    }
}
