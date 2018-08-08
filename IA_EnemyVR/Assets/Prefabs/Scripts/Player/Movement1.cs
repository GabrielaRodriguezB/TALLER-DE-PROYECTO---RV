using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {


    public float hspeed;
    public float vspeed;

    

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

       float h = Input.GetAxis("Horizontal") * hspeed;
       float v = Input.GetAxis("Vertical")* vspeed;

        transform.Translate(h, 0, 0);
        transform.Translate(0, 0, v);
            
		
	}
}
