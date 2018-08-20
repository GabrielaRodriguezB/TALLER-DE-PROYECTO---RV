using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Acelerometro : MonoBehaviour {
    public bool echado = true;
    private Rigidbody rigid;
    // Use this for initialization
    void Start() {
        rigid = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        Vector3 incline = Input.acceleration;

        if(echado)
        {
            incline = Quaternion.Euler(90, 0, 0) * incline;
        }

        rigid.AddForce(incline);
	}
}
