using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;




public class lookplayer : MonoBehaviour {


    public Transform targetPlayer;
    public float rotationSpeed;


    public GameObject Target;

    public NavMeshAgent agent;

    public float distance;




    


    void Update()
    {

        


        if (Vector3.Distance(Target.transform.position, transform.position) < distance)

        {
           

            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(targetPlayer.position - transform.position), rotationSpeed * Time.deltaTime);


        }

        
    }


    

}
