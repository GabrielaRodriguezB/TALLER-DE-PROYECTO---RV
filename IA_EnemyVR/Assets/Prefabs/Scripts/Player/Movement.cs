using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoCapsula : MonoBehaviour {
    public float velocidad;
    private Vector3 MoviCapsula;

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

        

    }
}
