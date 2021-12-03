using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightCollider : MonoBehaviour
{
    Light Lt;
    float originalRange;
    lightCollider LightCol;
    float Radius;



    // Start is called before the first frame update
    void Start()
    {
        Lt = GetComponent<Light>();
        originalRange = Lt.range;

        LightCol = GetComponent<lightCollider>();
        Radius = LightCol.Radius;

    }

    // Update is called once per frame
    void Update()
    {
        Lt.range = LightCol.Radius;
    }
}
