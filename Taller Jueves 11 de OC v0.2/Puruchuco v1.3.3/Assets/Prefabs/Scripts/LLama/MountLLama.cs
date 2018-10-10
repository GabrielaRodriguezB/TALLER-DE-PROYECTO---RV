using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MountLLama : MonoBehaviour {

    private bool useMount; 
                           
    public Transform mountObject; //Llama
    public Transform objControl;  //Player
    public GameObject SostenCamara;
    public GameObject CamaraVR;
    public Vector3 mountedPos;   
    public float moveSpeed = 2f;   
    public float mountSpeed = 3f;

    public Rigidbody rgbp;
    public Rigidbody rgbm;

    private bool mounted;
    public GameObject CameraObj;
    public float pos = 5f;

    void Start()
    {
        useMount = false;              
        mounted = false;
        objControl = transform;
        rgbp = GetComponent<Rigidbody>();
        
    }


    void Update()
    {
        if (useMount && Input.GetKeyDown(KeyCode.E))  
        {
            CamaraVR.transform.parent = SostenCamara.transform;
            transform.parent = mountObject.transform;
            rgbp = rgbm;
            objControl = mountObject; 
            mountedPos = mountObject.position + Vector3.up; 
            moveSpeed += mountSpeed;
            useMount = true;
            transform.position = mountedPos;
        }

        if (useMount && Input.GetKeyDown(KeyCode.G))
        {
            
            transform.parent = null;
            rgbp = GetComponent<Rigidbody>();
            objControl = transform;
            mountSpeed -= moveSpeed;
            useMount = false;

            transform.position = new Vector3(-16.75f, -0.71f, -17.24f);
        }


        if (Input.GetKey(KeyCode.W) && useMount)
        {
            mountObject.Translate(Vector3.forward * moveSpeed * Time.deltaTime); 
        }
        if (Input.GetKey(KeyCode.S) && useMount)
        {
            mountObject.Translate(Vector3.back * moveSpeed * Time.deltaTime); 
        }
        if (Input.GetKey(KeyCode.A) && useMount)
        {
            mountObject.Translate(Vector3.left * moveSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D) && useMount)
        {
            mountObject.Translate(Vector3.right * moveSpeed * Time.deltaTime);
        }

        rgbp.MovePosition(objControl.position + (new Vector3(CameraObj.transform.forward.x, 0f, CameraObj.transform.forward.z) * pos * Input.GetAxis("Vertical") + new Vector3(CameraObj.transform.right.x, 0f, CameraObj.transform.right.z) * pos * Input.GetAxis("Horizontal")) * Time.deltaTime);

    }

    void OnGUI()
    {
        if (useMount) 
        {
            GUI.Label(new Rect(Screen.width / 2 - 50, Screen.height / 2 - 10, 100, 20), "Presiona el Boton E para subirte!");
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
