using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    #region Variables

    public int MyNumber = 5;

    [SerializeField]
    private bool What = true;

    private int[] mynum = { 0, 10, 3 };  

    #endregion

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Scene Started");

        Debug.Log(multiply(5, 10));

        

        for (int i = 0; i < mynum.Length; i++)

        { 
        
        Debug.Log(mynum[i]);  // position of array starts with 0--1,2,3
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (MyNumber > 0)
        {
            Debug.Log("1st condition true");
        }
    }

    #region Methods


    // int multiply is a function ---- inside the parenthesis is a method

    int multiply(int a, int b)
    {
        int result;

        result = a * b;

        return result;
    }








	#endregion




}
