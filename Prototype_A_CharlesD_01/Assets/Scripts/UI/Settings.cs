using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Settings : MonoBehaviour
{
	#region Variables

	public bool IsGamePaused = false;
	public Canvas settings;

	private Canvas canvas;

	#endregion

	#region Messages

	// Start is called before the first frame update
	void Start()
	{
		canvas = settings.GetComponent<Canvas>();
	}

	// Update is called once per frame
	void Update()
	{
		// Pauses Game for rigidbody and other non-enbling/disabling component

		if (IsGamePaused)  
		{
			Time.timeScale = 0f;
		}
		else
		{
			Time.timeScale = 1f;
		}

		// Pause script for when the application is not in editor mode

		if (Input.GetKeyDown(KeyCode.Escape) && !Application.isEditor)
		{
			if (!IsGamePaused)
			{

				SetPausedAll(true);

				IsGamePaused = true;

				Cursor.lockState = CursorLockMode.None;
			}
			else
			{
				SetPausedAll(false);
				IsGamePaused = false;

				Cursor.lockState = CursorLockMode.Locked;
			}

			canvas.enabled = !canvas.enabled;
		}
		else if (Input.GetKeyDown(KeyCode.U))  // Pause button when in editor mode
		{
			// enables or disables componants depending on the state of the game (paused or not)

			if (!IsGamePaused)  
			{
				SetPausedAll(true);

				IsGamePaused = true;

				Cursor.lockState = CursorLockMode.None;
			}
			else
			{
				SetPausedAll(false);
				IsGamePaused = false;

				Cursor.lockState = CursorLockMode.Locked;
			}

			canvas.enabled = !canvas.enabled;
		}
	}

	#endregion

	#region Functions

	//Resume, Restart and QuitGame are buttons

	public void Resume()  
	{
		SetPausedAll(false);
		IsGamePaused = false;
		
		Cursor.lockState = CursorLockMode.Locked;

		canvas.enabled = !canvas.enabled;
	}

	public void Restart()
	{
		SceneManager.LoadScene(0);
	}

	public void QuitGame()
	{
		Debug.Log("Quit");

		Application.Quit();
	}

	void SetPausedAll(bool state)
	{
		var list = FindAllCurrentObjects();  // Gets GameObject List

		foreach (var item in list)  // For each item in that list--- if they have the component "Pausable" then set their Paused state to true .
		{
			Pausable pausableComp = item.GetComponent<Pausable>();

			if (pausableComp != null)
			{
				pausableComp.SetPaused(state);
			}
		}
	}

	GameObject[] FindAllCurrentObjects()  // Makes list of all GameObject In Scene
	{
		var list = GameObject.FindObjectsOfType<GameObject>();

		return list;
	}

	#endregion
}
