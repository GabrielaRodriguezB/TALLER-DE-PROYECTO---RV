using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Acelerometro : MonoBehaviour {
    public bool echado = true;
    float veloc = 10f;
    private Rigidbody rigid;
    // Use this for initialization
    void Start() {
        rigid = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void FixedUpdate ()
    {
        Vector3 incline = Input.acceleration;
        rigid.AddForce(incline.x * veloc, 0, incline.y * veloc);
	}
}
