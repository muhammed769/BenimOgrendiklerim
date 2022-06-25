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

        if (Input.touchCount > 0)
        {


            f_touch = Input.GetTouch(0);

            if (Vector3.Distance(gameObject.transform.position, Character.transform.position) < DistanceIdentifier)
            {
                Friend_Animator.SetBool("IsRush", true);
                DistanceCatch();

            }

            if (Vector3.Distance(gameObject.transform.position, Character.transform.position) >= DistanceIdentifier)

            {

                Friend_Animator.SetBool("IsRush", false);
            }
        }
    }



    void DistanceCatch()
    {

        Debug.Log("Mesafe çok az kaldý ne yapayým ... ");

        gameObject.transform.SetParent(Character.gameObject.transform);

        if (f_touch.phase == TouchPhase.Began)
        {

            Friend_Animator.SetBool("IsRush", true);
        }

        if (f_touch.phase == TouchPhase.Moved)
        {
            Friend_Animator.SetBool("IsRush", true);
        }

        if (f_touch.phase == TouchPhase.Ended)
        {
            Friend_Animator.SetBool("IsRush", false);
        }

    }


}



