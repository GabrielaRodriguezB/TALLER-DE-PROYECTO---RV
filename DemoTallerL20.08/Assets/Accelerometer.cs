using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Rigidbody))]
public class Accelerometer : MonoBehaviour
{

    /*public bool isFlat = true;
    private Rigidbody rb;

	// Use this for initialization
	void Start () {
     rb=GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 tilt = Input.acceleration;
        if(isFlat)
        {
            tilt = Quaternion.Euler(90,0,0)*tilt;
        }

        rb.AddForce(tilt);
        Debug.DrawRay(transform.position+Vector3.up,tilt,Color.cyan);
	}*/

    // gravity constant
    public float g = 9.8f;

    void FixedUpdate()
    {
        // normalize axis
        var gravity = new Vector3(
            Input.acceleration.x,
            Input.acceleration.z,
            Input.acceleration.y
        ) * g;

        GetComponent<Rigidbody>().AddForce(gravity, ForceMode.Acceleration);
    }

}
