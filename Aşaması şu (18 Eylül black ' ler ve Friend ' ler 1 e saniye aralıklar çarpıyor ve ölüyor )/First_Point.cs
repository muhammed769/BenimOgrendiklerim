using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class First_Point : MonoBehaviour
{

 
    public static  bool IsTrigger;

    void Start()
    {

        IsTrigger = false;
    
    
    }



    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {        
            IsTrigger = true;
            End_Controller.Friends_End.Add(other.gameObject);
            End_Controller.FriendCount++;
        }

        if (other.gameObject.CompareTag("Character"))
        {
             
            IsTrigger = true;

        } 


    }



  

}
