using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigidbodyCharacter : MonoBehaviour
{
    public Rigidbody m_Rigidbody;
    public GameObject centerOffMassPoint;

    public float deger;


    //public GameObject AddHelpCharacter;

    public float radius;
    public float power;

    public GameObject o_Anlayis;
    float setDensityYaniKutleDegeri = 30f;


    void Update()
    {


        #region  1 )Rigidbody.AddExplosionForce ve Physics.OverlapSphere () 



        /*

           NEDEN 2 FARKLI SINIFI VE METODU BÝRLÝKTE KULLANDIK ? 
           ÇÜNKÜ ÝKÝSÝNÝ BÝRBÝRÝYLE BAÐLANTILI ! ! ! AÞAÐIDAKÝ KODLARDAN DA BUNU ANLAYABÝLÝRSÝN.





            Vector3 explosionPos = transform.position;
            Vector3 HelpingCharacter = AddHelpCharacter.transform.position;

            Collider[] colliders = Physics.OverlapSphere(HelpingCharacter, radius);

            foreach (Collider hit in colliders)
            {

                //hit.gameObject. GetComponent<MeshRenderer>().enabled = false;
                Rigidbody rb = hit.GetComponent<Rigidbody>();

                if (rb != null )
                    rb.AddExplosionForce(power, HelpingCharacter, radius);

             }

        private void OnDrawGizmos()
        {
            Gizmos.DrawWireSphere(AddHelpCharacter.transform.position, radius);
            Gizmos.color = Color.red;
        }


        */

        #endregion


        #region 2 ) Rigidbody.AddForce ( )

        /*
         
          Rijit cisme bir kuvvet ekler.

          Force : Dünya koordinatlarýndaki KUVVET vektörü
          mode: Kuvvet Türü

          ForceMode.Force: Girdiyi kuvvet(Newton cinsinden ölçülür) olarak yorumlar ve hýzý kuvvet* DT / kütle deðeriyle deðiþtirir.
          Etki, simülasyon adým uzunluðuna ve cismin KÜTLESÝNE BAÐLIDIR.

          ForceMode.Acceleration: Parametreyi ivme olarak yorumlar(metre bölü saniye kare olarak ölçülür) ve hýzý kuvvet* DT deðeriyle deðiþtirir.
          Etki, simülasyon adým uzunluðuna baðlýdýr, ancak cismin kütlesine baðlý DEÐÝLDÝR.

          ForceMode.Impulse: Parametreyi bir darbe(Newton / saniye cinsinden ölçülür) olarak yorumlar ve hýzý kuvvet / kütle deðerine göre deðiþtirir.
          Etki, vücudun kütlesine baðlýdýr ancak simülasyon adým uzunluðuna baðlý DEÐÝLDÝR.

          ForceMode.VelocityChange: Parametreyi doðrudan hýz deðiþikliði(saniyede metre cinsinden ölçülür) olarak yorumlar ve hýzý kuvvet deðeriyle deðiþtirir.
          Etki, vücudun kütlesine veya simülasyon adým uzunluðuna baðlý DEÐÝLDÝR.
        
         Kuvvet yalnýzca aktif bir Sert Gövdeye uygulanabilir.Bir GameObject etkin deðilse, AddForce'un hiçbir etkisi yoktur. Ayrýca, Rigidbody kinematik olamaz.
         Varsayýlan olarak, Rigidbody'nin durumu, kuvvet Vector3.zero olmadýðý sürece, bir kuvvet uygulandýðýnda uyanacak þekilde ayarlanýr.

        

        // Vector3 power = new Vector3(1f, 10f, 1f);

         rg.AddForce(power, ForceMode.Force);
         rg.AddForce(power, ForceMode.Acceleration);
         rg.AddForce(power, ForceMode.Impulse);
         rg.AddForce(power, ForceMode.VelocityChange);

        */


        #endregion


        #region 3 ) Rigidbody.AddForceAtPosition ( )

        /*
         Pozisyonda kuvvet uygular.Sonuç olarak bu nesneye bir TORK VE KUVVET  uygular.

         - Gerçekçi efektler position için yaklaþýk olarak katý cismin yüzeyinin aralýðýnda olmalýdýr.Bu genellikle PATLAMALAR için kullanýlýr. Patlamalarý 
           uygularken kuvvetleri tek bir kare yerine birkaç kareye uygulamak en iyisidir. position Rijit gövdenin merkezinden uzakta olduðunda uygulanan torkun gerçek
           olamayacak kadar  BÜYÜK OLACAÐINI unutmayýn.

        float distance = Vector3.Distance(gameObject.transform.position, helpingObject.transform.position);

        Vector3 m_Force = new Vector3(8f, 0f, 0f);
        rg.AddForceAtPosition(m_Force, gameObject.transform.position);
       
            
         Debug.Log(" Fizik MOTORUNUN konumu :  " + rg.transform.position + " Karakterimin kendi pozisyonu :  " + gameObject.transform.position); 
         Hem FÝZÝK MOTORUNUN hemde karakterin pozisyonu AYNI DEÐERLERDE  ÇIKIYOR.
         
        */

        #endregion


        #region  4 ) Rigidbody.AddRelativeForce ( ) 

        /* Rigidbody 'e sahip objemize KOORDÝNAT SÝSTEMÝNE GÖRE bir kuvvet ekler.

         m_Rigidbody.AddRelativeForce(Vector3.right*deger);
        m_Rigidbody.AddRelativeForce(Vector3.forward * deger);

        YANÝ  Rigidbody ' sahip objeye belirttiðin EKSENDE  bir belirttiðin DEÐERDE bir kuvvet uygular. 
        ( Bu örnekte  KUVVETÝ SADECE 1 KERE UYGULADI . ) 
        
        */

        #endregion


        #region 5 ) Rigidbody.AddTorque ()

        /*
         
        Bu fonksiyonla uygulanan torklarýn etkileri, çaðrý anýnda toplanýr. Fizik sistemi, etkileri bir sonraki simülasyon 
        çalýþtýrmasý sýrasýnda uygular.(Ya FixedUpdate'den sonra ya da komut dosyasý açýkça Physics.Simulate yöntemini çaðýrdýðýnda)
        Bu fonksiyonun farklý modlarý olduðu için, fizik sistemi geçen tork deðerlerini deðil, sadece ortaya çýkan açýsal hýz 
        deðiþimini biriktirir. DeltaTime'ýn (DT) simülasyon adým uzunluðuna ( Time.fixedDeltaTime ) ve kütlenin torkun uygulandýðý
        Sert Cismin kütlesine eþit olduðunu varsayarsak, tüm modlar için açýsal hýz deðiþimi þu þekilde hesaplanýr:


         ForceMode.Force: Girdiyi tork (Newton-metre cinsinden ölçülür) olarak yorumlar ve açýsal hýzý tork * DT / kütle deðeriyle 
                          deðiþtirir. Etki, simülasyon adým uzunluðuna ve cismin kütlesine baðlýdýr.

         ForceMode.Acceleration: Parametreyi açýsal hýzlanma (derece/saniye kare cinsinden ölçülür) olarak yorumlar ve açýsal hýzý 
                                 tork * DT deðeriyle deðiþtirir. Etki, simülasyon adým uzunluðuna baðlýdýr ancak cismin kütlesine
                                 baðlý deðildir.
 
         ForceMode.Impulse: Parametreyi açýsal momentum (kilogram-metre-kare/saniye cinsinden ölçülür) olarak yorumlar ve açýsal
                            hýzý tork/kütle deðeriyle deðiþtirir. Etki, vücudun kütlesine baðlýdýr ancak simülasyon adým uzunluðuna
                            baðlý deðildir.

         ForceMode.VelocityChange: Parametreyi doðrudan açýsal hýz deðiþimi olarak yorumlar (derece/saniye olarak ölçülür) ve 
                                   açýsal hýzý tork deðeriyle deðiþtirir. Etki, vücudun kütlesine ve simülasyon adým uzunluðuna 
                                    baðlý deðildir.
       

        
       

        float yatay = Input.GetAxis("Horizontal");

      m_Rigidbody.AddTorque(transform.up * deger *yatay); // Sað ve sol tuþlarla bir nesneyi Y ( yukarý ) ekseninde döndürdük.
                                                             

      m_Rigidbody.AddTorque(transform.right * deger * yatay);// Sað ve sol tuþlarla bir nesneyi x EKSENÝNDE döndürerek ÝLERLETTÝK ! !


        */

        #endregion


        #region 6 ) Rigidbody.AddRelativeTorque

        /* Rigidbody ' sahip objeye KOORDÝNAT SÝSTEMÝNE göre bir TORK  ekler.
         
          Tork ( Döndürme Kuvveti ) : Kuvvet * Kuvvet Kolu ( Nm = Newton * Metre )   T = F * d 
          Aralarýnda açý varsa Tork : F * ( r * sin@ )

        // m_Rigidbody.AddRelativeTorque(Vector3.forward * deger);

        // m_Rigidbody.AddRelativeTorque(Vector3.right * deger);


        ÖNEMLÝ : AddRelativeForce ( ) ' de objeye sadece 1 kere kuvvet uygularken BURDA obje SÜREKLÝ BELÝRTTÝÐÝN EKSENDE
                 VE BELÝRTTÝÐÝN TORK DEÐERÝNDE SÜREKLÝ DÖNEREK GÝDÝYOR.

        */
        #endregion


        #region 7) Rigidbody.angularDrag

        /* 

         Nesnenin açýsal sürüklemesidir.

         AÇISAL SÜRÜKLEME, bir nesnenin DÖNÜÞÜNÜ  YAVAÞLATMAK için kullanýlabilir. Sürükleme ne kadar yüksek olursa objenin
         dönüþü o kadar yavaþlar.

         Debug.Log(m_Rigidbody.angularDrag); // objeye hiç bir þey yapmamýþ haliyle AÇISAL SÜRÜKLEMESÝ 0.05 MÝÞ

        if (Input.GetKeyDown(KeyCode.P))
        {
            m_Rigidbody.angularDrag = 0.8f;

        }

        */

        #endregion


        #region 8 ) Rigidbody.angularVelocity

        /*

        Saniyede radyan cinsinden ölçülen katý cismin AÇISAL HIZ VEKTÖRÜ.

        Çoðu durumda gerçekçi olmayan davranýþlara yol açabileceðinden doðrudan deðiþtirmemelisiniz.

        Rigidbody ayarlanmýþ, dönme kýsýtlamalarý varsa karþýlýk gelen açýsal hýz bileþenlerinin çaðrý sýrasýnda kütle uzayýnda
        ( yani atalet tensör dönüþüne göre ) sýfýra ayarlandýðýna dikkat edin.



        Debug.Log ( m_Rigidbody.angularVelocity ); // Ham haliyle ( 0,0,0 ) çýktýsýný aldým.

        float yatay =  Input.GetAxis("Horizontal");
        transform.Translate(new Vector3(yatay * Time.deltaTime, 0f, 0f));

       Debug.Log(m_Rigidbody.angularVelocity); // Sadece hareket ederken eðer biriyle temas ediyorsam sadece x ekseninde deðerleri
                                               // -0.1 vb deðerlerini aldým.  [ örnek : (  -0.1 ,0 , 0 ) ]

        Debug.Log(m_Rigidbody.angularVelocity.magnitude); // Hareket ettiðimde 1.59 * 10 üzeri -6 çýktýsýný aldým vb.. çýktýlarýný
        aldým.


        */
        #endregion


        #region 9 ) Rigidbody.centerOfMass

        /*
         
         Dönüþümün kökenine göre kütle merkezi.

         Bir komut dosyasýndan kütle merkezini ayarlamazsanýz bu katý cisme baðlý cisme baðlý cisim tðm çarpýþtýrýcýlardan otomatik
         olarak hesaplanacaktýr.Özel bir kütle merkezi ayarlandýktan sonra çarpýþtýrýcý ekleme veya çýkarma bunlar : Çevirme, 
         ölçekleme vb.. gibi deðiþikliklerde artýk otomatik olarak yeniden HESAPLANMAYACAKTIR. Otomatik olarak hesaplanan kütle
         merkezine geri dönmek için Rigidbody.ResetCenterOfMass ' i kullanýn.
            
            Arabalarý daha kararalý hale getirmek için simüle ederken kütle merkezini ayarlamak genellikle yararlýdýr. Kütle 
            merkezi daha düþük olan bir arabýnýn devrilme olasýlýðý daha düþüktür.

         Vector3 RigidbodyeSahipObjeninKutleMerkezi = m_Rigidbody.centerOfMass;
         Debug.Log(RigidbodyeSahipObjeninKutleMerkezi); // Hiçbir þey yapmazken kütle merkezi  0,0,0 mýþ.


        m_Rigidbody.centerOfMass = centerOffMassPoint.transform.position;
        Debug.Log(m_Rigidbody.centerOfMass);

             Hiçbir hareket kodu YAZMAMAMA raðmen obje bir sola bir saða gidiyor sürekli.

        */
        #endregion


        #region 10 ) Rigidbody.ClosestPointOnBounds ( ) 

        /*
        
        Ekli çarpýþtýrýcýlarýn sýnýrlayýcý kutusuna en yakýn nokta.

        Vector3 a = m_Rigidbody.ClosestPointOnBounds(transform.position);
        Debug.Log(a);

        Objenin konumu  ( -1.97 , 0.509 , 0.77 ) buydu. Biz bu kodu yazdýktan sonra bu deðerleri yuvarladý en yakýn sayýyý baz aldý
        Yani  ( -2.0 , 0.5 , 0.8 ) oldu ! ! !

        */


        #endregion


        #region 11 ) Rigidbody.collisionDetectionMode


        /*

        Katý cismin ÇARPIÞMA ALGILAMA MODUDUR.

        Bunu hýzlý hareket eden nesnelerin çarpýþmalarý algýlamadan diðer nesnelerden geçmesini önlemek için kullanýlan SÜREKLÝ
        ÇARPILMA  ALGILAMASI   için kullanýrýz.

        -- ÖNEMLÝ 

        En iyi sonuçlar için, hýzlý hareket eden nesneler için bu deðeri CollisionDetectionMode.ContinulousDynamic olarak
        ayarlayýn ve bunlarýn çarpýþmasý gereken diðer nesneler için CollisionDetectionMode.Continuous olarak ayarlayýn. 
        Bu iki seçeneðin fizik performansý üzerinde büyük etkisi vardýr. 

        Alternatif olarak, genellikle daha ucuz olan ve kinematik nesneler üzerinde de kullanýlabilen 
        CollisionDetectionMode.ContinulousSpeculative'i kullanabilirsiniz.

        Hýzlý nesnelerin çarpýþmasýyla ilgili sorunlarýnýz yoksa, CollisionDetectionMode.Discrete varsayýlan deðerine ayarlanmýþ
        olarak býrakýn. Sürekli Çarpýþma Algýlama yalnýzca Sphere-, Capusle- veya BoxColliders'lý Sert Gövdeler için desteklenir.



            1 ) CollisionDetectionMode.Continuous : SADECE STATÝK að geometirisi ile çarpýþma için sürekli çarpýþma algýlama modu
                                                    açýk olur.

            2 ) CollisionDetectionMode.ContinuousDynamic : STATÝK VE DÝNAMÝK geometri ile çarpýþma için sürekli çarpýþma algýlama
                                                           açýk olur.

            3 ) CollisionDetectionMode.ContinuousSpeculative :  STATÝK VE DÝNAMÝK geometriler için SPEKÜLATÝF  sürekli çarpýþma 
                                                                algýlama açýk olur.

            4 ) CollisionDetectionMode.Discrete : Bu Rigidbody için sürekli çarpýþma algýlama KAPALI olur.


        */


        #endregion


        #region 12 ) Rigidbody.detectCollisions

        /* ÇARPIÞMA ALGILAMA ETKÝNLEÞTÝRÝLSÝN MÝ ? 

        Debug.Log(m_Rigidbody.detectCollisions); // Default olarak TRUE yani çarpýþma algýlama ETKÝN bir þekilde geliyor.

        */

        #endregion


        #region 13 ) Rigidbody.constraints 

        /*
         Bu Rigidbody için hangi serbestlik derecelerine izin verildiðini kontrol eder.

         Unity tarafýnda Constraints kýsmýndan da istediðin SINIRLAMAYI  yapabilirsin KOD TARAFINDADA istediðin SINIRLAMAYI 
         yapabilirsin.

        
        m_Rigidbody.constraints = RigidbodyConstraints.FreezePositionX;

        */

        #endregion


        #region 14 ) Rigidbody.drag


        /*
        
        Objenin SÜRTÜNMESÝDÝR ! ! !

        Debug.Log(m_Rigidbody.drag); // HAM ( Default ) HALÝYLE  Rigidbody 'nin SÜRTÜNMESÝ 0 mýþ ! ! !


        m_Rigidbody.velocity = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
        m_Rigidbody.drag = 200f;
        m_Rigidbody.drag = 2f;

        Debug.Log(m_Rigidbody.drag);

        Gördüðün gibi objenin Rigidbody'sindeki Sürtünmeyi artýrdýðýnda obje yavaþ hareket ediyor ! ! !

        */

        #endregion


        #region 15 ) Rigidbody.freezeRotation

        /*
         
        Fiziðin nesnenin DÖNÜÞÜNÜ  deðiþtirip deðiþtirmeyeceðini belirler.
        ETKÝNLEÞTÝRÝLÝRSE DÖNDÜRME , Fizik( Rigidbody ) tarafýndan DEÐÝÞTÝRÝLEMEZ ! ! !
         
           Bu Birinci þahýs Niþancý ( FPS ) ayarlarý oluþturmak için kullanýþlýdýr, çünkü oyuncunun fareyi kullanarak dönüþün
           tam kontrolüne ihtiyacý vardýr.

        

        Debug.Log(m_Rigidbody.freezeRotation); // HAM ( DEfault ) HALÝYLE FÝZÝK NESNENÝN DÖNÜÞÜNÜ DEÐÝÞTÝREBÝLÝR.


        m_Rigidbody.freezeRotation = true;
        m_Rigidbody.velocity = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);

        obje saða sola giderken DÖNEREK GÝDÝYORDU ancak biz bu özelliði AKTÝFLEÞTÝRDÝÐÝMÝZ ÝÇÝN DÖNEREK SAÐA SOLA GÝDEMEZ 
        SADECE SAÐA SOLA GÝDER ! ! !


        */
        #endregion


        #region 16 ) Rigidbody.GetPointVelocity ( ) 

        /* Küresel uzayda nokta dünya noktasýnda katý cismin HIZINI HESAPLAR YANÝ YAKALAR.
           
            GetPointVelocity (), HIZI hesaplarken katý cismin AÇISAL HIZINI ( angular Velocity 'sini ) HESABA KATAR ! ! ! ! !

        m_Rigidbody.velocity = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
        Debug.Log(  m_Rigidbody.GetPointVelocity(transform.position) );
         

        */

        #endregion


        #region 17 ) Rigidbody.GetRelativePointVelocity ( )

        /*
         
         Nokta göreli noktasýnda katý cisme GÖRE HIZINI hesaplar.
         Hýzý hesaplarken katý cismin AÇISAL hýzýný hesaba katar.

        Görecelik : Varlýðý bir baþka þeyin varlýðýna baðlý bulunan, mutlak olmayan , göreli , baðlantýlý , izafi ,nispi, rölatif...

        m_Rigidbody.velocity = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
        Debug.Log( m_Rigidbody.GetRelativePointVelocity(transform.position));

        */
        #endregion


        #region 18 ) Rigidbody.inertiaTensor

        /*
         
        m_Rigidbody.velocity = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
        Debug.Log(m_Rigidbody.inertiaTensor); // Hiçbir iþlem yapmadan Objenin Eylemsizlik tensörü  ( 0.2  , 0.2 , 0.2 )' ymiþ.


        Bu cismin kütle merkezine yerleþtirilmiþ ve Rigidbody.inerttiaTensorRotation tarafýndan döndürülen bir referans 
        çerçevesindeki diyagonal matris olarak tanýmlanan bu cismin EYLEMSÝZLÝK TENSÖRÜDÜR.

            Eylemsizlik ( ATALET ) : Bir nesnenin bir dýþ etki olmadýðý sürece DEÐÝÞMEME özelliðidir.

                                     Eðer bir cismin üzerine etki eden net/toplam kuvvet sýfýr ise, durmakta olan bir cisim 
                                     durmayý, hareket etmekte olan bir cisim ise ayný yönde ve hýzda hareket etmeyi sürdürür.

                                     Fizikte bu, "eylemsizlik" ya da "atalet" olarak tanýmlanýr. Daha basit bir tanýmýyla 
                                     eylemsizlik, cisimlerin o anda bulunduklarý hareket durumunu korumaya olan eðilimleridir. 
                                     Duran bir cisim durmayý sürdürmek ister. Hareket halindeki bir cisimse ayný þekilde hareket 
                                     etmeyi... 

         TENSÖR : Matematikte, tensör, çok boyutlu verinin simgelenebildiði geometrik bir nesnedir. Skaler denilen yönsüz nicel
                  büyüklükler, vektör denilen yönlü büyüklükler ve matris denilen iki boyutlu nesneler birer tensördür. 
                  Tensör, tüm bu nesnelerin genelleþtirilmiþ halidir ve çok boyutlu veri kümeleri için kullanýlýr.

     
         MOMENT NEDÝR : Bir kuvvetin bir cisim üzerinde yarattýðý DÖNDÜRME etkisine MOMENT denir. Bir kuvvetin bir noktaya göre 
                        momentinin büyüklüðü, kuvvetle o noktaya olan dik uzaklýðýnýn çarpýmýdýr.
        Atalet tensörü, kütlenin dönüþsel bir analoðudur: belirli bir eksen etrafýndaki atalet bileþeni ne kadar büyükse, 
        o eksen etrafýnda ayný açýsal ivmeyi elde etmek için gereken torkta o kadar fazladýr.

        Sýfýr, geçerli bir atalet tensörü bileþeni deðil. Bu nedenle, fizik sistemi bunun yerine sýfýrlarý sonsuz deðerler 
        olarak yorumlar. Dolayýsýyla, örneðin (0, 1, 1) atalet tensörüne sahip bir cismin X etrafýnda dönmesi imkansýzdýr.

        Dönel Kýsýtlamalarýn Rigidbody Kýsýtlamalarýnýn Rigidbody'nin gerçekte atalet tensörü bileþenlerini kilitli
        serbestlik dereceleri hakkýnda sýfýra ayarlayarak uygulandýðýna dikkat edin.

        Atalet tensörünü bir komut dosyasýndan ayarlamazsanýz, Rigidbody'ye baðlý tüm çarpýþtýrýcýlardan otomatik olarak 
        hesaplanýr. Atalet tensörünü otomatik olarak hesaplanan deðere sýfýrlamak için Rigidbody.ResetInertiaTensor'u kullanýn.

        */

        #endregion


        #region 19 ) Rigidbody.inertiaTensorRotation


        /*
         
          Eylemsizlik tensörünün DÖNÜÞÜDÜR.
          Bir komut dosyasýndan eylemsizlik tensörü dönüþünü ayarlayamazsýnýz, bu katý cisme baðlý olan çarpýþtýrýcýlardan otomatik 
          olarak hesaplanýr.

        m_Rigidbody.velocity = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);

        Quaternion a = transform.rotation;
        m_Rigidbody.inertiaTensorRotation = a;

        Debug.Log(m_Rigidbody.inertiaTensorRotation);

        Hareket ettirmeden  ( 0.0, 0.0 0.0 , 1.0  ) deðerini aldý  haraket ettirdikten sonra  ( 0.0 , 0.0 , 0.6 , - 0.8 ),
        ( 0.0 , 0.0 , 0.3 , -1.0 ) vb.. deðerlerini  aldý.
                                                      

        Debug.Log(m_Rigidbody.inertiaTensorRotation); 

         HAM HALÝYLE ( 0.0 , 0.0 , 0.0 , 1.0 ) deðerleri aldý.
         HAREKET ETTÝRDÝKTEN  SONRADA (  0.0 , 0.0 , 0.0 , 1.0 ) deðerini aldý.                                              


        */
        #endregion


        #region 20 ) Rigidbody.interpolation

        /*
         
        Ýnterpolasyon, sabit bir kare hýzýnda çalýþan fiziðin etkisini YUMUÞATMAMIZA olanak tanýr.

        Varsayýlan olarak interpolasyon kapalýdýr. Oyuncunun karakterinde genellikle katý cisim interpolasyonu kullanýlýr. 
        Grafikler deðiþken kare hýzlarýnda oluþturulurken, fizik ayrý zaman adýmlarýnda çalýþýr. Bu, fizik ve grafikler tamamen
        senkronize olmadýðý için titrek görünen nesnelere yol açabilir. Efekt incedir, ancak özellikle kamera ana karakteri 
        takip ediyorsa, oyuncu karakterinde sýklýkla görülür. Ana karakter için enterpolasyonu açmanýz, ancak diðer her þey için 
        devre dýþý býrakmanýz önerilir.


        1 ) RigidbodyInterpolation.Extrapolate : EKSTRAPOLASYON, MEVCUT HIZA  dayalý olarak katý cismin KONUMUNU tahmin edecektir.

        2 ) RigidbodyInterpolation.Interpolate : INTERPOLASYON, her zaman biraz geride kalabilir ancak ekstrapolasyondan daha
                                                 yumuþak olabilir.

        3 ) RigidbodyInterpolation.None : Interpolasyon YOKTUR.


        

        Debug.Log(m_Rigidbody.interpolation);
            PROJE VE OBJE ham ( default ) haliyle NONE 'mýþ.YANÝ  Interpolasyon YOKMUÞ ! ! !

        m_Rigidbody.interpolation = RigidbodyInterpolation.Interpolate;
        Debug.Log(m_Rigidbody.interpolation);
           INTERPOLATE çýktýsýný bize verdi.

        m_Rigidbody.interpolation = RigidbodyInterpolation.Extrapolate;
        Debug.Log(m_Rigidbody.interpolation);
            EXTRAPOLATE çýktýsýný bize verdi.

        */


        #endregion


        #region 21 ) Rigidbody.isKinematic

        /*

        isKinematic ETKÝNLEÞTÝRÝLÝRSE, Kuvvetler, çarpýþmalar veya eklemler artýk katý cismi ETKÝLEMEYECEKTÝR. 
        
        Katý cisim, 
        transform.position deðiþtirilerek animasyonun veya komut dosyasýnýn tam kontrolü altýnda olacaktýr. Kinematik cisimler,
        çarpýþmalar veya eklemler yoluyla diðer katý cisimlerin hareketini de etkiler. Örneðin. kinematik bir rijit cismi normal 
        bir rijit cisme bir eklem ile baðlayabilir ve rijit cisim kinematik cismin hareketi ile sýnýrlandýrýlacaktýr. Kinematik 
        katý cisimler, normalde bir animasyon tarafýndan yönlendirilen karakterleri yapmak için özellikle yararlýdýr, ancak 
        belirli olaylarda, isKinematic'i false olarak ayarlayarak hýzlý bir þekilde bir bez bebek haline getirilebilir.

        KÝNEMATÝK NEDÝR ? 

        Kinematik, cisimlerin KÜTLELERÝ ve cisme etkiyen  KUVVETLER ele ALINMADAN onlarýn SADECE HAREKETLERÝ incelenir. 
        Burada sadece zaman ile alýnan yol arasýndaki iliþkiyi veren hareket denkleminin kurulmasýna çalýþýlýr.

        Kinematik, belli bir ZAMAN sonundaki bir cismin KONUMU araþtýrýldýðýndan, iki temel fiziksel büyüklüðe ihtiyaç duyulur.
        Bunlardan biri zaman birimi diðeri de uzunluk birimidir. SI birim sistemine göre, zaman birimi s (saniye) ve uzunluk 
        birimi m (metre)dir.

        
        m_Rigidbody.velocity = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);

          m_Rigidbody.isKinematic = true;   OBJE HÝÇBÝR ÞEKÝLDE HAREKET EDEMÝYOR !
          m_Rigidbody.isKinematic = false;  Obje hareket EDEBÝLÝYOR.

        */
        #endregion


        #region 22 ) Rigidbody.IsSleeping ()

        /*
         
        m_Rigidbody.velocity = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
        Debug.Log(m_Rigidbody.IsSleeping());

         Objeyi Rigidbody ile hareket ettirmezsen TRUE  yani Rigidbody UYUYOR ANLAMINA GELÝYOR.
         Objeyi Rigidbody ile hareket ettirirsen FALSE yani Rigidbody UYUMUYOR ÇALIÞIYOR anlamýna geliyor.

        */

        #endregion


        #region 23 ) Rigidbody.mass

        /*
         
          Katý cismin KÜTLESÝDÝR.

        Büyük kütle farklýlýklarýna sahip farklý Rijit cisimler, fizik simülasyonunu kararsýz hale getirebilir.

        Daha yüksek kütleli nesneler, çarpýþýrken daha düþük kütleli nesneleri daha fazla iter. Küçük bir arabaya çarpan büyük 
        bir kamyon düþünün.

        Yaygýn bir hata, aðýr nesnelerin hafif olanlardan daha hýzlý düþtüðünü varsaymaktýr. Hýz yerçekimine ve sürüklemeye
        baðlý olduðundan bu doðru deðildir.

        
        Debug.Log(m_Rigidbody.mass);

        */

        #endregion


        #region 24 ) Rigidbody.maxAngularVelocity 

        /*

        Saniyede radyan cinsinden ölçülen katý cismin MAKSÝMUM AÇISAL HIZI. (Varsayýlan 7) { 0, sonsuz } aralýðý.

        Hýzlý dönen gövdelerde SAYISAL KARARSIZLIÐI önlemek için katý cisimlerin açýsal hýzý maxAngularVelocity'ye kenetlenir.
        Bu, tekerlekler gibi nesneler üzerinde kasýtlý olarak hýzlý dönüþleri engelleyebileceðinden, katý cisim baþýna bu deðeri
        geçersiz kýlabilirsiniz.

        

        m_Rigidbody.velocity = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);

        Debug.Log(m_Rigidbody.maxAngularVelocity);

         HAM(Default)  haliyle maxAngularVelocity Yani MAKSÝMUM  AÇISAL HIZ 7 deðeri alýyormuþ ! ! !
         OBJEYLE HAREKET ETSENDE maxAngularVelocity 7 deðerini alýr. Sadece sen  maksimum açýsal hýz deðerine DIÞARIDAN BÝR
         DEÐER VERÝRSEN ANCAK ÖYLE DEÐÝÞÝR.

        m_Rigidbody.maxAngularVelocity = 2f;
        Debug.Log(m_Rigidbody.maxAngularVelocity);

        */


        #endregion


        #region 25 ) Rigidbody.maxDepenetrationVelocity ***

        /*
         
       Bir katý cismin nüfuz etme durumundan çýkarken maksimum hýzý.

       Vücutlarýnýzýn ÇARPIÞMA  durumundan varsayýlandan daha DÜZGÜN bir þekilde çýkmasýný saðlamak istediðinizde bu özelliði 
       kullanýn.


          m_Rigidbody.velocity = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);

          Debug.Log(m_Rigidbody.maxDepenetrationVelocity);

        Rigidbody 'nin HAM ( Default ) haliyle çarpýþma durumundan çýkma hýzý 10 ' MUÞ ! ! !
       Ama tabiki biz bu çarpýþma durumunda çýkma hýzýný kendimiz de belirleyebiliriz. ( atayabiliriz. )

        */


        #endregion


        #region 26 ) Rigidbody.MovePosition ( )

        /*
        MovePosition : Haraket Pozisyonu 

        Kinematik katý cismi KONUMA doðru hareket ETTÝRÝR (TAÞIR ).

        Rigidbody.MovePosition bir Rigidbody 'Yi taþýr ve enterpolasyon ayarlarýyla uyumludur. Rigidbody enterpolasyonu 

        etkinleþtirildiðinde, Rigidbody.MovePosition çerçeveler arasýnda yumuþak bir geçiþ oluþturur. Unity , her çaðrýda bir

        RigidbodyFixedUpdate taþýr . Dünya position uzayýnda gerçekleþir. Bir Rigidbody'yi bir konumdan diðerine ýþýnlamak, 

        MovePosition yerine Rigidbody.position kullanýn ! ! ! 

        
        Vector3 m_Input = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        m_Rigidbody.MovePosition(gameObject.transform.position + m_Input* Time.deltaTime*2f);
      
        Bu metodun içinde Rigidbody ' e sahip objenin KENDÝ KONUMUNU GÝRMEN ÞART. 

        Bunu  çünkü Metodun isminden ( MovePosition : Hareket Pozisyonu ) anlarsýn. 

        */

        #endregion


        #region 27 ) Rigidbody.MoveRotation ( )

        /*
         
        KATI CÝSMÝ DÖNDÜRÜR.

         Bir Rigidbody öðesini döndürmek için Rigidbody.MoveRotation öðesini Rigidbody'nin enterpolasyon ayarýna uygun olarak
         kullanýn.

        - Rigidbody üzerinde Rigidbody enterpolasyonu etkinleþtirilirse, Rigidbody.MoveRotation öðesinin çaðrýlmasý , oluþturulan 
          herhangi bir ara karede iki döndürme arasýnda yumuþak bir geçiþ saðlar. 

        - Her bir FixedUpdate içinde bir katý cismi SÜREKLÝ  olarak DÖNDÜRMEK  istiyorsanýz bu kullanýlmalýdýr !!!!!

        - Bir katý cismi hiçbir ara konum oluþturulmadan bir dönüþten diðerine  ýþýnlamak istiyorsanýz, bunun yerine
          Rigidbody.rotation özelliðini kullanýn.

        
        Vector3 eulerDondurmeVektoru = new Vector3(0f, 20f, 0f);
        Quaternion euler = Quaternion.Euler(eulerDondurmeVektoru * Time.deltaTime);
        m_Rigidbody.MoveRotation(m_Rigidbody.rotation * euler );

          Gördüðün gibi obje SÜREKLÝ DÖNÜYOR.

        */

        #endregion


        #region 28 ) Rigidbody.name

        // Debug.Log(m_Rigidbody.name);

        // Rigidbody' e sahip objenin Unity 'de Hierarchy 'deki ismini YAKALAR ! ! !


        #endregion


        #region 29 ) Rigidbody.position

        /*
         
        Debug.Log(m_Rigidbody.position);

      -- Rigidbody ' sahip objenin konumu = ( -1.97, 0.509 , 0.77 ) 'ymiþ. BU KODU YAZDIKTAN SONRA ÇIKTIMIZ AYNEN ÞÖYLE : 
         ( -2.0 , 0.5 , 0.8 ). Yani burdan þunu anlýyoruz yuvarlak sayýlarý en yakýn sayýya YUVARLIYOR.

      -- Rigidbody.position, fizik motorunu kullanarak bir Rigidbody'nin KONUMUNU almanýzý ve ayarlamanýzý saðlar. 
         Bir Rigibody'nin konumunu Rigidbody.position kullanarak deðiþtirirseniz, dönüþüm sonraki fizik simülasyonu adýmýndan 
         sonra güncellenecektir.Bu, Transform.position'ý kullanarak konumu güncellemekten daha HIZLIDIR ! ! !
         ÇÜNKÜ ikincisi tüm baðlý çarpýþtýrýcýlarýn konumlarýný Rigidbody'ye göre yeniden hesaplamasýna neden olacaktýr.

         Bir katý cismi SÜREKLÝ olarak taþýmak istiyorsanýz, bunun yerine enterpolasyonu hesaba katan MovePosition'ý kullanýn.

        

        Vector3 anlayisObjesininKonumu = o_Anlayis.transform.position;
        m_Rigidbody.position = anlayisObjesininKonumu;

        */

        #endregion


        #region 30 ) Rigidbody.ResetCenterOfMass ( )

        /*
         
        Katý cismin KÜTLE MERKEZÝNÝ SIFIRLAR.

        m_Rigidbody.centerOfMass = new Vector3(10f, 0f, 0f);
        m_Rigidbody.ResetCenterOfMass();
        Debug.Log(m_Rigidbody.centerOfMass);

        */

        #endregion


        #region 31 ) Rigidbody.ResetInertiaTensor ( )

        /*
         
        Vector3 a = m_Rigidbody.inertiaTensor;
        m_Rigidbody.ResetInertiaTensor();
        Debug.Log(a);

        */

        #endregion


        #region 32 ) Rigidbody.rotation

        /*
        Vector3 EulerVektoru = new Vector3(20f, 37f, 83f);
        Quaternion EulerDonmesi = Quaternion.Euler(EulerVektoru) ;
        m_Rigidbody.rotation = EulerDonmesi;

        
         
        Rigidbody.position, fizik motorunu kullanarak bir Rigidbody'nin DÖNÜÞÜNÜ  almanýzý ve ayarlamanýzý saðlar. 

        Bir Rigidbody'nin dönüþünü Rigidbody.rotation kullanarak deðiþtirmek, sonraki fizik simülasyon adýmýndan sonra 
        Dönüþüm'ü günceller. Bu, Transform.rotation kullanarak dönüþü güncellemekten daha HIZLIDIR, çünkü Transform.rotation
        tüm baðlý Çarpýþtýrýcýlarýn dönüþlerini Rigidbody'ye göre yeniden hesaplamasýna neden olurken, Rigidbody.rotation deðerleri
        doðrudan fizik sistemine ayarlar.

         Bir katý cismi SÜREKLÝ döndürmek istiyorsanýz, bunun yerine enterpolasyonu hesaba katan MoveRotation'ý kullanýn.

        

        Debug.Log(m_Rigidbody.rotation); // HAM ( DEFAULT ) haliyle ( 0.0, 0.0 , 0.0 , 1.0 ) Deðerini alýyormuþ.

        */

        #endregion


        #region 33 ) Rigidbody.SetDensity ( )

        /*
           SABÝT bir yoðunluðu varsayarak ekli çarpýþtýrýcýlara dayalý olarak KÜTLEYÝ ayarlar.

           Bu, kütleyi çarpýþtýrýcýlarýn boyutuna göre ölçeklenen bir deðere ayarlamak için kullanýþlýdýr.
         
           YANÝ  Rigidbody 'NÝN KÜTLESÝNÝ ayarlamamýzý saðlar ! ! ! ! !
        
      

        m_Rigidbody.SetDensity(setDensityYaniKutleDegeri);
        Debug.Log(m_Rigidbody.mass);
      
        */

        #endregion


        #region 34 ) Rigidbody.Sleep ( )

        /*
          Rigidbody ' i EN AZ BÝR KARE UYUMAYA ZORLAR.
          Projemi çalýþtýrdýðým objede rigidbody olmasýna raðmen obje yükseklikte duruyor ve yere düþmüyor. 30 saniye , 40 saniye
           belki dahada fazla yere düþmeden havada beklicek. Ýþte method bu iþe yarýyor ! ! 

        m_Rigidbody.Sleep();

        */
        #endregion


        #region 35 ) Rigidbody. sleepThreshold

        /*
         
         sleepThreshold : Uyku eþiði
          
         Altýnda nesnelerin uyumaya baþladýðý kütle olarak NORMALÝZE edilmiþ ENERJÝ EÞÝÐÝ.
        
         Debug.Log(m_Rigidbody.sleepThreshold);  HAM ( DEFAULT ) haliyle rigidbody 'nin UYKU EÞÝÐÝ  0.005 Deðerindeymiþ.

         BÝZ bu uyku eþiðini KENDÝMÝZ DE BELÝRLEYEBÝLÝRÝZ.

        */


        #endregion


        #region 36 ) Rigidbody.solverIterations

        /*

       ( solver Iterations : Çözücü yineleme sayýsý )

         -- solventIterations, Rigidbody eklemlerinin ve çarpýþma temaslarýnýn ne kadar doðru çözümlendiðini belirler.
              Physics.defaultSolverIterations'ý geçersiz kýlar. Olumlu olmalý.

          --  Baðlý Sert Gövdelerle ilgili sorun yaþýyorsanýz, salýným yapýyor ve kararsýz davranýyorsanýz, daha yüksek bir ÇÖZÜCÜ 
              YÝNELEME SAYISI ayarlamak kararlýlýklarýný artýrabilir (ancak daha yavaþtýr).

        YANÝ Rigidbody 'nin çarpýþmada daha KARARLI olabilmesini saðlar ! ! !



        Debug.Log(m_Rigidbody.solverIterations); 
        
        HAM ( DEFAULT ) haliyle Rigidbody 'nin çarpýþmalarda kararlý olma deðeri  6 'ymýþ.
       

        m_Rigidbody.solverIterations = 30; 

        iþte biz bu default 6 deðerini artýrarak Rigidbody ' i Çarpýþmalarda daha kararlý hale getirebiliyoruz.

            
            */

        #endregion


        #region 37 ) Rigidbody.solverVelocityIterations

        /*
           solverVelocityIterations : Çözücü HIZ Yinelemeleri
         
            Çözücü hýz yinelemeleri , Rigidbody eklemlerinin ve çarpýþma temaslarýnýn ne kadar doðru çözümlendiðini etkiler.
            Physics.defaultSolverVelocityIterations ' ý geçersiz kýlar. Olumlu olmalý.
         
         

        Debug.Log(m_Rigidbody.solverVelocityIterations);
        HAM (DEFAULT) HALÝYLE  Rigidbody 'nin Çarpýþmalarda Hýz kararlýlýðý deðeri 1 miþ ! ! ! ! ! ! 

        m_Rigidbody.solverVelocityIterations = 5;

        iþte biz bu default 1 deðerini artýrarak Rigidbody 'nin Çarpýþmalarda HIZ KARARLIÐINI artýrabiliyoruz.

        YANÝÝÝÝÝ bu deðerin arttýrýlmasý, bir Rigidbody sýçramasýndan sonra ortaya çýkan çýkýþ hýzýnýn daha yüksek doðruluðu ile 
        sonuçlanacaktýr. Çarpýþmalardan sonra eklemli Rigidbodies veya Ragdoll'larýn ÇOK FAZLA  HAREKET ETMESÝYLE ilgili sorunlar 
        yaþýyorsanýz, bu deðeri ARTIRIN !!!

        */

        #endregion


        #region  38 ) Rigidbody.SweepTest ( )

        /*
         
          Katý bir cisim sahnede hareket ettirilirse herhangi bir þeyle çarpýþýp çarpýþmayacaðýný test eder.

          Bu, Rigidbody'nin çarpýþtýrýcýlarýndan herhangi birinde bulunan tüm noktalar için bir Physics.Raycast yapmaya ve rapor 
          edilen tüm isabetlerin (varsa) en yakýnýný döndürmeye benzer. Bu, AI kodu için yararlýdýr, örneðin bir nesnenin hiçbir 
          þeyle çarpýþmadan bir boþluða sýðacaðýný bilmeniz gerekiyorsa.

          Bu iþlevin yalnýzca katý cisim nesnesine ilkel bir çarpýþtýrýcý türü (küre, küp veya kapsül) veya dýþbükey bir að 
          eklendiðinde çalýþtýðýný unutmayýn - içbükey að çarpýþtýrýcýlarý, tarama tarafýndan Sahnede algýlanabilmelerine raðmen 
          çalýþmayacaktýr.

          Sert cisim taramasý herhangi bir çarpýþtýrýcýyla kesiþtiðinde True, aksi takdirde false döner.

         direction : Katý cismin süpürüleceði yön.

         hitInfo   : hitInfo true döndürülürse, hitInfo çarpýþtýrýcýnýn vurulduðu yer hakkýnda daha fazla bilgi içerir. 
        
         maxDistance : Süpürmenin uzunluðu.

         queryTriggerInteraction : Bu sorgunun tetikleyicileri vurup vurmayacaðýný belirtir.
        


        
        m_Rigidbody.velocity = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);

        RaycastHit hit;
        bool dogruMu = m_Rigidbody.SweepTest(transform.forward, out hit, 200f);

        if (dogruMu)
        {
            Debug.Log(" çalýþtý.");
        }

         YANÝ Rigidbody ' e sahip obje baþka bir objeyle ( yukarýdaki açýklamalarý saðlayan objeler olmasý lazým )  çarpýþacaðýný
         ýþýn gönderek anlamamýzý saðlar.

         Mesela oyunu çalýþtýrdýðýmda characterim ilk baþta uzak olduðu için ÇALIÞMADI ama biraz daha baþka objelere yaklaþýnca
         ÇALIÞTI ! ! ! ! ! ! 
        
        */

        #endregion


        #region 39 ) Rigidbody.SweepTestAll ( )

        /*

        Rigidbody.SweepTest gibi, ancak tüm isabetleri döndürür.

        Eðer katý cismin ekli çarpýþtýrýcýlarýndan biri çarparsa, tarama ayný ÇARPIÞTIRICIYA birden fazla isabet verebilir.

        Bu iþlevin yalnýzca katý cisim nesnesine ilkel bir çarpýþtýrýcý türü (küre, küp veya kapsül) veya dýþbükey bir að 
        eklendiðinde çalýþtýðýný unutmayýn - içbükey að çarpýþtýrýcýlarý, tarama tarafýndan Sahnede algýlanabilmelerine raðmen
        çalýþmayacaktýr.

        Bu iþlev yalnýzca 128'e kadar isabet döndürebilir.
        

        m_Rigidbody.velocity = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);

        RaycastHit[] a =  m_Rigidbody.SweepTestAll(transform.forward, 200f);
    
        Debug.Log(a);
       

        */
        #endregion


        #region 40 ) Rigidbody.velocity 

        /*
         
        m_Rigidbody.velocity = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
        Debug.Log(m_Rigidbody.velocity);

        
        Katý cismin hýz vektörü. Rigidbody pozisyonunun deðiþim oranýný temsil eder.

        Çoðu durumda hýzý doðrudan deðiþtirmemelisiniz, çünkü bu gerçekçi olmayan davranýþlara neden olabilir  bunun yerine

        AddForce ( ) KULLANIN ! ! Bir nesnenin hýzýný her fizik adýmýnda AYARLAMAYIN, bu gerçekçi olmayan fizik simülasyonuna yol 

        açacaktýr. Tipik bir kullaným, birinci þahýs niþancý ( FPS ) oyununda hýzý deðiþtireceðiniz yerdir, çünkü hýzda anýnda bir 
        deðiþiklik istersiniz.


        */
        #endregion


        #region 41 ) Rigidbody.WakeUp ( )

        /* Rigidbody 'i UYANDIRIR.
         
        m_Rigidbody.WakeUp();

        */


        #endregion


    }













}