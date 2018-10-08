using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MountLLama : MonoBehaviour {

    private bool useMount; 
                           
    public Transform mountObject; 
    public Transform objControl;    
    public Vector3 mountedPos;   
    public float moveSpeed = 2f;   
    public float mountSpeed = 3f;   


    public GameObject CameraObj;
    public float pos = 5f;

    void Start()
    {
        useMount = false;              
        //mounted = false;
        objControl = transform;       
    }


    void Update()
    {
        if (useMount && Input.GetKeyDown(KeyCode.E) || Input.GetButton("Fire2"))  
        {
            mountObject.Find("mountTrigger").gameObject.SetActive(false); 
            useMount = false; 
                                          

            transform.parent = mountObject.transform;
            objControl = mountObject; 
            mountedPos = mountObject.position + Vector3.up; 
            moveSpeed += mountSpeed; 

            transform.position = mountedPos;
        }
       
        if (Input.GetKey(KeyCode.W))
        {
            objControl.Translate(Vector3.forward * moveSpeed * Time.deltaTime); 
            
            
        }
        if (Input.GetKey(KeyCode.S))
        {
            objControl.Translate(Vector3.back * moveSpeed * Time.deltaTime); 
        }

        objControl.GetComponent<Rigidbody>().MovePosition(transform.position + (new Vector3(CameraObj.transform.forward.x, 0f, CameraObj.transform.forward.z) * pos * Input.GetAxis("Vertical") + new Vector3(CameraObj.transform.right.x, 0f, CameraObj.transform.right.z) * pos * Input.GetAxis("Horizontal")) * Time.deltaTime);
        

     
    }

    void OnGUI()
    {
        if (useMount) 
        {
            GUI.Label(new Rect(Screen.width / 2 - 50, Screen.height / 2 - 10, 100, 20), "Presiona el Boton E o Fire2 para subir a la Llama!");
        }
    }

    void OnTriggerEnter(Collider trigger)
    {
     
        if (trigger.tag == "mount")
        {
            useMount = true; 
            mountObject = trigger.transform.parent; 
        }
    }

    void OnTriggerExit(Collider trigger)
    {
      
        if (trigger.tag == "mount")
        {
            useMount = false; 
            mountObject = null;
          
        }
    }
}
