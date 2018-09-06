using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movemenet : MonoBehaviour {






	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetAxis("Horizontal") != 0 || Input.GetAxis("Vertical") != 0)
        {
            // Only start playing, if the audio hasn't been started yet
            if (!GetComponent<AudioSource>().isPlaying)
                GetComponent<AudioSource>().Play();
        }
        else if (Input.GetAxis("Horizontal") == 0 || Input.GetAxis("Vertical") == 0)
            GetComponent<AudioSource>().Stop();

    }

    public float pos = 5f;

    public GameObject CameraObj;

    private void FixedUpdate()
    {
        GetComponent<Rigidbody>().MovePosition(transform.position + (new Vector3(CameraObj.transform.forward.x, 0f, CameraObj.transform.forward.z) * pos * Input.GetAxis("Vertical") + new Vector3(CameraObj.transform.right.x, 0f, CameraObj.transform.right.z) * pos * Input.GetAxis("Horizontal")) * Time.deltaTime);
    }

}
