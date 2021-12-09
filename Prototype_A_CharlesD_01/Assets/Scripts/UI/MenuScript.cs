using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
	#region Messages

	private void Start()
	{
        Cursor.lockState = CursorLockMode.None;
    }

	#endregion

	#region Functions

	public void PlayGame()
    { 
        SceneManager.LoadScene(0);
    }

    public void QuitGame()
    {
        Debug.Log("Quit");

        Application.Quit();
    }

	#endregion
}
