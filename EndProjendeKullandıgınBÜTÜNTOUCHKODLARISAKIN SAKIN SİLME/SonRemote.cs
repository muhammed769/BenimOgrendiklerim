using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SonRemote : MonoBehaviour
{

    // public Joystick m_joystick;

    private Touch my_Touch;
    [SerializeField] float TouchSpeedIdentifier;
    [SerializeField] float TranslateSpeed;
    [SerializeField] bool IsAction;
    public GameObject SecondCharacter;
    public Animator m_Animator;
     


    //[SerializeField] float SmoothTime; // 0.34f
    //float RefXVelocity = 0.0f;
    //float RefZVelocity = 0.0f;




    void Start()
    {
        IsAction = false;
    }


    void Update()
    {


        #region DELTA OLAYI �OK �OK �OK AMA �OK �NEML� B�R B�LG�

        /*

         ****************************** �NEML� B�LG�  ******************************


       deltaPosition.x , deltaPosition.y gibi Mobil'den oyun yaparken DOKUNU� hareketlerini yapt���m�z �ok �NEML� B�R �ZELL�K
       olan delta  �u i�leve ve �u anlama gelir : 

       !!!! DELTA , K���K AMA FARK ED�LEB�L�R B�R ETK�D�R !!!!
       !!!! PARMAK �Z�NDE BULUNAN ��GEN BENZER� �EK�LD�R  !!!!

         Bu Parmak izimdeki ETK�N�N DE�ER�N� PARMA�IMI 1 KERE DOKUNDU�UM ZAMAN YAKALAYAMAM SADECE   PARMA�IMI 
         S�R�KLED���M ZAMAN YAKALARIM !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!

         YAN� PARMAK �Z�MLE TELEFONA DOKUNDU�UMDA BUNU deltaPosition.x ve deltaPosition.y ile yakalar�z.
         Parmak izimin x ve y y�n�ne NE KADARLIK B�R BASIN� de�eriyle dokundu�umuzu  ANLARIZ !!!!!!!!!!!!!!!!!!!!!!!!!!!!!! 

          */

        #endregion


        #region Bilgi Ve Hat�rlatma



        //Debug.Log(MyTouch.deltaPosition.magnitude); // 0
        //Debug.Log(Input.touchPressureSupported); // dokunma bas�nc� s�f�rm��.


        /*

        Dokunu�un bas�n� miktar�n� ayarl�yoruz ..

     1) Debug.Log(MyTouch.pressure);
           Dokunu�un bas�n� miktar�(Varsay�lan olarak ayarlanm�� bir �ekilde gelir ama bunu biz de�i�tirebiliriz.

           Varsay�lan olarak dokunu�un bas�n� miktar� 1 mi�.

     2) Debug.Log(  MyTouch.radius ); Dokunu�un yar��ap de�eri 0.4993 'm��.

     3) Vector2 DokunmaninPixelKoordinatlarindakiIlkKonumu = MyTouch.rawPosition;
        Debug.Log(DokunmaninPixelKoordinatlarindakiIlkKonumu);

        VARSAYILAN olarak dokunu�un pixel koordinatlar�ndaki ilk konumu  ( 0.0  , -308748400000000.0 m��.)


         */

        /*
         my_Touch.pressure = 2f;

         my_Touch.radius = 1f;

         my_Touch.rawPosition = new Vector2(0, 0);

         my_Touch.deltaPosition



        */
        #endregion


        #region V�DEO 1  KODLARI SAKIN S�LME ( �ok g�zel bir kod S�LME )

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

        #endregion


        #region V�DEO 2 KODLARI SAKIN S�LME ( 2 boyutlu oyun i�in Touch kodlar� )

        /*

       1)  Bunu 2 boyutlu oyunlarda karakterini belirledi�in noktaya dokundu�un zaman orda olmas�n� istedi�in zamanlarda
           kullan�rs�n.

       2 ) VEYA yine 2 boyutlu oyunlarda ekrana dokundu�un yerde bir obje olu�mas�n� istedi�in durumlarda
           kullan�rs�n. 



        Vector3 PositionTouch = Camera.main.ScreenToWorldPoint(my_Touch.position);
        PositionTouch.z = 0f;
        transform.position = PositionTouch;

        */

        #endregion


        #region V�DEO 3 KODLARI SAKIN S�LME ( 2 BOYUTLU OYUN i�in birden fazla dokunu� oldu�unda Touch kodlar� )

        /*

        for (int i = 0; i < Input.touchCount; i++)
        {
            Vector3 touchPos = Camera.main.ScreenToWorldPoint(Input.touches[i].position);
            Debug.DrawLine(Vector3.zero, touchPos, Color.black);
            Debug.Log(Input.touches[i]);
        }


           2 BOYUTLU OYUNLARDA telefon ekran�nda  B�RDEN FAZLa DOKUNU�U yakalam�z� ve istedi�imiz her i�lemi yapabilmemizi
           sa�lar.

        */

        #endregion


        #region V�DEO 4 JOYST�CK oldu�unda TOUCH KODLARI

        /*

        float HorizontalAction = m_joystick.Horizontal * 0.1f;
        float VerticalAction = m_joystick.Vertical * 0.1f;
        //float JumpAction = m_joystick.

        gameObject.transform.Translate(new Vector3(HorizontalAction, 0f, VerticalAction));

         Yani Joystick 'i kullanarak objemizi ileri geri hareket ettirdik.

        */

        #endregion



        TecnicalFunction();
    }

    void YeniTouchMetodum()
    {
        if (Input.touchCount > 0)
        {

            my_Touch = Input.GetTouch(0);

            if (my_Touch.deltaPosition.x >= 50f)
            {            
                gameObject.transform.position = new Vector3
               (
                  gameObject.transform.position.x + my_Touch.deltaPosition.x * TouchSpeedIdentifier * Time.deltaTime,
                  gameObject.transform.position.y,
                  gameObject.transform.position.z + my_Touch.deltaPosition.y * TouchSpeedIdentifier * Time.deltaTime
               );               
            }

            if (my_Touch.deltaPosition.x < 50f)
            {
                gameObject.transform.position = new Vector3
              (
                gameObject.transform.position.x + my_Touch.deltaPosition.x * TouchSpeedIdentifier * Time.deltaTime,
                gameObject.transform.position.y,
                gameObject.transform.position.z + my_Touch.deltaPosition.y * TouchSpeedIdentifier * Time.deltaTime
              );              
            }
            /*
            if (my_Touch.deltaPosition.y >= 50f)
            {      
                gameObject.transform.position = new Vector3
               (
                  gameObject.transform.position.x + my_Touch.deltaPosition.y * TouchSpeedIdentifier * Time.deltaTime,
                  gameObject.transform.position.y,
                  gameObject.transform.position.z + my_Touch.deltaPosition.y * TouchSpeedIdentifier * Time.deltaTime
               );
            }

            if (my_Touch.deltaPosition.y < 50f)
            {              
                gameObject.transform.position = new Vector3
              (
                gameObject.transform.position.x + my_Touch.deltaPosition.y * TouchSpeedIdentifier * Time.deltaTime,
                gameObject.transform.position.y,
                gameObject.transform.position.z + my_Touch.deltaPosition.y * TouchSpeedIdentifier * Time.deltaTime

              );           
            }
            */
        }
    }

    void TecnicalFunction()
    {
        if (Input.touchCount > 0)
        {
            YeniTouchMetodum();
            transform.Translate(0f, 0f, 2f * Time.deltaTime);

            if (my_Touch.phase == TouchPhase.Began)
            {
                m_Animator.SetBool("CalissinMi", true);

                if (IsAction)
                    SecondCharacter.GetComponent<Animator>().SetBool("CalissinMi", true);

                gameObject.transform.localPosition = new Vector3(transform.localPosition.x, 0f, transform.localPosition.z);
            }

            if (my_Touch.phase == TouchPhase.Moved)
            {
                m_Animator.SetBool("CalissinMi", true);
                if (IsAction)
                    SecondCharacter.GetComponent<Animator>().SetBool("CalissinMi", true);

                gameObject.transform.localPosition = new Vector3(transform.localPosition.x, 0f, transform.localPosition.z);
            }

            if (my_Touch.phase == TouchPhase.Stationary)
            {
                m_Animator.SetBool("CalissinMi", true);
                if (IsAction)
                    SecondCharacter.GetComponent<Animator>().SetBool("CalissinMi", true);

                gameObject.transform.localPosition = new Vector3(transform.localPosition.x, 0f, transform.localPosition.z);
            }

            if (my_Touch.phase == TouchPhase.Ended)
            {
                m_Animator.SetBool("CalissinMi", false);
                SecondCharacter.GetComponent<Animator>().SetBool("CalissinMi", false);
                gameObject.transform.localPosition = new Vector3(transform.localPosition.x, 0f, transform.localPosition.z);

            }

            
        }
    }



    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Characterler"))
        {
            Debug.Log("Rigidbody ile temas etme i�lemim ger�ekle�ti.");
            IsAction = true;
            collision.gameObject.transform.SetParent(gameObject.transform);
            collision.gameObject.transform.position = gameObject.transform.TransformPoint(Vector3.right * 1);
        }



    }

}
