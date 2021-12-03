using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class keyPickUp : MonoBehaviour
{
    #region Variables

    public bool keyOwned;

    public Image keyIcon;

    private Image keys;


	#endregion
	// Start is called before the first frame update
	void Start()
    {
        keys = keyIcon.GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	private void OnTriggerEnter(Collider collider)
	{
        if (collider.gameObject.tag == "Player")
        {
            keyOwned = true;

            keys.enabled = !keys.enabled;

            Destroy(gameObject);

            Debug.Log("Key Picked Up");
        }
	}
}
