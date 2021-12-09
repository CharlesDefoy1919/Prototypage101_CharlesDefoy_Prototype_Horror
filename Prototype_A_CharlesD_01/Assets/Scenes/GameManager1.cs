using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager1 : MonoBehaviour
{
	#region Variables

	public int GamePlayed = 0;
    public int NbrOfCollectible;
    
    private static GameManager1 instance;

	#endregion

	#region Messages

	void Start()
    {
        NbrOfCollectible = 0;
    }

	#endregion

	#region Functions

	public void AddGameplayed()
    {
        GamePlayed++;
        Debug.Log("Game Played: " + GamePlayed);
    }

	#endregion
}
