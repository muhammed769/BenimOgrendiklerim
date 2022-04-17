using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicSinifiOzellikVeMetodlari : MonoBehaviour
{


    #region Deðiþkenler 1

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


    #region Physics.ComputePenetration ( ) metodunun deðiþkenleri 

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


    #region Deðiþkenler 2

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

          Fiziðin OTOMATÝK olarak SÝMÜLE edilip edilmeyeceðini ayarlar.

          Varsayýlan olarak, fizik oynatma modu sýrasýnda her Time.fixedDeltaTime güncellenir. Normal oyun döngüsünün bir parçasý,
         olarak otomatik olarak gerçekleþir.

          Ancak, fiziði manuel olarak ilerletmenin gerekli olduðu durumlar vardýr. Düzenleme modunda fiziði simüle eden özel bir 
          örnek. Baþka bir örnek, yetkili sunucudan veri alýrken zamaný geri sarmanýn ve tüm oyuncu girdisini uygulamanýn gerekli 
          olduðu að baðlantýlý fizik olabilir.

          Fizik simülasyonunu manuel olarak kontrol etmek için önce otomatik simülasyonu devre dýþý býrakýn ve ardýndan zamaný 
          ilerletmek için Physics.Simulate'i kullanýn. MonoBehaviour.FixedUpdate'in yine Time.fixedDeltaTime tarafýndan tanýmlanan
          hýzda çaðrýlacaðýný unutmayýn ., ancak fizik simülasyonu artýk otomatik olarak geliþtirilmeyecektir.


        Debug.Log(Physics.autoSimulation);

        Proje HAM ( DEFAULT ) haliyle TRUE  deðerini döndürdü. YANÝ  FÝZÝK OTOMATÝK OLARAK SÝMÜLE EDÝLÝYOR.

        */

        #endregion


        #region 2 ) Physics.autoSyncTransforms

        /*

        Bir TRANSFORM bileþeni deðiþtiðinde, dönüþüm deðiþikliklerinin fizik sistemiyle OTOMATÝK olarak senkronize edilip 
        edilmeyeceðini ayarlar.

        Bir Dönüþtürme bileþeni deðiþtiðinde, o Dönüþüm üzerindeki herhangi bir Sert Cisim veya Çarpýþtýrýcýnýn veya alt
        öðelerinin, Dönüþtürme'deki deðiþikliðe baðlý olarak yeniden konumlandýrýlmasý, döndürülmesi veya ölçeklenmesi 
        gerekebilir. Bu özelliði true olarak ayarlayarak, Dönüþtürme'de yapýlan deðiþikliklerin doðru bileþenlere otomatik 
        olarak uygulanýp uygulanmayacaðýný kontrol edebilirsiniz. Yanlýþ olarak ayarlandýðýnda, senkronizasyon yalnýzca Sabit
        Güncelleme sýrasýnda fizik simülasyonu adýmýndan önce gerçekleþir. Ayrýca, Physics.SyncTransforms'u kullanarak 
        dönüþtürme deðiþikliklerini manuel olarak senkronize edebilirsiniz.

        Not: autoSyncTransforms true olarak ayarlandýðýnda, bir Transform'u art arda deðiþtirmek ve ardýndan bir fizik 
        sorgusu gerçekleþtirmek performans kaybýna neden olabilir. Performansý etkilemekten kaçýnmak için, art arda birden 
        çok Dönüþtürme deðiþikliði ve sorgusu yapmak istiyorsanýz autoSyncTransforms'u false olarak ayarlayýn. Unity 2017.2'den
        önce yapýlmýþ mevcut projelerde geriye dönük fizik uyumluluðu için autoSyncTransforms'u yalnýzca true olarak 
        ayarlamalýsýnýz. Unity 2017.2 ve sonrasýnda yapýlan projeler için bu seçeneði KAPATIN ! ! ! 



                Debug.Log(Physics.autoSyncTransforms);

        Projede HAM ( DEFAULT ) haliyle FALSE deðerini verdi. Yani üstteki açýklamalarda Unity 'nin 2017 sonrasýndaki sürümlerinde
        bu özelliði kapatýn açýklamasýný DOÐRULAR NÝTELÝKTEDÝR ! ! !

        */

        #endregion


        #region 3 ) Physics.BakeMesh ( )

        /*

        Mesh'i MeshCollider ile kullaným için hazýrlar.

        Bu iþlev Mesh piþirmeyi çalýþtýrýr ve sonucu Mesh'in kendisine kaydeder. Bu Mesh'e baþvuran bir MeshCollider
        somutlaþtýrýldýðýnda, Mesh'i yeniden piþirmek yerine piþirilen verileri YENÝDEN kullanýr. Bu, pahalý piþirme sürecini
        Sahne yükleme süresinden veya örnekleme süresinden farklý bir zamana taþýmak istediðinizde kullanýþlýdýr. BakeMesh iþ
        parçacýðý için güvenlidir ve çaðrýldýðý iþ parçacýðý üzerinde hesaplamalar yapar, ancak tanýmsýz davranýþa neden olduðu 
        için ayný anda birden çok iþ parçacýðýndan ayný að üzerinde BakeMesh'i çaðýrmak geçerli deðildir. BakeMesh'i C# iþ sistemi
        ile kullanabilirsiniz.


        meshID : Çarpýþma verilerini oluþturulacaðý Mesh ' in örnek kimliði
        convex : dýþ bükey geometrinin piþirilip piþirilmeyeceðini gösteren bir bayrak.

         */


        #endregion


        #region 4 ) Physics.bounceThreshold

        /* 
           bounce Threshold : SIÇRAMA EÞÝÐÝ

        Bunun altýnda göreceli hýza sahip çarpýþan iki nesne sekmeyecektir (varsayýlan 2). Olumlu olmalý.

        Bu deðer genellikle Scriptler yerine Edit->Project Settings ->Physics denetçisinde deðiþtirilir.



        float sicramaEsigiYanibounceThresHold = Physics.bounceThreshold;
        Debug.Log(sicramaEsigiYanibounceThresHold);

        */
        #endregion


        #region 5 )  Physics.BoxCast ( )


        /*

          Kutuyu bir IÞIN boyunca FIRLATIR ve neyin çarpýldýðýna dair ayrýntýlý bilgi verir.

        1.Tür  :

        center      : Kutunun merkezi
        halfExtents : Her boyutta kutunun yarýsý boyutunda. 
        direcion    : Kutunun atýlacaðý yön
        orientation : Kutunun dönüþü
        maxDistance : Atmanýn maksimum uzunluðu
        layerMask   : Bir kapsül oluþtururken çarpýþtýrýcýlarý seçici olarak yok saymak için kullanýlan bir katman maskesi.
        queryTriggerInteraction : Bu sorgunun tetikleyicileri vurup vurmayacaðýný belirtir.

        hitInfo : hitInfo true döndürülürse, hitInfo çarpýþtýrýcýnýn vurulduðu yer hakkýnda DAHA FAZLA  bilgi ÝÇERÝR.



        float xAxis = Input.GetAxis("Horizontal") * m_Speed;
        float zAxis = Input.GetAxis("Vertical") * m_Speed;

        transform.Translate(new Vector3(xAxis * Time.deltaTime, 0, zAxis * Time.deltaTime));

        BoxCast()  metodunu kullanarak bir isabet olup olmadýðýný bulabiliriz.

        m_HitDetect = Physics.BoxCast(m_Collider.bounds.center, transform.localScale, transform.forward, out m_Hit, transform.rotation, m_MaxDistance);

        if (m_HitDetect) // isabet Ettiyse 
        {
            Debug.Log("Hit : " + m_Hit.collider.name);
            Kutuya isabet eden Çarpýþtýrýcýnýn(collider ' a sahip objenin ) adýný bulduk.


        }

        */


        /*  void OnDrawGizmos() // SÝLME VE MUTLAKA ARADA BAK !!!  ( UPDATE Metodunun dýþýna yaz ! ! ! ! ! ! ! )
        {



           Gizmos.color = Color.white;

           isabet kontrolu yapýyoruz:

           if (m_HitDetect)
           {

               Gizmos.DrawRay(transform.position, transform.forward * m_Hit.distance);  // objemizden ileriye doðru bir ýþýn çizdik.

               Gizmos.DrawWireCube(transform.position + transform.forward * m_Hit.distance, transform.localScale);

               isabetin olduðu yere kadar uzanan bir küp çizer.
           }

           else // Henüz bir vuruþ olmadýysa, ýþýný maksimum mesafeden çizer :
           {

               Gizmos.DrawRay(transform.position, transform.forward * m_MaxDistance);

               Gizmos.DrawWireCube(transform.position + transform.forward * m_MaxDistance, transform.localScale);
               Maksimum mesafede bir küp çizer.

           }
        */

        #endregion


        #region 6 ) Physics.BoxCastAll ( )

        /*

        Physics.BoxCast gibidir, ancak TÜM ÝSABETLERÝ  döndürür.

        Notlar: Taramanýn baþlangýcýnda kutuyla çakýþan çarpýþtýrýcýlar için, RaycastHit.normal, tarama yönünün tersine ayarlanýr, 
        RaycastHit.distance sýfýra ayarlanýr ve sýfýr vektörü RaycastHit.point'te döndürülür. Özel sorgunuzda durumun böyle olup 
        olmadýðýný kontrol etmek ve sonucu iyileþtirmek için ek sorgular yapmak isteyebilirsiniz.



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


        intresults :  Arabelleðe depolanan isabet miktarý .


        Kutuyu yön boyunca yayar ve isabet  saðladýklarýmý arabellekte saklar.

        result : Sonuçlarýn saklanacaðý ara bellek.




        float yatayHiz = Input.GetAxis("Horizontal") * Time.deltaTime;
        float zHiz = Input.GetAxis("Vertical") * Time.deltaTime;

        transform.Translate(yatayHiz, 0f, zHiz);

         araBellek=  Physics.BoxCastNonAlloc(transform.position, transform.localScale, transform.forward, ButunIsabetEdenIsinlar, transform.rotation, m_MaxDistance);

        Debug.Log(araBellek);


        */

        #endregion


        #region  8 ) Physics.CapsuleCast ( )

        /*

        Sahnedeki tüm çarpýþtýrýcýlara karþý bir kapsül atar ve neyin çarptýðý hakkýnda ayrýntýlý bilgi verir.

        Kapsül, kapsülün iki ucunu oluþturan nokta1 ve nokta2 çevresinde yarýçapa sahip iki küre tarafýndan tanýmlanýr. Kapsül yön 
        boyunca hareket ettirilirse bu kapsüle çarpacak olan ilk çarpýþtýrýcý için isabetler döndürülür. Bu, bir Raycast yeterli
        hassasiyet vermediðinde kullanýþlýdýr, çünkü bir karakter gibi belirli bir boyuttaki bir nesnenin yolda herhangi bir þeyle
        çarpýþmadan bir yere hareket edip edemeyeceðini öðrenmek istersiniz.

        Notlar: CapsuleCast, kapsülün çarpýþtýrýcýyla çakýþtýðý çarpýþtýrýcýlarý algýlamaz. Sýfýr yarýçapý geçmek, tanýmsýz 
               çýktýyla sonuçlanýr ve her zaman Physics.Raycast ile ayný þekilde davranmaz.

        point1 : Kapsülün baþlangýcýndaki kürenin merkezi
        point2 : Kapsülün sonundaki kürenin merkezi
        radius : Kapsülün yarýçapý
        Direction : Kapsülün süpürüleceði yön
        maxDistance : Süpürmenin maksimum uzunluðu
        layerMask : Bir kapsül oluþturulurken çarpýþtýrýcýlarý seçici olarak yok saymak için kullanýlan bir katman maskesi.
        queryTriggerInteraction : Bu sorgunun tetikleyicileri vurup vurmayacaðýný belirtir.
        hitInfo : hitInfo true döndürülürse, hitInfo çarpýþtýrýcýnýn vurulduðu yer hakkýnda DAHA FAZLA  bilgi ÝÇERÝR.

        -------------------------------------------------------------------------------------------------------------------

        float horizontal = Input.GetAxis("Horizontal") * Time.deltaTime;
        float vertical = Input.GetAxis("Vertical") * Time.deltaTime;

        transform.Translate(new Vector3(horizontal, 0f, vertical));


         Herhangi bir þeye çarpmak üzere olup olmadýðýný görmek için karakter denetleyicisi(characterController)
         þeklini 10 metre ileriye atýn.

        RaycastHit hit;

        CharacterController charContr = GetComponent<CharacterController>();

        Debug.Log(charContr.center);
        HAM(DEFAULT) HALÝYLE Character Controller Componentine sahip objenin Center 'ý ( 0,0,0 ) ' mýþ.

        Vector3 p1 = transform.position + charContr.center + Vector3.up * -charContr.height * 0.5F;  = kendi pozisyonu -1
        Vector3 p2 = p1 + Vector3.up * charContr.height;  === kendipozisyonu -1+2 ===> kendipozisyonu +1

        p1= kendiPozisyonu -1 
        p2 = kendiPozisyonu +1 ' MÝÞ ! ! !


        CapsuleCastIleTemasGerceklesTiMi = Physics.CapsuleCast(p1, p2, charContr.radius, transform.forward, out hit, 10f);


        if (CapsuleCastIleTemasGerceklesTiMi)
        {
            Debug.Log(hit.transform.gameObject.name);

        }

        !!!!!!!!!!!!!!!!!!!!!! YANÝ Capsule IÞINLARI ATARAK ÇARPIÞMALARI YAKALAYABÝLMEMÝZÝ YARAYAN BÝR METOTTUR !!!!!!!!!!!!!!!!!!


        -------------------------------------------------------------------------------------------------------------------


        private void OnDrawGizmos() // UPDATE METODUNUN DIÞINA YAZ.
        {
            Gizmos.color = Color.white;

            //isabet kontrolu yapýyoruz:

            if (CapsuleCastIleTemasGerceklesTiMi)
            {

                Gizmos.DrawRay(transform.position, transform.forward * hit.distance);  // objemizden ileriye doðru bir ýþýn çizdik.

                Gizmos.DrawWireCube(transform.position + transform.forward * hit.distance, transform.localScale);

                isabetin olduðu yere kadar uzanan bir küp çizer.
            }

            else // Henüz bir vuruþ olmadýysa, ýþýný maksimum mesafeden çizer :
            {

                Gizmos.DrawRay(transform.position, transform.forward * m_MaxDistance);

                Gizmos.DrawWireCube(transform.position + transform.forward * m_MaxDistance, transform.localScale);
                Maksimum mesafede bir küp çizer.
            }
        }

        */
        #endregion


        #region 9 ) Physics.CapsuleCastAll() ve  Physics.CapsuleCastNonAlloc ()

        // BoxCastAll() ve BoxCastNonAlloc () metotlarýndaki mantýk burdada geçerlidir o yüzden burayý detaylý açýklamadým.

        #endregion


        #region 10 ) Physics.CheckBox ( )

        // CheckBox : KONTROL kutusu 

        /*

        Verilen kutunun diðer çarpýþtýrýcýlarla(colliderlarla) örtüþüp örtüþmediðini kontrol eder.


        bool True, kutu HERHANGÝ bir çarpýþtýrýcýyla örtüþüyorsa.

        YANÝ YORUMUM : Kutu ile Çarpýþtýrýcý ( Collider ) eðer ayný plane üzerindeyse true deðerini dönüyor Yani kutu kendi
                       çarpýþtýrýcýsýyla ( Collider'ýyla ) ÖRTÜÞÜYOR. AMA AYNI PLANE ÜZERÝNDE DEÐÝLSE FALSE DEÐERÝNÝ DÖNÜYOR YANÝ
                       KUTU ÇARPIÞTIRICISIYLA ( COLLÝDER 'IYLA ) ÖRTÜÞMÜYOR !!!!!!!!!!!!!!

        center      : kutunun merkezi
        halfExtents : Her boyutta kutunun yarýsý boyutunda
        orientation : Kutunun dönüþü
        layermask   : Bir ýþýn yayýnlarken çarpýþtýrýcýlarý seçici olarak yok saymak için kullanýlan bir katman maskesi. 
        queryTriggerInteraction  : Bu sorgunun Tetikleyicileri vurup vurmayacaðýný belirtir.




        float horizontal = Input.GetAxis("Horizontal") * Time.deltaTime;
        float vertical = Input.GetAxis("Vertical") * Time.deltaTime;

        transform.Translate(new Vector3(horizontal, 0f, vertical));

        bool a = Physics.CheckBox(transform.position, transform.localScale, transform.rotation);

        if (a)
        {
            Debug.Log("EVET kutu diðer çarpýþtýrýcýlarla ÖRTÜÞTÜ.");
        }
        else
        {
            Debug.Log("HAYIR kutu diðer çarpýþtýrýcýlarla ÖRTÜÞMEDÝ.");
        }


        */

        #endregion


        #region 11) Physics.CheckCapsule ( )

        /*
          Check Capsule : Kapsülü kontrol et.

        Dünya uzayýnda HERHANGÝ bir çarpýþtýrýcýnýn (Collider'ýn) kapsül þeklindeki bir hacimle örtüþüp örtüþmediðini kontrol eder.

        Kapsül, kapsülün iki ucunu oluþturan nokta1 ve nokta2 çevresinde yarýçapa sahip iki küre tarafýndan tanýmlanýr.

        start  : Kapsülün baþlangýcýndaki kürenin merkezi
        end    : Kapsülün sonundaki kürenin merkezi
        radius : Kapsülün yarýçapý
        layermask : Bir kapsül oluþtururken çarpýþtýrýcýlarý seçici olarak yok saymak için kullanýlan bir katman maskesi.
        queryTriggerInteraction : Bu sorgunun tetikleyicileri vurup vurmayacaðýný belirtir.



        float horizontal = Input.GetAxis("Horizontal") * Time.deltaTime;
        float vertical = Input.GetAxis("Vertical") * Time.deltaTime;

        transform.Translate(new Vector3(horizontal, 0f, vertical));

        Vector3 start = transform.position + capsulecollider.bounds.center + Vector3.up *- capsulecollider.height * 0.5f;
        Vector3 end = start +Vector3.up *capsulecollider.height;

         start = kendi pozisyonu -1
         end = kendi pozisyonu + 1 

         bool CapsulSeklindeCarpistiriciVarmi = Physics.CheckCapsule(start,end,2f);
           
       ÖNEMLÝÝÝÝÝÝÝÝÝÝÝÝÝÝÝÝÝÝÝÝÝÝÝÝÝÝÝÝÝÝÝÝÝÝÝÝÝÝÝÝÝÝÝÝÝÝÝÝÝÝÝÝÝÝÝÝÝÝÝÝÝÝÝÝÝÝÝÝÝÝÝÝÝÝÝÝÝÝÝÝÝÝÝÝÝÝÝÝÝÝÝÝÝÝÝ :
         BU KODLARI Physics.OverlapCapsule ( ) 'DEKÝ OLUÞTURDUÐUN MANTIK VE KODLARI YAPMAK ZORUNDASIN YOKSA BU KODLAR ÇALIÞMAZ
         

        if (CapsulSeklindeCarpistiriciVarmi)
        {
            Debug.Log("Evet Capsül Collider 'a örtüþen bir Collider Var.  ");
        }

        else
        {
            Debug.Log("Hayýr yok.");
        }

        */

        #endregion


        #region 12 ) Physics.CheckSphere ( )

        /*


         Dünya koordinatlarýnda konum ve yarýçap tarafýndan tanýmlanan küreyle örtüþen HERHANGÝ bir çarpýþtýrýcý varsa true 
         deðerini döndürür.

        position  : Kürenin merkezi
        radius    : Kürenin yarýçapý
        layerMask : Bir kapsül oluþtururken çarpýþtýrýcýlarý seçici olarak yok saymak için kullanýlan bir katman maskesi.
        queryTriggerInteraction : Bu sorgunun tetikleyicileri vurup vurmayacaðýný belirtir.


        float horizontal = Input.GetAxis("Horizontal") * Time.deltaTime;
        float vertical = Input.GetAxis("Vertical") * Time.deltaTime;

        transform.Translate(new Vector3(horizontal, 0f, vertical));

        bool küreColliderVarmi= Physics.CheckSphere(transform.position, 1f);

        if (küreColliderVarmi)
        {
            Debug.Log("Evet küre collider 'ýmla ÖRTÜÞEN bir baþka  objenin Collider 'ý var ");

        }
        else
        {
            Debug.Log("Hayýr yok. ");
        }

        */

        #endregion


        #region 13 ) Physics.ClosestPoint ( )

        /*

        Closest Point : En yakýn nokta

        point    : En yakýn noktayý bulmak istediðiniz konum.
        collider : En yakýn noktayý bulduðunuz çarpýþtýrýcý
        position : Çarpýþtýrýcýnýn konumu
        rotation : Çarpýþtýrýcýnýn dönüþü

        Vector3 Çarpýþtýrýcýda belirtilen konuma en yakýn nokta.

        Belirtilen konuma en yakýn olan verilen çarpýþtýrýcýda bir nokta döndürür.

        Belirtilen konumun çarpýþtýrýcýnýn içinde veya tam olarak sýnýrýnda olmasý durumunda, bunun yerine giriþ konumunun 
        döndürüleceðini unutmayýn.

        Çarpýþtýrýcý yalnýzca BoxCollider, SphereCollider, CapsuleCollider veya bir dýþbükey MeshCollider olabilir.



        Vector3 enYakinNokta=   Physics.ClosestPoint(transform.position, m_Collider, transform.position, Quaternion.identity);

        Debug.Log(enYakinNokta);

        YANÝ belirlediðin nitelikler sonucunda EN YAKIN NOKTAYI bulabilmemizi saðlar.

        */

        #endregion


        #region 14 ) Physics.clothGravity

        /*

        Kumaþ Yerçekimi ayarý. Tüm kumaþ bileþenleri için yerçekimini ayarlayar.

        Debug.Log(Physics.clothGravity);

        Projede HAM ( DEFAULT ) HALÝYLE  Kumaþ yerçekimi ayarý ( 0, -9.8, 0 ) ' mýþ ! ! !

        */
        #endregion


        #region 15 ) Physics.ComputePenetration ( ) **

        /*

        Verilen çarpýþtýrýcýlarý belirtilen pozlarda birbirinden ayýrmak için gereken minimum çeviriyi hesaplayýn.

        Ýlk çarpýþtýrýcýyý yön * mesafeye göre çevirmek, iþlev doðru döndürülürse çarpýþtýrýcýlarý birbirinden ayýrýr. 
        Aksi takdirde yön ve mesafe tanýmlanmaz.

        Çarpýþtýrýcýlardan biri BoxCollider, SphereCollider CapsuleCollider veya bir dýþbükey MeshCollider olmalýdýr. Diðeri 
        HERHANGÝ     bir tip olabilir.

        Çaðrý anýnda çarpýþtýrýcýlarýn sahip olduðu konum ve dönüþle sýnýrlý olmadýðýnýzý unutmayýn. Halihazýrda ayarlanandan
        farklý geçiþ pozisyonu veya dönüþü, herhangi bir çarpýþtýrýcýyý fiziksel olarak hareket ettirme etkisine sahip deðildir, 
        dolayýsýyla Sahne üzerinde hiçbir yan etkisi yoktur.

        Ýlk olarak güncellenecek herhangi bir uzamsal yapýya baðlý deðildir, bu nedenle yalnýzca FixedUpdate zaman çerçevesi içinde
        kullanýlmasý zorunlu deðildir. Arka yüzlü üçgenleri yok sayar ve Physics.queriesHitBackfaces'e uymaz.

        Bu iþlev, ÖZEL NÜFUZ ETME ÝÞLEVLERÝ yazmak için kullanýþlýdýr. Belirli bir örnek, çevreleyen fizik nesneleri ile 
        çarpýþmaya karþý belirli bir tepkinin gerekli olduðu bir karakter denetleyicisinin uygulanmasýdýr. Bu durumda, kiþi önce 
        OverlapSphere kullanarak yakýndaki çarpýþtýrýcýlarý sorgular ve ardýndan ComputePenetration tarafýndan döndürülen verileri 
        kullanarak karakterin konumunu ayarlar.


        colliderA : Ýlk çarpýþtýrýcý
        positionA : ilk çarpýþtýrýcýnýn konumu
        rotationA : ilk çarpýþtýrýcýnýn dönüþü
        colliderB : Ýkinci çarpýþtýrýcý
        positionB : Ýkinci çarpýþtýrýcýnýn konumu
        rotationB : Ýkinci çarpýþtýrýcýnýn dönüþü
        direction : Çarpýþtýrýcýlarý birbirinden ayýrmak için çevirinin yönü minimumdur.
        distance  : Çarpýþtýrýcýlarý birbirinden ayýrmak için gerekli olan yön boyunca olan mesafe 

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

        YANÝÝÝÝÝÝÝÝÝÝÝÝÝÝÝÝ :

             BÝZ BURDA DÝRECTÝON (VECTOR3) VE DÝSTANCE (FLOAT  )'a bir deðer GÝRMEDÝK ÇÜNKÜ asýl amacýmýz asýl öðrenmemiz gereken
             þey þu : 2 OBJENÝN COLLÝDER 'I  birbirine girdiðinde BUNU YAKALAYABÝLMEMÝZÝ SAÐLAR VE GEREKLÝ ÝSTEDÝÐÝN ÝÞLEMÝ 
             YAPABÝLMENÝ SAÐLAR. Örneðin 2 obje birbirine girdiðinde Effect patlasýn, veya 2 obje birbirine girdiðinde
             bu içe içe giren objeler ateþ edilmeye baþlansýn gibi .......  


        if (IsPenetrating)
        {
            Debug.Log("Evet iç içe girdiler.");

            gameObject.transform.position = anlayisObject.transform.position;
        }

        else
        {
            Debug.Log("Hayýr içe içe DEÐÝLLER.");
        }


        */
        #endregion


        #region  16 ) Physics.defaultContactOffset

        /*

        Debug.Log(Physics.defaultContactOffset); 
            HAM ( DEFAULT ) haliyle Collider'larýn ( Çarpýþtýrýcýlarýn ) VARSAYILAN TEMAS ÖTELEMESÝ 0.01f Deðerindeymiþ ! ! !


        Physics.defaultContactOffset = temasOteleme; // defaultContactOffset temas otelemeye eþit olsun demiþ olduk.
        if (temasOteleme >= 1f)
        {
            Debug.Log("Temas etmeye 1 mesafe kaldý.");
        }
        else
        {
            Debug.Log("Hayýr deðil.");
        }


         YANÝÝÝÝÝÝÝÝ 2 collider Birbirlerine temas etmesi gerekirken TAM OLARAK TEMAS ETMÝYORSA  defaultContactOffset deðerini
         DAHADA KÜÇÜLTEREK SORUNU ÇÖZMEMÝZÝ SAÐLAYAN BÝR ÖZELLÝKTÝR ! ! ! ! ! ! ! ! ! ! ! !

        */


        #endregion


        #region 17 ) Physics.defaultMaxAngularSpeed


        /*

        Dinamik bir Rigidbody 'nin radyan cinsinden varsayýlan MAKSÝMUM AÇISAL HIZI ( )

        Radyan cinsinden ölçülen dinamik Rigidbody 'nin maksimum açýsal hýzýný kontrol eder. Açýsal hýz sýnýrý her bir katý gövde
        temelinde Rigidbody.maxAngularVelocity ile de deðiþtirilebilir.


        Debug.Log(Physics.defaultMaxAngularSpeed);

           Projede Edit => Project Settings => defaultMaxAngularSpeed ' de gördüðün gibi  Rigidbody 'nin HAM ( DEFAULT ) 
           MAKSÝMUM  AÇISAL HIZI 7 ' miþ.



        YANÝÝÝÝÝÝÝÝÝ sen bu  Rigidbody 'nin MAKSÝMUM AÇISAL HIZ ' ý projende kullanacaðýn zaman bu deðeri ister default haliyle
        ister projendeki algoritmaya  göre  kendin bir deðer atayabilirsin ! ! ! !  ! !

        */
        #endregion


        #region 18 ) Physics.defaultMaxDepenetrationVelocity ** Physics.ComputePenetration ile baðlantýlý DÝKKAT ET 

        /*

        Bir sert cismin çarpýþtýrýcýsýný baþka bir çarpýþtýrýcýnýn yüzey PENETRASYONUNDAN çýkarmak için makismum varsayýlan HIZ !
        Bu deðer genellikle Scriptler yerine Edit=>Project Settings => Physics penceresinden deðiþtirilir.

        Çok büyük deðerler, çarpýþma algýlamasý sýrasýnda kararsýzlýða neden olabilir; çok küçük deðerler çarpýþtýrýcýnýn nüfuz
        etmesinin baþarýsýz olmasýna neden olabilir.

        Ayrýca Rigidbody.maxDepenetrationVelocity aracýlýðýyla ayrý Rigidbodies için maksimum bir depenetrasyon hýzý ayarlayabilirsiniz.



        Debug.Log(Physics.defaultMaxDepenetrationVelocity);

         HAM ( DEFAULT ) haliyle  deðeri 10 ' muþ biz bunu oyunaki algoritmaya göre  hem Edit Physics sekmesinden hem de BURDAN
         DEÐÝÞTÝREBÝLÝRÝZ ! ! ! ! ! 


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

        Varsayýlan raycast katmanlarýný seçmek için KATMAN MASKESÝ SABÝTÝ.

        Bu, Physics.Raycast'in katman maskesi alanýnda ve varsayýlan raycast katmanlarýný seçmek için diðer yöntemlerde 
        kullanýlabilir. Varsayýlan katmanlar, yoksayýlan raycast katmaný dýþýndaki tüm katmanlardýr.

        Debug.Log(Physics.DefaultRaycastLayers);

        Ham ( Default ) haliyle -5 ' miþ.

        */

        #endregion


        #region 21 ) Physics.defaultSolverIterations Rigidbody.solverIterations ' la baðlantýlý


        /*
         Rigidbody.solverIterations baðlantýlý çünkü burda bu deðeri deðiþtirebiliriz.

         Rigidbody ' lerin çarpýþmalardaki çözücü yineleme sayýsýdýr . Yani bu deðeri artýrmak Rigidbody  'nin ÇARPIÞMADA
         daha KARARLI OLMASINI SAÐLAR.

        Debug.Log(Physics.defaultSolverIterations); // VARSAYILAN  çözücü yineleme sayisi 6 ymýþ.)

        Ama burda VARSAYILAN ÇÖZÜCÜ YÝNELEME sayýsýný kullanmýþ oluruz.
        Bu  varsayýlan 6 deðerini Edit => Project Setting=> Physics sekmesindende  deðiþtrebiliriz.

        YANÝÝÝÝÝÝÝÝÝÝÝÝÝÝÝÝÝÝÝ EÐER varsayýlan çözücü yineleme sayýsý  ( YANÝ defaultSolverIterations ) Oyunda ÇARPIÞMALARDA
        sorun yaþýyor ve KARARSIZ davranýþ VARSA Rigidbody.solverIterations 'u KULLAN  ! ! !


           */

        #endregion


        #region 22 ) Physics.defaultSolverVelocityIterations

        /*

        defaultSolverVelocityIterations : Çözücü hýz yinelemeleri

        HAM ( DEFAULT ) haliyle çözücü hýz yinelemesi sayýsý 1 ' miþ. Bunu scriptten deðiþtirebiliriz  Unity 'de Edit =>
        Physics sekmesinden de deðiþtirebiliriz.

        EðeR MEVCUT bir Rigidbody 'lerin HIZLI HAREKET etmesiyle ilgili bir sorun yaþarsan Rigidbody.solverVelocityIterions 'u
        KULLANMAK ZORUNDASIN ! ! !


        Debug.Log( Physics.defaultSolverVelocityIterations );

        */

        #endregion


        #region 23 ) Physics.GetIgnoreCollision ( )

        /*

        Get Ignore collision : ÇARPIÞMAYI GÖRMEZDEN GELMEK.

        Çarpýþma algýlama sisteminin çarpýþtýrýcý1 ( collider1 ) ve çarpýþtýrýcý2 ( collider2 )arasýndaki tüm 
        çarpýþmalarý/tetikleyicileri görmezden gelip gelmeyeceðini kontrol eder.

        bool carpismayiGormezdenGeliyimMi = Physics.GetIgnoreCollision(m_Dusunce, Denemem);

        if (carpismayiGormezdenGeliyimMi)
        {
            Debug.Log("çarpýþmayý görmezden geldim.");
        }
        else
        {
            Debug.Log("Çarpýþmayý görmezden GELMEDÝM.");
        }


         YANÝiiii EÐER 2 ÇARPIÞTIRICI ( COLLÝDER )  UNÝTY 'NÝN  ÇARPIÞMA MANTIÐINA UYGUN OLUYORSA  FALSE YANÝ 2 COLLÝDER BÝRBÝRiYLE
         ÇARPIÞABÝLÝR ANLAMINA GELÝR!!!!!!!!!

         iþte biz bu MANTIÐI sorgularýz aslýnda.

        */

        #endregion


        #region 24 ) Physics.GetIgnoreLayerCollision ( )

        /*

        Get Ignore Layer Collision : KATMAN ÇARPIÞMASINI YOK SAYMAK

        YANÝÝÝÝÝÝÝ belirttiðim katmanlarýn UNÝTY 'NÝN ÇARPIÞMA MANTIÐIN uygun oluyorsa FALSE YANÝ 2 katmana sahip obhe birbirleriyle
        ÇARPIÞABÝLÝR ANLAMINA GELÝR !!!!!!!!!!


        Debug.Log( Physics.GetIgnoreLayerCollision(1, 2));

        */

        #endregion


        #region 25 ) Physics.gravity

        /*

        Sahnedeki TÜM KATI CÝSÝMLERE UYGULANAN YERÇEKÝMÝDÝR.

        sahnedekiTumRigidbodylereUygulananYerCekimiDegeri = new Vector3(0f, -200f, 0f);

        sahnedekiTumRigidbodylereUygulananYerCekimiDegeri = new Vector3(0f, -5f, 0f);

        sahnedekiTumRigidbodylereUygulananYerCekimiDegeri = new Vector3(0f, -1f, 0f);

        Physics.gravity = sahnedekiTumRigidbodylereUygulananYerCekimiDegeri;


        */
        #endregion


        #region 26 ) Physics.IgnoreCollision() **

        /*

         collider1 : Herhangi bir çarpýþtýrýcý
         collider2 : Çarpýþmalarý yok sayamyý baþlatmak için veya durdurmak için sahip olmak istediðiniz baþka bir çarpýþtýrýcý.
         ignore    : Ýki çarpýþtýrýcý arasýndaki çarpýþmalarýn göz ardý edilip edilmeyeceði.

        Çarpýþma algýlama sisteminin çarpýþtýrýcý1 ve çarpýþtýrýcý2 arasýndaki tüm çarpýþmalarý YOK SAYAR.

        Bu ÖRNEÐÝN mermilerin , mermiyi ateþleyen NESNEYLE ( insanda olabilir hayvanda )  çarpýþmasýný önlemek için YARARLIDIR.

        IgnoreCollision ( ) 'ýn KALICI DEÐÝLDÝR. Bu bir sahneyi kaydederken çarpýþmayý yok sayma durumunun düzenleyecide 
        SAKLANMAYACAÐI anlamýna gelir.

        Eger ignore FALSE 'sa ÇARPIÞMALAR MEYDANA GELEBÝLÝR. Çarpýþmalarý YOK SAYMAK ÝÇÝN ignore = true OLMALIDIR ! ! ! ! ! ! 



        Physics.IgnoreCollision(m_Dusunce, m_Anlayis, true);

        Oyunu çalýþtýrdýðýnda gördüðün gibi dusunce objesi ve anlayis objesi birbirlerinini içinden geçiyor yani çarpýþma durumlarýný
        GÖZ ARDI ETMÝÞ OLDUK ! ! ! ! ! ! 1

        */

        #endregion


        #region 27 ) Physics.IgnoreLayerCollision ( ) **

        /*

        Physics.IgnoreLayerCollision(1, 2,true);

         Physics.IgnoreCollision ( ) 'la ayný mantýða sahip. 
         Yani burdada 1 ve 2 katmanlara sahip objeler arasýnda ÇARPIÞMALAR GÖZ ARDI EDÝLÝYOR ! ! ! ! ! !

        */
        #endregion


        #region 28 ) Physics.IgnoreRaycastLayer

        /*

        Ignore Raycast Layer : Raycast katmanýný yok sayar.

        Raycast katmanýný yok saymak için katman maskesi sabiti. ( 4 müþ )

        Bu, Physics.Raycast'in katman maskesi alanýnda ve "raycast'leri yoksay" katmanýný seçmek için diðer yöntemlerde 
        kullanýlabilir (varsayýlan olarak raycast'leri almaz).


        Debug.Log(Physics.IgnoreRaycastLayer);


        */

        #endregion


        #region 29 ) Physics.interCollisionDistance 

        /*

          inter Collision Distance : ÇARPIÞMA MESAFESÝ

          KUMAÞ çarpýþmasý için minimum ayýrma mesafesini ayarlar.

          Bu mesafeden daha yakýn olan farklý Cloth nesnelerine ait kumaþ parçacýklarý AYRILACAKTIR.


        Physics.interCollisionDistance; 

        Bunu eðer oyunlarda KUMAÞLARIN ( BAYRAKLARIN ) varsa o zaman kullanacaksýn ! ! !


        */
        #endregion


        #region 30 ) interCollisionSettingsToggle

        /*

        inter collision settings Toggle : Çarpýþma ayarlarý arasýnda geçiþ yap.



        bool carpismaAyarlariArasindaGecisVarmi=   Physics.interCollisionSettingsToggle;

        Debug.Log(carpismaAyarlariArasindaGecisVarmi);

             Proje HAM ( DEFAULT ) haliyle false döndü yani ÇARPIÞMA AYARLARI ARASINDA GEÇÝÞ YAPAMAYIZ.

        */
        #endregion


        #region 31 ) Physics.interCollisionStiffness

        /*

        Kumaþýn çarpýþmalar arasý SERTLÝÐÝNÝ ayarlar.

        Çarpýþmalar arasý SERTLÝK, çarpýþmalar arasý mesafeden ( interCollisionDistance ) daha yakýn olduklarýnda iki parçacýðýn 
        birbirini ne kadar ittiðini kontrol eder.


        float KumasinCarpismalarArasiSertligi = Physics.interCollisionStiffness;
        Debug.Log(KumasinCarpismalarArasiSertligi);

         Projede HAM ( DEFAULT ) haliyle kumaþýn çarpýþma arasý SERTLÝÐÝ 0 'mýþ.Biz bu deðeri kendimizde belirleyebiliriz ! ! !

        */

        #endregion


        #region 32 ) Physics.Linecast ( )

        /*

        start : Baslangýç noktasý
        end   : Bitiþ noktasý
        layerMask : Çarpýþtýrýcýlarý seçici olarak yok saymak için kullanýlan bir katman maskesi.
        queryTriggerInteraction : Bu sorgunun tetikleyicileri vurup vurmayacaðýný belirtir.


        hitInfo :  True döndürülürse hitInfo çarpýþtýrýcýnýn ( Collider'ýn ) vurulduðu yer hakkýnda daha  FAZLA BÝLGÝ VERÝR !  

        Baþlangýç ve Bitiþ arasýndaki çizgiyi KESEN herhangi bir çarpýþtýrýcý varsa TRUE döner.


        *******************************************************************

        RaycastHit hit;

        bool kesenNoktaDeneme1 = Physics.Linecast(m_Dusunce.transform.position, m_Anlayis.transform.position);
        bool kesenNoktaDeneme2 = Physics.Linecast(m_Anlayis.transform.position, m_Dusunce.transform.position, out hit);

        if (kesenNoktaDeneme1)
        {

            Debug.Log("Seni ortadan kaldýrdým.");
            Debug.Log(hit.transform.name) ;
            hit.transform.position = new Vector3(1f, 1f, 10f); 


            YANÝÝÝÝÝÝÝÝ Gördüðün gibi 2 obje arasýndaki deðen OBJEYÝ YAKALAYIP bu objeye bir iþlem yapabiliyorum.Örneðin konumu
            deðiþtirmek gibi. Mesela bu objeye bir efect te verebilirdim ! ! !


        }

        else
        {
            Debug.Log("Kaldýramadým.");
        }

        private void OnDrawGizmos() // Update Metodunun DIÞINA YAZ.
        {
            Gizmos.color = Color.white;
            Gizmos.DrawLine(m_Dusunce.transform.position, m_Anlayis.transform.position);
        }

        */
        #endregion


        #region 33 ) Physics.OverlapBox ( ) **

        /*

         overlap Box : Örtüþen kutu

        center      : Kutunun merkezi
        halfExtents : Her boyutta kutunun yarýsý
        orientation : Kutunun dönüþü
        layerMask   : Bir ýþýn yayýnlarken çarpýþtýrýcýlarý seçici olarak yok saymak için kullanýlan bir Katman Maskesi.
        queryTriggerInteraction : Bu sorgunun Tetikleyicileri vurup vurmayacaðýný belirtir.

        Verilen kutuya DOKUNAN  ÇARPIÞTIRICILARI veya  KUTUNUN içindeki TÜM ÇARPIÞTIRICILARI BULUR..

        Kutuyla temas eden tüm çarpýþtýrýcýlarýn çýktýsýný alarak çarpýþmalarý test eden, tanýmladýðýnýz görünmez bir kutu oluþturur.

        **********************************************************************

        Collider[] TemasEdenColliderlar= Physics.OverlapBox(gameObject.transform.position, transform.localScale, transform.rotation);
        int i = 0;
        while (i< TemasEdenColliderlar.Length)
        {
            Debug.Log("Deðen obje : " + TemasEdenColliderlar[i].name + i);
            i++;
        }

        */

        #endregion


        #region 34 ) Physics.OverlapBoxNonAlloc ( )

        /*

         Overlap Box  Non Alloc : ÖRTÜÞME KUTUSU TAHSÝS EDÝLMEYEN.

        center      : Kutunun merkezi
        halfExtents : Her boyutta kutunun boyutunun yarýsý
        results     : Sonuçlarýn depolanacaðý ARABELLEK. ( Ýçinde depolanan çarpýþtýrýcýlarýn miktarý )
        orientation : Kutunun dönüþü
        layerMask   : Bir ýþýn yayýnlarken çarpýþtýrýcýlarý seçici olarak yok saymak için kullanýlan bir Katman Maskesi.
        queryTriggerInteraction : Bu sorgunun Tetikleyicileri vurup vurmayacaðýný belirtir.

        Verilen kutuya DOKUNAN ÇARPIÞTIRICILARI VEYA KUTUNUN ÝÇÝNDEKÝ tüm çarpýþtýrýcýlarý bulur ve bunlarý ARABELLEKTE saklar.



        int miktar=  Physics.OverlapBoxNonAlloc(transform.position, transform.localScale, colliderLarinDizisi, transform.rotation);
        Debug.Log(miktar);

                */
        #endregion


        #region 35 ) Physics.OverlapCapsule ( ) **


        /*
          
        point0 : Kapsülün baþlangýcýndaki kürenin merkezi.
        point1 : Kapsülün sonundaki kürenin merkezi.
        radius : Kapsülün yarýçapý.
        layerMask : Bir kapsülü oluþtururken çarpýþtýrýcýlarý seçici olarak yok saymak için kullanýlan bir Katman Maskesi.
        queryTriggerInteraction : Bu sorgunun tetikleyicileri vurup vurmayacaðýný belirtir.

         Verilen KAPSÜLE DOKUNAN  ÇARPIÞTIRICILARI veya  KAPSÜLÜN içindeki TÜM ÇARPIÞTIRICILARI BULUR.

        
         ****************************************************************************************
         *
        Debug.Log(m_Capsule.transform.position);
        p1=m_Capsule.transform.position + m_Capsule.bounds.size.y * Vector3.up * -0.75f;
        p2 = p1 + m_Capsule.bounds.size.y * Vector3.up * 0.5f;

        colliderLarinDizisi =  Physics.OverlapCapsule(p1, p2, 0.5f);
        int i = 0;

        while (i<colliderLarinDizisi.Length)
        {
            Debug.Log("Deðen objenin Collider 'ý  : " + colliderLarinDizisi[i].name);
            i++;
        }

         ÇOK ÖNEMLÝ ! ! ! ! ! !  
         TAM ÝSTEDÝÐÝN GÝBÝ ÇALIÞTI TAM DEFTERDEKÝ SAYFANDA BU MANTIÐI  nasýl oluþturduðununun RESMÝ VE ANLATIMI VAR.
         ÜSTTEKÝ  Physics.CheckCapsule ( ) metodunuda bu mantýktan yaz ! ! ! 


        */
        #endregion


        #region 36 )  Physics.OverlapCapsuleNonAlloc ( ) ve OverlapSphereNonAlloc () 

        /*
         
         Bu iki metodun mantýðý Physics.OverlapBoxNonAlloc () Metodunun mantýðýyla aynýdýr. 
         Bu yüzden   Physics.OverlapBoxNonAlloc () metodunun mantýðýný referans alarak bu 2 metotlarý anlar  ve  gerekli 
         olduðu durumlarda anlar ve kullanýrsýn.......

        */

        #endregion


        #region 37 ) Physics.OverlapSphere ( ) **

        /*

        position  : Kürenin merkezi
        radius    : Kürenin yarýçapý.
        layerMask : Sorguya hangi çarpýþtýrýcý katmanlarýn ekleneceðini tanýmlar.
        queryTriggerInteraction : Bu sorgunun tetikleyicileri vurup vurmayacaðýný belirtir.

        KÜREYE TEMAS eden veya kürenin kendi içindeki çarpýþtýrýcýlarý hesaplar ve  çarpýþtýrýcý dizesinde saklar..

        

        colliderLarinDizisi =   Physics.OverlapSphere(m_Sphere.transform.position, 0.5f);
        int i = 0;

        while (i<colliderLarinDizisi.Length)
        {
            Debug.Log("Deðen Carpýþtýrýcý Yani Collider : " + colliderLarinDizisi[i].name);
            i++;
        }

        */

        #endregion


        #region 38 ) Physics.queriesHitBackfaces

        /*
         
        Fizik sorgularýnýn arka yüz üçgenlerine çarpmasý gerekip gerekmediði.

        Varsayýlan olarak, ýþýn yayýný veya þekil taramasý (örn. SphereCastAll) gibi tüm fizik sorgularý, arka yüz üçgenleri olan 
        isabetleri algýlamaz.

        VARSAYILAN OLARAK Edit => Physics Sekmesindede bu FALSE 'tur.ÇÜNKÜ BUNA GEREK YOK.
       
        
        bool arkaYuzUcgenlereCarpsinMi = Physics.queriesHitBackfaces;
        Debug.Log(arkaYuzUcgenlereCarpsinMi);
        
        FALSE DÖNDÜ.Hem Edit=>Physics sekmesinde hem kodda false deðerini aldýk.

        */

        #endregion


        #region  39 ) Physics.queriesHitTriggers

        /*
        
         Sorgularýn (raycast'ler, küre ýþýný atmalar, örtüþme testleri vb.) varsayýlan olarak Tetikleyicilere ulaþýp ulaþmadýðýný
         belirtir.
 
        Bu, QueryTriggerInteraction parametresi belirtilerek sorgu baþýna düzeyinde geçersiz kýlýnabilir. YANÝ SORGUYA ÖZEL
        FALSE YAPILABÝLÝR.

        YANÝÝÝ Edit=> Project Settings => Physic sekmesinde  varsayýlan olarak  TRUE 'dur.ÇÜNKÜ  O Raycast'lerle SphereCast, 
        BoxCast, OverlapTest gibi sorgular yaptýðýmýz  Fizik sistemimizin TETÝKLEYÝCÝLERE ÝHTÝYACI VAR O YÜZDEN
        TRUE OLARAK KALMALIDIR ! ! ! ! ! ! !

        Debug.Log(Physics.queriesHitTriggers);

        */

        #endregion


        #region 40 ) Physics.Raycast ( ) **

        /*
         
        origin      : Iþýnýn dünya koordinatlarýnda baþlangýç noktasý
        direction   : Iþýnýn yönü
        hitInfo     : True döndürülürse hitInfo en yakýn ÇARPIÞTIRICININ ( Collider'ýn ) nerede çarpýldýðý hakkýnda daha FAZLA 
                      verir ! 
        maxDistance : Iþýnýn çarpýþmalar için kontrol etmesi gereken maksimum mesafe
        layerMask   : Bir ýþýný yayýnlarken çarpýþtýrýcýlarý seçici olarak yok saymak için kullanýlan bir katman maskesi.
        queryTriggerInteraction : Bu sorgunun tetikleyicieri vurup vurmayacaðýný belirtir.

       bool :  Iþýn bir Çarpýþtýrýcý ( Collider ) ile kesiþiyorsa TRUE, aksi takdirde FALSE döner.

       Sahnedeki tüm çarpýþtýrýcýlara  belirlediðin NOKTADAN belirlediðin YÖNDE ve belirttiðin UZAKLIKTA bir IÞIN göndermeni saðlar.

       Çarpýþma olmasýný istemediðin durumlarda Çarpýþtýrýcýlarý  FÝLTRELEMEK için LayerMask 'ý kullan.

       Raycast'ler Raycast kaynaðýnýn çarpýþtýrýcýnýn içinde olduðu çarpýþtýrýcýlarý algýlamaz. 
       Diðer BoxCast(),SphereCast ()  gibi metotlarda kaynaðýn içindeki çarpýþtýrýlarý algýlanýr.

        
     **************************************************************************************************************

     isinGittiMi =   Physics.Raycast(gameObject.transform.position, transform.forward,  out hit,200f);

        if (isinGittiMi)
        {
            Debug.Log(hit.transform.gameObject.name);
        }


        private void OnDrawGizmos() // Update Metodunun dýþýna yaz.
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


