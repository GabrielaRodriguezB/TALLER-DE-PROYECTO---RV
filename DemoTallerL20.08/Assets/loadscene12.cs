using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadscene12 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButton("Fire1"))
        {
            SceneManager.LoadScene("SampleScene");
        }
        if (Input.GetButton("Fire2"))
        {
            SceneManager.LoadScene("Scene2");
        }

    }
}
