using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class benimOgrendiklerim : MonoBehaviour
{
    public GameObject deneme;
    public GameObject Karakterim;
    public GameObject s;

    Vector3 benim;
    Vector3 senin;
    Vector3 onun = new Vector3(1f, 2f, 4f);



    private void Start()
    {


        #region ��rendiklerim 0 

        //float ikiKupArasindakiMesafe = Vector3.Distance(Karakterim.transform.position, deneme.transform.position);
        //// Debug.Log(ikiKupArasindakiMesafe);


        //if (ikiKupArasindakiMesafe < 7f && ikiKupArasindakiMesafe > 5f)
        //{
        //    Vector3 olusacakNoktaninTamKonumu = transform.TransformPoint(Vector3.left * 3);
        //    Instantiate(deneme, olusacakNoktaninTamKonumu, Quaternion.identity);
        //}

        //else if (ikiKupArasindakiMesafe < 5f && ikiKupArasindakiMesafe > 1f)
        //{
        //    Vector3 olusacakNoktaninTamKonumu = transform.TransformPoint(Vector3.right * 33);
        //    Instantiate(deneme, olusacakNoktaninTamKonumu, Quaternion.identity);
        //}

        // NOT :  2 obje aras�ndaki mesafeyi bulmay� ve  istedi�in noktaya obje olu�turmay� anlad�n. .


        #endregion


        #region ��rendiklerim 1 

        //gameObject.transform.position = deneme.transform.position ;

        //benim.Set(0f, 30f, -2565f);

        //deneme.transform.position = benim;

        #endregion


        #region ��rendiklerim 2

        // senin.Set(1f, 0f, 0f);

        // benim = Karakterim.transform.position;

        // benim.Scale(senin); // senin vekt�r�n x 'i ile benim vekt�r�m�n x 'sini �arpar. ayn� �ekilde senin vekt�r�n�n y 'siylede benim vekt�r�m�n y seni �arpar. Z koordinat� i�inde ayn�s� ge�erlidir.
        // Debug.Log(benim);

        #endregion


        #region ��rendiklerim 3

        //Quaternion donusAcim=  Quaternion.Euler(45f, 45f, 45f);
        // deneme.transform.rotation = donusAcim;

        #endregion


        #region ��rendiklerim 4

        //float BelirttigimVektorunKaresi =  Vector3.SqrMagnitude(onun);
        // Debug.Log(BelirttigimVektorunKaresi);

        #endregion


        #region ��rendiklerim 5 

        //Vector3 VektorBuyukluguBirOldu = Vector3.Normalize(onun);
        //Debug.Log(VektorBuyukluguBirOldu);

        // Gerekli anlat�m Sayfa 1 a4 '�nde yaz�yor.

        #endregion


        #region ��rendiklerim 6 

        //float MutlakDegeriAlinmisSayi = Mathf.Abs(-2f);
        //Debug.Log(MutlakDegeriAlinmisSayi);

        #endregion


        #region ��rendiklerim 7 

        //Quaternion donus=   Quaternion.LookRotation(Karakterim.transform.position, Karakterim.transform.position);
        //  deneme.transform.rotation = donus;

        #endregion


        #region Tam ��renemedin 

        //Quaternion takip = Quaternion.Lerp(s.transform.rotation, Karakterim.transform.rotation, 0.1f);

        //s.transform.rotation = takip;
        //Debug.Log(takip);

        #endregion


        #region ��rendiklerim 8

        //Vector3 ikiVektorArasindakiCizgi = Vector3.Lerp(deneme.transform.position, Karakterim.transform.position, Time.time * 0.2f);

        //s.transform.position = ikiVektorArasindakiCizgi + new Vector3(0f, 3.5f, 0f);

        // ------ �K�NC� �RNEK ------

        //Vector3 ilkPozisyon = new Vector3(deneme.transform.position.x, deneme.transform.position.y, deneme.transform.position.z) + new Vector3(0f, 3f, 0f);
        //Vector3 ikinciPozisyon = new Vector3(deneme.transform.position.x, deneme.transform.position.y, deneme.transform.position.z) + new Vector3(0f, 25f, 0f);

        //Vector3 ikiVektor = Vector3.Lerp(ilkPozisyon, ikinciPozisyon, Time.time * 0.2f);
        //s.transform.position = ikiVektor;


        #endregion


        #region  ��rendiklerim 9

        //deneme.transform.rotation =  Quaternion.Euler(0f, 45f, 90f);

        // Euler Metodu d�nd�rme i�lemini SADECE 1 KERE UYGULAR. Yani Update( ) metodu i�erisinde kendini G�NCELLEYEMEZ ! 

        #endregion


        #region ��rendiklerim 10

        //float denemeVeKarakteriminArasindakiAcininDereceCinsindenVerilmesi = Quaternion.Angle(deneme.transform.rotation, Karakterim.transform.rotation);
        //Debug.Log(denemeVeKarakteriminArasindakiAcininDereceCinsindenVerilmesi);


        //Quaternion donus = Quaternion.Inverse(deneme.transform.rotation);
        //Debug.Log(donus);

        #endregion


        #region ��rendiklerim 11

        //bool kontrolEt = Vector3.Equals(deneme.transform.position, Karakterim.transform.position);
        //if (kontrolEt)

        //{
        //    Debug.Log("Evet deneme ve karakterim objelerinin Vektorleri ayn�");
        //}
        //else
        //{
        //    Debug.Log("Hay�r DE��L ! ! ! ");
        //}

        #endregion


        #region ��rendiklerim 12 

        //Vector3 currentVelocity = new Vector3(1f, 0f, 0f);
        //s.transform.position = Vector3.SmoothDamp(s.transform.position, deneme.transform.position, ref currentVelocity, 50f, 2f, Time.deltaTime);
        //s.transform.TransformDirection(deneme.transform.position);


        #endregion
    }

    private void Update()
    {
       
        
    }



  
}
