using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HyperController : MonoBehaviour
{

    private Touch my_Touch;
    [SerializeField] Animator hyper_Animator;

    [SerializeField] float TouchSpeedIdentifier;
    [SerializeField] float Translate_Speed;

    [SerializeField] float DirectionSpeed;


    void Update()
    {
        MyTouchPhase();

    }



    public void MyTouchPhase()
    {
        if (Input.touchCount > 0)
        {

            TouchController();
            transform.Translate(0f, 0f, Translate_Speed * Time.deltaTime);



            if (my_Touch.phase == TouchPhase.Began)
            {

                gameObject.transform.localPosition = new Vector3(transform.localPosition.x, 0f, transform.localPosition.z);
                hyper_Animator.SetBool("IsRun", true);


                // Character imizin i�ine enemy girdiyse kontrol� yap�ls�n ve animasyonu kabul olsun.

            }

            if (my_Touch.phase == TouchPhase.Moved)
            {

                gameObject.transform.localPosition = new Vector3(transform.localPosition.x, 0f, transform.localPosition.z);
                hyper_Animator.SetBool("IsRun", true);


            }

            if (my_Touch.phase == TouchPhase.Stationary)
            {

                gameObject.transform.localPosition = new Vector3(transform.localPosition.x, 0f, transform.localPosition.z);
                hyper_Animator.SetBool("IsRun", true);


            }

            if (my_Touch.phase == TouchPhase.Ended)
            {

                gameObject.transform.localPosition = new Vector3(transform.localPosition.x, 0f, transform.localPosition.z);
                hyper_Animator.SetBool("IsRun", false);

            }

        }
    }


    void TouchController()
    {

        if (Input.touchCount > 0)
        {

            my_Touch = Input.GetTouch(0);

            if (my_Touch.deltaPosition.x >= 50f)


                gameObject.transform.position = new Vector3
               (
                  gameObject.transform.position.x + my_Touch.deltaPosition.x * TouchSpeedIdentifier * Time.deltaTime,
                  gameObject.transform.position.y,
                  gameObject.transform.position.z + my_Touch.deltaPosition.y * TouchSpeedIdentifier * Time.deltaTime

               );


            gameObject.transform.Rotate(Vector3.up * my_Touch.deltaPosition.x * (DirectionSpeed * Time.deltaTime));



        }


        if (my_Touch.deltaPosition.x < 50f)
        {

            gameObject.transform.position = new Vector3

          (
            gameObject.transform.position.x + my_Touch.deltaPosition.x * TouchSpeedIdentifier * Time.deltaTime,
            gameObject.transform.position.y,
            gameObject.transform.position.z + my_Touch.deltaPosition.y * TouchSpeedIdentifier * Time.deltaTime

          );


            gameObject.transform.Rotate(Vector3.up * my_Touch.deltaPosition.x * (DirectionSpeed * Time.deltaTime));


        }



        // Enemy D��manla kar��la�t���nda Kendi i�imizdeki herhangi bir Friend 'le birlikte Kafa kafa �arp��s�n.




        #region Animation HATA ��Z�M� ( SAKIN S�LME )

        /*  

          Animation HATA ��Z�M� : Mixamo 'dan indirdi�in karakterine animasyonu Mixamodan uygulad�n ama Unity taraf�nda bunu
          �ALI�TIRAMAMI�TIN. BU HATAYI TAM 1 HAFTA BOYUNCA ��ZEMED�N ��Z�M� ��YLE : 
          Karakterin alt cocuk objelerindeki metaring ' e Animator 'u EKLEME Ana ( PARENT , ANNE ) OLAN OBJE K�MSE ONA AN�MATORU
          EKLE VE AN�MASYONLAR ORDA DURSUN. B�yle yapmazsan ASLA AMA ASLA Mixamo 'daki animasyonlar UN�TY TARAFINDA
          �ALI�TIRAMIYORSUN !!!!!!!!!

        */

        #endregion



    }







}







