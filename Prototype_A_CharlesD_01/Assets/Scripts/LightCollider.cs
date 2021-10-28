using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightCollider : MonoBehaviour
{
    Light Lt;
    float originalRange;
    LightCollider LightCol;
    float Radius;



    // Start is called before the first frame update
    void Start()
    {
        Lt = GetComponent<Light>();
        originalRange = Lt.range;

        LightCol = GetComponent<LightCollider>();
        Radius = LightCol.Radius;

    }

    // Update is called once per frame
    void Update()
    {
        Lt.range = LightCol.Radius;
    }
}
