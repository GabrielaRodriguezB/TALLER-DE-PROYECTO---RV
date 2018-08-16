using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Footsteps : MonoBehaviour {

    

    // Use this for initialization
    void Start () {

        

    }

    // Update is called once per frame
    void Update ()
    {

        /*if(Input.GetButtonDown("Vertical") || Input.GetButtonDown("Horizontal"))
        {
            GetComponent<AudioSource>().Play();
        }
        if(Input.GetButtonUp("Vertical") || Input.GetButtonUp("Horizontal"))
        {
            GetComponent<AudioSource>().Stop();
        }*/

        if (Input.GetAxis("Horizontal") != 0 || Input.GetAxis("Vertical") != 0)
        {
            // Only start playing, if the audio hasn't been started yet
            if (!GetComponent<AudioSource>().isPlaying)
                GetComponent<AudioSource>().Play();
        }
        else if (Input.GetAxis("Horizontal") == 0 || Input.GetAxis("Vertical") == 0)
        GetComponent<AudioSource>().Stop();


    }

        

}
