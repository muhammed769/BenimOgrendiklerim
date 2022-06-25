using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FriendController : MonoBehaviour
{
    [SerializeField] bool IsContact;
    [SerializeField] Animator Friend_Animator;
    Touch f_touch;

    [SerializeField] GameObject Character;
    [SerializeField] float DistanceIdentifier;
    void Start()
    {
        IsContact = false;
    }


    void Update()
    {
        if (Vector3.Distance(gameObject.transform.position, Character.transform.position) < DistanceIdentifier)
        {
            DistanceCatch();

        }

        //if (Vector3.Distance(gameObject.transform.position, Character.transform.position) >= DistanceIdentifier)

        //{

        //    f_touch = Input.GetTouch(0);

        //    if (f_touch.phase == TouchPhase.Began)

        //    {


        //        Friend_Animator.SetBool("IsRush", true);
        //    }

        //    if (f_touch.phase == TouchPhase.Ended)
        //    {
        //        Friend_Animator.SetBool("IsRush", false);
        //    }
        //}
    }
    void DistanceCatch()
    {

        Debug.Log("Mesafe çok az kaldý ne yapayým ... ");

        gameObject.transform.SetParent(Character.gameObject.transform);

      

        f_touch = Input.GetTouch(0);

        if (f_touch.phase == TouchPhase.Began)

        {


            Friend_Animator.SetBool("IsRush", true);
        }

        if (f_touch.phase == TouchPhase.Ended)
        {
            Friend_Animator.SetBool("IsRush", false);
        }



    }


}



