using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crouch : MonoBehaviour {

    CharacterController cc;
    CapsuleCollider cap;
    CapsuleCollider cp;
	// Use this for initialization
	void Start () {
        cc = gameObject.GetComponent<CharacterController>();
        cap = gameObject.GetComponent<CapsuleCollider>();
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.C))
        {
            cc.height = 1f;
        }
        else
        {
            cc.height = 1.8f;
        }

	}
}
