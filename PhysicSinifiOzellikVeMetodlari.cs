using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicSinifiOzellikVeMetodlari : MonoBehaviour
{


    #region Değişkenler 1

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


    #region Physics.ComputePenetration ( ) metodunun değişkenleri 

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


    #region Değişkenler 2

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

    bool kureIsiniGittiMi;

    RaycastHit[] IsinDizesi;

    int sayiOlanAraBellek ;
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

          Fiziğin OTOMATİK olarak SİMÜLE edilip edilmeyeceğini ayarlar.

          Varsayılan olarak, fizik oynatma modu sırasında her Time.fixedDeltaTime güncellenir. Normal oyun döngüsünün bir parçası,
         olarak otomatik olarak gerçekleşir.

          Ancak, fiziği manuel olarak ilerletmenin gerekli olduğu durumlar vardır. Düzenleme modunda fiziği simüle eden özel bir 
          örnek. Başka bir örnek, yetkili sunucudan veri alırken zamanı geri sarmanın ve tüm oyuncu girdisini uygulamanın gerekli 
          olduğu ağ bağlantılı fizik olabilir.

          Fizik simülasyonunu manuel olarak kontrol etmek için önce otomatik simülasyonu devre dışı bırakın ve ardından zamanı 
          ilerletmek için Physics.Simulate'i kullanın. MonoBehaviour.FixedUpdate'in yine Time.fixedDeltaTime tarafından tanımlanan
          hızda çağrılacağını unutmayın ., ancak fizik simülasyonu artık otomatik olarak geliştirilmeyecektir.


        Debug.Log(Physics.autoSimulation);

        Proje HAM ( DEFAULT ) haliyle TRUE  değerini döndürdü. YANİ  FİZİK OTOMATİK OLARAK SİMÜLE EDİLİYOR.

        */

        #endregion


        #region 2 ) Physics.autoSyncTransforms

        /*

        Bir TRANSFORM bileşeni değiştiğinde, dönüşüm değişikliklerinin fizik sistemiyle OTOMATİK olarak senkronize edilip 
        edilmeyeceğini ayarlar.

        Bir Dönüştürme bileşeni değiştiğinde, o Dönüşüm üzerindeki herhangi bir Sert Cisim veya Çarpıştırıcının veya alt
        öğelerinin, Dönüştürme'deki değişikliğe bağlı olarak yeniden konumlandırılması, döndürülmesi veya ölçeklenmesi 
        gerekebilir. Bu özelliği true olarak ayarlayarak, Dönüştürme'de yapılan değişikliklerin doğru bileşenlere otomatik 
        olarak uygulanıp uygulanmayacağını kontrol edebilirsiniz. Yanlış olarak ayarlandığında, senkronizasyon yalnızca Sabit
        Güncelleme sırasında fizik simülasyonu adımından önce gerçekleşir. Ayrıca, Physics.SyncTransforms'u kullanarak 
        dönüştürme değişikliklerini manuel olarak senkronize edebilirsiniz.

        Not: autoSyncTransforms true olarak ayarlandığında, bir Transform'u art arda değiştirmek ve ardından bir fizik 
        sorgusu gerçekleştirmek performans kaybına neden olabilir. Performansı etkilemekten kaçınmak için, art arda birden 
        çok Dönüştürme değişikliği ve sorgusu yapmak istiyorsanız autoSyncTransforms'u false olarak ayarlayın. Unity 2017.2'den
        önce yapılmış mevcut projelerde geriye dönük fizik uyumluluğu için autoSyncTransforms'u yalnızca true olarak 
        ayarlamalısınız. Unity 2017.2 ve sonrasında yapılan projeler için bu seçeneği KAPATIN ! ! ! 



                Debug.Log(Physics.autoSyncTransforms);

        Projede HAM ( DEFAULT ) haliyle FALSE değerini verdi. Yani üstteki açıklamalarda Unity 'nin 2017 sonrasındaki sürümlerinde
        bu özelliği kapatın açıklamasını DOĞRULAR NİTELİKTEDİR ! ! !

        */

        #endregion


        #region 3 ) Physics.BakeMesh ( )

        /*

        Mesh'i MeshCollider ile kullanım için hazırlar.

        Bu işlev Mesh pişirmeyi çalıştırır ve sonucu Mesh'in kendisine kaydeder. Bu Mesh'e başvuran bir MeshCollider
        somutlaştırıldığında, Mesh'i yeniden pişirmek yerine pişirilen verileri YENİDEN kullanır. Bu, pahalı pişirme sürecini
        Sahne yükleme süresinden veya örnekleme süresinden farklı bir zamana taşımak istediğinizde kullanışlıdır. BakeMesh iş
        parçacığı için güvenlidir ve çağrıldığı iş parçacığı üzerinde hesaplamalar yapar, ancak tanımsız davranışa neden olduğu 
        için aynı anda birden çok iş parçacığından aynı ağ üzerinde BakeMesh'i çağırmak geçerli değildir. BakeMesh'i C# iş sistemi
        ile kullanabilirsiniz.


        meshID : Çarpışma verilerini oluşturulacağı Mesh ' in örnek kimliği
        convex : dış bükey geometrinin pişirilip pişirilmeyeceğini gösteren bir bayrak.

         */


        #endregion


        #region 4 ) Physics.bounceThreshold

        /* 
           bounce Threshold : SIÇRAMA EŞİĞİ

        Bunun altında göreceli hıza sahip çarpışan iki nesne sekmeyecektir (varsayılan 2). Olumlu olmalı.

        Bu değer genellikle Scriptler yerine Edit->Project Settings ->Physics denetçisinde değiştirilir.



        float sicramaEsigiYanibounceThresHold = Physics.bounceThreshold;
        Debug.Log(sicramaEsigiYanibounceThresHold);

        */
        #endregion


        #region 5 )  Physics.BoxCast ( )


        /*

          Kutuyu bir IŞIN boyunca FIRLATIR ve neyin çarpıldığına dair ayrıntılı bilgi verir.

        1.Tür  :

        center      : Kutunun merkezi
        halfExtents : Her boyutta kutunun yarısı boyutunda. 
        direcion    : Kutunun atılacağı yön
        orientation : Kutunun dönüşü
        maxDistance : Atmanın maksimum uzunluğu
        layerMask   : Bir kapsül oluştururken çarpıştırıcıları seçici olarak yok saymak için kullanılan bir katman maskesi.
        queryTriggerInteraction : Bu sorgunun tetikleyicileri vurup vurmayacağını belirtir.

        hitInfo : hitInfo true döndürülürse, hitInfo çarpıştırıcının vurulduğu yer hakkında DAHA FAZLA  bilgi İÇERİR.



        float xAxis = Input.GetAxis("Horizontal") * m_Speed;
        float zAxis = Input.GetAxis("Vertical") * m_Speed;

        transform.Translate(new Vector3(xAxis * Time.deltaTime, 0, zAxis * Time.deltaTime));

        BoxCast()  metodunu kullanarak bir isabet olup olmadığını bulabiliriz.

        m_HitDetect = Physics.BoxCast(m_Collider.bounds.center, transform.localScale, transform.forward, out m_Hit, transform.rotation, m_MaxDistance);

        if (m_HitDetect) // isabet Ettiyse 
        {
            Debug.Log("Hit : " + m_Hit.collider.name);
            Kutuya isabet eden Çarpıştırıcının(collider ' a sahip objenin ) adını bulduk.


        }

        */


        /*  void OnDrawGizmos() // SİLME VE MUTLAKA ARADA BAK !!!  ( UPDATE Metodunun dışına yaz ! ! ! ! ! ! ! )
        {

           Gizmos.color = Color.white;

           isabet kontrolu yapıyoruz:

           if (m_HitDetect)
           {

               Gizmos.DrawRay(transform.position, transform.forward * m_Hit.distance);  // objemizden ileriye doğru bir ışın çizdik.

               Gizmos.DrawWireCube(transform.position + transform.forward * m_Hit.distance, transform.localScale);

               isabetin olduğu yere kadar uzanan bir küp çizer.
           }

           else // Henüz bir vuruş olmadıysa, ışını maksimum mesafeden çizer :
           {

               Gizmos.DrawRay(transform.position, transform.forward * m_MaxDistance);

               Gizmos.DrawWireCube(transform.position + transform.forward * m_MaxDistance, transform.localScale);
               Maksimum mesafede bir küp çizer.

           }
        */

        #endregion


        #region 6 ) Physics.BoxCastAll ( )

        /*

        Physics.BoxCast gibidir, ancak TÜM İSABETLERİ  döndürür.

        Notlar: Taramanın başlangıcında kutuyla çakışan çarpıştırıcılar için, RaycastHit.normal, tarama yönünün tersine ayarlanır, 
        RaycastHit.distance sıfıra ayarlanır ve sıfır vektörü RaycastHit.point'te döndürülür. Özel sorgunuzda durumun böyle olup 
        olmadığını kontrol etmek ve sonucu iyileştirmek için ek sorgular yapmak isteyebilirsiniz.



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


        intresults :  Arabelleğe depolanan isabet miktarı .


        Kutuyu yön boyunca yayar ve isabet  sağladıklarımı arabellekte saklar.

        result : Sonuçların saklanacağı ara bellek.




        float yatayHiz = Input.GetAxis("Horizontal") * Time.deltaTime;
        float zHiz = Input.GetAxis("Vertical") * Time.deltaTime;

        transform.Translate(yatayHiz, 0f, zHiz);

         araBellek=  Physics.BoxCastNonAlloc(transform.position, transform.localScale, transform.forward, ButunIsabetEdenIsinlar, transform.rotation, m_MaxDistance);

        Debug.Log(araBellek);


        */

        #endregion


        #region  8 ) Physics.CapsuleCast ( )

        /*

        Sahnedeki tüm çarpıştırıcılara karşı bir kapsül atar ve neyin çarptığı hakkında ayrıntılı bilgi verir.

        Kapsül, kapsülün iki ucunu oluşturan nokta1 ve nokta2 çevresinde yarıçapa sahip iki küre tarafından tanımlanır. Kapsül yön 
        boyunca hareket ettirilirse bu kapsüle çarpacak olan ilk çarpıştırıcı için isabetler döndürülür. Bu, bir Raycast YETERLİ
        HASSASİYET vermediğinde kullanışlıdır, çünkü bir karakter gibi belirli bir boyuttaki bir nesnenin yolda herhangi bir şeyle
        çarpışmadan bir yere hareket edip edemeyeceğini öğrenmek istersiniz.

        Notlar: CapsuleCast, kapsülün çarpıştırıcıyla çakıştığı çarpıştırıcıları algılamaz. Sıfır yarıçapı geçmek, tanımsız 
               çıktıyla sonuçlanır ve her zaman Physics.Raycast ile aynı şekilde davranmaz.

        point1 : Kapsülün başlangıcındaki kürenin merkezi
        point2 : Kapsülün sonundaki kürenin merkezi
        radius : Kapsülün yarıçapı
        Direction : Kapsülün süpürüleceği yön
        maxDistance : Süpürmenin maksimum uzunluğu
        layerMask : Bir kapsül oluşturulurken çarpıştırıcıları seçici olarak yok saymak için kullanılan bir katman maskesi.
        queryTriggerInteraction : Bu sorgunun tetikleyicileri vurup vurmayacağını belirtir.
        hitInfo : hitInfo true döndürülürse, hitInfo çarpıştırıcının vurulduğu yer hakkında DAHA FAZLA  bilgi İÇERİR.

        -------------------------------------------------------------------------------------------------------------------

        float horizontal = Input.GetAxis("Horizontal") * Time.deltaTime;
        float vertical = Input.GetAxis("Vertical") * Time.deltaTime;

        transform.Translate(new Vector3(horizontal, 0f, vertical));


         Herhangi bir şeye çarpmak üzere olup olmadığını görmek için karakter denetleyicisi(characterController)
         şeklini 10 metre ileriye atın.

        RaycastHit hit;

        CharacterController charContr = GetComponent<CharacterController>();

        Debug.Log(charContr.center);
        HAM(DEFAULT) HALİYLE Character Controller Componentine sahip objenin Center 'ı ( 0,0,0 ) ' mış.

        Vector3 p1 = transform.position + charContr.center + Vector3.up * -charContr.height * 0.5F;  = kendi pozisyonu -1
        Vector3 p2 = p1 + Vector3.up * charContr.height;  === kendipozisyonu -1+2 ===> kendipozisyonu +1

        p1= kendiPozisyonu -1 
        p2 = kendiPozisyonu +1 ' MİŞ ! ! !


        CapsuleCastIleTemasGerceklesTiMi = Physics.CapsuleCast(p1, p2, charContr.radius, transform.forward, out hit, 10f);


        if (CapsuleCastIleTemasGerceklesTiMi)
        {
            Debug.Log(hit.transform.gameObject.name);

        }

        !!!!!!!!!!!!!!!!!!!!!! YANİ Capsule IŞINLARI ATARAK ÇARPIŞMALARI YAKALAYABİLMEMİZİ YARAYAN BİR METOTTUR !!!!!!!!!!!!!!!!!!


        -------------------------------------------------------------------------------------------------------------------


        private void OnDrawGizmos() // UPDATE METODUNUN DIŞINA YAZ.
        {
            Gizmos.color = Color.white;

            //isabet kontrolu yapıyoruz:

            if (CapsuleCastIleTemasGerceklesTiMi)
            {

                Gizmos.DrawRay(transform.position, transform.forward * hit.distance);  // objemizden ileriye doğru bir ışın çizdik.

                Gizmos.DrawWireCube(transform.position + transform.forward * hit.distance, transform.localScale);

                isabetin olduğu yere kadar uzanan bir küp çizer.
            }

            else // Henüz bir vuruş olmadıysa, ışını maksimum mesafeden çizer :
            {

                Gizmos.DrawRay(transform.position, transform.forward * m_MaxDistance);

                Gizmos.DrawWireCube(transform.position + transform.forward * m_MaxDistance, transform.localScale);
                Maksimum mesafede bir küp çizer.
            }
        }

        */
        #endregion


        #region 9 ) Physics.CapsuleCastAll() ve  Physics.CapsuleCastNonAlloc ()

        // BoxCastAll() ve BoxCastNonAlloc () metotlarındaki mantık burdada geçerlidir o yüzden burayı detaylı açıklamadım.

        #endregion


        #region 10 ) Physics.CheckBox ( )

        // CheckBox : KONTROL kutusu 

        /*

        Verilen kutunun diğer çarpıştırıcılarla(colliderlarla) örtüşüp örtüşmediğini kontrol eder.


        bool True, kutu HERHANGİ bir çarpıştırıcıyla örtüşüyorsa.

        YANİ YORUMUM : Kutu ile Çarpıştırıcı ( Collider ) eğer aynı plane üzerindeyse true değerini dönüyor Yani kutu kendi
                       çarpıştırıcısıyla ( Collider'ıyla ) ÖRTÜŞÜYOR. AMA AYNI PLANE ÜZERİNDE DEĞİLSE FALSE DEĞERİNİ DÖNÜYOR YANİ
                       KUTU ÇARPIŞTIRICISIYLA ( COLLİDER 'IYLA ) ÖRTÜŞMÜYOR !!!!!!!!!!!!!!

        center      : kutunun merkezi
        halfExtents : Her boyutta kutunun yarısı boyutunda
        orientation : Kutunun dönüşü
        layermask   : Bir ışın yayınlarken çarpıştırıcıları seçici olarak yok saymak için kullanılan bir katman maskesi. 
        queryTriggerInteraction  : Bu sorgunun Tetikleyicileri vurup vurmayacağını belirtir.




        float horizontal = Input.GetAxis("Horizontal") * Time.deltaTime;
        float vertical = Input.GetAxis("Vertical") * Time.deltaTime;

        transform.Translate(new Vector3(horizontal, 0f, vertical));

        bool a = Physics.CheckBox(transform.position, transform.localScale, transform.rotation);

        if (a)
        {
            Debug.Log("EVET kutu diğer çarpıştırıcılarla ÖRTÜŞTÜ.");
        }
        else
        {
            Debug.Log("HAYIR kutu diğer çarpıştırıcılarla ÖRTÜŞMEDİ.");
        }


        */

        #endregion


        #region 11) Physics.CheckCapsule ( )

        /*
          Check Capsule : Kapsülü kontrol et.

        Dünya uzayında HERHANGİ bir çarpıştırıcının (Collider'ın) kapsül şeklindeki bir hacimle örtüşüp örtüşmediğini kontrol eder.

        Kapsül, kapsülün iki ucunu oluşturan nokta1 ve nokta2 çevresinde yarıçapa sahip iki küre tarafından tanımlanır.

        start  : Kapsülün başlangıcındaki kürenin merkezi
        end    : Kapsülün sonundaki kürenin merkezi
        radius : Kapsülün yarıçapı
        layermask : Bir kapsül oluştururken çarpıştırıcıları seçici olarak yok saymak için kullanılan bir katman maskesi.
        queryTriggerInteraction : Bu sorgunun tetikleyicileri vurup vurmayacağını belirtir.



        float horizontal = Input.GetAxis("Horizontal") * Time.deltaTime;
        float vertical = Input.GetAxis("Vertical") * Time.deltaTime;

        transform.Translate(new Vector3(horizontal, 0f, vertical));

        Vector3 start = transform.position + capsulecollider.bounds.center + Vector3.up *- capsulecollider.height * 0.5f;
        Vector3 end = start +Vector3.up *capsulecollider.height;

         start = kendi pozisyonu -1
         end = kendi pozisyonu + 1 

         bool CapsulSeklindeCarpistiriciVarmi = Physics.CheckCapsule(start,end,2f);
           
       ÖNEMLİİİİİİİİİİİİİİİİİİİİİİİİİİİİİİİİİİİİİİİİİİİİİİİİİİİİİİİİİİİİİİİİİİİİİİİİİİİİİİİİİİİİİİİİİİİİİİİ :
         BU KODLARI Physics.OverlapCapsule ( ) 'DEKİ OLUŞTURDUĞUN MANTIK VE KODLARI YAPMAK ZORUNDASIN YOKSA BU KODLAR ÇALIŞMAZ
         

        if (CapsulSeklindeCarpistiriciVarmi)
        {
            Debug.Log("Evet Capsül Collider 'a örtüşen bir Collider Var.  ");
        }

        else
        {
            Debug.Log("Hayır yok.");
        }

        */

        #endregion


        #region 12 ) Physics.CheckSphere ( )

        /*


         Dünya koordinatlarında konum ve yarıçap tarafından tanımlanan küreyle örtüşen HERHANGİ bir çarpıştırıcı varsa true 
         değerini döndürür.

        position  : Kürenin merkezi
        radius    : Kürenin yarıçapı
        layerMask : Bir kapsül oluştururken çarpıştırıcıları seçici olarak yok saymak için kullanılan bir katman maskesi.
        queryTriggerInteraction : Bu sorgunun tetikleyicileri vurup vurmayacağını belirtir.


        float horizontal = Input.GetAxis("Horizontal") * Time.deltaTime;
        float vertical = Input.GetAxis("Vertical") * Time.deltaTime;

        transform.Translate(new Vector3(horizontal, 0f, vertical));

        bool küreColliderVarmi= Physics.CheckSphere(transform.position, 1f);

        if (küreColliderVarmi)
        {
            Debug.Log("Evet küre collider 'ımla ÖRTÜŞEN bir başka  objenin Collider 'ı var ");

        }
        else
        {
            Debug.Log("Hayır yok. ");
        }

        */

        #endregion


        #region 13 ) Physics.ClosestPoint ( )

        /*

        Closest Point : En yakın nokta

        point    : En yakın noktayı bulmak istediğiniz konum.
        collider : En yakın noktayı bulduğunuz çarpıştırıcı
        position : Çarpıştırıcının konumu
        rotation : Çarpıştırıcının dönüşü

        Vector3 Çarpıştırıcıda belirtilen konuma en yakın nokta.

        Belirtilen konuma en yakın olan verilen çarpıştırıcıda bir nokta döndürür.

        Belirtilen konumun çarpıştırıcının içinde veya tam olarak sınırında olması durumunda, bunun yerine giriş konumunun 
        döndürüleceğini unutmayın.

        Çarpıştırıcı yalnızca BoxCollider, SphereCollider, CapsuleCollider veya bir dışbükey MeshCollider olabilir.



        Vector3 enYakinNokta=   Physics.ClosestPoint(transform.position, m_Collider, transform.position, Quaternion.identity);

        Debug.Log(enYakinNokta);

        YANİ belirlediğin nitelikler sonucunda EN YAKIN NOKTAYI bulabilmemizi sağlar.

        */

        #endregion


        #region 14 ) Physics.clothGravity

        /*

        Kumaş Yerçekimi ayarı. Tüm kumaş bileşenleri için yerçekimini ayarlayar.

        Debug.Log(Physics.clothGravity);

        Projede HAM ( DEFAULT ) HALİYLE  Kumaş yerçekimi ayarı ( 0, -9.8, 0 ) ' mış ! ! !

        */
        #endregion


        #region 15 ) Physics.ComputePenetration ( ) **

        /*

        Verilen çarpıştırıcıları belirtilen pozlarda birbirinden ayırmak için gereken minimum çeviriyi hesaplayın.

        İlk çarpıştırıcıyı yön * mesafeye göre çevirmek, işlev doğru döndürülürse çarpıştırıcıları birbirinden ayırır. 
        Aksi takdirde yön ve mesafe tanımlanmaz.

        Çarpıştırıcılardan biri BoxCollider, SphereCollider CapsuleCollider veya bir dışbükey MeshCollider olmalıdır. Diğeri 
        HERHANGİ     bir tip olabilir.

        Çağrı anında çarpıştırıcıların sahip olduğu konum ve dönüşle sınırlı olmadığınızı unutmayın. Halihazırda ayarlanandan
        farklı geçiş pozisyonu veya dönüşü, herhangi bir çarpıştırıcıyı fiziksel olarak hareket ettirme etkisine sahip değildir, 
        dolayısıyla Sahne üzerinde hiçbir yan etkisi yoktur.

        İlk olarak güncellenecek herhangi bir uzamsal yapıya bağlı değildir, bu nedenle yalnızca FixedUpdate zaman çerçevesi içinde
        kullanılması zorunlu değildir. Arka yüzlü üçgenleri yok sayar ve Physics.queriesHitBackfaces'e uymaz.

        Bu işlev, ÖZEL NÜFUZ ETME İŞLEVLERİ yazmak için kullanışlıdır. Belirli bir örnek, çevreleyen fizik nesneleri ile 
        çarpışmaya karşı belirli bir tepkinin gerekli olduğu bir karakter denetleyicisinin uygulanmasıdır. Bu durumda, kişi önce 
        OverlapSphere kullanarak yakındaki çarpıştırıcıları sorgular ve ardından ComputePenetration tarafından döndürülen verileri 
        kullanarak karakterin konumunu ayarlar.


        colliderA : İlk çarpıştırıcı
        positionA : ilk çarpıştırıcının konumu
        rotationA : ilk çarpıştırıcının dönüşü
        colliderB : İkinci çarpıştırıcı
        positionB : İkinci çarpıştırıcının konumu
        rotationB : İkinci çarpıştırıcının dönüşü
        direction : Çarpıştırıcıları birbirinden ayırmak için çevirinin yönü minimumdur.
        distance  : Çarpıştırıcıları birbirinden ayırmak için gerekli olan yön boyunca olan mesafe 

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

        YANİİİİİİİİİİİİİİİİ :

             BİZ BURDA DİRECTİON (VECTOR3) VE DİSTANCE (FLOAT  )'a bir değer GİRMEDİK ÇÜNKÜ asıl amacımız asıl öğrenmemiz gereken
             şey şu : 2 OBJENİN COLLİDER 'I  birbirine girdiğinde BUNU YAKALAYABİLMEMİZİ SAĞLAR VE GEREKLİ İSTEDİĞİN İŞLEMİ 
             YAPABİLMENİ SAĞLAR. Örneğin 2 obje birbirine girdiğinde Effect patlasın, veya 2 obje birbirine girdiğinde
             bu içe içe giren objeler ateş edilmeye başlansın gibi .......  


        if (IsPenetrating)
        {
            Debug.Log("Evet iç içe girdiler.");

            gameObject.transform.position = anlayisObject.transform.position;
        }

        else
        {
            Debug.Log("Hayır içe içe DEĞİLLER.");
        }


        */
        #endregion


        #region  16 ) Physics.defaultContactOffset

        /*

        Debug.Log(Physics.defaultContactOffset); 
            HAM ( DEFAULT ) haliyle Collider'ların ( Çarpıştırıcıların ) VARSAYILAN TEMAS ÖTELEMESİ 0.01f Değerindeymiş ! ! !


        Physics.defaultContactOffset = temasOteleme; // defaultContactOffset temas otelemeye eşit olsun demiş olduk.
        if (temasOteleme >= 1f)
        {
            Debug.Log("Temas etmeye 1 mesafe kaldı.");
        }
        else
        {
            Debug.Log("Hayır değil.");
        }


         YANİİİİİİİİ 2 collider Birbirlerine temas etmesi gerekirken TAM OLARAK TEMAS ETMİYORSA  defaultContactOffset değerini
         DAHADA KÜÇÜLTEREK SORUNU ÇÖZMEMİZİ SAĞLAYAN BİR ÖZELLİKTİR ! ! ! ! ! ! ! ! ! ! ! !

        */


        #endregion


        #region 17 ) Physics.defaultMaxAngularSpeed


        /*

        Dinamik bir Rigidbody 'nin radyan cinsinden varsayılan MAKSİMUM AÇISAL HIZI ( )

        Radyan cinsinden ölçülen dinamik Rigidbody 'nin maksimum açısal hızını kontrol eder. Açısal hız sınırı her bir katı gövde
        temelinde Rigidbody.maxAngularVelocity ile de değiştirilebilir.


        Debug.Log(Physics.defaultMaxAngularSpeed);

           Projede Edit => Project Settings => defaultMaxAngularSpeed ' de gördüğün gibi  Rigidbody 'nin HAM ( DEFAULT ) 
           MAKSİMUM  AÇISAL HIZI 7 ' miş.



        YANİİİİİİİİİ sen bu  Rigidbody 'nin MAKSİMUM AÇISAL HIZ ' ı projende kullanacağın zaman bu değeri ister default haliyle
        ister projendeki algoritmaya  göre  kendin bir değer atayabilirsin ! ! ! !  ! !

        */
        #endregion


        #region 18 ) Physics.defaultMaxDepenetrationVelocity ** Physics.ComputePenetration ile bağlantılı DİKKAT ET 

        /*

        Bir sert cismin çarpıştırıcısını başka bir çarpıştırıcının yüzey PENETRASYONUNDAN çıkarmak için makismum varsayılan HIZ !
        Bu değer genellikle Scriptler yerine Edit=>Project Settings => Physics penceresinden değiştirilir.

        Çok büyük değerler, çarpışma algılaması sırasında kararsızlığa neden olabilir; çok küçük değerler çarpıştırıcının nüfuz
        etmesinin başarısız olmasına neden olabilir.

        Ayrıca Rigidbody.maxDepenetrationVelocity aracılığıyla ayrı Rigidbodies için maksimum bir depenetrasyon hızı ayarlayabilirsiniz.



        Debug.Log(Physics.defaultMaxDepenetrationVelocity);

         HAM ( DEFAULT ) haliyle  değeri 10 ' muş biz bunu oyunaki algoritmaya göre  hem Edit Physics sekmesinden hem de BURDAN
         DEĞİŞTİREBİLİRİZ ! ! ! ! ! 


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

        Varsayılan raycast katmanlarını seçmek için KATMAN MASKESİ SABİTİ.

        Bu, Physics.Raycast'in katman maskesi alanında ve varsayılan raycast katmanlarını seçmek için diğer yöntemlerde 
        kullanılabilir. Varsayılan katmanlar, yoksayılan raycast katmanı dışındaki tüm katmanlardır.

        Debug.Log(Physics.DefaultRaycastLayers);

        Ham ( Default ) haliyle -5 ' miş.

        */

        #endregion


        #region 21 ) Physics.defaultSolverIterations Rigidbody.solverIterations ' la bağlantılı


        /*
         Rigidbody.solverIterations bağlantılı çünkü burda bu değeri değiştirebiliriz.

         Rigidbody ' lerin çarpışmalardaki çözücü yineleme sayısıdır . Yani bu değeri artırmak Rigidbody  'nin ÇARPIŞMADA
         daha KARARLI OLMASINI SAĞLAR.

        Debug.Log(Physics.defaultSolverIterations); // VARSAYILAN  çözücü yineleme sayisi 6 ymış.)

        Ama burda VARSAYILAN ÇÖZÜCÜ YİNELEME sayısını kullanmış oluruz.
        Bu  varsayılan 6 değerini Edit => Project Setting=> Physics sekmesindende  değiştrebiliriz.

        YANİİİİİİİİİİİİİİİİİİİ EĞER varsayılan çözücü yineleme sayısı  ( YANİ defaultSolverIterations ) Oyunda ÇARPIŞMALARDA
        sorun yaşıyor ve KARARSIZ davranış VARSA Rigidbody.solverIterations 'u KULLAN  ! ! !


           */

        #endregion


        #region 22 ) Physics.defaultSolverVelocityIterations

        /*

        defaultSolverVelocityIterations : Çözücü hız yinelemeleri

        HAM ( DEFAULT ) haliyle çözücü hız yinelemesi sayısı 1 ' miş. Bunu scriptten değiştirebiliriz  Unity 'de Edit =>
        Physics sekmesinden de değiştirebiliriz.

        EğeR MEVCUT bir Rigidbody 'lerin HIZLI HAREKET etmesiyle ilgili bir sorun yaşarsan Rigidbody.solverVelocityIterions 'u
        KULLANMAK ZORUNDASIN ! ! !


        Debug.Log( Physics.defaultSolverVelocityIterations );

        */

        #endregion


        #region 23 ) Physics.GetIgnoreCollision ( )

        /*

        Get Ignore collision : ÇARPIŞMAYI GÖRMEZDEN GELMEK.

        Çarpışma algılama sisteminin çarpıştırıcı1 ( collider1 ) ve çarpıştırıcı2 ( collider2 )arasındaki tüm 
        çarpışmaları/tetikleyicileri görmezden gelip gelmeyeceğini kontrol eder.

        bool carpismayiGormezdenGeliyimMi = Physics.GetIgnoreCollision(m_Dusunce, Denemem);

        if (carpismayiGormezdenGeliyimMi)
        {
            Debug.Log("çarpışmayı görmezden geldim.");
        }
        else
        {
            Debug.Log("Çarpışmayı görmezden GELMEDİM.");
        }


         YANİiiii EĞER 2 ÇARPIŞTIRICI ( COLLİDER )  UNİTY 'NİN  ÇARPIŞMA MANTIĞINA UYGUN OLUYORSA  FALSE YANİ 2 COLLİDER BİRBİRiYLE
         ÇARPIŞABİLİR ANLAMINA GELİR!!!!!!!!!

         işte biz bu MANTIĞI sorgularız aslında.

        */

        #endregion


        #region 24 ) Physics.GetIgnoreLayerCollision ( )

        /*

        Get Ignore Layer Collision : KATMAN ÇARPIŞMASINI YOK SAYMAK

        YANİİİİİİİ belirttiğim katmanların UNİTY 'NİN ÇARPIŞMA MANTIĞIN uygun oluyorsa FALSE YANİ 2 katmana sahip obhe birbirleriyle
        ÇARPIŞABİLİR ANLAMINA GELİR !!!!!!!!!!


        Debug.Log( Physics.GetIgnoreLayerCollision(1, 2));

        */

        #endregion


        #region 25 ) Physics.gravity

        /*

        Sahnedeki TÜM KATI CİSİMLERE UYGULANAN YERÇEKİMİDİR.

        sahnedekiTumRigidbodylereUygulananYerCekimiDegeri = new Vector3(0f, -200f, 0f);

        sahnedekiTumRigidbodylereUygulananYerCekimiDegeri = new Vector3(0f, -5f, 0f);

        sahnedekiTumRigidbodylereUygulananYerCekimiDegeri = new Vector3(0f, -1f, 0f);

        Physics.gravity = sahnedekiTumRigidbodylereUygulananYerCekimiDegeri;


        */
        #endregion


        #region 26 ) Physics.IgnoreCollision() **

        /*

         collider1 : Herhangi bir çarpıştırıcı
         collider2 : Çarpışmaları yok sayamyı başlatmak için veya durdurmak için sahip olmak istediğiniz başka bir çarpıştırıcı.
         ignore    : İki çarpıştırıcı arasındaki çarpışmaların göz ardı edilip edilmeyeceği.

        Çarpışma algılama sisteminin çarpıştırıcı1 ve çarpıştırıcı2 arasındaki tüm çarpışmaları YOK SAYAR.

        Bu ÖRNEĞİN mermilerin , mermiyi ateşleyen NESNEYLE ( insanda olabilir hayvanda )  çarpışmasını önlemek için YARARLIDIR.

        IgnoreCollision ( ) 'ın KALICI DEĞİLDİR. Bu bir sahneyi kaydederken çarpışmayı yok sayma durumunun düzenleyecide 
        SAKLANMAYACAĞI anlamına gelir.

        Eger ignore FALSE 'sa ÇARPIŞMALAR MEYDANA GELEBİLİR. Çarpışmaları YOK SAYMAK İÇİN ignore = true OLMALIDIR ! ! ! ! ! ! 



        Physics.IgnoreCollision(m_Dusunce, m_Anlayis, true);

        Oyunu çalıştırdığında gördüğün gibi dusunce objesi ve anlayis objesi birbirlerinini içinden geçiyor yani çarpışma durumlarını
        GÖZ ARDI ETMİŞ OLDUK ! ! ! ! ! ! 1

        */

        #endregion


        #region 27 ) Physics.IgnoreLayerCollision ( ) **

        /*

        Physics.IgnoreLayerCollision(1, 2,true);

         Physics.IgnoreCollision ( ) 'la aynı mantığa sahip. 
         Yani burdada 1 ve 2 katmanlara sahip objeler arasında ÇARPIŞMALAR GÖZ ARDI EDİLİYOR ! ! ! ! ! !

        */
        #endregion


        #region 28 ) Physics.IgnoreRaycastLayer

        /*

        Ignore Raycast Layer : Raycast katmanını yok sayar.

        Raycast katmanını yok saymak için katman maskesi sabiti. ( 4 müş )

        Bu, Physics.Raycast'in katman maskesi alanında ve "raycast'leri yoksay" katmanını seçmek için diğer yöntemlerde 
        kullanılabilir (varsayılan olarak raycast'leri almaz).


        Debug.Log(Physics.IgnoreRaycastLayer);


        */

        #endregion


        #region 29 ) Physics.interCollisionDistance 

        /*

          inter Collision Distance : ÇARPIŞMA MESAFESİ

          KUMAŞ çarpışması için minimum ayırma mesafesini ayarlar.

          Bu mesafeden daha yakın olan farklı Cloth nesnelerine ait kumaş parçacıkları AYRILACAKTIR.


        Physics.interCollisionDistance; 

        Bunu eğer oyunlarda KUMAŞLARIN ( BAYRAKLARIN ) varsa o zaman kullanacaksın ! ! !


        */
        #endregion


        #region 30 ) interCollisionSettingsToggle

        /*

        inter collision settings Toggle : Çarpışma ayarları arasında geçiş yap.



        bool carpismaAyarlariArasindaGecisVarmi=   Physics.interCollisionSettingsToggle;

        Debug.Log(carpismaAyarlariArasindaGecisVarmi);

             Proje HAM ( DEFAULT ) haliyle false döndü yani ÇARPIŞMA AYARLARI ARASINDA GEÇİŞ YAPAMAYIZ.

        */
        #endregion


        #region 31 ) Physics.interCollisionStiffness

        /*

        Kumaşın çarpışmalar arası SERTLİĞİNİ ayarlar.

        Çarpışmalar arası SERTLİK, çarpışmalar arası mesafeden ( interCollisionDistance ) daha yakın olduklarında iki parçacığın 
        birbirini ne kadar ittiğini kontrol eder.


        float KumasinCarpismalarArasiSertligi = Physics.interCollisionStiffness;
        Debug.Log(KumasinCarpismalarArasiSertligi);

         Projede HAM ( DEFAULT ) haliyle kumaşın çarpışma arası SERTLİĞİ 0 'mış.Biz bu değeri kendimizde belirleyebiliriz ! ! !

        */

        #endregion


        #region 32 ) Physics.Linecast ( )

        /*

        start : Baslangıç noktası
        end   : Bitiş noktası
        layerMask : Çarpıştırıcıları seçici olarak yok saymak için kullanılan bir katman maskesi.
        queryTriggerInteraction : Bu sorgunun tetikleyicileri vurup vurmayacağını belirtir.


        hitInfo :  True döndürülürse hitInfo çarpıştırıcının ( Collider'ın ) vurulduğu yer hakkında daha  FAZLA BİLGİ VERİR !  

        Başlangıç ve Bitiş arasındaki çizgiyi KESEN herhangi bir çarpıştırıcı varsa TRUE döner.


        *******************************************************************

        RaycastHit hit;

        bool kesenNoktaDeneme1 = Physics.Linecast(m_Dusunce.transform.position, m_Anlayis.transform.position);
        bool kesenNoktaDeneme2 = Physics.Linecast(m_Anlayis.transform.position, m_Dusunce.transform.position, out hit);

        if (kesenNoktaDeneme1)
        {

            Debug.Log("Seni ortadan kaldırdım.");
            Debug.Log(hit.transform.name) ;
            hit.transform.position = new Vector3(1f, 1f, 10f); 


            YANİİİİİİİİ Gördüğün gibi 2 obje arasındaki değen OBJEYİ YAKALAYIP bu objeye bir işlem yapabiliyorum.Örneğin konumu
            değiştirmek gibi. Mesela bu objeye bir efect te verebilirdim ! ! !


        }

        else
        {
            Debug.Log("Kaldıramadım.");
        }

        private void OnDrawGizmos() // Update Metodunun DIŞINA YAZ.
        {
            Gizmos.color = Color.white;
            Gizmos.DrawLine(m_Dusunce.transform.position, m_Anlayis.transform.position);
        }

        */
        #endregion


        #region 33 ) Physics.OverlapBox ( ) **

        /*

         overlap Box : Örtüşen kutu

        center      : Kutunun merkezi
        halfExtents : Her boyutta kutunun yarısı
        orientation : Kutunun dönüşü
        layerMask   : Bir ışın yayınlarken çarpıştırıcıları seçici olarak yok saymak için kullanılan bir Katman Maskesi.
        queryTriggerInteraction : Bu sorgunun Tetikleyicileri vurup vurmayacağını belirtir.

        Verilen kutuya DOKUNAN  ÇARPIŞTIRICILARI veya  KUTUNUN içindeki TÜM ÇARPIŞTIRICILARI BULUR..

        Kutuyla temas eden tüm çarpıştırıcıların çıktısını alarak çarpışmaları test eden, tanımladığınız görünmez bir kutu oluşturur.

        **********************************************************************

        Collider[] TemasEdenColliderlar= Physics.OverlapBox(gameObject.transform.position, transform.localScale, transform.rotation);
        int i = 0;
        while (i< TemasEdenColliderlar.Length)
        {
            Debug.Log("Değen obje : " + TemasEdenColliderlar[i].name + i);
            i++;
        }

        */

        #endregion


        #region 34 ) Physics.OverlapBoxNonAlloc ( )

        /*

         Overlap Box  Non Alloc : ÖRTÜŞME KUTUSU TAHSİS EDİLMEYEN.

        center      : Kutunun merkezi
        halfExtents : Her boyutta kutunun boyutunun yarısı
        results     : Sonuçların depolanacağı ARABELLEK. ( İçinde depolanan çarpıştırıcıların miktarı )
        orientation : Kutunun dönüşü
        layerMask   : Bir ışın yayınlarken çarpıştırıcıları seçici olarak yok saymak için kullanılan bir Katman Maskesi.
        queryTriggerInteraction : Bu sorgunun Tetikleyicileri vurup vurmayacağını belirtir.

        Verilen kutuya DOKUNAN ÇARPIŞTIRICILARI VEYA KUTUNUN İÇİNDEKİ tüm çarpıştırıcıları bulur ve bunları ARABELLEKTE saklar.



        int miktar=  Physics.OverlapBoxNonAlloc(transform.position, transform.localScale, colliderLarinDizisi, transform.rotation);
        Debug.Log(miktar);

                */
        #endregion


        #region 35 ) Physics.OverlapCapsule ( ) **


        /*
          
        point0 : Kapsülün başlangıcındaki kürenin merkezi.
        point1 : Kapsülün sonundaki kürenin merkezi.
        radius : Kapsülün yarıçapı.
        layerMask : Bir kapsülü oluştururken çarpıştırıcıları seçici olarak yok saymak için kullanılan bir Katman Maskesi.
        queryTriggerInteraction : Bu sorgunun tetikleyicileri vurup vurmayacağını belirtir.

         Verilen KAPSÜLE DOKUNAN  ÇARPIŞTIRICILARI veya  KAPSÜLÜN içindeki TÜM ÇARPIŞTIRICILARI BULUR.

        
         ****************************************************************************************
         *
        Debug.Log(m_Capsule.transform.position);
        p1=m_Capsule.transform.position + m_Capsule.bounds.size.y * Vector3.up * -0.75f;
        p2 = p1 + m_Capsule.bounds.size.y * Vector3.up * 0.5f;

        colliderLarinDizisi =  Physics.OverlapCapsule(p1, p2, 0.5f);
        int i = 0;

        while (i<colliderLarinDizisi.Length)
        {
            Debug.Log("Değen objenin Collider 'ı  : " + colliderLarinDizisi[i].name);
            i++;
        }

         ÇOK ÖNEMLİ ! ! ! ! ! !  
         TAM İSTEDİĞİN GİBİ ÇALIŞTI TAM DEFTERDEKİ SAYFANDA BU MANTIĞI  nasıl oluşturduğununun RESMİ VE ANLATIMI VAR.
         ÜSTTEKİ  Physics.CheckCapsule ( ) metodunuda bu mantıktan yaz ! ! ! 


        */
        #endregion


        #region 36 )  Physics.OverlapCapsuleNonAlloc ( ) ve OverlapSphereNonAlloc () 

        /*
         
         Bu iki metodun mantığı Physics.OverlapBoxNonAlloc () Metodunun mantığıyla aynıdır. 
         Bu yüzden   Physics.OverlapBoxNonAlloc () metodunun mantığını referans alarak bu 2 metotları anlar  ve  gerekli 
         olduğu durumlarda anlar ve kullanırsın.......

        */

        #endregion


        #region 37 ) Physics.OverlapSphere ( ) **

        /*

        position  : Kürenin merkezi
        radius    : Kürenin yarıçapı.
        layerMask : Sorguya hangi çarpıştırıcı katmanların ekleneceğini tanımlar.
        queryTriggerInteraction : Bu sorgunun tetikleyicileri vurup vurmayacağını belirtir.

        KÜREYE TEMAS eden veya kürenin kendi içindeki çarpıştırıcıları hesaplar ve  çarpıştırıcı dizesinde saklar..

        

        colliderLarinDizisi =   Physics.OverlapSphere(m_Sphere.transform.position, 0.5f);
        int i = 0;

        while (i<colliderLarinDizisi.Length)
        {
            Debug.Log("Değen Carpıştırıcı Yani Collider : " + colliderLarinDizisi[i].name);
            i++;
        }

        */

        #endregion


        #region 38 ) Physics.queriesHitBackfaces

        /*
         
        Fizik sorgularının arka yüz üçgenlerine çarpması gerekip gerekmediği.

        Varsayılan olarak, ışın yayını veya şekil taraması (örn. SphereCastAll) gibi tüm fizik sorguları, arka yüz üçgenleri olan 
        isabetleri algılamaz.

        VARSAYILAN OLARAK Edit => Physics Sekmesindede bu FALSE 'tur.ÇÜNKÜ BUNA GEREK YOK.
       
        
        bool arkaYuzUcgenlereCarpsinMi = Physics.queriesHitBackfaces;
        Debug.Log(arkaYuzUcgenlereCarpsinMi);
        
        FALSE DÖNDÜ.Hem Edit=>Physics sekmesinde hem kodda false değerini aldık.

        */

        #endregion


        #region  39 ) Physics.queriesHitTriggers

        /*
        
         Sorguların (raycast'ler, küre ışını atmalar, örtüşme testleri vb.) varsayılan olarak Tetikleyicilere ulaşıp ulaşmadığını
         belirtir.
 
        Bu, QueryTriggerInteraction parametresi belirtilerek sorgu başına düzeyinde geçersiz kılınabilir. YANİ SORGUYA ÖZEL
        FALSE YAPILABİLİR.

        YANİİİ Edit=> Project Settings => Physic sekmesinde  varsayılan olarak  TRUE 'dur.ÇÜNKÜ  O Raycast'lerle SphereCast, 
        BoxCast, OverlapTest gibi sorgular yaptığımız  Fizik sistemimizin TETİKLEYİCİLERE İHTİYACI VAR O YÜZDEN
        TRUE OLARAK KALMALIDIR ! ! ! ! ! ! !

        Debug.Log(Physics.queriesHitTriggers);

        */

        #endregion


        #region 40 ) Physics.Raycast ( ) **

        /*
         
        origin      : Işının dünya koordinatlarında başlangıç noktası
        direction   : Işının yönü
        hitInfo     : True döndürülürse hitInfo en yakın ÇARPIŞTIRICININ ( Collider'ın ) nerede çarpıldığı hakkında daha FAZLA 
                      verir ! 
        maxDistance : Işının çarpışmalar için kontrol etmesi gereken maksimum mesafe
        layerMask   : Bir ışını yayınlarken çarpıştırıcıları seçici olarak yok saymak için kullanılan bir katman maskesi.
        queryTriggerInteraction : Bu sorgunun tetikleyicieri vurup vurmayacağını belirtir.

       bool :  Işın bir Çarpıştırıcı ( Collider ) ile kesişiyorsa TRUE, aksi takdirde FALSE döner.

       Sahnedeki tüm çarpıştırıcılara  belirlediğin NOKTADAN belirlediğin YÖNDE ve belirttiğin UZAKLIKTA bir IŞIN göndermeni sağlar.

       Çarpışma olmasını istemediğin durumlarda Çarpıştırıcıları  FİLTRELEMEK için LayerMask 'ı kullan.

       Raycast'ler Raycast kaynağının çarpıştırıcının içinde olduğu çarpıştırıcıları algılamaz. 
       Diğer BoxCast(),SphereCast ()  gibi metotlarda kaynağın içindeki çarpıştırıları algılanır.

        
     **************************************************************************************************************

     isinGittiMi =   Physics.Raycast(gameObject.transform.position, transform.forward,  out hit,200f);

        if (isinGittiMi)
        {
            Debug.Log(hit.transform.gameObject.name);
        }


        private void OnDrawGizmos() // Update Metodunun dışına yaz.
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


        #region 41 ) Physics.RaycastAll ( )

        /*
         
        ray         : Işının başlangıç noktası ve yönü
        maxDistance : Ray vuruşunun ray'ın başlangıcından itibaren olmasına izin verilen maksimum MESAFE.
        layerMask   : Bir ışını yayınlarken çarpıştırıcıları seçici olarak yok saymak için kullanılan bir  Katman Maskesi
        queryTriggerInteraction : Bu sorgunun tetikleyicileri vurup vurmayacağın belirtir.


        origin      : Işının dünya koordinatlarında başlangıç noktası
        direction   : Işının yönü
        hitInfo     : True döndürülürse hitInfo en yakın ÇARPIŞTIRICININ ( Collider'ın ) nerede çarpıldığı hakkında daha FAZLA 
                      verir ! 
        maxDistance : Işının çarpışmalar için kontrol etmesi gereken maksimum mesafe.


        Sahne boyunca bir IŞIN GÖNDERİR ve TÜM İSABET EDEN IŞINLARI yakalar. Sonuçların sırasının tanımsız olduğuna dikkat edin.


        **********************************************************************************************************
        
        RaycastHit[] hitDizisi;
        hitDizisi = Physics.RaycastAll(gameObject.transform.position, transform.forward, 200f);

        for (int i = 0; i < hitDizisi.Length; i++)
        {
            Debug.Log(hitDizisi[i].transform.name);
            if (hitDizisi[i].transform.name == "Capsule")
            {
                m_Capsule.gameObject.transform.GetComponent<Rigidbody>().velocity = transform.forward;
            }
            i++;
        }

        */
        #endregion


        #region 42 ) Physics.RaycastNonAlloc ( ) Tam anlamadın.

        /*

         result : İsabet eden ışınların depolanacağı ARABELLEK.


         Raycast sorgusu daha fazla isabet olmadığında ve/veya sonuç arabelleği dolduğunda sona erer. Sonuçların sırası tanımsızdır.
         Tam bir arabellek döndürüldüğünde sonuçların en yakın isabetler olduğu garanti edilmez ve arabelleğin uzunluğu döndürülür.
         Boş bir arabellek geçirilirse , hiçbir sonuç döndürülmez ve hiçbir hata veya istisna atılmaz.


         Physics.RaycastNonAlloc  .................

         */

        #endregion


        #region 43 ) Physics.RebuildBroadphaseRegions ( ) Tam anlamadın

        /*
         
          worldBounds  : Fizik dünyasının sınırları
          subdivisions : x,y ve z ekseni boyunca oluşturulacak HÜCRE SAYISI.

        
        Geniş fazlı ilgi bölgelerini yeniden oluşturun ve dünya sınırlarını belirleyin.

        Yalnızca Çoklu Kutu Budama Geniş Aşaması kullanıldığında etkilidir.

        Bu modda, DÜNYANIN SINIRLARI belirlenmelidir ve ardından fizik motoru, hacmi XZ düzleminde düz bir ızgaraya böler ve her
        hücre hücreye ait bir dizi nesne içerir. Her hücrenin normal süpür ve budama geniş fazının bir örneğini içerdiği 
        düşünülebilir. Bir ızgaraya sahip olmanın ana yararı, düz bir dünyada tüm nesnelerin Y ekseni boyunca birbiriyle örtüştüğü 
        ve böylece her eksen boyunca SAP projeksiyon listelerinin aşırı yeniden oluşturulmasına neden olduğu tipik süpür ve budama
        yerellik probleminden kaçınabilmektir. uzaktaki nesneler için.

        Dünya sınırlarının dışında bulunan fizik nesnelerinin çarpışmaları hiç ALGILAMAYACAĞINI unutmayın.

        Şu anda dünya hücrelerinin toplam miktarında 256'lık bir sınır vardır, bu nedenle alt bölümlere ayarlayabileceğiniz 
        maksimum sayı 16'dır.

        Bu işlev, geniş faz ayarlarını proje başına değil, sahne başına yapmak için kullanışlıdır.

        */



        #endregion


        #region 44 ) Physics.reuseCollisionCallbacks

        /*
        reuse Collision Call backs : Çarpışma geri aramaların yeniden kullan. 

        Çöp toplayıcının tüm çarpışma geri aramaları için yalnızca bir Çarpışma türünün TEK BİR örneğini YENİDEN kullanması gerekip 
        gerekmediğini belirler.

        Bir MonoBehaviour.OnCollisionEnter, MonoBehaviour.OnCollisionStay veya MonoBehaviour.OnCollisionExit çarpışma geri araması
        gerçekleştiğinde, kendisine geçirilen Collision nesnesi her bir geri arama için oluşturulur. Bu, çöp toplayıcının her
        nesneyi kaldırması gerektiği anlamına gelir ve bu da performansı düşürür.

        Bu seçenek DOĞRU olduğunda, her bir geri arama için Çarpışma türünün yalnızca tek bir örneği oluşturulur ve yeniden 
        kullanılır. Bu, çöp toplayıcının işlemesi için israfı azaltır ve performansı artırır.

        Bu seçeneği yalnızca, Çarpışma nesnesine daha sonra işlenmek üzere çarpışma geri çağrısının dışında başvuruluyorsa false
        olarak ayarlarsınız, bu nedenle Çarpışma nesnesinin geri dönüştürülmesi gerekmez.


            Edit => Project Settigs => Physics ' de VARSAYILAN OLARAK TRUE seçilmiş.
        
       Debug.Log( Physics.reuseCollisionCallbacks);


        */
        #endregion


        #region 45 ) Physics.Simulate ( ) Tam anlamadın

        /*
         
        step : Diziği ilerletme ZAMANI

        Otomatik simülasyon kapatıldığında fiziği manuel olarak simüle etmek için bunu arayın. Simülasyon, çarpışma tespiti,
        katı cisim ve eklem entegrasyonu ve fizik geri aramalarının (temas, tetik ve eklemler) dosyalanmasının tüm aşamalarını
        içerir. Physics.Simulate'in çağrılması, FixedUpdate'in çağrılmasına neden olmaz. MonoBehaviour.FixedUpdate , otomatik
        simülasyonun açık veya kapalı olmasına bakılmaksızın ve Physics.Simulate'i ne zaman çağırdığınızdan bağımsız olarak
        Time.fixedDeltaTime tarafından tanımlanan hızda çağrılacaktır.

        Fizik motoruna kare hızına bağlı adım değerleri ( Time.deltaTime gibi ) iletirseniz, ortaya çıkabilecek kare hızında
        öngörülemeyen dalgalanmalar nedeniyle simülasyonunuzun deterministik olmayacağını unutmayın.

        Deterministik fizik sonuçları elde etmek için, her çağırdığınızda Physics.Simulate'e sabit bir adım değeri iletmelisiniz. 
        Genellikle, step KÜÇÜK bir POZİTİF sayı olmalıdır.  step 0,03'ten büyük değerlerin kullanılması yanlış sonuçlar doğurabilir.

        Physics.Simulate(0.03f);

        */
        #endregion


        #region 46 ) Physics.sleepThreshold == Rigidbody.sleepThreshold

        /*
         
        sleep Threshold : Uyku Eşiği 

        Altında nesnelerin uyumaya başladığı kütleye göre normalleştirilmiş enerji eşiği 

        
        Debug.Log(Physics.sleepThreshold);

         Edit => Project Settings =>  Physics sekmesinde Unity tarafından sleepThreshold 0.005 olarak ayarlanmış.
         Ancak hem kod tarafında hem Physics penceresinde bu değeri İSTERSEN DEĞİŞTİREBİLİRSİN ! ! !

        */

        #endregion


        #region 47 ) Physics.SphereCast ( ) **

        /*
        origin      : Süpürmenin başlangıcındaki kürenin merkezi
        radius      : Kürenin yarıçapı.
        direction   : Kürenin süpürüleceği yön
        hitInfo     : True dönerse çarpıştırıcının vurulduğu yer hakkında DAHA FAZLA BİLGİYE sahip oluruz.
        maxDistance : Dökümün maksimum uzunluğu
        layerMask   : Bir kapsül oluştururken çarpıştırıcıları seçici olarak yok saymak için kullanılan bir Katman maskesidir.
        queryTriggerInteraction : Bu sorgunun tetikleyicileri vurup vurmayacağını belirtir.

        ray         : Küre taramasının yapıldığı ışının başlangıç noktası ve  yönü.


        Bir ışın boyunca bir KÜRE  atar ve neyin ÇARPTIĞI hakkında ayrıntılı bilgi verir.

        Bu, bir Raycast yeterli hassasiyet vermediğinde kullanışlıdır, çünkü bir karakter gibi belirli bir boyuttaki bir nesnenin 
        yolda herhangi bir şeyle çarpışmadan bir yere hareket edip edemeyeceğini öğrenmek istersiniz. Küreyi KALIN bir IŞIN dökümü 
        gibi düşünün. Bu durumda ışın, bir başlangıç ​​vektörü ve bir yön ile belirtilir.

        Notlar: SphereCast, kürenin çarpıştırıcıyla çakıştığı çarpıştırıcıları algılamaz. Sıfır yarıçapı geçmek, tanımsız çıktıyla 
        sonuçlanır ve her zaman Physics.Raycast ile aynı şekilde davranmaz .
        
         ***************************************************************************************************************

        

        kureIsiniGittiMi = Physics.SphereCast(m_Sphere.transform.position, 0.5f, transform.forward, out hit, 200f);

        if (kureIsiniGittiMi)
        {
            Debug.Log("Temas Eden obje : " + hit.transform.name);
            hit.transform.GetComponent<Rigidbody>().AddForce(0f, 10f*Time.deltaTime, 0f, ForceMode.Impulse);
        }

      ÇOK ÖNEMLİ  NOT : EĞER HİÇBİR ÇARPIŞTIRICIYA ( COLLİDER'A ) ÇARPMAZSA KENDİ COLLİDER 'INA ÇARPIŞ OLARAK KABUL EDİYOR ! ! ! 
                        SEN BUNU İSTEMEZSEN EĞER OBJENİN KENDİ COLLİDER 'INI PASİF HALE GETİREBİLİRSİN ! ! ! !  ! ! !

        ***************************************************************************************************************
        
          private void OnDrawGizmos() // UPDATE METODUNUN DIŞINA YAZ.
    {

        Gizmos.color = Color.white;

        //Gizmos.DrawSphere(m_Sphere.bounds.center, 0.5f);

        if (kureIsiniGittiMi)
        {
            Gizmos.DrawLine(m_Sphere.transform.position, hit.transform.position);
            Gizmos.DrawWireSphere(hit.transform.position  ,0.5f);
            
        }

        else
        {
            Gizmos.DrawLine(m_Sphere.transform.position, Vector3.forward * 200f);
            Gizmos.DrawWireSphere(m_Sphere.transform.position  + m_Sphere.transform.forward * 200f,0.5f);
        }
    }

        */

        #endregion


        #region 48 ) Physics.SphereCastAll ( )

        /*
         
        Physics.SphereCast gibi, ancak bu işlev KÜRE TARAMASININ kesiştiği tüm İSABETLERİ döndürür.

        Sahnedeki tüm çarpıştırıcılara bir küre atar ve vurulan her çarpıştırıcı hakkında ayrıntılı bilgi verir. Bu, bir Raycast
        yeterli hassasiyet vermediğinde kullanışlıdır, çünkü bir karakter gibi belirli bir boyuttaki bir nesnenin yolda herhangi 
        bir şeyle çarpışmadan bir yere hareket edip edemeyeceğini öğrenmek istersiniz.

        Notlar: Taramanın başlangıcında küreyle örtüşen çarpıştırıcılar için, RaycastHit.normal, tarama yönünün tersine ayarlanır,
        RaycastHit.distance sıfıra ayarlanır ve sıfır vektörü RaycastHit.point'te döndürülür. Özel sorgunuzda durumun böyle olup
        olmadığını kontrol etmek ve sonucu iyileştirmek için ek sorgular yapmak isteyebilirsiniz. Sıfır yarıçapı geçmek, tanımsız
        çıktıyla sonuçlanır ve her zaman Physics.Raycast ile aynı şekilde davranmaz.


        

        IsinDizesi = Physics.SphereCastAll(m_Sphere.bounds.center, 0.5f, Vector3.forward, 200f);

        foreach (var isinlar in IsinDizesi)
        {
           Debug.Log( isinlar.transform.name);
        }

      *****************  ÇOK ÖNEMLİ  NOT *****************
      
        EĞER HİÇBİR ÇARPIŞTIRICIYA(COLLİDER'A ) ÇARPMAZSA KENDİ COLLİDER 'INA ÇARPIŞ OLARAK KABUL EDİYOR !!!
 
        SEN BUNU İSTEMEZSEN EĞER OBJENİN KENDİ COLLİDER 'INI PASİF HALE GETİREBİLİRSİN ! ! ! !  ! ! !

        */

        #endregion


        #region 49 ) Physics. Physics.SphereCastNonAlloc ( ) TAM ANLAMADIN

        /*

        Yön boyunca küre yayın ve sonuçları arabellekte saklayın.

        Bu, Physics.SphereCastAll'ın bir çeşididir, ancak DİZİYİ SORGUNUN SONUÇLARIYLA ayırmak yerine, sonuçları KULLANICI 
        tarafından SAĞLANAN DİZİDE depolar. Yalnızca arabelleğe sığacak kadar isabet hesaplar ve bunları belirli bir sırayla 
        saklar. Yalnızca en yakın isabetleri depolayacağı garanti edilmez. Çöp üretmez.

        results : Arabellekte depolanan isabet miktarı. ( isabetlerin kaydedileceği ara bellek . )

        */

        #endregion


        #region  50 ) Physics.SyncTransforms

        /*
         
        Dönüşüm değişikliklerini fizik moturuna uygulayın.

        Bir Transform bileşeni değiştiğinde o Transform üzerindeki herhangi bir Rigidbody veya Çarpıştırıcının veya alt öğelerinin
        öğesindeki değişikliğe bağlı olarak yeniden konumlandırılması döndürülmesi veya ölçeklenmesi gerekelebilir. Bu değişiklikleri
        fizik motorunda MANUEL olarak TEMİZLEMEK için bu işlevi kullanın.

        Edit => Project Settings => Physics sekmesinde Auto Sync Transforms  PASİF BİR ŞEKİLDE UNİTY TARAFINDAN AYARLANMIŞTIR.
        
        Physics.SyncTransforms();

        */
        #endregion

    }





}


