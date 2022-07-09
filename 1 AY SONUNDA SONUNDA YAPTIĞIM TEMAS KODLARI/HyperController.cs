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


                // Character imizin içine enemy girdiyse kontrolü yapýlsýn ve animasyonu kabul olsun.

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



        // Enemy Düþmanla karþýlaþtýðýnda Kendi içimizdeki herhangi bir Friend 'le birlikte Kafa kafa çarpýþsýn.




        #region Animation HATA ÇÖZÜMÜ ( SAKIN SÝLME )

        /*  

          Animation HATA ÇÖZÜMÜ : Mixamo 'dan indirdiðin karakterine animasyonu Mixamodan uyguladýn ama Unity tarafýnda bunu
          ÇALIÞTIRAMAMIÞTIN. BU HATAYI TAM 1 HAFTA BOYUNCA ÇÖZEMEDÝN ÇÖZÜMÜ ÞÖYLE : 
          Karakterin alt cocuk objelerindeki metaring ' e Animator 'u EKLEME Ana ( PARENT , ANNE ) OLAN OBJE KÝMSE ONA ANÝMATORU
          EKLE VE ANÝMASYONLAR ORDA DURSUN. Böyle yapmazsan ASLA AMA ASLA Mixamo 'daki animasyonlar UNÝTY TARAFINDA
          ÇALIÞTIRAMIYORSUN !!!!!!!!!

        */

        #endregion



    }







}







