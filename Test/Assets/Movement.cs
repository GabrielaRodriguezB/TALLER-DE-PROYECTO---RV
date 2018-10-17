using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    
    public float pos = 10f;
    public GameObject CameraObj;
    public int forceConst = 5;
    private bool grounded=true;
    private bool canJump;
    private Rigidbody selfRigidbody;
    CapsuleCollider colliderCapsula;
    // Use this for initialization
    void Start () {
        selfRigidbody = GetComponent<Rigidbody>();
        colliderCapsula = gameObject.GetComponent<CapsuleCollider>();

    }
	
	// Update is called once per frame
	void Update ()
    {
        
        
        if (Input.GetAxis("Horizontal") != 0 || Input.GetAxis("Vertical") != 0)
        {
            // Only start playing, if the audio hasn't been started yet
            /*if (!GetComponent<AudioSource>().isPlaying)
                GetComponent<AudioSource>().Play();*/
        }
        else if (Input.GetAxis("Horizontal") == 0 || Input.GetAxis("Vertical") == 0)
            //GetComponent<AudioSource>().Stop();


        if (Input.GetButton("Jump") && grounded == true)
        {
            canJump = true;
        }

        if(Input.GetButton("Fire1"))
        {
            colliderCapsula.height = 1.0f;
        }
        else
        {
            colliderCapsula.height = 1.8f;
        }
    }

    void OnCollisionEnter(Collision hit)
    {
        if (hit.gameObject.tag == "grounded")
        {
            grounded = true;
        }
    }

    void OnCollisionExit(Collision hit)
    {
        if (hit.gameObject.tag == "grounded")
        {
            grounded = false;
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


