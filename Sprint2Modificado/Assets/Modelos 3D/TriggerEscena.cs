using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerEscena : MonoBehaviour {
    public GameObject guiObject;
    public string escena2;
	// Use this for initialization
	void Start () {
        guiObject.SetActive(false);
	}

    // Update is called once per frame
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            guiObject.SetActive(true);
            if (guiObject.activeInHierarchy == true)
            {
                Application.LoadLevel(escena2);
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        guiObject.SetActive(false);
    }
}
