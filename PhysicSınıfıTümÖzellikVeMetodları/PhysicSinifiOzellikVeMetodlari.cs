using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicSinifiOzellikVeMetodlari : MonoBehaviour
{


    #region De�i�kenler 1

    /*
     
    float m_MaxDistance;
    float m_Speed;
    bool m_HitDetect;

    Collider m_Collider;
    //CapsuleCollider capsulecollider;
    //RaycastHit m_Hit;
    RaycastHit hit;

    bool benimIsabetTespitim;
    int araBellek;
    RaycastHit[] ButunIsabetEdenIsinlar;

    bool CapsuleCastIleTemasGerceklesTiMi;



    */

    #endregion


    #region Physics.ComputePenetration ( ) metodunun de�i�kenleri 

    /*
    public GameObject anlayisObject;
    public GameObject Dusunce;
    [SerializeField]  Collider colliderAnlayis;
    [SerializeField] Collider colliderDusunce;
    [SerializeField] float m_distance;
    [SerializeField] Vector3 m_direction;
    [SerializeField] bool IsPenetrating;
    private object GizmosForPhysics3D;
    */

    #endregion


    #region De�i�kenler 2

    [SerializeField] float temasOteleme;
    public Collider m_Anlayis;
    public Collider m_Dusunce;
    public Collider m_Capsule;
    public Collider m_Sphere;
    //public Collider Denemem;

    Vector3 sahnedekiTumRigidbodylereUygulananYerCekimiDegeri;

    Collider[] colliderLarinDizisi;
    Vector3 p1;
    Vector3 p2;
    int i;

    RaycastHit hit;
    bool isinGittiMi;

    #endregion

    void Start()
    {
        /*
        Choose the distance the Box can reach to
        m_MaxDistance = 300.0f;
        m_Speed = 20.0f;
        m_Collider = GetComponent<Collider>();
        capsulecollider = GetComponent<CapsuleCollider>();
        */
    }



    void Update()
    {

        #region 1 ) Physics.autoSimulation

        /*

          Fizi�in OTOMAT�K olarak S�M�LE edilip edilmeyece�ini ayarlar.

          Varsay�lan olarak, fizik oynatma modu s�ras�nda her Time.fixedDeltaTime g�ncellenir. Normal oyun d�ng�s�n�n bir par�as�,
         olarak otomatik olarak ger�ekle�ir.

          Ancak, fizi�i manuel olarak ilerletmenin gerekli oldu�u durumlar vard�r. D�zenleme modunda fizi�i sim�le eden �zel bir 
          �rnek. Ba�ka bir �rnek, yetkili sunucudan veri al�rken zaman� geri sarman�n ve t�m oyuncu girdisini uygulaman�n gerekli 
          oldu�u a� ba�lant�l� fizik olabilir.

          Fizik sim�lasyonunu manuel olarak kontrol etmek i�in �nce otomatik sim�lasyonu devre d��� b�rak�n ve ard�ndan zaman� 
          ilerletmek i�in Physics.Simulate'i kullan�n. MonoBehaviour.FixedUpdate'in yine Time.fixedDeltaTime taraf�ndan tan�mlanan
          h�zda �a�r�laca��n� unutmay�n ., ancak fizik sim�lasyonu art�k otomatik olarak geli�tirilmeyecektir.


        Debug.Log(Physics.autoSimulation);

        Proje HAM ( DEFAULT ) haliyle TRUE  de�erini d�nd�rd�. YAN�  F�Z�K OTOMAT�K OLARAK S�M�LE ED�L�YOR.

        */

        #endregion


        #region 2 ) Physics.autoSyncTransforms

        /*

        Bir TRANSFORM bile�eni de�i�ti�inde, d�n���m de�i�ikliklerinin fizik sistemiyle OTOMAT�K olarak senkronize edilip 
        edilmeyece�ini ayarlar.

        Bir D�n��t�rme bile�eni de�i�ti�inde, o D�n���m �zerindeki herhangi bir Sert Cisim veya �arp��t�r�c�n�n veya alt
        ��elerinin, D�n��t�rme'deki de�i�ikli�e ba�l� olarak yeniden konumland�r�lmas�, d�nd�r�lmesi veya �l�eklenmesi 
        gerekebilir. Bu �zelli�i true olarak ayarlayarak, D�n��t�rme'de yap�lan de�i�ikliklerin do�ru bile�enlere otomatik 
        olarak uygulan�p uygulanmayaca��n� kontrol edebilirsiniz. Yanl�� olarak ayarland���nda, senkronizasyon yaln�zca Sabit
        G�ncelleme s�ras�nda fizik sim�lasyonu ad�m�ndan �nce ger�ekle�ir. Ayr�ca, Physics.SyncTransforms'u kullanarak 
        d�n��t�rme de�i�ikliklerini manuel olarak senkronize edebilirsiniz.

        Not: autoSyncTransforms true olarak ayarland���nda, bir Transform'u art arda de�i�tirmek ve ard�ndan bir fizik 
        sorgusu ger�ekle�tirmek performans kayb�na neden olabilir. Performans� etkilemekten ka��nmak i�in, art arda birden 
        �ok D�n��t�rme de�i�ikli�i ve sorgusu yapmak istiyorsan�z autoSyncTransforms'u false olarak ayarlay�n. Unity 2017.2'den
        �nce yap�lm�� mevcut projelerde geriye d�n�k fizik uyumlulu�u i�in autoSyncTransforms'u yaln�zca true olarak 
        ayarlamal�s�n�z. Unity 2017.2 ve sonras�nda yap�lan projeler i�in bu se�ene�i KAPATIN ! ! ! 



                Debug.Log(Physics.autoSyncTransforms);

        Projede HAM ( DEFAULT ) haliyle FALSE de�erini verdi. Yani �stteki a��klamalarda Unity 'nin 2017 sonras�ndaki s�r�mlerinde
        bu �zelli�i kapat�n a��klamas�n� DO�RULAR N�TEL�KTED�R ! ! !

        */

        #endregion


        #region 3 ) Physics.BakeMesh ( )

        /*

        Mesh'i MeshCollider ile kullan�m i�in haz�rlar.

        Bu i�lev Mesh pi�irmeyi �al��t�r�r ve sonucu Mesh'in kendisine kaydeder. Bu Mesh'e ba�vuran bir MeshCollider
        somutla�t�r�ld���nda, Mesh'i yeniden pi�irmek yerine pi�irilen verileri YEN�DEN kullan�r. Bu, pahal� pi�irme s�recini
        Sahne y�kleme s�resinden veya �rnekleme s�resinden farkl� bir zamana ta��mak istedi�inizde kullan��l�d�r. BakeMesh i�
        par�ac��� i�in g�venlidir ve �a�r�ld��� i� par�ac��� �zerinde hesaplamalar yapar, ancak tan�ms�z davran��a neden oldu�u 
        i�in ayn� anda birden �ok i� par�ac���ndan ayn� a� �zerinde BakeMesh'i �a��rmak ge�erli de�ildir. BakeMesh'i C# i� sistemi
        ile kullanabilirsiniz.


        meshID : �arp��ma verilerini olu�turulaca�� Mesh ' in �rnek kimli�i
        convex : d�� b�key geometrinin pi�irilip pi�irilmeyece�ini g�steren bir bayrak.

         */


        #endregion


        #region 4 ) Physics.bounceThreshold

        /* 
           bounce Threshold : SI�RAMA E����

        Bunun alt�nda g�receli h�za sahip �arp��an iki nesne sekmeyecektir (varsay�lan 2). Olumlu olmal�.

        Bu de�er genellikle Scriptler yerine Edit->Project Settings ->Physics denet�isinde de�i�tirilir.



        float sicramaEsigiYanibounceThresHold = Physics.bounceThreshold;
        Debug.Log(sicramaEsigiYanibounceThresHold);

        */
        #endregion


        #region 5 )  Physics.BoxCast ( )


        /*

          Kutuyu bir I�IN boyunca FIRLATIR ve neyin �arp�ld���na dair ayr�nt�l� bilgi verir.

        1.T�r  :

        center      : Kutunun merkezi
        halfExtents : Her boyutta kutunun yar�s� boyutunda. 
        direcion    : Kutunun at�laca�� y�n
        orientation : Kutunun d�n���
        maxDistance : Atman�n maksimum uzunlu�u
        layerMask   : Bir kaps�l olu�tururken �arp��t�r�c�lar� se�ici olarak yok saymak i�in kullan�lan bir katman maskesi.
        queryTriggerInteraction : Bu sorgunun tetikleyicileri vurup vurmayaca��n� belirtir.

        hitInfo : hitInfo true d�nd�r�l�rse, hitInfo �arp��t�r�c�n�n vuruldu�u yer hakk�nda DAHA FAZLA  bilgi ��ER�R.



        float xAxis = Input.GetAxis("Horizontal") * m_Speed;
        float zAxis = Input.GetAxis("Vertical") * m_Speed;

        transform.Translate(new Vector3(xAxis * Time.deltaTime, 0, zAxis * Time.deltaTime));

        BoxCast()  metodunu kullanarak bir isabet olup olmad���n� bulabiliriz.

        m_HitDetect = Physics.BoxCast(m_Collider.bounds.center, transform.localScale, transform.forward, out m_Hit, transform.rotation, m_MaxDistance);

        if (m_HitDetect) // isabet Ettiyse 
        {
            Debug.Log("Hit : " + m_Hit.collider.name);
            Kutuya isabet eden �arp��t�r�c�n�n(collider ' a sahip objenin ) ad�n� bulduk.


        }

        */


        /*  void OnDrawGizmos() // S�LME VE MUTLAKA ARADA BAK !!!  ( UPDATE Metodunun d���na yaz ! ! ! ! ! ! ! )
        {



           Gizmos.color = Color.white;

           isabet kontrolu yap�yoruz:

           if (m_HitDetect)
           {

               Gizmos.DrawRay(transform.position, transform.forward * m_Hit.distance);  // objemizden ileriye do�ru bir ���n �izdik.

               Gizmos.DrawWireCube(transform.position + transform.forward * m_Hit.distance, transform.localScale);

               isabetin oldu�u yere kadar uzanan bir k�p �izer.
           }

           else // Hen�z bir vuru� olmad�ysa, ���n� maksimum mesafeden �izer :
           {

               Gizmos.DrawRay(transform.position, transform.forward * m_MaxDistance);

               Gizmos.DrawWireCube(transform.position + transform.forward * m_MaxDistance, transform.localScale);
               Maksimum mesafede bir k�p �izer.

           }
        */

        #endregion


        #region 6 ) Physics.BoxCastAll ( )

        /*

        Physics.BoxCast gibidir, ancak T�M �SABETLER�  d�nd�r�r.

        Notlar: Taraman�n ba�lang�c�nda kutuyla �ak��an �arp��t�r�c�lar i�in, RaycastHit.normal, tarama y�n�n�n tersine ayarlan�r, 
        RaycastHit.distance s�f�ra ayarlan�r ve s�f�r vekt�r� RaycastHit.point'te d�nd�r�l�r. �zel sorgunuzda durumun b�yle olup 
        olmad���n� kontrol etmek ve sonucu iyile�tirmek i�in ek sorgular yapmak isteyebilirsiniz.



        float yatayHiz=  Input.GetAxis("Horizontal") * Time.deltaTime;
        float zHiz = Input.GetAxis("Vertical" )* Time.deltaTime;

        transform.Translate(yatayHiz, 0f, zHiz);
        a= Physics.BoxCastAll(m_Collider.bounds.center, transform.localScale, transform.forward, transform.rotation, 200f);


        foreach (var item in a)
        {
           Debug.Log ( item.transform.name );
        }

        */

        #endregion


        #region 7 ) Physics.BoxCastNonAlloc ( ) TAM ANLAMADIN 

        /*


        intresults :  Arabelle�e depolanan isabet miktar� .


        Kutuyu y�n boyunca yayar ve isabet  sa�lad�klar�m� arabellekte saklar.

        result : Sonu�lar�n saklanaca�� ara bellek.




        float yatayHiz = Input.GetAxis("Horizontal") * Time.deltaTime;
        float zHiz = Input.GetAxis("Vertical") * Time.deltaTime;

        transform.Translate(yatayHiz, 0f, zHiz);

         araBellek=  Physics.BoxCastNonAlloc(transform.position, transform.localScale, transform.forward, ButunIsabetEdenIsinlar, transform.rotation, m_MaxDistance);

        Debug.Log(araBellek);


        */

        #endregion


        #region  8 ) Physics.CapsuleCast ( )

        /*

        Sahnedeki t�m �arp��t�r�c�lara kar�� bir kaps�l atar ve neyin �arpt��� hakk�nda ayr�nt�l� bilgi verir.

        Kaps�l, kaps�l�n iki ucunu olu�turan nokta1 ve nokta2 �evresinde yar��apa sahip iki k�re taraf�ndan tan�mlan�r. Kaps�l y�n 
        boyunca hareket ettirilirse bu kaps�le �arpacak olan ilk �arp��t�r�c� i�in isabetler d�nd�r�l�r. Bu, bir Raycast yeterli
        hassasiyet vermedi�inde kullan��l�d�r, ��nk� bir karakter gibi belirli bir boyuttaki bir nesnenin yolda herhangi bir �eyle
        �arp��madan bir yere hareket edip edemeyece�ini ��renmek istersiniz.

        Notlar: CapsuleCast, kaps�l�n �arp��t�r�c�yla �ak��t��� �arp��t�r�c�lar� alg�lamaz. S�f�r yar��ap� ge�mek, tan�ms�z 
               ��kt�yla sonu�lan�r ve her zaman Physics.Raycast ile ayn� �ekilde davranmaz.

        point1 : Kaps�l�n ba�lang�c�ndaki k�renin merkezi
        point2 : Kaps�l�n sonundaki k�renin merkezi
        radius : Kaps�l�n yar��ap�
        Direction : Kaps�l�n s�p�r�lece�i y�n
        maxDistance : S�p�rmenin maksimum uzunlu�u
        layerMask : Bir kaps�l olu�turulurken �arp��t�r�c�lar� se�ici olarak yok saymak i�in kullan�lan bir katman maskesi.
        queryTriggerInteraction : Bu sorgunun tetikleyicileri vurup vurmayaca��n� belirtir.
        hitInfo : hitInfo true d�nd�r�l�rse, hitInfo �arp��t�r�c�n�n vuruldu�u yer hakk�nda DAHA FAZLA  bilgi ��ER�R.

        -------------------------------------------------------------------------------------------------------------------

        float horizontal = Input.GetAxis("Horizontal") * Time.deltaTime;
        float vertical = Input.GetAxis("Vertical") * Time.deltaTime;

        transform.Translate(new Vector3(horizontal, 0f, vertical));


         Herhangi bir �eye �arpmak �zere olup olmad���n� g�rmek i�in karakter denetleyicisi(characterController)
         �eklini 10 metre ileriye at�n.

        RaycastHit hit;

        CharacterController charContr = GetComponent<CharacterController>();

        Debug.Log(charContr.center);
        HAM(DEFAULT) HAL�YLE Character Controller Componentine sahip objenin Center '� ( 0,0,0 ) ' m��.

        Vector3 p1 = transform.position + charContr.center + Vector3.up * -charContr.height * 0.5F;  = kendi pozisyonu -1
        Vector3 p2 = p1 + Vector3.up * charContr.height;  === kendipozisyonu -1+2 ===> kendipozisyonu +1

        p1= kendiPozisyonu -1 
        p2 = kendiPozisyonu +1 ' M�� ! ! !


        CapsuleCastIleTemasGerceklesTiMi = Physics.CapsuleCast(p1, p2, charContr.radius, transform.forward, out hit, 10f);


        if (CapsuleCastIleTemasGerceklesTiMi)
        {
            Debug.Log(hit.transform.gameObject.name);

        }

        !!!!!!!!!!!!!!!!!!!!!! YAN� Capsule I�INLARI ATARAK �ARPI�MALARI YAKALAYAB�LMEM�Z� YARAYAN B�R METOTTUR !!!!!!!!!!!!!!!!!!


        -------------------------------------------------------------------------------------------------------------------


        private void OnDrawGizmos() // UPDATE METODUNUN DI�INA YAZ.
        {
            Gizmos.color = Color.white;

            //isabet kontrolu yap�yoruz:

            if (CapsuleCastIleTemasGerceklesTiMi)
            {

                Gizmos.DrawRay(transform.position, transform.forward * hit.distance);  // objemizden ileriye do�ru bir ���n �izdik.

                Gizmos.DrawWireCube(transform.position + transform.forward * hit.distance, transform.localScale);

                isabetin oldu�u yere kadar uzanan bir k�p �izer.
            }

            else // Hen�z bir vuru� olmad�ysa, ���n� maksimum mesafeden �izer :
            {

                Gizmos.DrawRay(transform.position, transform.forward * m_MaxDistance);

                Gizmos.DrawWireCube(transform.position + transform.forward * m_MaxDistance, transform.localScale);
                Maksimum mesafede bir k�p �izer.
            }
        }

        */
        #endregion


        #region 9 ) Physics.CapsuleCastAll() ve  Physics.CapsuleCastNonAlloc ()

        // BoxCastAll() ve BoxCastNonAlloc () metotlar�ndaki mant�k burdada ge�erlidir o y�zden buray� detayl� a��klamad�m.

        #endregion


        #region 10 ) Physics.CheckBox ( )

        // CheckBox : KONTROL kutusu 

        /*

        Verilen kutunun di�er �arp��t�r�c�larla(colliderlarla) �rt���p �rt��medi�ini kontrol eder.


        bool True, kutu HERHANG� bir �arp��t�r�c�yla �rt���yorsa.

        YAN� YORUMUM : Kutu ile �arp��t�r�c� ( Collider ) e�er ayn� plane �zerindeyse true de�erini d�n�yor Yani kutu kendi
                       �arp��t�r�c�s�yla ( Collider'�yla ) �RT���YOR. AMA AYNI PLANE �ZER�NDE DE��LSE FALSE DE�ER�N� D�N�YOR YAN�
                       KUTU �ARPI�TIRICISIYLA ( COLL�DER 'IYLA ) �RT��M�YOR !!!!!!!!!!!!!!

        center      : kutunun merkezi
        halfExtents : Her boyutta kutunun yar�s� boyutunda
        orientation : Kutunun d�n���
        layermask   : Bir ���n yay�nlarken �arp��t�r�c�lar� se�ici olarak yok saymak i�in kullan�lan bir katman maskesi. 
        queryTriggerInteraction  : Bu sorgunun Tetikleyicileri vurup vurmayaca��n� belirtir.




        float horizontal = Input.GetAxis("Horizontal") * Time.deltaTime;
        float vertical = Input.GetAxis("Vertical") * Time.deltaTime;

        transform.Translate(new Vector3(horizontal, 0f, vertical));

        bool a = Physics.CheckBox(transform.position, transform.localScale, transform.rotation);

        if (a)
        {
            Debug.Log("EVET kutu di�er �arp��t�r�c�larla �RT��T�.");
        }
        else
        {
            Debug.Log("HAYIR kutu di�er �arp��t�r�c�larla �RT��MED�.");
        }


        */

        #endregion


        #region 11) Physics.CheckCapsule ( )

        /*
          Check Capsule : Kaps�l� kontrol et.

        D�nya uzay�nda HERHANG� bir �arp��t�r�c�n�n (Collider'�n) kaps�l �eklindeki bir hacimle �rt���p �rt��medi�ini kontrol eder.

        Kaps�l, kaps�l�n iki ucunu olu�turan nokta1 ve nokta2 �evresinde yar��apa sahip iki k�re taraf�ndan tan�mlan�r.

        start  : Kaps�l�n ba�lang�c�ndaki k�renin merkezi
        end    : Kaps�l�n sonundaki k�renin merkezi
        radius : Kaps�l�n yar��ap�
        layermask : Bir kaps�l olu�tururken �arp��t�r�c�lar� se�ici olarak yok saymak i�in kullan�lan bir katman maskesi.
        queryTriggerInteraction : Bu sorgunun tetikleyicileri vurup vurmayaca��n� belirtir.



        float horizontal = Input.GetAxis("Horizontal") * Time.deltaTime;
        float vertical = Input.GetAxis("Vertical") * Time.deltaTime;

        transform.Translate(new Vector3(horizontal, 0f, vertical));

        Vector3 start = transform.position + capsulecollider.bounds.center + Vector3.up *- capsulecollider.height * 0.5f;
        Vector3 end = start +Vector3.up *capsulecollider.height;

         start = kendi pozisyonu -1
         end = kendi pozisyonu + 1 

         bool CapsulSeklindeCarpistiriciVarmi = Physics.CheckCapsule(start,end,2f);
           
       �NEML����������������������������������������������������������������������������������������������� :
         BU KODLARI Physics.OverlapCapsule ( ) 'DEK� OLU�TURDU�UN MANTIK VE KODLARI YAPMAK ZORUNDASIN YOKSA BU KODLAR �ALI�MAZ
         

        if (CapsulSeklindeCarpistiriciVarmi)
        {
            Debug.Log("Evet Caps�l Collider 'a �rt��en bir Collider Var.  ");
        }

        else
        {
            Debug.Log("Hay�r yok.");
        }

        */

        #endregion


        #region 12 ) Physics.CheckSphere ( )

        /*


         D�nya koordinatlar�nda konum ve yar��ap taraf�ndan tan�mlanan k�reyle �rt��en HERHANG� bir �arp��t�r�c� varsa true 
         de�erini d�nd�r�r.

        position  : K�renin merkezi
        radius    : K�renin yar��ap�
        layerMask : Bir kaps�l olu�tururken �arp��t�r�c�lar� se�ici olarak yok saymak i�in kullan�lan bir katman maskesi.
        queryTriggerInteraction : Bu sorgunun tetikleyicileri vurup vurmayaca��n� belirtir.


        float horizontal = Input.GetAxis("Horizontal") * Time.deltaTime;
        float vertical = Input.GetAxis("Vertical") * Time.deltaTime;

        transform.Translate(new Vector3(horizontal, 0f, vertical));

        bool k�reColliderVarmi= Physics.CheckSphere(transform.position, 1f);

        if (k�reColliderVarmi)
        {
            Debug.Log("Evet k�re collider '�mla �RT��EN bir ba�ka  objenin Collider '� var ");

        }
        else
        {
            Debug.Log("Hay�r yok. ");
        }

        */

        #endregion


        #region 13 ) Physics.ClosestPoint ( )

        /*

        Closest Point : En yak�n nokta

        point    : En yak�n noktay� bulmak istedi�iniz konum.
        collider : En yak�n noktay� buldu�unuz �arp��t�r�c�
        position : �arp��t�r�c�n�n konumu
        rotation : �arp��t�r�c�n�n d�n���

        Vector3 �arp��t�r�c�da belirtilen konuma en yak�n nokta.

        Belirtilen konuma en yak�n olan verilen �arp��t�r�c�da bir nokta d�nd�r�r.

        Belirtilen konumun �arp��t�r�c�n�n i�inde veya tam olarak s�n�r�nda olmas� durumunda, bunun yerine giri� konumunun 
        d�nd�r�lece�ini unutmay�n.

        �arp��t�r�c� yaln�zca BoxCollider, SphereCollider, CapsuleCollider veya bir d��b�key MeshCollider olabilir.



        Vector3 enYakinNokta=   Physics.ClosestPoint(transform.position, m_Collider, transform.position, Quaternion.identity);

        Debug.Log(enYakinNokta);

        YAN� belirledi�in nitelikler sonucunda EN YAKIN NOKTAYI bulabilmemizi sa�lar.

        */

        #endregion


        #region 14 ) Physics.clothGravity

        /*

        Kuma� Yer�ekimi ayar�. T�m kuma� bile�enleri i�in yer�ekimini ayarlayar.

        Debug.Log(Physics.clothGravity);

        Projede HAM ( DEFAULT ) HAL�YLE  Kuma� yer�ekimi ayar� ( 0, -9.8, 0 ) ' m�� ! ! !

        */
        #endregion


        #region 15 ) Physics.ComputePenetration ( ) **

        /*

        Verilen �arp��t�r�c�lar� belirtilen pozlarda birbirinden ay�rmak i�in gereken minimum �eviriyi hesaplay�n.

        �lk �arp��t�r�c�y� y�n * mesafeye g�re �evirmek, i�lev do�ru d�nd�r�l�rse �arp��t�r�c�lar� birbirinden ay�r�r. 
        Aksi takdirde y�n ve mesafe tan�mlanmaz.

        �arp��t�r�c�lardan biri BoxCollider, SphereCollider CapsuleCollider veya bir d��b�key MeshCollider olmal�d�r. Di�eri 
        HERHANG�     bir tip olabilir.

        �a�r� an�nda �arp��t�r�c�lar�n sahip oldu�u konum ve d�n��le s�n�rl� olmad���n�z� unutmay�n. Halihaz�rda ayarlanandan
        farkl� ge�i� pozisyonu veya d�n���, herhangi bir �arp��t�r�c�y� fiziksel olarak hareket ettirme etkisine sahip de�ildir, 
        dolay�s�yla Sahne �zerinde hi�bir yan etkisi yoktur.

        �lk olarak g�ncellenecek herhangi bir uzamsal yap�ya ba�l� de�ildir, bu nedenle yaln�zca FixedUpdate zaman �er�evesi i�inde
        kullan�lmas� zorunlu de�ildir. Arka y�zl� ��genleri yok sayar ve Physics.queriesHitBackfaces'e uymaz.

        Bu i�lev, �ZEL N�FUZ ETME ��LEVLER� yazmak i�in kullan��l�d�r. Belirli bir �rnek, �evreleyen fizik nesneleri ile 
        �arp��maya kar�� belirli bir tepkinin gerekli oldu�u bir karakter denetleyicisinin uygulanmas�d�r. Bu durumda, ki�i �nce 
        OverlapSphere kullanarak yak�ndaki �arp��t�r�c�lar� sorgular ve ard�ndan ComputePenetration taraf�ndan d�nd�r�len verileri 
        kullanarak karakterin konumunu ayarlar.


        colliderA : �lk �arp��t�r�c�
        positionA : ilk �arp��t�r�c�n�n konumu
        rotationA : ilk �arp��t�r�c�n�n d�n���
        colliderB : �kinci �arp��t�r�c�
        positionB : �kinci �arp��t�r�c�n�n konumu
        rotationB : �kinci �arp��t�r�c�n�n d�n���
        direction : �arp��t�r�c�lar� birbirinden ay�rmak i�in �evirinin y�n� minimumdur.
        distance  : �arp��t�r�c�lar� birbirinden ay�rmak i�in gerekli olan y�n boyunca olan mesafe 

        *****************************************************************************************************************



        IsPenetrating = Physics.ComputePenetration(

            colliderA: colliderAnlayis,
            positionA: colliderAnlayis.transform.position,
            rotationA: colliderAnlayis.transform.rotation,
            colliderB: colliderDusunce,
            positionB: colliderDusunce.transform.position,
            rotationB: colliderDusunce.transform.rotation,
            direction: out m_direction,
            distance: out m_distance);

        YAN���������������� :

             B�Z BURDA D�RECT�ON (VECTOR3) VE D�STANCE (FLOAT  )'a bir de�er G�RMED�K ��NK� as�l amac�m�z as�l ��renmemiz gereken
             �ey �u : 2 OBJEN�N COLL�DER 'I  birbirine girdi�inde BUNU YAKALAYAB�LMEM�Z� SA�LAR VE GEREKL� �STED���N ��LEM� 
             YAPAB�LMEN� SA�LAR. �rne�in 2 obje birbirine girdi�inde Effect patlas�n, veya 2 obje birbirine girdi�inde
             bu i�e i�e giren objeler ate� edilmeye ba�lans�n gibi .......  


        if (IsPenetrating)
        {
            Debug.Log("Evet i� i�e girdiler.");

            gameObject.transform.position = anlayisObject.transform.position;
        }

        else
        {
            Debug.Log("Hay�r i�e i�e DE��LLER.");
        }


        */
        #endregion


        #region  16 ) Physics.defaultContactOffset

        /*

        Debug.Log(Physics.defaultContactOffset); 
            HAM ( DEFAULT ) haliyle Collider'lar�n ( �arp��t�r�c�lar�n ) VARSAYILAN TEMAS �TELEMES� 0.01f De�erindeymi� ! ! !


        Physics.defaultContactOffset = temasOteleme; // defaultContactOffset temas otelemeye e�it olsun demi� olduk.
        if (temasOteleme >= 1f)
        {
            Debug.Log("Temas etmeye 1 mesafe kald�.");
        }
        else
        {
            Debug.Log("Hay�r de�il.");
        }


         YAN�������� 2 collider Birbirlerine temas etmesi gerekirken TAM OLARAK TEMAS ETM�YORSA  defaultContactOffset de�erini
         DAHADA K���LTEREK SORUNU ��ZMEM�Z� SA�LAYAN B�R �ZELL�KT�R ! ! ! ! ! ! ! ! ! ! ! !

        */


        #endregion


        #region 17 ) Physics.defaultMaxAngularSpeed


        /*

        Dinamik bir Rigidbody 'nin radyan cinsinden varsay�lan MAKS�MUM A�ISAL HIZI ( )

        Radyan cinsinden �l��len dinamik Rigidbody 'nin maksimum a��sal h�z�n� kontrol eder. A��sal h�z s�n�r� her bir kat� g�vde
        temelinde Rigidbody.maxAngularVelocity ile de de�i�tirilebilir.


        Debug.Log(Physics.defaultMaxAngularSpeed);

           Projede Edit => Project Settings => defaultMaxAngularSpeed ' de g�rd���n gibi  Rigidbody 'nin HAM ( DEFAULT ) 
           MAKS�MUM  A�ISAL HIZI 7 ' mi�.



        YAN��������� sen bu  Rigidbody 'nin MAKS�MUM A�ISAL HIZ ' � projende kullanaca��n zaman bu de�eri ister default haliyle
        ister projendeki algoritmaya  g�re  kendin bir de�er atayabilirsin ! ! ! !  ! !

        */
        #endregion


        #region 18 ) Physics.defaultMaxDepenetrationVelocity ** Physics.ComputePenetration ile ba�lant�l� D�KKAT ET 

        /*

        Bir sert cismin �arp��t�r�c�s�n� ba�ka bir �arp��t�r�c�n�n y�zey PENETRASYONUNDAN ��karmak i�in makismum varsay�lan HIZ !
        Bu de�er genellikle Scriptler yerine Edit=>Project Settings => Physics penceresinden de�i�tirilir.

        �ok b�y�k de�erler, �arp��ma alg�lamas� s�ras�nda karars�zl��a neden olabilir; �ok k���k de�erler �arp��t�r�c�n�n n�fuz
        etmesinin ba�ar�s�z olmas�na neden olabilir.

        Ayr�ca Rigidbody.maxDepenetrationVelocity arac�l���yla ayr� Rigidbodies i�in maksimum bir depenetrasyon h�z� ayarlayabilirsiniz.



        Debug.Log(Physics.defaultMaxDepenetrationVelocity);

         HAM ( DEFAULT ) haliyle  de�eri 10 ' mu� biz bunu oyunaki algoritmaya g�re  hem Edit Physics sekmesinden hem de BURDAN
         DE���T�REB�L�R�Z ! ! ! ! ! 


        */

        #endregion


        #region 19 ) Physics.defaultPhysicsScene

        /* 

         Hangi fizik sahnesindeyiz onu yakalar.

         Debug.Log(Physics.defaultPhysicsScene);

        */
        #endregion


        #region 20 ) Physics.DefaultRaycastLayers


        /*

        Varsay�lan raycast katmanlar�n� se�mek i�in KATMAN MASKES� SAB�T�.

        Bu, Physics.Raycast'in katman maskesi alan�nda ve varsay�lan raycast katmanlar�n� se�mek i�in di�er y�ntemlerde 
        kullan�labilir. Varsay�lan katmanlar, yoksay�lan raycast katman� d���ndaki t�m katmanlard�r.

        Debug.Log(Physics.DefaultRaycastLayers);

        Ham ( Default ) haliyle -5 ' mi�.

        */

        #endregion


        #region 21 ) Physics.defaultSolverIterations Rigidbody.solverIterations ' la ba�lant�l�


        /*
         Rigidbody.solverIterations ba�lant�l� ��nk� burda bu de�eri de�i�tirebiliriz.

         Rigidbody ' lerin �arp��malardaki ��z�c� yineleme say�s�d�r . Yani bu de�eri art�rmak Rigidbody  'nin �ARPI�MADA
         daha KARARLI OLMASINI SA�LAR.

        Debug.Log(Physics.defaultSolverIterations); // VARSAYILAN  ��z�c� yineleme sayisi 6 ym��.)

        Ama burda VARSAYILAN ��Z�C� Y�NELEME say�s�n� kullanm�� oluruz.
        Bu  varsay�lan 6 de�erini Edit => Project Setting=> Physics sekmesindende  de�i�trebiliriz.

        YAN������������������� E�ER varsay�lan ��z�c� yineleme say�s�  ( YAN� defaultSolverIterations ) Oyunda �ARPI�MALARDA
        sorun ya��yor ve KARARSIZ davran�� VARSA Rigidbody.solverIterations 'u KULLAN  ! ! !


           */

        #endregion


        #region 22 ) Physics.defaultSolverVelocityIterations

        /*

        defaultSolverVelocityIterations : ��z�c� h�z yinelemeleri

        HAM ( DEFAULT ) haliyle ��z�c� h�z yinelemesi say�s� 1 ' mi�. Bunu scriptten de�i�tirebiliriz  Unity 'de Edit =>
        Physics sekmesinden de de�i�tirebiliriz.

        E�eR MEVCUT bir Rigidbody 'lerin HIZLI HAREKET etmesiyle ilgili bir sorun ya�arsan Rigidbody.solverVelocityIterions 'u
        KULLANMAK ZORUNDASIN ! ! !


        Debug.Log( Physics.defaultSolverVelocityIterations );

        */

        #endregion


        #region 23 ) Physics.GetIgnoreCollision ( )

        /*

        Get Ignore collision : �ARPI�MAYI G�RMEZDEN GELMEK.

        �arp��ma alg�lama sisteminin �arp��t�r�c�1 ( collider1 ) ve �arp��t�r�c�2 ( collider2 )aras�ndaki t�m 
        �arp��malar�/tetikleyicileri g�rmezden gelip gelmeyece�ini kontrol eder.

        bool carpismayiGormezdenGeliyimMi = Physics.GetIgnoreCollision(m_Dusunce, Denemem);

        if (carpismayiGormezdenGeliyimMi)
        {
            Debug.Log("�arp��may� g�rmezden geldim.");
        }
        else
        {
            Debug.Log("�arp��may� g�rmezden GELMED�M.");
        }


         YAN�iiii E�ER 2 �ARPI�TIRICI ( COLL�DER )  UN�TY 'N�N  �ARPI�MA MANTI�INA UYGUN OLUYORSA  FALSE YAN� 2 COLL�DER B�RB�RiYLE
         �ARPI�AB�L�R ANLAMINA GEL�R!!!!!!!!!

         i�te biz bu MANTI�I sorgular�z asl�nda.

        */

        #endregion


        #region 24 ) Physics.GetIgnoreLayerCollision ( )

        /*

        Get Ignore Layer Collision : KATMAN �ARPI�MASINI YOK SAYMAK

        YAN������� belirtti�im katmanlar�n UN�TY 'N�N �ARPI�MA MANTI�IN uygun oluyorsa FALSE YAN� 2 katmana sahip obhe birbirleriyle
        �ARPI�AB�L�R ANLAMINA GEL�R !!!!!!!!!!


        Debug.Log( Physics.GetIgnoreLayerCollision(1, 2));

        */

        #endregion


        #region 25 ) Physics.gravity

        /*

        Sahnedeki T�M KATI C�S�MLERE UYGULANAN YER�EK�M�D�R.

        sahnedekiTumRigidbodylereUygulananYerCekimiDegeri = new Vector3(0f, -200f, 0f);

        sahnedekiTumRigidbodylereUygulananYerCekimiDegeri = new Vector3(0f, -5f, 0f);

        sahnedekiTumRigidbodylereUygulananYerCekimiDegeri = new Vector3(0f, -1f, 0f);

        Physics.gravity = sahnedekiTumRigidbodylereUygulananYerCekimiDegeri;


        */
        #endregion


        #region 26 ) Physics.IgnoreCollision() **

        /*

         collider1 : Herhangi bir �arp��t�r�c�
         collider2 : �arp��malar� yok sayamy� ba�latmak i�in veya durdurmak i�in sahip olmak istedi�iniz ba�ka bir �arp��t�r�c�.
         ignore    : �ki �arp��t�r�c� aras�ndaki �arp��malar�n g�z ard� edilip edilmeyece�i.

        �arp��ma alg�lama sisteminin �arp��t�r�c�1 ve �arp��t�r�c�2 aras�ndaki t�m �arp��malar� YOK SAYAR.

        Bu �RNE��N mermilerin , mermiyi ate�leyen NESNEYLE ( insanda olabilir hayvanda )  �arp��mas�n� �nlemek i�in YARARLIDIR.

        IgnoreCollision ( ) '�n KALICI DE��LD�R. Bu bir sahneyi kaydederken �arp��may� yok sayma durumunun d�zenleyecide 
        SAKLANMAYACA�I anlam�na gelir.

        Eger ignore FALSE 'sa �ARPI�MALAR MEYDANA GELEB�L�R. �arp��malar� YOK SAYMAK ���N ignore = true OLMALIDIR ! ! ! ! ! ! 



        Physics.IgnoreCollision(m_Dusunce, m_Anlayis, true);

        Oyunu �al��t�rd���nda g�rd���n gibi dusunce objesi ve anlayis objesi birbirlerinini i�inden ge�iyor yani �arp��ma durumlar�n�
        G�Z ARDI ETM�� OLDUK ! ! ! ! ! ! 1

        */

        #endregion


        #region 27 ) Physics.IgnoreLayerCollision ( ) **

        /*

        Physics.IgnoreLayerCollision(1, 2,true);

         Physics.IgnoreCollision ( ) 'la ayn� mant��a sahip. 
         Yani burdada 1 ve 2 katmanlara sahip objeler aras�nda �ARPI�MALAR G�Z ARDI ED�L�YOR ! ! ! ! ! !

        */
        #endregion


        #region 28 ) Physics.IgnoreRaycastLayer

        /*

        Ignore Raycast Layer : Raycast katman�n� yok sayar.

        Raycast katman�n� yok saymak i�in katman maskesi sabiti. ( 4 m�� )

        Bu, Physics.Raycast'in katman maskesi alan�nda ve "raycast'leri yoksay" katman�n� se�mek i�in di�er y�ntemlerde 
        kullan�labilir (varsay�lan olarak raycast'leri almaz).


        Debug.Log(Physics.IgnoreRaycastLayer);


        */

        #endregion


        #region 29 ) Physics.interCollisionDistance 

        /*

          inter Collision Distance : �ARPI�MA MESAFES�

          KUMA� �arp��mas� i�in minimum ay�rma mesafesini ayarlar.

          Bu mesafeden daha yak�n olan farkl� Cloth nesnelerine ait kuma� par�ac�klar� AYRILACAKTIR.


        Physics.interCollisionDistance; 

        Bunu e�er oyunlarda KUMA�LARIN ( BAYRAKLARIN ) varsa o zaman kullanacaks�n ! ! !


        */
        #endregion


        #region 30 ) interCollisionSettingsToggle

        /*

        inter collision settings Toggle : �arp��ma ayarlar� aras�nda ge�i� yap.



        bool carpismaAyarlariArasindaGecisVarmi=   Physics.interCollisionSettingsToggle;

        Debug.Log(carpismaAyarlariArasindaGecisVarmi);

             Proje HAM ( DEFAULT ) haliyle false d�nd� yani �ARPI�MA AYARLARI ARASINDA GE��� YAPAMAYIZ.

        */
        #endregion


        #region 31 ) Physics.interCollisionStiffness

        /*

        Kuma��n �arp��malar aras� SERTL���N� ayarlar.

        �arp��malar aras� SERTL�K, �arp��malar aras� mesafeden ( interCollisionDistance ) daha yak�n olduklar�nda iki par�ac���n 
        birbirini ne kadar itti�ini kontrol eder.


        float KumasinCarpismalarArasiSertligi = Physics.interCollisionStiffness;
        Debug.Log(KumasinCarpismalarArasiSertligi);

         Projede HAM ( DEFAULT ) haliyle kuma��n �arp��ma aras� SERTL��� 0 'm��.Biz bu de�eri kendimizde belirleyebiliriz ! ! !

        */

        #endregion


        #region 32 ) Physics.Linecast ( )

        /*

        start : Baslang�� noktas�
        end   : Biti� noktas�
        layerMask : �arp��t�r�c�lar� se�ici olarak yok saymak i�in kullan�lan bir katman maskesi.
        queryTriggerInteraction : Bu sorgunun tetikleyicileri vurup vurmayaca��n� belirtir.


        hitInfo :  True d�nd�r�l�rse hitInfo �arp��t�r�c�n�n ( Collider'�n ) vuruldu�u yer hakk�nda daha  FAZLA B�LG� VER�R !  

        Ba�lang�� ve Biti� aras�ndaki �izgiyi KESEN herhangi bir �arp��t�r�c� varsa TRUE d�ner.


        *******************************************************************

        RaycastHit hit;

        bool kesenNoktaDeneme1 = Physics.Linecast(m_Dusunce.transform.position, m_Anlayis.transform.position);
        bool kesenNoktaDeneme2 = Physics.Linecast(m_Anlayis.transform.position, m_Dusunce.transform.position, out hit);

        if (kesenNoktaDeneme1)
        {

            Debug.Log("Seni ortadan kald�rd�m.");
            Debug.Log(hit.transform.name) ;
            hit.transform.position = new Vector3(1f, 1f, 10f); 


            YAN�������� G�rd���n gibi 2 obje aras�ndaki de�en OBJEY� YAKALAYIP bu objeye bir i�lem yapabiliyorum.�rne�in konumu
            de�i�tirmek gibi. Mesela bu objeye bir efect te verebilirdim ! ! !


        }

        else
        {
            Debug.Log("Kald�ramad�m.");
        }

        private void OnDrawGizmos() // Update Metodunun DI�INA YAZ.
        {
            Gizmos.color = Color.white;
            Gizmos.DrawLine(m_Dusunce.transform.position, m_Anlayis.transform.position);
        }

        */
        #endregion


        #region 33 ) Physics.OverlapBox ( ) **

        /*

         overlap Box : �rt��en kutu

        center      : Kutunun merkezi
        halfExtents : Her boyutta kutunun yar�s�
        orientation : Kutunun d�n���
        layerMask   : Bir ���n yay�nlarken �arp��t�r�c�lar� se�ici olarak yok saymak i�in kullan�lan bir Katman Maskesi.
        queryTriggerInteraction : Bu sorgunun Tetikleyicileri vurup vurmayaca��n� belirtir.

        Verilen kutuya DOKUNAN  �ARPI�TIRICILARI veya  KUTUNUN i�indeki T�M �ARPI�TIRICILARI BULUR..

        Kutuyla temas eden t�m �arp��t�r�c�lar�n ��kt�s�n� alarak �arp��malar� test eden, tan�mlad���n�z g�r�nmez bir kutu olu�turur.

        **********************************************************************

        Collider[] TemasEdenColliderlar= Physics.OverlapBox(gameObject.transform.position, transform.localScale, transform.rotation);
        int i = 0;
        while (i< TemasEdenColliderlar.Length)
        {
            Debug.Log("De�en obje : " + TemasEdenColliderlar[i].name + i);
            i++;
        }

        */

        #endregion


        #region 34 ) Physics.OverlapBoxNonAlloc ( )

        /*

         Overlap Box  Non Alloc : �RT��ME KUTUSU TAHS�S ED�LMEYEN.

        center      : Kutunun merkezi
        halfExtents : Her boyutta kutunun boyutunun yar�s�
        results     : Sonu�lar�n depolanaca�� ARABELLEK. ( ��inde depolanan �arp��t�r�c�lar�n miktar� )
        orientation : Kutunun d�n���
        layerMask   : Bir ���n yay�nlarken �arp��t�r�c�lar� se�ici olarak yok saymak i�in kullan�lan bir Katman Maskesi.
        queryTriggerInteraction : Bu sorgunun Tetikleyicileri vurup vurmayaca��n� belirtir.

        Verilen kutuya DOKUNAN �ARPI�TIRICILARI VEYA KUTUNUN ���NDEK� t�m �arp��t�r�c�lar� bulur ve bunlar� ARABELLEKTE saklar.



        int miktar=  Physics.OverlapBoxNonAlloc(transform.position, transform.localScale, colliderLarinDizisi, transform.rotation);
        Debug.Log(miktar);

                */
        #endregion


        #region 35 ) Physics.OverlapCapsule ( ) **


        /*
          
        point0 : Kaps�l�n ba�lang�c�ndaki k�renin merkezi.
        point1 : Kaps�l�n sonundaki k�renin merkezi.
        radius : Kaps�l�n yar��ap�.
        layerMask : Bir kaps�l� olu�tururken �arp��t�r�c�lar� se�ici olarak yok saymak i�in kullan�lan bir Katman Maskesi.
        queryTriggerInteraction : Bu sorgunun tetikleyicileri vurup vurmayaca��n� belirtir.

         Verilen KAPS�LE DOKUNAN  �ARPI�TIRICILARI veya  KAPS�L�N i�indeki T�M �ARPI�TIRICILARI BULUR.

        
         ****************************************************************************************
         *
        Debug.Log(m_Capsule.transform.position);
        p1=m_Capsule.transform.position + m_Capsule.bounds.size.y * Vector3.up * -0.75f;
        p2 = p1 + m_Capsule.bounds.size.y * Vector3.up * 0.5f;

        colliderLarinDizisi =  Physics.OverlapCapsule(p1, p2, 0.5f);
        int i = 0;

        while (i<colliderLarinDizisi.Length)
        {
            Debug.Log("De�en objenin Collider '�  : " + colliderLarinDizisi[i].name);
            i++;
        }

         �OK �NEML� ! ! ! ! ! !  
         TAM �STED���N G�B� �ALI�TI TAM DEFTERDEK� SAYFANDA BU MANTI�I  nas�l olu�turdu�ununun RESM� VE ANLATIMI VAR.
         �STTEK�  Physics.CheckCapsule ( ) metodunuda bu mant�ktan yaz ! ! ! 


        */
        #endregion


        #region 36 )  Physics.OverlapCapsuleNonAlloc ( ) ve OverlapSphereNonAlloc () 

        /*
         
         Bu iki metodun mant��� Physics.OverlapBoxNonAlloc () Metodunun mant���yla ayn�d�r. 
         Bu y�zden   Physics.OverlapBoxNonAlloc () metodunun mant���n� referans alarak bu 2 metotlar� anlar  ve  gerekli 
         oldu�u durumlarda anlar ve kullan�rs�n.......

        */

        #endregion


        #region 37 ) Physics.OverlapSphere ( ) **

        /*

        position  : K�renin merkezi
        radius    : K�renin yar��ap�.
        layerMask : Sorguya hangi �arp��t�r�c� katmanlar�n eklenece�ini tan�mlar.
        queryTriggerInteraction : Bu sorgunun tetikleyicileri vurup vurmayaca��n� belirtir.

        K�REYE TEMAS eden veya k�renin kendi i�indeki �arp��t�r�c�lar� hesaplar ve  �arp��t�r�c� dizesinde saklar..

        

        colliderLarinDizisi =   Physics.OverlapSphere(m_Sphere.transform.position, 0.5f);
        int i = 0;

        while (i<colliderLarinDizisi.Length)
        {
            Debug.Log("De�en Carp��t�r�c� Yani Collider : " + colliderLarinDizisi[i].name);
            i++;
        }

        */

        #endregion


        #region 38 ) Physics.queriesHitBackfaces

        /*
         
        Fizik sorgular�n�n arka y�z ��genlerine �arpmas� gerekip gerekmedi�i.

        Varsay�lan olarak, ���n yay�n� veya �ekil taramas� (�rn. SphereCastAll) gibi t�m fizik sorgular�, arka y�z ��genleri olan 
        isabetleri alg�lamaz.

        VARSAYILAN OLARAK Edit => Physics Sekmesindede bu FALSE 'tur.��NK� BUNA GEREK YOK.
       
        
        bool arkaYuzUcgenlereCarpsinMi = Physics.queriesHitBackfaces;
        Debug.Log(arkaYuzUcgenlereCarpsinMi);
        
        FALSE D�ND�.Hem Edit=>Physics sekmesinde hem kodda false de�erini ald�k.

        */

        #endregion


        #region  39 ) Physics.queriesHitTriggers

        /*
        
         Sorgular�n (raycast'ler, k�re ���n� atmalar, �rt��me testleri vb.) varsay�lan olarak Tetikleyicilere ula��p ula�mad���n�
         belirtir.
 
        Bu, QueryTriggerInteraction parametresi belirtilerek sorgu ba��na d�zeyinde ge�ersiz k�l�nabilir. YAN� SORGUYA �ZEL
        FALSE YAPILAB�L�R.

        YAN��� Edit=> Project Settings => Physic sekmesinde  varsay�lan olarak  TRUE 'dur.��NK�  O Raycast'lerle SphereCast, 
        BoxCast, OverlapTest gibi sorgular yapt���m�z  Fizik sistemimizin TET�KLEY�C�LERE �HT�YACI VAR O Y�ZDEN
        TRUE OLARAK KALMALIDIR ! ! ! ! ! ! !

        Debug.Log(Physics.queriesHitTriggers);

        */

        #endregion


        #region 40 ) Physics.Raycast ( ) **

        /*
         
        origin      : I��n�n d�nya koordinatlar�nda ba�lang�� noktas�
        direction   : I��n�n y�n�
        hitInfo     : True d�nd�r�l�rse hitInfo en yak�n �ARPI�TIRICININ ( Collider'�n ) nerede �arp�ld��� hakk�nda daha FAZLA 
                      verir ! 
        maxDistance : I��n�n �arp��malar i�in kontrol etmesi gereken maksimum mesafe
        layerMask   : Bir ���n� yay�nlarken �arp��t�r�c�lar� se�ici olarak yok saymak i�in kullan�lan bir katman maskesi.
        queryTriggerInteraction : Bu sorgunun tetikleyicieri vurup vurmayaca��n� belirtir.

       bool :  I��n bir �arp��t�r�c� ( Collider ) ile kesi�iyorsa TRUE, aksi takdirde FALSE d�ner.

       Sahnedeki t�m �arp��t�r�c�lara  belirledi�in NOKTADAN belirledi�in Y�NDE ve belirtti�in UZAKLIKTA bir I�IN g�ndermeni sa�lar.

       �arp��ma olmas�n� istemedi�in durumlarda �arp��t�r�c�lar�  F�LTRELEMEK i�in LayerMask '� kullan.

       Raycast'ler Raycast kayna��n�n �arp��t�r�c�n�n i�inde oldu�u �arp��t�r�c�lar� alg�lamaz. 
       Di�er BoxCast(),SphereCast ()  gibi metotlarda kayna��n i�indeki �arp��t�r�lar� alg�lan�r.

        
     **************************************************************************************************************

     isinGittiMi =   Physics.Raycast(gameObject.transform.position, transform.forward,  out hit,200f);

        if (isinGittiMi)
        {
            Debug.Log(hit.transform.gameObject.name);
        }


        private void OnDrawGizmos() // Update Metodunun d���na yaz.
        {
            Gizmos.color = Color.white;


            if (isinGittiMi)
            {
                Gizmos.DrawLine(gameObject.transform.position, hit.transform.position);
            }

            else
            {
                Gizmos.DrawLine(gameObject.transform.position, transform.forward * 50f);

            }
        }

        */

        #endregion





    }





}


