using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoteIlkKodlar : MonoBehaviour
{

    #region Deðiþkenler

    public Rigidbody m_body;
    public Animator m_Animator;

    public GameObject SecondCharacter;

    //public Camera m_Camera;

    bool sol;
    bool sag;


    Vector3 endPos;
    [SerializeField] float ArtisMiktari;
    int dokunusSayisi;

    [SerializeField] float hiz = 5.0f;
    [SerializeField] float StationarySinirlarIcinHiz;

    float ziplama = 5.0f;

    bool IsAction;

    #endregion

    //public GameObject cubem;
    [SerializeField] float DistanceIdentifier;

   
    private void Start()
    {
        ArtisMiktari = 5f;
        IsAction = false;
     
    }


    private void Update()
    {
        TecnicalFunction();
       
    }

    // mesafeden yakala enemy 'i o zaman animasyon çalýþýyor mu bak ???????*
    void TecnicalFunction()
    {


        if (Input.touchCount > 0)
        {

            Touch dokunus = Input.GetTouch(0);

            transform.Translate(0f, 0f, hiz * Time.deltaTime);
            TumGidisler();

            if (dokunus.phase == TouchPhase.Began)
            {
                m_Animator.SetBool("CalissinMi", true);
              

                if (IsAction)
                    SecondCharacter.GetComponent<Animator>().SetBool("CalissinMi", true);

                gameObject.transform.localPosition = new Vector3(transform.localPosition.x, 0f, transform.localPosition.z);

            }

            if (dokunus.phase == TouchPhase.Moved)
            {
                m_Animator.SetBool("CalissinMi", true);
              
                if (IsAction)
                    SecondCharacter.GetComponent<Animator>().SetBool("CalissinMi", true);

                /* Debug.Log("Parmagým Telefona sürekli dokunurken aldýðým PÝKSEL X : " + dokunus.deltaPosition.x);
                   Debug.Log("Parmaðým Telefona sürekli dokunurken aldýðým PÝKSEL  Y : " + dokunus.deltaPosition.y); */

                gameObject.transform.localPosition = new Vector3(transform.localPosition.x, 0f, transform.localPosition.z);

              
            }

            if (dokunus.phase == TouchPhase.Stationary)// PARMAK ekrana dokunuyor ama hareket etmiyorsa bunu kullan.
                                                       // Debug.Log("PARMAK ekrana dokunuyor ama hareket etmiyor.");
            {
                m_Animator.SetBool("CalissinMi", true);
             

                if (IsAction)
                    SecondCharacter.GetComponent<Animator>().SetBool("CalissinMi", true);

                gameObject.transform.localPosition = new Vector3(transform.localPosition.x, 0f, transform.localPosition.z);
               
            }

            if (dokunus.phase == TouchPhase.Ended)
            {
                m_Animator.SetBool("CalissinMi", false);
           
                SecondCharacter.GetComponent<Animator>().SetBool("CalissinMi", false);

                //Vector3 GeriyeItilmisVector = gameObject.transform.TransformPoint(Vector3.back * (ArtisMiktari));

                //gameObject.transform.position = GeriyeItilmisVector;

                
            }


        }

    }

    void TumGidisler()
    {
        if (Input.touchCount > 0)
        {
            Touch dokunus = Input.GetTouch(0);

            transform.Translate(0f, 0f, hiz * Time.deltaTime);

            //Vector3 Saga_Gidis = new Vector3(4.27f, transform.position.y, transform.position.z);
            //Vector3 Sola_Gidis = new Vector3(-3.76f, transform.position.y, transform.position.z);

            Vector3 Saga_Gidis = new Vector3(2.49f, 0f, transform.position.z);
            Vector3 Sola_Gidis = new Vector3(-3.16f, 0f, transform.position.z);

            if (dokunus.deltaPosition.x >= 50f)
            {

                sag = true;
                sol = false;
            }

            if (dokunus.deltaPosition.x < -50f && dokunus.deltaPosition.x <= 49f)
            {

                sag = false;
                sol = true;
            }

            if (dokunus.deltaPosition.y < 50f)
            {
                //m_body.velocity = Vector3.zero;
                m_body.velocity = Vector3.up;


            }
            if (dokunus.deltaPosition.y > 50f)
            {
                m_body.velocity = Vector3.up * ziplama;

            }

            if (sag == true)
            {
                //transform.position = Vector3.Lerp(transform.position, Saga_Gidis, Time.deltaTime);
                transform.position = Vector3.Lerp(new Vector3(transform.localPosition.x, 0f, transform.localPosition.z), Saga_Gidis, Time.deltaTime);

            }
            if (sol == true)
            {
                //transform.position = Vector3.Lerp(transform.position, Sola_Gidis, Time.deltaTime);
                transform.position = Vector3.Lerp(new Vector3(transform.localPosition.x, 0f, transform.localPosition.z), Sola_Gidis, Time.deltaTime);

            }
        }

    }





    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Characterler"))
        {
            Debug.Log("Rigidbody ile temas etme iþlemim gerçekleþti.");
            IsAction = true;
            collision.gameObject.transform.SetParent(gameObject.transform);
            collision.gameObject.transform.position = gameObject.transform.TransformPoint(Vector3.right * 1);
        }


      
    }


    /*

           if (my_Touch.phase == TouchPhase.Moved)
           {
               gameObject.transform.position = new Vector3
                     (

                     transform.position.x + my_Touch.deltaPosition.x * TouchSpeedIdentifier,
                     transform.position.y,
                     transform.position.z + my_Touch.deltaPosition.y * TouchSpeedIdentifier


                     );
           }

           */

}












