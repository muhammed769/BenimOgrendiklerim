using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Friends : MonoBehaviour
{

    public GameObject Character;
    [SerializeField] List<GameObject> E_enemys = new List<GameObject>();
    [SerializeField] Animator F_Anim;

    [SerializeField] float IdentifierDistance;
    [SerializeField] float f_DeathDistance;
    [SerializeField] bool IsCharacterContact;
    [SerializeField] bool IsMySelfContact;


    Touch AllTouch;


    void Start()
    {

        IsCharacterContact = false;
        IsMySelfContact = false;

    }


    private void Update()
    {

        //gameObject.transform.GetComponent<BoxCollider>().transform.rotation = Quaternion.Euler(gameObject.transform.rotation.x,
        //    gameObject.transform.rotation.y, gameObject.transform.rotation.z);

        if (IsCharacterContact)
        {
            CAndFriendContact();
        }

        if (IsMySelfContact)
        {
            FriendAndFriendContact();
        }


    }





    private void OnTriggerEnter(Collider other)
    {


        if (other.gameObject.transform.CompareTag("Character"))
        {
            Debug.Log("Character bana ( YANÝ Friend ' e ) çarptý.");
            IsCharacterContact = true;
        }


        if (other.gameObject.transform.CompareTag("Player"))
        {

            Debug.Log("Ýkizim ( Yani Friend ) bana çarptý.");
            IsMySelfContact = true;

        }


    }
 

    void CAndFriendContact()
    {


        /*  Vector3 Istikamet = gameObject.transform.position - Character.transform.position;
          gameObject.transform.rotation = Quaternion.LookRotation(Istikamet, Vector3.up * Time.deltaTime * 0.01f); */


        AllAnimasyonController();

        Character.transform.position = new Vector3(Character.transform.position.x, 0f, Character.transform.position.z);
        gameObject.transform.SetParent(Character.transform);


        Vector3 As = Character.transform.eulerAngles;
        gameObject.transform.rotation = Quaternion.Euler(As.x, As.y, As.z);


    }


    void FriendAndFriendContact()
    {

        /*   Vector3 Istikamet = gameObject.transform.position - Character.transform.position;
        gameObject.transform.rotation = Quaternion.LookRotation(Istikamet, Vector3.up * Time.deltaTime * 0.01f);*/

        AllAnimasyonController();

        Character.transform.position = new Vector3(Character.transform.position.x, 0f, Character.transform.position.z);
        gameObject.transform.SetParent(Character.transform);


        Vector3 As = Character.transform.eulerAngles;
        gameObject.transform.rotation = Quaternion.Euler(As.x, As.y, As.z);

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

            if (AllTouch.phase == TouchPhase.Stationary)
            {
                F_Anim.SetBool("IsRush", true);
            }

            if (AllTouch.phase == TouchPhase.Ended)
            {
                F_Anim.SetBool("IsRush", false);
            }

        }

    }




    #region BU SCRÝPTÝ ÝLERDE SÝLMEN GEREKEN BÝR DURUM OLURSA BÝLE BU YAZDIÐIM ÞEYLERÝ SAKIN SÝLME 2 *****************************

    /*

     Hem Really_Meet ' deki Scriptindeki bu kýsmý SAKIN SÝLME HEMDE BU YAZDIKLARIMI SAKIN SÝLME.

     Þimdi sen bazý durumlarda ETKÝLEÞÝMLERÝ  MESAFEDEN  yakalaman gereken durumlar olabilir. Ancak bu durumlarda
     Eðer DEBUG  edersen  o durumun MESAFEDEN yapýlabilip yapýlamadýðýný ANLARSIN. 


    */

    #endregion



}
