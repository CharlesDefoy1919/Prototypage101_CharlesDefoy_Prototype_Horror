using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameFinish : MonoBehaviour
{
	#region Messages

	public void OnTriggerEnter(Collider other)
	{
        if (other.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(1);
        }
    }

	#endregion
}
