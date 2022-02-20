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
    public GameObject DunyaUzayýKonumObjesi;
    public GameObject anlayisObjesi;
    public GameObject resim;
    public GameObject tablo;

    Vector3 benim;
    Vector3 senin;
    Vector3 onun = new Vector3(1f, 2f, 4f);

    int TiklanmaSayisi = 0;
    bool BastimMi = false;


    public Vector3 a = new Vector3(1f, 10f, 2f);


    #endregion


    #region hideflags 'in  alt dallarý


    #region [ Range ( ) ] 

    /* Range arasýna yazdýðým deðerler arasýnda Unity tarafýnda ayarlayabilmemi saðlar. 

    [Range(15, 22)]
    public int sayimiAyarla; 
    */

    #endregion


    #region [ HideInInspector ]

    /* [ HideInInspector ] 'ün altýna yazdýðým kod public olsa bile bunu Inspector 'de SAKLAR ! !

    [HideInInspector]
    public string ad;

    */

    #endregion


    #region [ Min ( ) ]

    /*
        Min ( ) içine yazdýðým deðer en düþük bu deðeri alabilir.

    [Min(7)]
    public int sayi;

     Yani sayi deðiþkenim en DÜÞÜK 7 deðerini alabilir.
    */


    #endregion


    #region [ Multineline ( ) ]

    /*
     [Multiline(7)]                      Altýnda yazýlan olan Text alanýnýn 7 satýrlýk olmasýný saðladýk.Bunu uzun metinler yazmamýz gereken durumlarda kullanýrýz ! ! 
     public string yazmakIstedigimSey;

    */

    #endregion


    #region [Tooltip ( ) ]

    /*
     
    [Tooltip("Arabanýn vites geciþ ayarlarý buradan yapýlýr.")]
    public int vites;

    Altýna yazdýðýn deðiþkenine KENDÝN AÇIKLAMA yazýp, bunun notunu kendine HATIRLATMAN gereken yerlerde iþine yarayabilir.

   */

    #endregion


    #region [ Header ( ) ]

    /*
      [ Header ( ) ] Projede çok fazla deðiþken olduðunda bunlarý KATEGORÝZE etmeni saðlar.

    [Header(" Burasý Tekerleklere yaptýðýn AYARLAR")]
    public int tekerlek1;
    public string tekerlektipi;

    [Header("Burasý arabanýn içinin AYARLARI")]
    public int koltuksayisi;
    public string camsayisi;

    */

    #endregion


    #region  [ ContextMenu ]

    /*
    [ContextMenu("Benim Menum",false,1)]
    [ContextMenu("senin Menun", false, 2)]

    benim Menun Senin Menun 'den üstte gözükmüþ oldu. 
    [ContextMenu("Benim Menum")] // Bu Scriptin baðlý olduðu  Unity yerinde ... olan yere sað týkladýðýnda Benim Menum yazýsý gözükür ve aþaðýda yazdýðýn metotta yazdýrmak istedigin þeyi yazdýrabilirsin ! ! !

    void BenimMenum()
    {
        print("benim lan bu menü.");
    }
    */

    #endregion



    #endregion




    private void Start()
    {

        /*   Time.time : Oyun baþladýktan sonra ne kadar zaman geçtigini bize söyler.
           Time.deltaTime : Oyun baþladýktan sonra  kaç frame(kare) zamaný  geçtiðini bize söyler.
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


        #region Tam Öðrenemedin 

        //Quaternion takip = Quaternion.Lerp(s.transform.rotation, Karakterim.transform.rotation, 0.1f);

        //s.transform.rotation = takip;
        //Debug.Log(takip);

        #endregion


        #region  Quaternion.Euler ( )

        //deneme.transform.rotation =  Quaternion.Euler(0f, 45f, 90f);

        // Euler Metodu döndürme iþlemini SADECE 1 KERE UYGULAR. Yani Update( ) metodu içerisinde kendini GÜNCELLEYEMEZ ! 

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
        //    Debug.Log("Evet deneme ve karakterim objelerinin Vektorleri ayný");
        //}
        //else
        //{
        //    Debug.Log("Hayýr DEÐÝL ! ! ! ");
        //}

        #endregion


        #region Vector3.Dot ( )

        /*
        Vector3 birinci = new Vector3(3f, 5f, 1f);
        Vector3 ikinci = new Vector3(2f, 2f, 2f);

        float ÝkiVektorunNoktasalCarpimi =   Vector3.Dot(birinci,ikinci);
        Debug.Log(ÝkiVektorunNoktasalCarpimi);

        */
        // iki Vektorun büyüklüklerinin birlikte çarpýmý ve sonra aralarýndaki açýnýn kosinüsü ile çarpýlmasýyla elde edilen bir deðer ( float )  bulunur.

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

        // NOT :  2 obje arasýndaki mesafeyi bulmayý ve  istediðin noktaya obje oluþturmayý anladýn. .


        #endregion


        #region Vector3.Distance ( )  Örnek

        /*  float KarakterimVedenemeObjeleriminArasindakiMesafe = Vector3.Distance(Karakterim.transform.position, deneme.transform.position);
          Debug.Log(KarakterimVedenemeObjeleriminArasindakiMesafe);

          if (KarakterimVedenemeObjeleriminArasindakiMesafe <= 5)
          {
              Debug.Log("Çok yaklaþtýn.");
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

        // benim.Scale(senin); // senin vektörün x 'i ile benim vektörümün x 'sini çarpar. ayný þekilde senin vektörünün y 'siylede benim vektörümün y seni çarpar. Z koordinatý içinde aynýsý geçerlidir.
        // Debug.Log(benim);

        #endregion


        #region Vector3.SqrMagnitude 

        //float BelirttigimVektorunKaresi =  Vector3.SqrMagnitude(onun);
        // Debug.Log(BelirttigimVektorunKaresi);

        #endregion


        #region Vector3.Normalize ( )

        //Vector3 VektorBuyukluguBirOldu = Vector3.Normalize(onun);
        //Debug.Log(VektorBuyukluguBirOldu);

        // Gerekli anlatým Sayfa 1 a4 'ünde yazýyor.

        #endregion


        #region Vector3.Magnitude ( )

        //float bibak = Vector3.Magnitude(new Vector3(1f, 2f, 3f));
        //Debug.Log(bibak);

        #endregion


        #region Vector3.Max ( ) 

        /*   Vector3 þunun = new Vector3(5f, 3f, 9f);
           Vector3 onun = new Vector3(3f, 1f, 12f);

           Vector3 benim =   Vector3.Max(þunun, onun);
           Debug.Log(benim);  
           // ÇIKTI  Vektörüm  (  5f , 3f , 12f )  oldu.  */

        #endregion


        #region Vector3.MoveTowards ( )

        //Vector3 ppp = Vector3.MoveTowards(deneme.transform.position, new Vector3(1f, 1f, 1f), 10f * Time.deltaTime);
        //deneme.transform.position = ppp;

        // YANÝ bir objeyi bulunduðu konumdan baþka bir konuma taþýmak istiyorsan bu metodu kullan.

        #endregion


        #region Vector3.RotateTowards ( )


        /*  AÇIKLAMA 
         *  RotateTowards 'ýn oluþturduðu konum
         * Bir vektör akýmýný hedefe doðru döndürür.

       Bu iþlev, vektörün bir konum yerine bir yön olarak ele alýnmasý dýþýnda MoveTowards'a benzer. 
       Geçerli vektör, hedefi aþmak yerine tam olarak hedefin üzerine inecek olsa da, hedef yönüne doðru maxRadiansDelta açýsý kadar döndürülecektir.
        Akým ve hedefin büyüklükleri farklýysa, sonucun büyüklüðü dönüþ sýrasýnda lineer olarak enterpolasyonlu olacaktýr. maxRadiansDelta için negatif bir deðer kullanýlýrsa,
       vektör tam tersi yönü gösterene kadar hedeften/'den uzaða döner ve sonra durur.
    */

        /* 1 'inci ÖRNEK 

        Vector3 a = new Vector3(2f, 2f, 2f);
        Vector3 b = new Vector3(5f, 7f, 10f);
        Vector3 dondurulenVektor =  Vector3.RotateTowards(a, b, 67f, 45f);

        Debug.Log(dondurulenVektor); // dondurulenVektor =  (5f,7f, 10f ) çýktýsýný BÝZE veriyor.

        */

        /* 2 'inci ÖRNEK 
        Vector3  m_sninKonumu = s.transform.position;
        Vector3 m_denemeninKonumu = deneme.transform.position;

        Vector3 olusanKonumveAyniZamandaHedefeDogruDöndürülenVektor = Vector3.RotateTowards(m_sninKonumu, m_denemeninKonumu, 20f, 20f);
        s.transform.position = olusanKonumveAyniZamandaHedefeDogruDöndürülenVektor;

        */

        // YANÝ bir objeyi bulunduðu konumdan baþka bir konuma DÖNDÜRÜLMÜÞ bir þekilde TAÞIMAK istiyorsan bu metodu kullan.


        #endregion


        #region Vector3.Normalize( ) 

        //Vector3 vektorBuyuklugununBirOlmasi = new Vector3(2f, 3f, 4f);
        //Debug.Log( Vector3.Normalize(vektorBuyuklugununBirOlmasi));
        // Vektör büyüklüðünün bir olmasý demek Vector3.Magnitude ( ) metodunun otomatik olarak hesaplanmasý demek.

        #endregion


        #region Vector3.Project ( ) 

        /* 1 'inci Örnek 
         Vector3 a = new Vector3(1f, 1f, 1f);
         Vector3 b = new Vector3(2f, 2f, 2f);
         Vector3 debug = Vector3.Project(a, b);
         Debug.Log(debug); */


        /* 2 'inci Örnek 
          Vector3 c = new Vector3(3f, 1f, 6f);
          Vector3 d = new Vector3(2f, 3f, 4f);
          Vector3 debug = Vector3.Project(c, d);
          Debug.Log(debug); */

        /* ÝSTEDÝÐÝNE ULAÞTIÐIN ÖRNEK

          Vector3 c = new Vector3(3f, 1f, 6f);
          Vector3 d = new Vector3(2f, 3f, 4f);
          deneme.transform.position = c;

          Vector3 k = Vector3.Project(deneme.transform.position, s.transform.position); // Deneme 'nin Vektörünü s 'in Vektörüne YANSITTIM.

          s.transform.position = k;

        */

        #endregion


        #region Vector3.Reflect ( )

        /*   ÖRNEK 1 
            *  Vector3 a = new Vector3(2f, 2f, 2f);
              Vector3 b = new Vector3(3f,3f, 3f);

              Vector3 c = Vector3.Reflect(b, a);

              Debug.Log(c);*/

        // deneme.transform.position = c;


        /* -----------------------------------------------------------
            ASIL OLAN ÖRNEK : 

            Vector3 m_InNormal = new Vector3(0f, 0f, 0f);
            Vector3 yansitilanVektor = Vector3.Reflect(Karakterim.transform.position, m_InNormal);
            s.transform.position = yansitilanVektor;

            // his objesinin yanýna s objesini YANSITMIÞ OLDUK. YANÝ sen bir objeyi bir objenin yanýna yansýtabilmeyi öðrenmiþ oldun.

            */
        #endregion


        #region Vector3.SignedAngle ( ) 

        // Eksene göre vektörler arasýndaki açýyý hesaplar.
        // Axis ( Eksen ) : Etrafýnda diðer vektörlerin döndürüldüðü vektör.
        // Ýki vektör arasýndaki olasý iki açýdan daha küçük olaný döndürülür, bu nedenle sonuç asla 180 derecen büyük veya -180 dereceden küçük OLAMAZ ! !

        /*
                Vector3 hisinKonumu = his.transform.position;
                Vector3 sinKonumu = s.transform.position;


                float VektörlerArasindakiAci = Vector3.SignedAngle(hisinKonumu, sinKonumu, new Vector3(0f, 20f, 0f));
                Debug.Log(VektörlerArasindakiAci);
        */
        #endregion


        #region Vector3.Lerp  ( )

        // 2 vektör arasýndaki doðrusal bir çizgi oluþturup birinin diðerinin yanýna gitmesini saðlýcaz.

        //Vector3 ikiVektorArasindakiCizgi = Vector3.Lerp(deneme.transform.position, Karakterim.transform.position, Time.time * 0.2f);

        //s.transform.position = ikiVektorArasindakiCizgi + new Vector3(0f, 3.5f, 0f);

        // ------ ÝKÝNCÝ ÖRNEK ------

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

        //Lerp te olduðu gibi iki vektör arasýnda bir çizgi oluþturup birinin diðerinin yanýna gitmesini saðladýk.
        //   a ve b arasýnda t miktarýna göre interpolasyon yapar.
        //   t parametresi[0, 1] aralýðýna sabitlenir.

        //Vector3 denemeninKonumu = deneme.transform.position;
        //Vector3 SobjesinininKonumu = s.transform.position;

        //Vector3 IkiVektorarasindakicizgi = Vector3.Slerp(denemeninKonumu, SobjesinininKonumu, 0.2f);
        //s.transform.position = IkiVektorarasindakicizgi;


        #endregion


        #region Vector.Lerp () ve Vector3.Slerp () arasýndaki FARK 

        /*
         Vector.Lerp ( ) VE Vector.Slerp ( ) arasýndaki FARK :

                  Slerp 'te vektörlerin uzaydaki NOKTALAR  yerine YÖNLER  olarak ele alýnmasýdýr.
                  Döndürülen vektörlerin yönü, açý ile ile interpolasyon yapýlýr ve büyüklüðü from ve to büyükleri arsaýnda interpolasyon yapýlýr.       

        Yani ikisindede benim yaptýðým denemeler sonucunda  çýktýlarýn ayný olduðunu gördüm. O zaman burdan þunu anlayabilirim : Ýkiside ( Lerp ve Slerp ) ayný sonuçlarý veriyor sadece yöntemleri  farklý. 

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

        /* Vector3.SlerpUnclamped statik bir yöntemdir, a ve b vektörlerinin ÖTESÝNE GEÇEBÝLÝR. Vector3.Slerp ( ) 'te ise t kaç olursa olsun a ve b vektörlerinin ÖTESÝNE GEÇEMEZ ! ! 
         * Bu t 'nin SIFIRDAN KÜÇÜK veya BÝRDEN BÜYÜK olabileceði anlamýna gelir.


       */
        #endregion


        #region Vector3.zero

        /* Vektörü ( 0,0,0 ) yapar.

        Vector3 a = new Vector3(2f, 4f, 5f);
         a = Vector3.zero;
        Debug.Log(a);

        */
        #endregion


        #region Vector3.up

        /* 
         Vektörü  ( 0,1,0 ) yapar.
        Vector3 a = new Vector3(3f, 45f, 9f);
        a = Vector3.up;
        Debug.Log(a);

        */

        #endregion


        #region Vector3.forward

        /*
                Vektörü ( 0,0,1 ) yapar.

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

        /*   1 'inci Örnek 
          *  Vector3 a = new Vector3(2f, 5f, 6f);
          a = Vector3.right; // Vektörü ( 1,0,0 ) yapar.
           Debug.Log(a); */

        /* *************************************** 2 Ýnci Örnek*************************************** 

           Vector3 m_hisinKonumu = his.transform.position;
           m_hisinKonumu = Vector3.right;

        // Debug.Log(m_hisinKonumu);

           his.transform.position = m_hisinKonumu;

        YANÝ  his'in Konumunu 1,0,0 taþýmýþ olduk. 
           */

        #endregion


        // ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------




        #region transform.BroadcastMessage ()
        /* BroadcastMessage kendine mesaj göndermesinin yanýnda eðer istenirse çocuk objelerinin tamamýna mesaj gönderebilir.
        //  gameObject.transform.BroadcastMessage("Mesajim");

        void Mesajim(int numara)
        {
            Debug.Log("naber lan" + numara);
        }*/
        #endregion


        #region transform.SendMessage ()

        /*
        // Sadece baðlý olduðu objeye mesah gönderebilir.
        //  transform.SendMessage("Mesajim",144,SendMessageOptions.DontRequireReceiver);

        void Mesajim(int numara)
        {
            Debug.Log("naber lan" + numara);
        } */

        #endregion


        #region transform.childCount
        /* Kendi cocuk objelerinin sayýsýný bize verir.

        int cocukObjeleriminSayisi = transform.childCount;
        Debug.Log(cocukObjeleriminSayisi);

         */

        #endregion


        #region transform.DetachChildren();

        // Tüm çocuklarý EBEVEYNSÝZ býrakýr.
        // gameObject.transform.DetachChildren();


        #endregion


        #region transform.Equals ( )
        /*  1'inci ÖRNEK
         bool dogruMu = gameObject.transform.Equals(his.transform.position);

          if (dogruMu)
          {
              Debug.Log("Evet dpgru");

          }

          else
          {
              Debug.Log("Hayýr yanlýþ.");
          }
        */

        /* 2'ÝNCÝ ÖRNEK 
        Transform a = gameObject.transform;

     bool kontrolEt=    gameObject.transform.Equals(a);

        if (kontrolEt)
        {
            Debug.Log("Evet doðru");

        }
        else
        {
            Debug.Log("hayýr yanlýþ.");
        }
        */
        #endregion


        #region transform.eulerAngles

        /*   eulerAngles, dünya uzayýndaki dönüþü temsil eder. ... Unity'de bu döndürmeler Z ekseni, X ekseni ve Y ekseni etrafýnda bu sýrayla gerçekleþtirilir.
             Bu özelliði ayarlayarak bir Kuaternion'un dönüþünü ayarlayabilir ve bu özelliði okuyarak Euler açý deðerlerini okuyabilirsiniz.

        // YANÝ  objelerin Rotation x,y ve z deðerlerinin ne olduðunu anlarýz ! !

         Vector3  b = deneme.transform.eulerAngles;
         Debug.Log(b); 

        */

        #endregion


        #region transform.Find

        // kendi çocuk objelerinde  þu isimli bir obje varmý bulmaya yarar.

        /*   Transform bulunulanObje  =   gameObject.transform.Find("Top3");

           Debug.Log(bulunulanObje.name); */

        #endregion


        #region  transform.forward *

        /* 
         transform.forward z ekseninde hareket ettirir.
         Vector3.forward 'dan FARKLI OLARAK Transform.forward GameObject ' i HAREKET ETTÝRÝRKEN AYNI ZAMANDA  ROTASYONUNUDA DÝKKATE ALIR.
         Bir GameObject DÖNDÜRÜLDÜÐÜNDE, GameObject'in z eksenini temsil eden mavi ok da YÖN  DEÐÝÞTÝRÝR ! !  


        1'inci örnek    deneme.transform.position = transform.forward; // denemenin konumu ( 0,0,1 ) de artýk. */

        /*
          2  'inci örnek

         Bu kodu  update metodu içerisinde yaz yoksa ANLAMAZSIN düzen bozulmasýn diye buraya yazdým.

         deneme.transform.GetComponent<Rigidbody>().velocity = his.transform.forward * 2f;  // deneme objesini DÖNDÜREREK Z EKSENÝNDE HAREKET ETTÝRDÝK ! ! 

         */

        // BÝLORDO TOP OYUN FÝKRÝNDE BURDAN ÝLHAM AL ! !
        #endregion


        #region   transform.GetChild ( ) *

        /* Kenci çocuk objesini yakalayýp onun üstünde iþlem yapabilmeyi bize saðlar.

      Transform ilkCocugum=   transform.GetChild(0);

        ilkCocugum.localPosition  = new Vector3(1f, 1f, 1f);                                // gerçekten  ( 1 , 1 ,1 )  e  gelmiþ oldu. ÇÜNKÜ LOCALPOSÝTÝON  = OBJENÝN KENDÝSÝNÝN O  ANKÝ POZÝSYONUNU MERKEZ NOKTA ( 0 ,0,0 ) KABUL ETTÝ SONRA  onu 1,1,1
                                                                                               e getirdi.
        ilkCocugum.position = new Vector3(1f, 1f, 1f);                                      //  ( 2.98 , -4.55 240.95 ) e geldi. ÇÜNKÜ  POSÝTÝON  = SAHNEDEKÝ merkez noktaya ( 0,0,0 ) gitti ordan (  1, 1, 1) ' e geldi.  

        Debug.Log(ilkCocugum.name);

        */

        #endregion


        #region transform.GetEnumerator()

        // Ýlgili IEnumerator' ü ( Coroutine 'ü) yakalayýp iþlem yapabilmeyi saðlar.
        //    IEnumerator b = transform.GetEnumerator();

        #endregion


        #region GetHashCode () ve GetInstanceID ( )

        /*  

           int hashcode = transform.GetHashCode();
           Debug.Log(hashcode); // 19174

          int objeminKimligi =   transform.GetInstanceID();
          Debug.Log(objeminKimligi); // 19174

          Gördüðün gibi GetHasCode ( ) ve GetInstanceID ( ) metodu bu objem için ayný deðeri verdi. YANÝ objem 19174 deðeriyle SÝSTEMDE kendine yer buluyor ! ! 

        */
        #endregion


        #region  transform.GetSiblingIndex()

        /*

        int a = cocuklar[2].transform.GetSiblingIndex();
        Debug.Log(a);

         Parent - child iliþkisi olan objelerde istediðin çocuðun indeksini alabilirsin.

        */


        #endregion


        #region transform.hideflags ==> Bu Scriptin en baþýna yani hideFlags'in alt dallarý kýsmýna da bir bakman senin için iyi olur 



        //   transform.hideFlags = HideFlags.DontSave; ( TAM ANLAMADIN ! ! )     // Nesne sahneye kaydedilmez. Yeni bir sahne yüklendiðinde  yok edilmeyecektir.


        //     transform.hideFlags = HideFlags.NotEditable;        // objemin transform COMPONENTÝNDE  Inspectorunda herhangi bir ayarý   deðiþtirmemi ENGELLER ! ! ! 

        //   transform.hideFlags = HideFlags.HideInInspector;     // objemin transformunu Inspector 'DA GÖSTERMEZ ! !

        //     transform.hideFlags = HideFlags.HideInHierarchy;  // objemi Hierarchy 'de GÖSTERMEZ AMA sahnede vardýr.

        #endregion


        #region transform.hierarchyCapacity

        /*
         
        int sayi = 6;
           transform.hierarchyCapacity=sayi;
        Debug.Log(transform.hierarchyCapacity);

        // Hierarchy'nin  o haliyle Hierarchy kapasitesini SÝSTEM BÝZE 4 olarak verdi ama ben burda dedimki KAPASÝTESÝ 6 OLSUN demiþ oldum.

        */

        #endregion


        #region transform.hierarchyCount

        // Dönüþümün hiyerarþi veri yapýsýndaki dönüþümün sayýsý 

        //  Debug.Log(transform.hierarchyCount);

        #endregion


        #region   transform.InverseTransformDirection ( )

        /* Ýlgili yönü dünya uzayýndan yerel uzaya dönüþtürür.

        Vector3 relative;
        relative = transform.InverseTransformDirection(Vector3.forward);
        Debug.Log(relative);

        */

        #endregion


        #region transform.InverseTransformPoint 'i  ( )  anlaman için çalýþmalarýn 1 

        /*    KONUYA GEÇMEDEN ÖNCE BURAYI MUTLAKA  OKU 
           Vector3 denemeninKonumVektorDegeri = deneme.transform.position;
            Debug.Log(denemeninKonumVektorDegeri); // ekranda denemenin Position  x , y,  z ( -25.63,0.69, -434.79  ) olarakta AYNISINI GÖRÜYORSUN ÞUAN.....

            Vector3 DenemeninbirBirimÝlerletilmisVektoru=  denemeninKonumVektorDegeri + (Vector3.forward);
            Debug.Log(DenemeninbirBirimÝlerletilmisVektoru);   ekranda x , y ,z  (  -25.63,0.69,   -433.79   ) olarak gördün. 

           */

        /* YANÝ SEN BURDA YAKALAMAK ÝSTEDÝÐÝN VEKTÖRÜ YAKALADIN VE ÝSTEDÝÐÝN ÝÞLEMÝ YAPTIRABÝLÝRSÝN. ÞÝMDÝ bu InverseTransformPoint olayýný dolasýylada Local uzay olayýný ÇÖZMEN LAZIM ..... 
           BURAYI MUTLAKA AMA MUTLAKA ÇÖZMEN LAZIM ! ! !  */



        //Vector3 denemeninVektoru=  deneme.transform.InverseTransformPoint(Vector3.forward);
        //    Debug.Log(denemeninVektoru); 
        // deneme.transform.position = denemeninVektoru; 


        //Vector3 denemeninKonumVektoru = deneme.transform.position;
        //Debug.Log(denemeninKonumVektoru);


        //Vector3 x = deneme.transform.InverseTransformPoint(new Vector3(0.001f, 0.001f, 0.001f));
        //Debug.Log(x);
        //deneme.transform.position = x;

        //Vector3 denemeninLocalKonumu = deneme.transform.localPosition;
        //Debug.Log(denemeninLocalKonumu); // ekranda denemenin konum deðerleri neyse çýktý olarakta aynýsýný alýyoruz.

        #endregion


        #region transform.InverseTransformPoint 'i ( )  anlaman için çalýþmalarýn 2 

        /* aþama 1 
        Vector3 DusunceninKonumununVektoru = Dusunce.transform.position;
        Debug.Log(DusunceninKonumununVektoru);

        */

        /* aþama 2
        Vector3 transformPointinVEktoru =   Dusunce.transform.TransformPoint(Vector3.forward);
        Debug.Log(transformPointinVEktoru);

        */

        /* AÞAMA 3  SONUNDA ANLADIN  DEFTERDE  8 NUMARALI SAYFAYA BAK

        Vector3 DusunceInverseTransformPointinVektoru = Dusunce.transform.InverseTransformPoint(Vector3.forward);
        Debug.Log(DusunceInverseTransformPointinVektoru);

        */
        #endregion


        #region  transform.InverseTransformPoint  ( ) 'i ARTIK ANLADIN ÞÝMDÝ ÖRNEK YAPABÝLÝRSÝN

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
              Dusunce kendi VEktorunu forward özelliðinden aldý yani ne olursa olsun( 0, 0, 1 ) oldu.



        Vector3 DusunceninInverseTransformVectoru = Dusunce.transform.InverseTransformVector(DusunceIki.transform.position);
        Debug.Log(DusunceninInverseTransformVectoru);
        Dusunce.transform.position = DusunceninInverseTransformVectoru; 
              DusunceIki 'nin Vektörünü almýþ oldu.

         Yani BURDA InverseTransformPoint ( ) 'te olduðu gibi EKSÝ 'LÝ BÝR DEÐER ALMA SÖZ KONUSU DEÐÝL ! ! 
       */


        #endregion


        #region transform.IsChildOf ( ) 

        // bir obje bir objenin annesimi deðil mi kontrol eder. ( true , false döndürür.)
        //  Debug.Log(   his.transform.IsChildOf(DusunceIki.transform));

        #endregion


        #region transform.localEulerAngles

        /*   Debug.Log( deneme.transform.localEulerAngles);

        Vector3 denemeninRotationDegerleri = new Vector3(23f, 45f, 302f);
        deneme.transform.localEulerAngles = denemeninRotationDegerleri;

         transform.localEulerAngles = YANÝ Rotation x, y ve z deðelerini ayarlamamýzý saðlar. ( derece ) 

        */


        #endregion


        #region transform.localPosition ve transform.Position TAM ANLADIÐIN HALÝ 


        // s objesi resetlenmiþ bir þekilde deneme objesinin cocuk objesi.  % % Deneme = ( -4.19 , 0.841 , 4.59 )   % % anlayisobjesi = ( 7.84 , 1.34 , 12.33 )  % % DunyaUZayýKonumobjesi = ( 0,0,0 )


        //   Vector3 Referansvektorum = new Vector3(1f, 1f, 1f);

        //  *************** 1.KISIM ***************

        //  s.transform.localPosition = Referansvektorum;              // s  'in konumu vektor deðerleri  = ( 1 , 1 , 1 ) oldu.
        //  anlayisObjesi.transform.position = Referansvektorum;      // anlayis objesinin 'de konumu ( 1,1,1 ) oldu.   

        // ANCAK anlayis objesi DÜNYA UZAYI ( 0 ,0 ,0 ) KONUMUNA GÖRE ( 1 , 1 ,1 ) OLDU.  S objesi ise  KENDÝ DÜNYA UZAYI DENEME OBJESÝ OLDUÐU ÝÇÝN DENEMEYE GÖRE ( 1, 1 ,1 ) KONUMUNU ALDI ! !


        // *************** 2.KISIM ***************

        // s.transform.position = Referansvektorum;
        // anlayisObjesi.transform.position = Referansvektorum;

        /*  s ' inde anlayis objesininde konumu AYNI YERDE OLDU. Yani ( 1,1 ,1 ) konumuna geldi. çünkü S ' i oyunun  DÜNYA UZAYINA GÖRE ( 0 , 0 ,0 ) göre konumlandýrdýk.
            s 'i burda OYUNUN DÜNYA UZAYINA GÖRE konumlandýrdýk evet ama s, deneme objesinin çocuk objesi olduðu için  Ekranda deneme objesine göre uzaklýðýnýn  vektor deðerlerini  ( 4.62 , 4.29 , 0.0972 )  almýþ oldu. */


        //  *************** 3.KISIM * **************

        //anlayisObjesi.transform.localPosition = Referansvektorum;
        //anlayisObjesi.transform.position = Referansvektorum;

        // Gördüðün gibi anlayisObjesi HERHANGÝ BÝR OBJEYLE ANNE COCUK ÝLÝÞKÝSÝ OLMADIÐI ÝÇÝN localPosition desende position desende SAHNEDE AYNI KONUMDA AYNI VEKTOR DEÐERLERÝNE SAHÝP OLARAK GÖRÜRSÜN ! !

        #endregion


        #region  transform.localRotation ve transform.rotation TAM ANLADIÐIN HALÝ 

        Quaternion SadeceStartMetodundaYaniBirKezCalisacakolanDondurmeIslemi =  Quaternion.Euler(40f , 40f,40f);


        // s.transform.localRotation = SadeceStartMetodundaYaniBirKezCalisacakolanDondurmeIslemi; // s 'in Rotation x, y ,z ( 40 ,40 , 40) olarak aldý ama bunu DÜNYA UZAYI DENEME OBJESÝ OLDUÐU ÝÇÝN DENEME OBJESÝNE GÖRE (40 , 40 ,40 ) DEÐERLERÝNÝ ALDI.
        // DENEMENÝN UZAYINA GÖRE DÖNDÜ AMA  KENDÝSÝNE VERMÝÞ OLDUÐUM VEKTÖR DEÐERLERÝNÝ ALMIÞ OLDU.

        // s.transform.rotation = SadeceStartMetodundaYaniBirKezCalisacakolanDondurmeIslemi;  // OYUNUN DÜNYA UZAYINA GÖRE ÝÞLEM YAPTIK AMA Anne cocuk iliþkisi olduðu için DENEME OBJESÝNE GÖRE ( 17.86 , 20.99 , 82.65 ) DEÐERLERÝNÝ ALMIÞ OLDU ! !
        // OYUNUN UZAYINA GÖRE DÖNDÜ AMA DENEMENÝN DÖNÜÞÜNE GÖRE VEKTÖR DEÐERLERÝNÝ ALDI.


        #endregion


        #region transform.localScale

        //Vector3 BelirledigimOlcek = new Vector3(4f, 4f, 3f);
        // s.transform.localScale = BelirledigimOlcek;

        // localScale 'da localPosition ve localRotation 'dan FARKLI OLARAK AÝLESÝNE BAKMADAN DÝREK VERMÝÞ OLDUÐUM VEKTÖRÜ UYGULAR.

        #endregion


        #region  transform.lossyScale 

        //  Debug.Log (s.transform.lossyScale ) ;

        //  Objenin ölçeðini deðerlerini yakalamamýzý saðlar.

        #endregion


        #region  transform.parent 

        /*

        // ÝLGÝLÝ objenin annesini yakalamamýzý veya da yeni bir anne atamamýzý saðlar.

        //   his.transform.parent = Dusunce.transform;

        Debug.Log(s.transform.parent);
        if(s.transform.parent.name == "Deneme3")
        {
            Debug.Log("Aile cocuk olayýný anladýn.");
        }

        else
        {
            Debug.Log(" Kontrol etsene LAN ! !");
        }

        */

        #endregion


        #region transform.localToWorldMatrix;

        /* OKU MUTLAKA 
         
         * Bir dönüþüm matrisi, homojen koordinatlar kullanarak rastgele doðrusal 3B dönüþümler (yani öteleme, döndürme, ölçek, kesme vb.) ve perspektif dönüþümler gerçekleþtirebilir. 
         * 
         * Komut dosyalarýnda nadiren matris kullanýrsýnýz; Çoðu zaman Vector3 s, Quaternion s ve Transform sýnýfýnýn iþlevselliðini kullanmak daha basittir. 
         * 
         * Düz matrisler, standart olmayan kamera projeksiyonunun ayarlanmasý gibi özel durumlarda kullanýlýr. Unity'de birkaç Dönüþtür , Kamera , Malzeme , Grafik ve GL iþlevi Matrix4x4'ü kullanýr.

         * Unity'deki matrisler sütun majördür; yani bir dönüþüm matrisinin konumu son sütundadýr ve ilk üç sütun x, y ve z eksenlerini içerir.
           Verilere þu þekilde eriþilir: row + (column*4). Matrisler, 2B diziler gibi dizine alýnabilir, ancak, gibi bir ifadede mat[a, b], sütun dizinine atýfta  bulunurken a , satýr dizinine atýfta bulunurken  b 'dir ! !

       

        var matrix = Dusunce .transform.localToWorldMatrix;

        var konum = new Vector3(matrix[0, 3], matrix[1, 3], matrix[1, 3]);
        Debug.Log(" Konumu Matristen dönüþtür( deðiþtir ) : " + konum);

      */
        #endregion


        #region transform.right

        // Dünya uzayýndaki dönüþümün (Deðiþimin ) KIRMIZI EKSENÝ 

        //  Debug.Log(anlayisObjesi. transform.right);

        #endregion


        #region  transform.root 

        //  Anne- cocuk iliþkisi olarak bakarsan Annesini yakalar ve gösterir.

        // Transform a = transform.root;
        // Debug.Log(a);

        // Transform EnUsttekiObjeyiGosterir = Capsule.transform.root;
        // Debug.Log(EnUsttekiObjeyiGosterir);


        #endregion


        #region transform.LookAt ( ) update Metoduna yaz bunu


        //   1 )  anlayisObjesi.transform.LookAt(Dusunce.transform);
        //   2 )  anlayisObjesi.transform.LookAt(Dusunce.transform,Vector3.up);

        /*   3 )  Vector3 bakilacakNokta = new Vector3(-2.94f, 1.75f, 17.19f);
                  anlayisObjesi.transform.LookAt(a); // Oyunun dünya uzayýnda bir vektör belirleriz ve objenin bu vektöre bakmasýný saðlarýz.  */

        /*    4)   Vector3 bakilacakNokta = new Vector3(-2.94f, 1.75f, 17.19f);
                   anlayisObjesi.transform.LookAt(a, Vector3.up);   */

        // YANÝ biz transform.LookAt ( ) metodunda hedefin hareketlerine göre objemizin Rotation x , y ,z deðerlerini deðiþtiririz dolayýsýyla objemiz hedefe konumuna hareketlerine BAKAR.
        // VE  objemiz dünya üzerinde bir Vektör belirleriz ve objemiz bu dünya üzerindeki vektöre BAKAR. ( objenin yine Rotation x ,  y ,z deðerleri deðiþmiþ olur . )



        #endregion


        #region transform.Rotate ( ) update Metoduna yaz.

        //  Vector3 dondurmekIstediginDereceler = new Vector3(20f, 20f, 20f);

        //  1 ) ****************************************

        // anlayisObjesi.transform.Rotate(dondurmekIstediginDereceler*Time.deltaTime); // Anlayis objesi Vermiþ olduðu vektör deðerlerinde ( z ekseni etrafýnda z derece, x ekseni etrafýnda x derece , y eksen, etrafýnda y derece ) DÖNER.

        // ÖNEMLÝ : EULER AÇISI OLARAK DÖNDÜRÜR.

        /*  2 ) ****************************************

        anlayisObjesi.transform.Rotate(dondurmekIstediginDereceler * Time.deltaTime*3f, Space.World );
        s.transform.Rotate(dondurmekIstediginDereceler * Time.deltaTime * 3f, Space.Self);

        // Space.World  = Dünya ekseninde vermiþ olduðum Vektör DERECELERÝYLE döner. Boþlukta dönüyomuþ gibi döner.
        // Space.Local  = Annesi varsa annesinin ekseninde vermiþ olduðum vektör DERECELERÝYLE DÖNER. [ kendi  ekseninden döner. Kendi durumuna göre döner yani kendini referans alýr.]

        */

        /*

         3 )************************************************

             X ekseni mi z Ekseni mi yoksa Y ekseni etrafýnda döndürmek istiyorsun önce onu belirle daha sonra ne kadar HIZDA  DÖNDÜRMEK ÝSTÝYORSAN onu yaz.

                     // ÖRNEK  1

       Vector3 ZEkseni = Vector3.forward;
       Vector3 Xekseni = Vector3.right;

     anlayisObjesi.transform.Rotate(ZEkseni, 45f);  // Anlayis objesinin  Rotation z kýsmý 45 90 135 180 þeklinde yani 45f HIZINDA DÖNDER
     anlayisObjesi.transform.Rotate(Xekseni , 45f * Time.deltaTime );
     anlayisObjesi.transform.Rotate(Xekseni, 1f * Time.deltaTime);
     anlayisObjesi.transform.Rotate(-Xekseni, 1f);


                      // ÖRNEK 2 

        Vector3 yEkseni = Vector3.up;
        anlayisObjesi.transform.Rotate(yEkseni, 20f * Time.deltaTime);

        Vector3 Xekseni = Vector3.right;
        resim.transform.Rotate(Xekseni, 20f * Time.deltaTime);

        Vector3 ZEkseni = Vector3.forward;
        tablo.transform.Rotate(ZEkseni, 20f * Time.deltaTime);

        
        

        //   4 ) ************************************************

        float m_deltaTime=  Time.deltaTime;
        anlayisObjesi.transform.Rotate(25f* m_deltaTime, 25f*m_deltaTime, 25f*m_deltaTime); // NORMAL AÇI OLARAK DÖNDÜRÜR.

        

        //   5 ) ************************************************

        float m_deltaTime = Time.deltaTime;

        Vector3 xYonu = Vector3.right;
        anlayisObjesi.transform.Rotate(xYonu, 120f*m_deltaTime, Space.World);
        tablo.transform.Rotate(xYonu, 120f*m_deltaTime, Space.Self);

        Vector3 yYonu = Vector3.up;
     //  resim.transform.Rotate(yYonu, 120f * m_deltaTime, Space.World);
        resim.transform.Rotate(yYonu, 120f * m_deltaTime, Space.Self);

        // Nesneyi, verilen açý tarafýndan tanýmlanan derece sayýsý kadar verilen eksen etrafýnda döndürür. Space,  Self olayýný 2 ) 'de anlattým.


        */

        //  6 ) ************************************************

        //             4 ) 'ün AYNISI SADECE SONUNA Space.World , Space.Self olayý geliyor.


        #endregion



    }




    private void Update()
    {
        
    }


}





