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
    void Start()
    {
        Jugador = GameObject.FindWithTag("Player");
        scriptMove = GetComponent<MovimientoCarrito>();
        //mounted = false;  
    }

    void Update()
    {
        if (estado && Input.GetKeyDown(KeyCode.E))  
        {
            Jugador.SetActive(false);
            //CamaraVR.transform.parent = Llama.transform;
            CamaraVR.transform.parent = EmptyGameObject.transform;
            Jugador.transform.parent = Llama.transform;
            Llama.GetComponent<MovimientoCarrito>().enabled = true;
            scriptMove.enabled = true;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag=="Carrito")
        {
            estado = true;
        }
    }
}
