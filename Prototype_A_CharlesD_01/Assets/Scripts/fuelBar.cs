using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class fuelBar : MonoBehaviour
{
    #region
    public Slider SliderBar;

    #endregion
    //----------------
    public void SetMaxFuel(int fuel)
    {
        SliderBar.maxValue = fuel;
        SliderBar.value = fuel;
    }

    public void SetFuel(int fuel)
    {
        SliderBar.value = fuel;
    }
}
