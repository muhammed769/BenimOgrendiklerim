using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class benimOgrendiklerim : MonoBehaviour
{

    #region Degiskenler

    public GameObject deneme;
    public GameObject Karakterim;
    public GameObject s;
    public GameObject his;
    public GameObject Dusunce;
    public GameObject DusunceIki;
    Rigidbody DenemeninRigidbodysi;
    public GameObject[] cocuklar;
    public GameObject DunyaUzay�KonumObjesi;
    public GameObject anlayisObjesi;

    Vector3 benim;
    Vector3 senin;
    Vector3 onun = new Vector3(1f, 2f, 4f);

    int TiklanmaSayisi = 0;
    bool BastimMi = false;


    public Vector3 a = new Vector3(1f, 10f, 2f);


    #endregion


    #region hideflags 'in  alt dallar�


    #region [ Range ( ) ] 

    /* Range aras�na yazd���m de�erler aras�nda Unity taraf�nda ayarlayabilmemi sa�lar. 

    [Range(15, 22)]
    public int sayimiAyarla; 
    */

    #endregion


    #region [ HideInInspector ]

    /* [ HideInInspector ] '�n alt�na yazd���m kod public olsa bile bunu Inspector 'de SAKLAR ! !

    [HideInInspector]
    public string ad;

    */

    #endregion


    #region [ Min ( ) ]

    /*
        Min ( ) i�ine yazd���m de�er en d���k bu de�eri alabilir.

    [Min(7)]
    public int sayi;

     Yani sayi de�i�kenim en D���K 7 de�erini alabilir.
    */


    #endregion


    #region [ Multineline ( ) ]

    /*
     [Multiline(7)]                      Alt�nda yaz�lan olan Text alan�n�n 7 sat�rl�k olmas�n� sa�lad�k.Bunu uzun metinler yazmam�z gereken durumlarda kullan�r�z ! ! 
     public string yazmakIstedigimSey;

    */

    #endregion


    #region [Tooltip ( ) ]

    /*
     
    [Tooltip("Araban�n vites geci� ayarlar� buradan yap�l�r.")]
    public int vites;

    Alt�na yazd���n de�i�kenine KEND�N A�IKLAMA yaz�p, bunun notunu kendine HATIRLATMAN gereken yerlerde i�ine yarayabilir.

   */

    #endregion


    #region [ Header ( ) ]

    /*
      [ Header ( ) ] Projede �ok fazla de�i�ken oldu�unda bunlar� KATEGOR�ZE etmeni sa�lar.

    [Header(" Buras� Tekerleklere yapt���n AYARLAR")]
    public int tekerlek1;
    public string tekerlektipi;

    [Header("Buras� araban�n i�inin AYARLARI")]
    public int koltuksayisi;
    public string camsayisi;

    */

    #endregion


    #region  [ ContextMenu ]

    /*
    [ContextMenu("Benim Menum",false,1)]
    [ContextMenu("senin Menun", false, 2)]

    benim Menun Senin Menun 'den �stte g�z�km�� oldu. 
    [ContextMenu("Benim Menum")] // Bu Scriptin ba�l� oldu�u  Unity yerinde ... olan yere sa� t�klad���nda Benim Menum yaz�s� g�z�k�r ve a�a��da yazd���n metotta yazd�rmak istedigin �eyi yazd�rabilirsin ! ! !

    void BenimMenum()
    {
        print("benim lan bu men�.");
    }
    */

    #endregion



    #endregion




    private void Start()
    {

        /*   Time.time : Oyun ba�lad�ktan sonra ne kadar zaman ge�tigini bize s�yler.
           Time.deltaTime : Oyun ba�lad�ktan sonra  ka� frame(kare) zaman�  ge�ti�ini bize s�yler.
           Time.timeScale
     */


        #region Mathf.Abs ( )

        //float MutlakDegeriAlinmisSayi = Mathf.Abs(-2f);
        //Debug.Log(MutlakDegeriAlinmisSayi);

        #endregion


        #region Quaternion.LookRotation 

        //Quaternion donus=   Quaternion.LookRotation(Karakterim.transform.position, Karakterim.transform.position);
        //  deneme.transform.rotation = donus;

        #endregion


        #region Tam ��renemedin 

        //Quaternion takip = Quaternion.Lerp(s.transform.rotation, Karakterim.transform.rotation, 0.1f);

        //s.transform.rotation = takip;
        //Debug.Log(takip);

        #endregion


        #region  Quaternion.Euler ( )

        //deneme.transform.rotation =  Quaternion.Euler(0f, 45f, 90f);

        // Euler Metodu d�nd�rme i�lemini SADECE 1 KERE UYGULAR. Yani Update( ) metodu i�erisinde kendini G�NCELLEYEMEZ ! 

        #endregion


        #region Quaternion.Angle ( )

        //float denemeVeKarakteriminArasindakiAcininDereceCinsindenVerilmesi = Quaternion.Angle(deneme.transform.rotation, Karakterim.transform.rotation);
        //Debug.Log(denemeVeKarakteriminArasindakiAcininDereceCinsindenVerilmesi);


        //Quaternion donus = Quaternion.Inverse(deneme.transform.rotation);
        //Debug.Log(donus);

        #endregion





        // ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


        #region Vector3.Equals 

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


        #region Vector3.Dot ( )

        /*
        Vector3 birinci = new Vector3(3f, 5f, 1f);
        Vector3 ikinci = new Vector3(2f, 2f, 2f);

        float �kiVektorunNoktasalCarpimi =   Vector3.Dot(birinci,ikinci);
        Debug.Log(�kiVektorunNoktasalCarpimi);

        */
        // iki Vektorun b�y�kl�klerinin birlikte �arp�m� ve sonra aralar�ndaki a��n�n kosin�s� ile �arp�lmas�yla elde edilen bir de�er ( float )  bulunur.

        #endregion


        #region Vector3.SmoothDamp ( ) 

        //Vector3 currentVelocity = new Vector3(1f, 0f, 0f);
        //s.transform.position = Vector3.SmoothDamp(s.transform.position, deneme.transform.position, ref currentVelocity, 50f, 2f, Time.deltaTime);
        //s.transform.TransformDirection(deneme.transform.position);


        #endregion


        #region Vector3.Distance ( )

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


        #region Vector3.Distance ( )  �rnek

        /*  float KarakterimVedenemeObjeleriminArasindakiMesafe = Vector3.Distance(Karakterim.transform.position, deneme.transform.position);
          Debug.Log(KarakterimVedenemeObjeleriminArasindakiMesafe);

          if (KarakterimVedenemeObjeleriminArasindakiMesafe <= 5)
          {
              Debug.Log("�ok yakla�t�n.");
          }

        */
        #endregion


        #region Vector3.Set ( )

        //gameObject.transform.position = deneme.transform.position ;

        //benim.Set(0f, 30f, -2565f);

        //deneme.transform.position = benim;

        #endregion


        #region Vector3.Scale ( )

        // senin.Set(1f, 0f, 0f);

        // benim = Karakterim.transform.position;

        // benim.Scale(senin); // senin vekt�r�n x 'i ile benim vekt�r�m�n x 'sini �arpar. ayn� �ekilde senin vekt�r�n�n y 'siylede benim vekt�r�m�n y seni �arpar. Z koordinat� i�inde ayn�s� ge�erlidir.
        // Debug.Log(benim);

        #endregion


        #region Vector3.SqrMagnitude 

        //float BelirttigimVektorunKaresi =  Vector3.SqrMagnitude(onun);
        // Debug.Log(BelirttigimVektorunKaresi);

        #endregion


        #region Vector3.Normalize ( )

        //Vector3 VektorBuyukluguBirOldu = Vector3.Normalize(onun);
        //Debug.Log(VektorBuyukluguBirOldu);

        // Gerekli anlat�m Sayfa 1 a4 '�nde yaz�yor.

        #endregion


        #region Vector3.Magnitude ( )

        //float bibak = Vector3.Magnitude(new Vector3(1f, 2f, 3f));
        //Debug.Log(bibak);

        #endregion


        #region Vector3.Max ( ) 

        /*   Vector3 �unun = new Vector3(5f, 3f, 9f);
           Vector3 onun = new Vector3(3f, 1f, 12f);

           Vector3 benim =   Vector3.Max(�unun, onun);
           Debug.Log(benim);  
           // �IKTI  Vekt�r�m  (  5f , 3f , 12f )  oldu.  */

        #endregion


        #region Vector3.MoveTowards ( )

        //Vector3 ppp = Vector3.MoveTowards(deneme.transform.position, new Vector3(1f, 1f, 1f), 10f * Time.deltaTime);
        //deneme.transform.position = ppp;

        // YAN� bir objeyi bulundu�u konumdan ba�ka bir konuma ta��mak istiyorsan bu metodu kullan.

        #endregion


        #region Vector3.RotateTowards ( )


        /*  A�IKLAMA 
         *  RotateTowards '�n olu�turdu�u konum
         * Bir vekt�r ak�m�n� hedefe do�ru d�nd�r�r.

       Bu i�lev, vekt�r�n bir konum yerine bir y�n olarak ele al�nmas� d���nda MoveTowards'a benzer. 
       Ge�erli vekt�r, hedefi a�mak yerine tam olarak hedefin �zerine inecek olsa da, hedef y�n�ne do�ru maxRadiansDelta a��s� kadar d�nd�r�lecektir.
        Ak�m ve hedefin b�y�kl�kleri farkl�ysa, sonucun b�y�kl��� d�n�� s�ras�nda lineer olarak enterpolasyonlu olacakt�r. maxRadiansDelta i�in negatif bir de�er kullan�l�rsa,
       vekt�r tam tersi y�n� g�sterene kadar hedeften/'den uza�a d�ner ve sonra durur.
    */

        /* 1 'inci �RNEK 

        Vector3 a = new Vector3(2f, 2f, 2f);
        Vector3 b = new Vector3(5f, 7f, 10f);
        Vector3 dondurulenVektor =  Vector3.RotateTowards(a, b, 67f, 45f);

        Debug.Log(dondurulenVektor); // dondurulenVektor =  (5f,7f, 10f ) ��kt�s�n� B�ZE veriyor.

        */

        /* 2 'inci �RNEK 
        Vector3  m_sninKonumu = s.transform.position;
        Vector3 m_denemeninKonumu = deneme.transform.position;

        Vector3 olusanKonumveAyniZamandaHedefeDogruD�nd�r�lenVektor = Vector3.RotateTowards(m_sninKonumu, m_denemeninKonumu, 20f, 20f);
        s.transform.position = olusanKonumveAyniZamandaHedefeDogruD�nd�r�lenVektor;

        */

        // YAN� bir objeyi bulundu�u konumdan ba�ka bir konuma D�ND�R�LM�� bir �ekilde TA�IMAK istiyorsan bu metodu kullan.


        #endregion


        #region Vector3.Normalize( ) 

        //Vector3 vektorBuyuklugununBirOlmasi = new Vector3(2f, 3f, 4f);
        //Debug.Log( Vector3.Normalize(vektorBuyuklugununBirOlmasi));
        // Vekt�r b�y�kl���n�n bir olmas� demek Vector3.Magnitude ( ) metodunun otomatik olarak hesaplanmas� demek.

        #endregion


        #region Vector3.Project ( ) 

        /* 1 'inci �rnek 
         Vector3 a = new Vector3(1f, 1f, 1f);
         Vector3 b = new Vector3(2f, 2f, 2f);
         Vector3 debug = Vector3.Project(a, b);
         Debug.Log(debug); */


        /* 2 'inci �rnek 
          Vector3 c = new Vector3(3f, 1f, 6f);
          Vector3 d = new Vector3(2f, 3f, 4f);
          Vector3 debug = Vector3.Project(c, d);
          Debug.Log(debug); */

        /* �STED���NE ULA�TI�IN �RNEK

          Vector3 c = new Vector3(3f, 1f, 6f);
          Vector3 d = new Vector3(2f, 3f, 4f);
          deneme.transform.position = c;

          Vector3 k = Vector3.Project(deneme.transform.position, s.transform.position); // Deneme 'nin Vekt�r�n� s 'in Vekt�r�ne YANSITTIM.

          s.transform.position = k;

        */

        #endregion


        #region Vector3.Reflect ( )

        /*   �RNEK 1 
            *  Vector3 a = new Vector3(2f, 2f, 2f);
              Vector3 b = new Vector3(3f,3f, 3f);

              Vector3 c = Vector3.Reflect(b, a);

              Debug.Log(c);*/

        // deneme.transform.position = c;


        /* -----------------------------------------------------------
            ASIL OLAN �RNEK : 

            Vector3 m_InNormal = new Vector3(0f, 0f, 0f);
            Vector3 yansitilanVektor = Vector3.Reflect(Karakterim.transform.position, m_InNormal);
            s.transform.position = yansitilanVektor;

            // his objesinin yan�na s objesini YANSITMI� OLDUK. YAN� sen bir objeyi bir objenin yan�na yans�tabilmeyi ��renmi� oldun.

            */
        #endregion


        #region Vector3.SignedAngle ( ) 

        // Eksene g�re vekt�rler aras�ndaki a��y� hesaplar.
        // Axis ( Eksen ) : Etraf�nda di�er vekt�rlerin d�nd�r�ld��� vekt�r.
        // �ki vekt�r aras�ndaki olas� iki a��dan daha k���k olan� d�nd�r�l�r, bu nedenle sonu� asla 180 derecen b�y�k veya -180 dereceden k���k OLAMAZ ! !

        /*
                Vector3 hisinKonumu = his.transform.position;
                Vector3 sinKonumu = s.transform.position;


                float Vekt�rlerArasindakiAci = Vector3.SignedAngle(hisinKonumu, sinKonumu, new Vector3(0f, 20f, 0f));
                Debug.Log(Vekt�rlerArasindakiAci);
        */
        #endregion


        #region Vector3.Lerp  ( )

        // 2 vekt�r aras�ndaki do�rusal bir �izgi olu�turup birinin di�erinin yan�na gitmesini sa�l�caz.

        //Vector3 ikiVektorArasindakiCizgi = Vector3.Lerp(deneme.transform.position, Karakterim.transform.position, Time.time * 0.2f);

        //s.transform.position = ikiVektorArasindakiCizgi + new Vector3(0f, 3.5f, 0f);

        // ------ �K�NC� �RNEK ------

        //Vector3 ilkPozisyon = new Vector3(deneme.transform.position.x, deneme.transform.position.y, deneme.transform.position.z) + new Vector3(0f, 3f, 0f);
        //Vector3 ikinciPozisyon = new Vector3(deneme.transform.position.x, deneme.transform.position.y, deneme.transform.position.z) + new Vector3(0f, 25f, 0f);

        //Vector3 ikiVektor = Vector3.Lerp(ilkPozisyon, ikinciPozisyon, Time.time * 0.2f);
        //s.transform.position = ikiVektor;


        #endregion


        #region Vector3.LerpUnclamped ( ) 


        // Vector3 LerpUnclampedDenemesi = Vector3.LerpUnclamped(deneme.transform.position, Karakterim.transform.position, Time.time);

        // s.transform.position = LerpUnclampedDenemesi;

        // Debug.Log(LerpUnclampedDenemesi);

        #endregion


        #region Vector3.Slerp ()

        //Lerp te oldu�u gibi iki vekt�r aras�nda bir �izgi olu�turup birinin di�erinin yan�na gitmesini sa�lad�k.
        //   a ve b aras�nda t miktar�na g�re interpolasyon yapar.
        //   t parametresi[0, 1] aral���na sabitlenir.

        //Vector3 denemeninKonumu = deneme.transform.position;
        //Vector3 SobjesinininKonumu = s.transform.position;

        //Vector3 IkiVektorarasindakicizgi = Vector3.Slerp(denemeninKonumu, SobjesinininKonumu, 0.2f);
        //s.transform.position = IkiVektorarasindakicizgi;


        #endregion


        #region Vector.Lerp () ve Vector3.Slerp () aras�ndaki FARK 

        /*
         Vector.Lerp ( ) VE Vector.Slerp ( ) aras�ndaki FARK :

                  Slerp 'te vekt�rlerin uzaydaki NOKTALAR  yerine Y�NLER  olarak ele al�nmas�d�r.
                  D�nd�r�len vekt�rlerin y�n�, a�� ile ile interpolasyon yap�l�r ve b�y�kl��� from ve to b�y�kleri arsa�nda interpolasyon yap�l�r.       

        Yani ikisindede benim yapt���m denemeler sonucunda  ��kt�lar�n ayn� oldu�unu g�rd�m. O zaman burdan �unu anlayabilirim : �kiside ( Lerp ve Slerp ) ayn� sonu�lar� veriyor sadece y�ntemleri  farkl�. 

        */
        #endregion


        #region Vector3.SlerpUnclamped ( )
        /*
        Vector3 denemeninKonumu = deneme.transform.position;
        Vector3 SobjesinininKonumu = s.transform.position;

        Vector3 IkiVektorarasindakicizgi = Vector3.SlerpUnclamped(denemeninKonumu, SobjesinininKonumu, 3f);
        s.transform.position = IkiVektorarasindakicizgi;

        */
        #endregion


        #region Vector.Slerp ( ) ve Vector.SlerpUnclamped ( ) ' ten FARKI 

        /* Vector3.SlerpUnclamped statik bir y�ntemdir, a ve b vekt�rlerinin �TES�NE GE�EB�L�R. Vector3.Slerp ( ) 'te ise t ka� olursa olsun a ve b vekt�rlerinin �TES�NE GE�EMEZ ! ! 
         * Bu t 'nin SIFIRDAN K���K veya B�RDEN B�Y�K olabilece�i anlam�na gelir.


       */
        #endregion


        #region Vector3.zero

        /* Vekt�r� ( 0,0,0 ) yapar.

        Vector3 a = new Vector3(2f, 4f, 5f);
         a = Vector3.zero;
        Debug.Log(a);

        */
        #endregion


        #region Vector3.up

        /* 
         Vekt�r�  ( 0,1,0 ) yapar.
        Vector3 a = new Vector3(3f, 45f, 9f);
        a = Vector3.up;
        Debug.Log(a);

        */

        #endregion


        #region Vector3.forward

        /*
                Vekt�r� ( 0,0,1 ) yapar.

          Vector3 a = new Vector3(8f, 92f, 3f);
          a = Vector3.forward;
          Debug.Log(a);

       */

        #endregion


        #region  Vector3.one 


        // Vector3 h = new Vector3(4f, 5f, 2f);
        // Debug.Log(  h = Vector3.one);

        // transform.position = Vector3.one;
        //  Karakterim.transform.localScale =Vector3.one;

        #endregion


        #region Vector3.right

        /*   1 'inci �rnek 
          *  Vector3 a = new Vector3(2f, 5f, 6f);
          a = Vector3.right; // Vekt�r� ( 1,0,0 ) yapar.
           Debug.Log(a); */

        /* *************************************** 2 �nci �rnek*************************************** 

           Vector3 m_hisinKonumu = his.transform.position;
           m_hisinKonumu = Vector3.right;

        // Debug.Log(m_hisinKonumu);

           his.transform.position = m_hisinKonumu;

        YAN�  his'in Konumunu 1,0,0 ta��m�� olduk. 
           */

        #endregion


        // ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------




        #region transform.BroadcastMessage ()
        /* BroadcastMessage kendine mesaj g�ndermesinin yan�nda e�er istenirse �ocuk objelerinin tamam�na mesaj g�nderebilir.
        //  gameObject.transform.BroadcastMessage("Mesajim");

        void Mesajim(int numara)
        {
            Debug.Log("naber lan" + numara);
        }*/
        #endregion


        #region transform.SendMessage ()

        /*
        // Sadece ba�l� oldu�u objeye mesah g�nderebilir.
        //  transform.SendMessage("Mesajim",144,SendMessageOptions.DontRequireReceiver);

        void Mesajim(int numara)
        {
            Debug.Log("naber lan" + numara);
        } */

        #endregion


        #region transform.childCount
        /* Kendi cocuk objelerinin say�s�n� bize verir.

        int cocukObjeleriminSayisi = transform.childCount;
        Debug.Log(cocukObjeleriminSayisi);

         */

        #endregion


        #region transform.DetachChildren();

        // T�m �ocuklar� EBEVEYNS�Z b�rak�r.
        // gameObject.transform.DetachChildren();


        #endregion


        #region transform.Equals ( )
        /*  1'inci �RNEK
         bool dogruMu = gameObject.transform.Equals(his.transform.position);

          if (dogruMu)
          {
              Debug.Log("Evet dpgru");

          }

          else
          {
              Debug.Log("Hay�r yanl��.");
          }
        */

        /* 2'�NC� �RNEK 
        Transform a = gameObject.transform;

     bool kontrolEt=    gameObject.transform.Equals(a);

        if (kontrolEt)
        {
            Debug.Log("Evet do�ru");

        }
        else
        {
            Debug.Log("hay�r yanl��.");
        }
        */
        #endregion


        #region transform.eulerAngles

        /*   eulerAngles, d�nya uzay�ndaki d�n��� temsil eder. ... Unity'de bu d�nd�rmeler Z ekseni, X ekseni ve Y ekseni etraf�nda bu s�rayla ger�ekle�tirilir.
             Bu �zelli�i ayarlayarak bir Kuaternion'un d�n���n� ayarlayabilir ve bu �zelli�i okuyarak Euler a�� de�erlerini okuyabilirsiniz.

        // YAN�  objelerin Rotation x,y ve z de�erlerinin ne oldu�unu anlar�z ! !

         Vector3  b = deneme.transform.eulerAngles;
         Debug.Log(b); 

        */

        #endregion


        #region transform.Find

        // kendi �ocuk objelerinde  �u isimli bir obje varm� bulmaya yarar.

        /*   Transform bulunulanObje  =   gameObject.transform.Find("Top3");

           Debug.Log(bulunulanObje.name); */

        #endregion


        #region  transform.forward *

        /* 
         transform.forward z ekseninde hareket ettirir.
         Vector3.forward 'dan FARKLI OLARAK Transform.forward GameObject ' i HAREKET ETT�R�RKEN AYNI ZAMANDA  ROTASYONUNUDA D�KKATE ALIR.
         Bir GameObject D�ND�R�LD���NDE, GameObject'in z eksenini temsil eden mavi ok da Y�N  DE���T�R�R ! !  


        1'inci �rnek    deneme.transform.position = transform.forward; // denemenin konumu ( 0,0,1 ) de art�k. */

        /*
          2  'inci �rnek

         Bu kodu  update metodu i�erisinde yaz yoksa ANLAMAZSIN d�zen bozulmas�n diye buraya yazd�m.

         deneme.transform.GetComponent<Rigidbody>().velocity = his.transform.forward * 2f;  // deneme objesini D�ND�REREK Z EKSEN�NDE HAREKET ETT�RD�K ! ! 

         */

        // B�LORDO TOP OYUN F�KR�NDE BURDAN �LHAM AL ! !
        #endregion


        #region   transform.GetChild ( ) *

        /* Kenci �ocuk objesini yakalay�p onun �st�nde i�lem yapabilmeyi bize sa�lar.

      Transform ilkCocugum=   transform.GetChild(0);

        ilkCocugum.localPosition  = new Vector3(1f, 1f, 1f);                                // ger�ekten  ( 1 , 1 ,1 )  e  gelmi� oldu. ��NK� LOCALPOS�T�ON  = OBJEN�N KEND�S�N�N O  ANK� POZ�SYONUNU MERKEZ NOKTA ( 0 ,0,0 ) KABUL ETT� SONRA  onu 1,1,1
                                                                                               e getirdi.
        ilkCocugum.position = new Vector3(1f, 1f, 1f);                                      //  ( 2.98 , -4.55 240.95 ) e geldi. ��NK�  POS�T�ON  = SAHNEDEK� merkez noktaya ( 0,0,0 ) gitti ordan (  1, 1, 1) ' e geldi.  

        Debug.Log(ilkCocugum.name);

        */

        #endregion


        #region transform.GetEnumerator()

        // �lgili IEnumerator' � ( Coroutine '�) yakalay�p i�lem yapabilmeyi sa�lar.
        //    IEnumerator b = transform.GetEnumerator();

        #endregion


        #region GetHashCode () ve GetInstanceID ( )

        /*  

           int hashcode = transform.GetHashCode();
           Debug.Log(hashcode); // 19174

          int objeminKimligi =   transform.GetInstanceID();
          Debug.Log(objeminKimligi); // 19174

          G�rd���n gibi GetHasCode ( ) ve GetInstanceID ( ) metodu bu objem i�in ayn� de�eri verdi. YAN� objem 19174 de�eriyle S�STEMDE kendine yer buluyor ! ! 

        */
        #endregion


        #region  transform.GetSiblingIndex()

        /*

        int a = cocuklar[2].transform.GetSiblingIndex();
        Debug.Log(a);

         Parent - child ili�kisi olan objelerde istedi�in �ocu�un indeksini alabilirsin.

        */


        #endregion


        #region transform.hideflags ==> Bu Scriptin en ba��na yani hideFlags'in alt dallar� k�sm�na da bir bakman senin i�in iyi olur 



        //   transform.hideFlags = HideFlags.DontSave; ( TAM ANLAMADIN ! ! )     // Nesne sahneye kaydedilmez. Yeni bir sahne y�klendi�inde  yok edilmeyecektir.


        //     transform.hideFlags = HideFlags.NotEditable;        // objemin transform COMPONENT�NDE  Inspectorunda herhangi bir ayar�   de�i�tirmemi ENGELLER ! ! ! 

        //   transform.hideFlags = HideFlags.HideInInspector;     // objemin transformunu Inspector 'DA G�STERMEZ ! !

        //     transform.hideFlags = HideFlags.HideInHierarchy;  // objemi Hierarchy 'de G�STERMEZ AMA sahnede vard�r.

        #endregion


        #region transform.hierarchyCapacity

        /*
         
        int sayi = 6;
           transform.hierarchyCapacity=sayi;
        Debug.Log(transform.hierarchyCapacity);

        // Hierarchy'nin  o haliyle Hierarchy kapasitesini S�STEM B�ZE 4 olarak verdi ama ben burda dedimki KAPAS�TES� 6 OLSUN demi� oldum.

        */

        #endregion


        #region transform.hierarchyCount

        // D�n���m�n hiyerar�i veri yap�s�ndaki d�n���m�n say�s� 

        //  Debug.Log(transform.hierarchyCount);

        #endregion


        #region   transform.InverseTransformDirection ( )

        /* �lgili y�n� d�nya uzay�ndan yerel uzaya d�n��t�r�r.

        Vector3 relative;
        relative = transform.InverseTransformDirection(Vector3.forward);
        Debug.Log(relative);

        */

        #endregion


        #region transform.InverseTransformPoint 'i  ( )  anlaman i�in �al��malar�n 1 

        /*    KONUYA GE�MEDEN �NCE BURAYI MUTLAKA  OKU 
           Vector3 denemeninKonumVektorDegeri = deneme.transform.position;
            Debug.Log(denemeninKonumVektorDegeri); // ekranda denemenin Position  x , y,  z ( -25.63,0.69, -434.79  ) olarakta AYNISINI G�R�YORSUN �UAN.....

            Vector3 DenemeninbirBirim�lerletilmisVektoru=  denemeninKonumVektorDegeri + (Vector3.forward);
            Debug.Log(DenemeninbirBirim�lerletilmisVektoru);   ekranda x , y ,z  (  -25.63,0.69,   -433.79   ) olarak g�rd�n. 

           */

        /* YAN� SEN BURDA YAKALAMAK �STED���N VEKT�R� YAKALADIN VE �STED���N ��LEM� YAPTIRAB�L�RS�N. ��MD� bu InverseTransformPoint olay�n� dolas�ylada Local uzay olay�n� ��ZMEN LAZIM ..... 
           BURAYI MUTLAKA AMA MUTLAKA ��ZMEN LAZIM ! ! !  */



        //Vector3 denemeninVektoru=  deneme.transform.InverseTransformPoint(Vector3.forward);
        //    Debug.Log(denemeninVektoru); 
        // deneme.transform.position = denemeninVektoru; 


        //Vector3 denemeninKonumVektoru = deneme.transform.position;
        //Debug.Log(denemeninKonumVektoru);


        //Vector3 x = deneme.transform.InverseTransformPoint(new Vector3(0.001f, 0.001f, 0.001f));
        //Debug.Log(x);
        //deneme.transform.position = x;

        //Vector3 denemeninLocalKonumu = deneme.transform.localPosition;
        //Debug.Log(denemeninLocalKonumu); // ekranda denemenin konum de�erleri neyse ��kt� olarakta ayn�s�n� al�yoruz.

        #endregion


        #region transform.InverseTransformPoint 'i ( )  anlaman i�in �al��malar�n 2 

        /* a�ama 1 
        Vector3 DusunceninKonumununVektoru = Dusunce.transform.position;
        Debug.Log(DusunceninKonumununVektoru);

        */

        /* a�ama 2
        Vector3 transformPointinVEktoru =   Dusunce.transform.TransformPoint(Vector3.forward);
        Debug.Log(transformPointinVEktoru);

        */

        /* A�AMA 3  SONUNDA ANLADIN  DEFTERDE  8 NUMARALI SAYFAYA BAK

        Vector3 DusunceInverseTransformPointinVektoru = Dusunce.transform.InverseTransformPoint(Vector3.forward);
        Debug.Log(DusunceInverseTransformPointinVektoru);

        */
        #endregion


        #region  transform.InverseTransformPoint  ( ) 'i ARTIK ANLADIN ��MD� �RNEK YAPAB�L�RS�N

        /*
              Vector3 DusunceninInverseTransformPointVektoru =   Dusunce.transform.InverseTransformPoint(Vector3.forward*2);
              Dusunce.transform.position = DusunceninInverseTransformPointVektoru;

              Vector3 DusunceIkininTransformPointVektoru = DusunceIki.transform.TransformPoint(Vector3.forward);
              DusunceIki.transform.position = DusunceIkininTransformPointVektoru;

              */
        #endregion


        #region  transform.InverseTransformVector ()

        /*
         * 
        Vector3 DusunceninKonumu = Dusunce.transform.position;
        Debug.Log(DusunceninKonumu);


        Vector3 DusunceninInverseTransformVectoru = Dusunce.transform.InverseTransformVector(Vector3.forward);
        Dusunce.transform.position = DusunceninInverseTransformVectoru;
        Debug.Log(Dusunce.transform.position);
              Dusunce kendi VEktorunu forward �zelli�inden ald� yani ne olursa olsun( 0, 0, 1 ) oldu.



        Vector3 DusunceninInverseTransformVectoru = Dusunce.transform.InverseTransformVector(DusunceIki.transform.position);
        Debug.Log(DusunceninInverseTransformVectoru);
        Dusunce.transform.position = DusunceninInverseTransformVectoru; 
              DusunceIki 'nin Vekt�r�n� alm�� oldu.

         Yani BURDA InverseTransformPoint ( ) 'te oldu�u gibi EKS� 'L� B�R DE�ER ALMA S�Z KONUSU DE��L ! ! 
       */


        #endregion


        #region transform.IsChildOf ( ) 

        // bir obje bir objenin annesimi de�il mi kontrol eder. ( true , false d�nd�r�r.)
        //  Debug.Log(   his.transform.IsChildOf(DusunceIki.transform));

        #endregion


        #region transform.localEulerAngles

        /*   Debug.Log( deneme.transform.localEulerAngles);

        Vector3 denemeninRotationDegerleri = new Vector3(23f, 45f, 302f);
        deneme.transform.localEulerAngles = denemeninRotationDegerleri;

         transform.localEulerAngles = YAN� Rotation x, y ve z de�elerini ayarlamam�z� sa�lar. ( derece ) 

        */


        #endregion




        #region transform.localPosition ve transform.Position TAM ANLADI�IN HAL� 


        // s objesi resetlenmi� bir �ekilde deneme objesinin cocuk objesi.  % % Deneme = ( -4.19 , 0.841 , 4.59 )   % % anlayisobjesi = ( 7.84 , 1.34 , 12.33 )  % % DunyaUZay�Konumobjesi = ( 0,0,0 )


        Vector3 Referansvektorum = new Vector3(1f, 1f, 1f);

        //  *************** 1.KISIM ***************

        //  s.transform.localPosition = Referansvektorum;              // s  'in konumu vektor de�erleri  = ( 1 , 1 , 1 ) oldu.
        //  anlayisObjesi.transform.position = Referansvektorum;      // anlayis objesinin 'de konumu ( 1,1,1 ) oldu.   

        // ANCAK anlayis objesi D�NYA UZAYI ( 0 ,0 ,0 ) KONUMUNA G�RE ( 1 , 1 ,1 ) OLDU.  S objesi ise  KEND� D�NYA UZAYI DENEME OBJES� OLDU�U ���N DENEMEYE G�RE ( 1, 1 ,1 ) KONUMUNU ALDI ! !


        // *************** 2.KISIM ***************

        // s.transform.position = Referansvektorum;
        // anlayisObjesi.transform.position = Referansvektorum;

        /*  s ' inde anlayis objesininde konumu AYNI YERDE OLDU. Yani ( 1,1 ,1 ) konumuna geldi. ��nk� S ' i oyunun  D�NYA UZAYINA G�RE ( 0 , 0 ,0 ) g�re konumland�rd�k.
            s 'i burda oyunun D�NYA UZAYINA G�RE konumland�rd�k evet ama deneme objesinin �ocuk objesi oldu�u i�in  Ekranda deneme objesine g�re uzakl���n�n  vektor de�erlerini  ( 4.62 , 4.29 , 0.0972 )  alm�� oldu. */


      //  *************** 3.KISIM * **************

       anlayisObjesi.transform.localPosition = Referansvektorum;
       anlayisObjesi.transform.position = Referansvektorum;

        // G�rd���n gibi anlayisObjesi HERHANG� B�R OBJEYLE ANNE COCUK �L��K�S� OLMADI�I ���N localPosition desende position desende SAHNEDE AYNI KONUMDA AYNI VEKTOR DE�ERLER�NE SAH�P OLARAK G�R�RS�N ! !

        #endregion
    }




    private void Update()
    {


        // BUNLARA SONRA BAKMAYI UNUTMA ! !

        #region TransformPoint ( ) 

        //  Vector3 KarakteriminPozisyonu = s.transform.TransformPoint(Vector3.back); // s Objesinin arkas�ndaki Vekt�r� YAKALADIK ! !
        //  Debug.Log(KarakteriminPozisyonu);
        //  Instantiate(s, KarakteriminPozisyonu, Quaternion.identity);

        // �STED���M NOKTAYI YAKALAYIP BU NOKTAYLA �LG�L� ��LEM YAPAB�L�YORUM ! !


        #endregion


        #region TransformPoint 'in�rne�i

        /*  if (Input.GetKeyDown(KeyCode.Q))
          {
              KupOlusturmaFunction();

          }

      }

      void KupOlusturmaFunction()
      {
          TiklanmaSayisi++;

          if (TiklanmaSayisi <= 3)
          {
              Vector3 olusacakObjeminKonumu = s.transform.TransformPoint(Vector3.back); // s Objesinin arkas�ndaki Vekt�r� YAKALADIK ! !
                                                                                        //  Debug.Log(KarakteriminPozisyonu);
              Instantiate(s, olusacakObjeminKonumu, Quaternion.identity);

          }
          else if (TiklanmaSayisi >= 4 && TiklanmaSayisi <= 6)
          {
              Vector3 IkinciTurOlusacakObjeminKonumu = deneme.transform.TransformPoint(Vector3.forward);
              Instantiate(s, IkinciTurOlusacakObjeminKonumu, Quaternion.identity);
          }

          else
          {
              Debug.Log(" Bir daha t�klayamazs�n ! ! ! ! ! !");
          }

          */

        #endregion



    }




}





