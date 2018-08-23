using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadscene : MonoBehaviour {

	// Use this for initialization
	void Start () {
        //SceneManager.LoadScene("Scene2");
       
    }
	
	// Update is called once per frame
	void Update () {


        if (Input.GetButton("Fire2"))
        {
            SceneManager.LoadScene("Scene2");
        }
        if (Input.GetButton("Fire3"))
        {
            SceneManager.LoadScene("Scene3");
        }
    }
}
