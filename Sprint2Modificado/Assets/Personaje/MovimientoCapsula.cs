using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoCapsula : MonoBehaviour {
    public float velocidad;
    public float gravedad = 20f;
    private Vector3 MoviCapsula;

    public float horizontalSpeed = 2.0F;
    public float verticalSpeed = 2.0F;

    private const float Y_ANGLE_MIN = 20.0f;
    private const float Y_ANGLE_MAX = 50.0f;
    //private Transform Vrg;


    //public CharacterController controller;

    // Use this for initialization
    void Start ()
    {
        velocidad = 5f;
        //controller = GetComponent<CharacterController>();

       // Vrg = Camera.main.transform;
   
	}
	
	// Update is called once per frame
	void Update ()
    {
        //1era forma funciona y se cae en abismos
        //2da forma funciona pero no se cae en abismos
        //3era forma sube y sube, pero si se cae en abismos

        //hola
        /*float inputDerIzq = Input.GetAxis("Horizontal");
        float inputArrAba = Input.GetAxis("Vertical");

        float moverDerIzq = inputDerIzq * velocidad * Time.deltaTime;
        float moverArrAba = inputArrAba * velocidad * Time.deltaTime;*/

        /*float moverDerIzq = inputDerIzq * velocidad;
	    float moverArrAba = inputArrAba * velocidad;*/

        //1era forma
        //transform.Translate(0f, 0f, moverArrAba);

        //2da forma
        //MoviCapsula = new Vector3(moverDerIzq, 0f, moverArrAba);

        //3era forma
        //MoviCapsula = (transform.forward * moverArrAba) + (transform.right * moverDerIzq);
        //MoviCapsula.y = MoviCapsula.y + (Physics.gravity.y * gravedad * Time.deltaTime);

        //controller.Move(MoviCapsula * Time.deltaTime);

        //4ta forma
        //Vector3 moviCapsula = new Vector3(0, 0, Input.GetAxis("Vertical") * velocidad);
        //MoviCapsula.y -= gravedad * Time.deltaTime;
        //controller.Move(moviCapsula * Time.deltaTime);
        //aaaa transform.Rotate(0, Input.GetAxis("Horizontal"), 0);

        float inputDerIzq = Input.GetAxis("Horizontal");
        float inputArrAba = Input.GetAxis("Vertical");


        float moverDerIzq = inputDerIzq * velocidad * Time.deltaTime;
        float moverArrAba = inputArrAba * velocidad * Time.deltaTime;

        transform.Translate(moverDerIzq, 0f, 0f);
        transform.Translate(0f, 0f, moverArrAba);

        //transform.Rotate(0, Input.GetAxis("Horizontal"), 0);


        float h = horizontalSpeed * Input.GetAxis("Mouse X");
        float v = verticalSpeed * Input.GetAxis("Mouse Y");
        //Debug.Log(v.ToString());
        //v = Mathf.Clamp(v, Y_ANGLE_MIN, Y_ANGLE_MAX);

        transform.Rotate(0, h, 0);


        

    }
}
