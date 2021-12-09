using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FuelBar : MonoBehaviour
{
    #region
    public Slider SliderBar;

	#endregion

	#region Functions

    // Sets Fuel Values

	public void SetMaxFuel(int fuel) 
    {
        SliderBar.maxValue = fuel;
        SliderBar.value = fuel;
    }

    public void SetFuel(int fuel)
    {
        SliderBar.value = fuel;
    }

	#endregion
}
