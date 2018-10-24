using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MountLLama : MonoBehaviour {

    public GameObject Jugador;
    public GameObject Llama;
    public GameObject CamaraVR;
    public GameObject EmptyGameObject;
    MovimientoCarrito scriptMove;
    public bool estado = false;
    public bool EnCarro;
    void Start()
    {
        Jugador = GameObject.FindWithTag("Player");
        scriptMove = GetComponent<MovimientoCarrito>();
        //mounted = false;
        EnCarro = false;
    }

    void Update()
    {
        if (estado && Input.GetKeyDown(KeyCode.E))  
        {
            EnCarro = true;
            Jugador.SetActive(false);
            //CamaraVR.transform.parent = Llama.transform;
            CamaraVR.transform.parent = EmptyGameObject.transform;
            Jugador.transform.parent = Llama.transform;
            Llama.GetComponent<MovimientoCarrito>().enabled = true;
            scriptMove.enabled = true;
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            EnCarro = false;
            //Jugador.SetActive(true);
            //Jugador.transform.parent;
            //CamaraVR.transform.parent = Jugador.transform;
            //scriptMove.enabled = false;  
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag=="Carrito")
        {
            estado = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Carrito")
        {
            estado = false;
        }
    }
}
