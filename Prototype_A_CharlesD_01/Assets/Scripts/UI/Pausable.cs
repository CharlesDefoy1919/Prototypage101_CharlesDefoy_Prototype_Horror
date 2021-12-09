using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pausable : MonoBehaviour
{
	#region Variables

	[SerializeField]
    private Behaviour[] pausableScripts;  // Create an array of behavior (which are components that can be enabled/disabled)

	#endregion

	#region Function

	public void SetPaused(bool state)
    {
        for (var i = 0; i < pausableScripts.Length; i++) 
        {
            var compName = pausableScripts[i].name;  //gives the component an index

            if (state)  // if the Menu script states that the game is paused then --- disables components in Pausable script's array
            {
                pausableScripts[i].enabled = false;

                Debug.Log("Paused");
            }
            else  // if the Menu script states that the game is Unpaused then --- enables components in Pausable script's array
            {
                pausableScripts[i].enabled = true;
                Debug.Log("UnPaused");
            }
        }
    }

	#endregion
}
