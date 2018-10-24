using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoCarrito : MonoBehaviour {

    public float pos = 10f;
    public GameObject CameraObj;
    //MovimientoCarrito script;
    public int forceConst = 5;
    private bool canJump;
    private Rigidbody selfRigidbody;



    public bool EnCarro = true;
    public GameObject Jugador;
    public GameObject Llama;
    public GameObject CamaraVR;

    // Use this for initialization
    void Start()
    {
        selfRigidbody = GetComponent<Rigidbody>();
        //script = GetComponent<MovimientoCarrito>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            EnCarro = false;
            Jugador.SetActive(true);
            //Jugador.transform.parent = Jugador.transform;
            CamaraVR.transform.parent = Jugador.transform;
            this.enabled = false;  
        }
    }

    private void FixedUpdate()
    {
        GetComponent<Rigidbody>().MovePosition(transform.position + (new Vector3(CameraObj.transform.forward.x, 0f, CameraObj.transform.forward.z) * pos * Input.GetAxis("Vertical") + new Vector3(CameraObj.transform.right.x, 0f, CameraObj.transform.right.z) * pos * Input.GetAxis("Horizontal")) * Time.deltaTime);

        if (canJump)
        {
            canJump = false;
            selfRigidbody.AddForce(0, forceConst, 0, ForceMode.Impulse);
        }

    }
}
