using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TextFade : MonoBehaviour
{
	#region Variables

	public Text Text;
    public GameManager1 GameManagerScript;
    public Text YouFailed;

    private Text FailText;

    #endregion

    #region Messages

    // Start is called before the first frame update
    void Start()
    {
       Text = GetComponent<Text>();

       GameManagerScript = GameObject.Find("GameManager1").GetComponent<GameManager1>();

       FailText = GameObject.Find("DeathPrompt").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))  // Fades out Text on player movement
        {
            Text.CrossFadeAlpha(0, 2, true);
        }

        if (GameManagerScript.GamePlayed >= 1)
        {
            FailText.enabled = !FailText.enabled;

            FailText.CrossFadeAlpha(0, 2, true);
        }
    }

	#endregion
}
