using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoviCapsula : MonoBehaviour {

    public float velocidad;
    public float gravedad = 20f;
    //private Vector3 V3_MoviCapsula;

    public float horizontalSpeed = 2.0F;
    public float verticalSpeed = 2.0F;

    private const float Y_ANGLE_MIN = 20.0f;
    private const float Y_ANGLE_MAX = 50.0f;

    // Use this for initialization
    void Start ()
    {
        velocidad = 5f;
    }
	
	// Update is called once per frame
	void Update ()
    {
        float inputDerIzq = Input.GetAxis("Horizontal");
        float inputArrAba = Input.GetAxis("Vertical");


        float moverDerIzq = inputDerIzq * velocidad * Time.deltaTime;
        float moverArrAba = inputArrAba * velocidad * Time.deltaTime;

        transform.Translate(moverDerIzq, 0f, 0f);
        transform.Translate(0f, 0f, moverArrAba);

        float h = horizontalSpeed * Input.GetAxis("Mouse X");
        float v = verticalSpeed * Input.GetAxis("Mouse Y");
        //Debug.Log(v.ToString());
        //v = Mathf.Clamp(v, Y_ANGLE_MIN, Y_ANGLE_MAX);

        transform.Rotate(0, h, 0);
    }
}
