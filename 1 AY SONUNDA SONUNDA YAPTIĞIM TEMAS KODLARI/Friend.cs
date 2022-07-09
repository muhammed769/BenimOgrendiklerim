using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Friend : MonoBehaviour
{


    public GameObject FriedController;
    public GameObject[] AllFriends;
    public GameObject Character;
    [SerializeField] float IdentifierDistance;
    [SerializeField] Animator F_Anim;
    [SerializeField] bool FriendilkTemasGerceklestiMi;
    [SerializeField] bool CharacterleilkTemasGerceklestiMi;
    Touch AllTouch;
    int i;


    void Start()
    {
        i = 0;
        FriendilkTemasGerceklestiMi = false;
        CharacterleilkTemasGerceklestiMi = false;
    }


    void Update()
    {


        if (Vector3.Distance(gameObject.transform.position, Character.transform.position) < IdentifierDistance)
        {
            CharacterAndFriendProximity();
        }


        if (FriendilkTemasGerceklestiMi)
        {
            Character.transform.position = new Vector3(Character.transform.position.x, 0f, Character.transform.position.z);
            gameObject.transform.SetParent(Character.transform);
            AllAnimasyonController();
        }
    }


    void CharacterAndFriendProximity()
    {

        CharacterleilkTemasGerceklestiMi = true;

        Character.transform.position = new Vector3(Character.transform.position.x, 0f, Character.transform.position.z);
        gameObject.transform.SetParent(Character.transform);

        AllAnimasyonController();

    }


    private void OnTriggerEnter(Collider other)
    {


        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Friend 'ler KENDÝ ARASINDA ÇARPIÞTI ... ");
            FriendilkTemasGerceklestiMi = true;
        }


    }


    void AllAnimasyonController()
    {

        if (Input.touchCount > 0)
        {
            AllTouch = Input.GetTouch(0);

            if (AllTouch.phase == TouchPhase.Began)
            {
                F_Anim.SetBool("IsRush", true);
            }

            if (AllTouch.phase == TouchPhase.Moved)
            {
                F_Anim.SetBool("IsRush", true);
            }

            if (AllTouch.phase == TouchPhase.Ended)
            {
                F_Anim.SetBool("IsRush", false);
            }

        }


    }



}
