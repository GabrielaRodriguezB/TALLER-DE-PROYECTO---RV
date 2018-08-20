using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public float pos = 5f;

    public GameObject CameraObj;

    private void FixedUpdate()
    {
        GetComponent<Rigidbody>().MovePosition(transform.position + (new Vector3(CameraObj.transform.forward.x, 0f, CameraObj.transform.forward.z) * pos * Input.GetAxis("Vertical") + new Vector3(CameraObj.transform.right.x, 0f, CameraObj.transform.right.z) * pos * Input.GetAxis("Horizontal")) * Time.deltaTime);
    }
    
    

}
