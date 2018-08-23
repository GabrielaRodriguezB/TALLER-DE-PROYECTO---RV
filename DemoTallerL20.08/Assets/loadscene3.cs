using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadscene3 : MonoBehaviour {

	// Use this for initialization
	void Start () {
        //SceneManager.LoadScene("Scene3");
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetButton("Fire1"))
        {
            SceneManager.LoadScene("SampleScene");
        }
        if(Input.GetButton("Fire3"))
        {
            SceneManager.LoadScene("Scene3");
        }
    }
}
