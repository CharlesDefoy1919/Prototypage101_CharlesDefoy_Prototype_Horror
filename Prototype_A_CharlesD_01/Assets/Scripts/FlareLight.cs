using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlareLight : MonoBehaviour
{
    #region variables
    
    Light Lt;

    float Radius;

    float originalRange;

    public float Lightr = 3.0f;


	#endregion


	// Start is called before the first frame update
	void Start()
    {
        Lt = GetComponent<Light>();
        originalRange = Lt.range;

    }

    // Update is called once per frame
    void Update()
    {

       // if ProjectileThrow()
        {

           // Lt.range -= Lightr * Time.deltaTime;
        }
    }
}
