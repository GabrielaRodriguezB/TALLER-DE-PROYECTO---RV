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

    public float pos = 10f;

    public GameObject CameraObj;

    private void FixedUpdate()
    {
        base.GetComponent<Rigidbody>().MovePosition(base.transform.position + (new Vector3(this.CameraObj.transform.forward.x, 0f, this.CameraObj.transform.forward.z) * this.pos * Input.GetAxis("Vertical") + new Vector3(this.CameraObj.transform.right.x, 0f, this.CameraObj.transform.right.z) * this.pos * Input.GetAxis("Horizontal")) * Time.deltaTime);
    }
}
