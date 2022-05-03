using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnityRemoteTest : MonoBehaviour
{

    #region Deðiþkenler 1

    public Rigidbody m_body;
    public Animator m_Animator;
    public GameObject SecondCharacter;
    bool sol;
    bool sag;


    Vector3 endPos;
    [SerializeField] float ArtisMiktari;
    int dokunusSayisi;

    [SerializeField] float hiz = 5.0f;
    [SerializeField] float StationarySinirlarIcinHiz;

    float ziplama = 5.0f;
    bool IsAction;

    [SerializeField] float DistanceIdentifier;

    private Touch my_Touch;
    [SerializeField] float TouchSpeedIdentifier;

    #endregion



    private void Start()
    {
        ArtisMiktari = 5f;
        IsAction = false;

    }


    private void Update()
    {

        #region DELTA OLAYI ÇOK ÇOK ÇOK AMA ÇOK ÖNEMLÝ BÝR BÝLGÝ

        /*

         ****************************** ÖNEMLÝ BÝLGÝ  ******************************


       deltaPosition.x , deltaPosition.y gibi Mobil'den oyun yaparken DOKUNUÞ hareketlerini yaptýðýmýz çok ÖNEMLÝ BÝR ÖZELLÝK
       olan delta  þu iþleve ve þu anlama gelir : 

       !!!! DELTA , KÜÇÜK AMA FARK EDÝLEBÝLÝR BÝR ETKÝDÝR !!!!
       !!!! PARMAK ÝZÝNDE BULUNAN ÜÇGEN BENZERÝ ÞEKÝLDÝR  !!!!

         Bu Parmak izimdeki ETKÝNÝN DEÐERÝNÝ PARMAÐIMI 1 KERE DOKUNDUÐUM ZAMAN YAKALAYAMAM SADECE   PARMAÐIMI 
         SÜRÜKLEDÝÐÝM ZAMAN YAKALARIM !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!

         YANÝ PARMAK ÝZÝMLE TELEFONA DOKUNDUÐUMDA BUNU deltaPosition.x ve deltaPosition.y ile yakalarýz.
         Parmak izimin x ve y yönüne NE KADARLIK BÝR BASINÇ deðeriyle dokunduðumuzu  ANLARIZ !!!!!!!!!!!!!!!!!!!!!!!!!!!!!! 

          */

        #endregion


        #region Bilgi Ve Hatýrlatma



        //Debug.Log(MyTouch.deltaPosition.magnitude); // 0
        //Debug.Log(Input.touchPressureSupported); // dokunma basýncý sýfýrmýþ.


        /*

        Dokunuþun basýnç miktarýný ayarlýyoruz ..

     1) Debug.Log(MyTouch.pressure);
           Dokunuþun basýnç miktarý(Varsayýlan olarak ayarlanmýþ bir þekilde gelir ama bunu biz deðiþtirebiliriz.

           Varsayýlan olarak dokunuþun basýnç miktarý 1 miþ.

     2) Debug.Log(  MyTouch.radius ); Dokunuþun yarýçap deðeri 0.4993 'müþ.

     3) Vector2 DokunmaninPixelKoordinatlarindakiIlkKonumu = MyTouch.rawPosition;
        Debug.Log(DokunmaninPixelKoordinatlarindakiIlkKonumu);

        VARSAYILAN olarak dokunuþun pixel koordinatlarýndaki ilk konumu  ( 0.0  , -308748400000000.0 mýþ.)


         */

        /*
         my_Touch.pressure = 2f;

         my_Touch.radius = 1f;

         my_Touch.rawPosition = new Vector2(0, 0);

         my_Touch.deltaPosition



        */
        #endregion


        #region VÝDEO 1  KODLARI SAKIN SÝLME ( çok güzel bir kod SÝLME )

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


        #region VÝDEO 2 KODLARI SAKIN SÝLME ( 2 boyutlu oyun için Touch kodlarý )

        /*

       1)  Bunu 2 boyutlu oyunlarda karakterini belirlediðin noktaya dokunduðun zaman orda olmasýný istediðin zamanlarda
           kullanýrsýn.

       2 ) VEYA yine 2 boyutlu oyunlarda ekrana dokunduðun yerde bir obje oluþmasýný istediðin durumlarda
           kullanýrsýn. 



        Vector3 PositionTouch = Camera.main.ScreenToWorldPoint(my_Touch.position);
        PositionTouch.z = 0f;
        transform.position = PositionTouch;

        */

        #endregion


        #region VÝDEO 3 KODLARI SAKIN SÝLME ( 2 BOYUTLU OYUN için birden fazla dokunuþ olduðunda Touch kodlarý )

        /*

        for (int i = 0; i < Input.touchCount; i++)
        {
            Vector3 touchPos = Camera.main.ScreenToWorldPoint(Input.touches[i].position);
            Debug.DrawLine(Vector3.zero, touchPos, Color.black);
            Debug.Log(Input.touches[i]);
        }


           2 BOYUTLU OYUNLARDA telefon ekranýnda  BÝRDEN FAZLa DOKUNUÞU yakalamýzý ve istediðimiz her iþlemi yapabilmemizi
           saðlar.

        */

        #endregion


        #region VÝDEO 4 JOYSTÝCK olduðunda TOUCH KODLARI

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

    // mesafeden yakala enemy 'i o zaman animasyon çalýþýyor mu bak ???????*
    void TecnicalFunction()
    {


        if (Input.touchCount > 0)
        {

           

            transform.Translate(0f, 0f, hiz * Time.deltaTime);
            

            if (my_Touch.phase == TouchPhase.Began)
            {
                m_Animator.SetBool("CalissinMi", true);
                TumGidisler();

                if (IsAction)
                    SecondCharacter.GetComponent<Animator>().SetBool("CalissinMi", true);

                gameObject.transform.localPosition = new Vector3(transform.localPosition.x, 0f, transform.localPosition.z);

            }

            if (my_Touch.phase == TouchPhase.Moved)
            {
                m_Animator.SetBool("CalissinMi", true);
                TumGidisler();

                if (IsAction)
                    SecondCharacter.GetComponent<Animator>().SetBool("CalissinMi", true);

                /* Debug.Log("Parmagým Telefona sürekli dokunurken aldýðým PÝKSEL X : " + dokunus.deltaPosition.x);
                   Debug.Log("Parmaðým Telefona sürekli dokunurken aldýðým PÝKSEL  Y : " + dokunus.deltaPosition.y); */

                gameObject.transform.localPosition = new Vector3(transform.localPosition.x, 0f, transform.localPosition.z);


            }

            if (my_Touch.phase == TouchPhase.Stationary)// PARMAK ekrana dokunuyor ama hareket etmiyorsa bunu kullan.
                                                       // Debug.Log("PARMAK ekrana dokunuyor ama hareket etmiyor.");
            {
                m_Animator.SetBool("CalissinMi", true);
                TumGidisler();


                if (IsAction)
                    SecondCharacter.GetComponent<Animator>().SetBool("CalissinMi", true);

                gameObject.transform.localPosition = new Vector3(transform.localPosition.x, 0f, transform.localPosition.z);

            }

            if (my_Touch.phase == TouchPhase.Ended)
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

        if (my_Touch.deltaPosition.y >= 50f)
        {

            gameObject.transform.position = new Vector3

           (
              gameObject.transform.position.x,
              gameObject.transform.position.y,
              gameObject.transform.position.z + my_Touch.deltaPosition.y * TouchSpeedIdentifier * Time.deltaTime

           );

        }

        if (my_Touch.deltaPosition.y < 50f)
        {

            gameObject.transform.position = new Vector3

          (
            gameObject.transform.position.x,
            gameObject.transform.position.y,
            gameObject.transform.position.z + my_Touch.deltaPosition.y * TouchSpeedIdentifier * Time.deltaTime

          );

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

}
