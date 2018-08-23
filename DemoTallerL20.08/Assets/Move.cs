using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {


    public float speed = 10.0F;
    
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        float v = Input.GetAxis("Vertical") * speed;
        float h = Input.GetAxis("Horizontal") * speed;
        v *= Time.deltaTime;
        h *= Time.deltaTime;
        transform.Translate(h, 0, v);
        


    }
}
