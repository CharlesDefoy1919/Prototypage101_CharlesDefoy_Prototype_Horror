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

    public GameObject flares;

    private bool ProjectileThrown = false;

    #endregion


    // Start is called before the first frame update
    void Start()
    {
        Lt = GetComponent<Light>();
        originalRange = Lt.range;

        flares = GameObject.FindGameObjectWithTag("Flare");

        //ProjectileThrown = flares.GetComponent<Projectiles>().ProjectileThrow();

    }

    // Update is called once per frame
    void Update()
    {
      




       // if (flares.GetComponent<Projectiles>().ProjectileThrow())
        {

            //Lt.range -= Lightr * Time.deltaTime;
        }
    }
}
