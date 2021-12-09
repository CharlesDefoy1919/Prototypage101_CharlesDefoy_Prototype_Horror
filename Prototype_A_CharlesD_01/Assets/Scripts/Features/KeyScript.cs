 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeyScript : MonoBehaviour
{
    #region Variables

    public DoorScript DoorScript;

    public Image KeyIcon;

    private Image keys;


	#endregion

	#region Messages

	// Start is called before the first frame update
	void Start()
    {
        keys = KeyIcon.GetComponent<Image>();

        DoorScript = GameObject.Find("Door_02").GetComponent<DoorScript>();
    }

	private void OnTriggerEnter(Collider collider)
	{
        if (collider.gameObject.tag == "Player")  // On collision give door script the Keyowned bool, enable the Key image on UI and Destroy the collectible.
        {
            DoorScript.KeyOwned = true;

			keys.enabled = !keys.enabled;

            Destroy(gameObject);

			Debug.Log("Key Picked Up");
        }
	}

	#endregion
}
