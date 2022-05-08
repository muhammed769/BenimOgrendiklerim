using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavMeshAgentAI : MonoBehaviour


{

    [SerializeField] NavMeshAgent c_NavMeshAgent;
    [SerializeField] Animator m_Anim;

    //NavMeshPath m_navmeshpath;
    //[SerializeField] GameObject m_Target;

    [SerializeField] GameObject TryObject;
    [SerializeField] GameObject TargetObject;



    void Update()
    {



        #region Inspector'da Component 'te hazýr olan gelen özellikler



        #region  1 ) NavMeshAgent.acceleration

        /*  Karakterimizin  maksimum ivmesidir. Speed Deðeriyle orantýlý olmalýdýr.
            Get ve Set iþlemi yapýlabilir.

        Debug.Log(c_NavMeshAgent.acceleration);

        */

        #endregion


        #region 2 )  NavMeshAgent.angularSpeed

        /*

        Bir yolu takip ederken ( DERECE / SN ) cinsinden maksimum DÖNÜÞ HIZIDIR. ( AÇISAL HIZIDIR. )

        Karakterin bir yol noktasý tarafýndan tnaýmlanan  '' KÖÞEYÝ '' DÖNERKEN  dönebileceði MAKSÝMUM HIZIDIR. 

        Gerçek dönüþ çemberi ayrýca aracýn yaklaþmadaki hýzýndan ve ayrýca maksimum hýzlanmadan da etkilenir.

        Get ve Set iþlemi yapýlabilir.

        */


        #endregion


        #region 3 ) NavMeshAgent.areaMask

        /* c_NavMeshAgent.areaMask

              Herhangi bir bölgeyi maskelememizi saðlar. Yani ajanýn hangi bölgelere gidip gidemeyeceðini seçtiðimiz yerdir.
              Get ve Set iþlemi yapýlabilir. */

        #endregion


        #region 4 ) NavMeshAgent.autoBraking

        /*

        c_NavMeshAgent.autoBraking

        OTOMATÝK FREN ayarýdýr.

        Aracýnýn varýþ noktasýna yakýn bir yere inmesi gerekiyorsa, hedef bölge etrafýnda aþýrýya kaçmaktan veya sonsuz 
        "yörüngeden" kaçýnmak için tipik olarak fren yapmasý gerekir. Bu özellik true olarak ayarlanýrsa, aracý hedefe 
        yaklaþtýðýnda otomatik olarak fren yapar.

        Get ve Set iþlemi yapýlabilir.

            */

        #endregion


        #region 5 ) NavMeshAgent.autoRepath

        /*
        c_NavMeshAgent.autoRepath =true

            // Ajan kýsmi bir yolun sonuna geldiðinde yolu BULMAYA  çalýþýr.AKTÝF OLMALIDIR.

            // Get ve Set iþlemi yapýlabilir.
        */

        #endregion


        #region 6 ) NavMeshAgent.autoTraverseOffMeshLink

        /*
         
        autoTraverseOffMeshLink :  //  Að dýþý baðlantýdan otomatik geçiþ

        Að dýþý baðlantýlar NavMesh'in AYRIK bölgelerini baðlamak için kullanýlýr.

        Genellikle karakter OTOMATÝK olarak baðlantýlardan geçebilmelidir. Bu özellik TRUE olarak ayarlanýrsa gerçekleþir.
        Ancak hareket üzerinde ÖZEL KONTROLÜN gerekli olduðu durumlarda FALSE olarak da ayarlanabilir.

        */

        #endregion


        #region 7 ) NavMeshAgent.avoidancePriority

        /*
         
        avoidance Priority : KAÇINMA ÖNCELÝÐÝ

        Get ve Set iþlemi yapýlabilir.

        Kaçýnma sýrasýnda önceliði burdan belirleriz. Yani burdaki deðeri DÜÞÜK OLAN AJAN EN ÖNEMLÝ ÖNCELÝÐÝE sahip olan ajan 
        olur.

        Geçerli aralýk 0 ÝLE 99 ARASINDADIR.

        YANÝÝÝ  HEDEF OBJEMÝZÝ HANGÝ AJANIN DAHA YAKINDAN HANGÝSÝNÝN DAHA UZAKTAN TAKÝP ETMESÝNÝ BURDAN BELÝRLEYEBÝLÝYORUZ.


        c_NavMeshAgent.avoidancePriority=50;

       */

        #endregion


        #region 8 ) NavMeshAgent.baseOffset

        /*
         
        offset : Ötelemek, kaydýrmak

        Sahip olan objenin göreli DÝKEY YER DEÐÝÞTÝRMESÝ.

        Ajanýn kendine ait olan çarpýþma çapý.

        Get ve Set iþlemi yapýlabilir.

        

        c_NavMeshAgent.baseOffset = 0.5f;

        */

        #endregion


        #region 9 ) NavMeshAgent.height

        /*

        Engellerin altýndan geçmek için etkenin yüksekliði.

        YANÝ Ajanýn engele çarpma yükseliðidir.

        Get ve Set iþlemi yapýlabilir.

        */


        #endregion


        #region 10 ) NavMeshAgent.radius

        /*

        Ajanýma engellerin ve diðer ajanlarýn  geçebilme veyahut geçememe mesafesidir.
        Örneðin Radiusu FAZLA ayarlarsan engeller veya diðer ajanlar ANA AJANIMA yakýnlaþsalar bile ÇOK UZAK DURURLAR ÇÜNKÜ
        Radius fazla olduðu için daha fazla YAKLAÞAMAZLAR !!!

        Get ve Set iþlemi yapýlabilir.

        

        Debug.Log(c_NavMeshAgent.radius);

        */

        #endregion


        #region 11 ) NavMeshAgent.speed

        /*

        Bir yolu takip ederken maksimum hareket hýzýdýr.

        Bir aracý bir yolu takip ederken tipik olarak hýzlanmasý ve yavaþlamasý gerekir.Hýz genellikle bir yol parçasýnýn 
        uzunluðu ve hýzlanma ve frenleme için geçen süre ile sýnýrlýdýr, ancak hýz,uzun düz bir yolda bile bu özellik tarafýndan
        ayarlanan deðeri aþamaz.

        Get ve Set iþlemi yapýlabilir.

        
        c_NavMeshAgent.speed = 2f;

        */


        #endregion


        #region 12 ) NavMeshAgent.stoppingDistance

        /*

        Durma mesafesidir.Yani ajanýn HEDEFE ne kadar mesafede duracaðýný belirttiðimiz yerdir.

        Tam olarak hedef noktaya inmek nadiren mümkündür, bu nedenle bu özellik, ajanýn içinde durmasý gereken kabul edilebilir
        bir yarýçap ayarlamak için kullanýlabilir. Daha büyük bir durma mesafesi , aracýya yolun sonuna manevra için daha 
        fazla alan saðlayacak ve ani frenleme , dönüþ veya ve diðer ikna edici olmayan AI davranýþlarýndan kaçýnabilir.

        Get ve Set iþlemi yapýlabilir.

        

        c_NavMeshAgent.stoppingDistance = 2f;

        */

        #endregion




        #endregion



        #region Inspector'da Component 'te OLMAYAN ÖZELLÝK VE METOTLAR !!!!!!!!!!!!!!



        #region 1 ) NavMeshAgent.ActivateCurrentOffMeshLink () 


        /* c_NavMeshAgent.ActivateCurrentOffMeshLink(true);

              // Geçerli kapalý að baðlantýsýný etkinleþtirir veya devre dýþý býrakýr. Yani açýp kapatýlabilir.*/

        #endregion


        #region 2 ) NavMeshAgent.agentTypeID

        /* Debug.Log(c_NavMeshAgent.agentTypeID);

        Ajan tipinin kimlik numarasýdýr.Get ve Set iþlemi yapýlabilir. */

        #endregion


        #region 3 ) c_NavMeshAgent.CalculatePath ( ) **

        /*

        Calculate Path : Yolu hesaplar


        targetPosition : Ýstenen yolun SON konumu
        path           : Ortaya çýkan yol

        Bool : Bir yol bulunursa True döner.


        Belirli bir noktaya giden yolu hesaplayýn ve elde edilen yolu saklayýn.

        1 ) Bu metodla bir yol gerektiðinde oyundaki gecikmeyi ÖNLEMEK için  önceden bir yol planlamak için kullanýlabilir.

        2 ) Bu metodla Ajaný hareket ettirmeden önce HEDEF KONUMA ULAÞILABÝLÝR OLUP OLMADIÐINI kontrol etmek için kullanýlabilir.

        

        c_NavMeshAgent.CalculatePath()

        NAVMESHPATH CLASS'INA GÝDÝP ORDAKÝ ÖZELLÝKLERÝ ANLAMAN LAZIM YOKSA BURDAKÝLERÝ   ANLAMAZSIN !!!!!!!!!!!!!!!! 
      


      if (m_navmeshpath.status == NavMeshPathStatus.PathComplete)

        {

         YOL hedefte sona erdiyse bana þu iþlemleri yap ......

        }

      !!!!!!!!!!!!!!!!!!! ÇOK ÖNEMLÝ OKU !!!!!!!!!!!!!!!!!!!

         BU KONUNUN DAHA NET ANLAÞILMASI ÝÇÝN  TumYapayZekaKonularininScripti 'ne bakman lazým çünkü o scriptte
         VÝDEO'DAN ARGE YAPTIN !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!


        */



        #endregion


        #region 3 ) 'le BAÐLANTILI OLAN NavMeshPath CLASS'INDAKÝ ÖZELLÝK ve METOTLARIN AÇIKLANMASI !!!!!

        /*

            Nav Mesh Path : Gezinme Aðý yolu

         ************************************************************************************

          1 ) NavMeshPath.ClearCorners ()

          m_navmeshpath.ClearCorners(); // Yoldaki TÜM KÖÞE NOKTALARI siler.


          ************************************************************************************

   
         2 )  NavMeshPath.corners ( TAM ANLAMADIN )


          Yolun köþe nokta'LARI.
          Ara Noktalar olarak bilinen köþeler , bir yol boyunca yön deðiþtirdiði yerleri tanýmlar. ( Yani Yol köþeler arasýnda
          bir dizi düz çizgi hareketinden oluþur.

         SADECE Get iþlemi yapýlabilir.


        ************************************************************************************

        

         3 ) NavMeshPath.GetCornersNonAlloc


         results : Yoldaki köþeleri depolamak için kullanýlan bir dizi

         int : Yol üzerindeki köþelerin sayýsý ( baþlangýç ve bitiþ noktalarý dahil.)

         Yolun köþelerini hesaplayýn.

         Bu metod, sonuçlarýn saðlanan dizide döndürülmesi dýþýnda corners özelliðine benzer.

         Bu iþlevin saðlanan dizinin en az 2 öðeye sahip olmasýný dikkat edin.

        ************************************************************************************

       

         4 ) NavMeshPath.status

         Nav Mesh Path status : Gezinme aðý yolu DURUMU 

             m_navmeshpath.status= NavMeshPathStatus.PathComplete // Yol hedefte SONA ERER.
             m_navmeshpath.status = NavMeshPathStatus.PathPartial // YOL HEDEFE ULAÞAMAZ.
             m_navmeshpath.status = NavMeshPathStatus.PathInvalid // Yol GEÇERSÝZ.

        ************************************************************************************

        !!!!!!!!!!!!!!!!!!! ÇOK ÖNEMLÝ OKU !!!!!!!!!!!!!!!!!!!

         BU KONUNUN DAHA NET ANLAÞILMASI ÝÇÝN  TumYapayZekaKonularininScripti 'ne bakman lazým çünkü o scriptte
         VÝDEO'DAN ARGE YAPTIN !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!

      */

        #endregion


        #region 4 ) NavMeshAgent.CompleteOffMeshLink () 

        /*

        Mevcut að dýþý baðlantý üzerindeki HAREKETÝ tamamlar.

        Karakteri mevcut að dýþý baðlantý 'nýn diðer ucundaki EN YAKIN mevcut NAVMESH KONUMUNA( gezinme aðý konumuna )
        hareket edecektir.

        Karakter Að dýþý baðlantý ( OffMeshLink ) üzerinde olmadýðý sürece  CompleteOffMeshLink 'ÝN hiçbir etkisi OLAMAZ.

        autoTraverseOffMeshLink devre dýþý býrakýldýðýnda , bir aracý bu iþlev çaðrýlana kadar að dýþý bir baðlantýda
        duraklayacaktýr. OffMeshLinks genelinde özel hareket uygulamak için kullanýþlýdýr.

        

        c_NavMeshAgent.CompleteOffMeshLink();

        */

        #endregion


        #region 5 )  NavMeshAgent.FindClosestEdge ( )

        /*
         
        Find Closest Edge : En yakýn kenarý bul.

        hit : Ortaya çýkan KONUMUN özelliklerini tutar.

        En yakýn kenarý bulursa TRUE döner.

        En yakýn NavMesh ( Gezinme aðý ) kenarýný bulun.

        Döndürülen NavMeshHit nesnesi , NavMesh'in kenarýndaki en yakýn noktanýn KONUMUNU VE AYRINTILARINI içerir.
        Bir kenar tipik olarak bir  duvara veya baþka bir büyük nesneye karþýlýk geldiðinden, bu bir karakterin duvara 
        olduðunca yakýn bir yerde siper almasýný saðlamak için kullanýlabilir.
        
        YANÝ NavMesh ( Gezinebileceðim ALANLARDAKÝ ) en yakýn KENARI BULUR.


        
        if (Input.GetMouseButtonDown(0))
        {

            NavMeshHit m_NavmeshHit;
            bool EnYakinKenariBulduMu = c_NavMeshAgent.FindClosestEdge(out m_NavmeshHit);
            if (EnYakinKenariBulduMu)
            {

                c_NavMeshAgent.SetDestination(m_NavmeshHit.position);
            }



        }

        */

        #endregion


        #region 6 ) NavMeshAgent.desiredVelocity

        /*

        Kaçýnmadan kaynaklanan herhangi bir potansiyel katký dahil olmak üzere ajanýn istenen HIZI.

        SADECE   Get iþlemi yapýlabilir.

        Vector3 olarak döner.

        
        Debug.Log(c_NavMeshAgent.desiredVelocity); 

        SADECE GET ÝÞLEMÝ YAPILDIÐI için istenen hýzý varsayýlan olarak kullanýlýr.Varsayýlan olarak istenen hýzýmýz
         (0,0,0) ' mýþ !!!!!!!!!!

        */

        #endregion


        #region 7 ) NavMeshAgent.destination ** 

        /*
          
        destination : VARIÞ NOKTASI 


      *  Ajanýn hedefini dünya - uzay birimlerinde alýr veya ayarlamaya çalýþýr.

      *  Bu aracý için hedef kümesini döndürür.

      *  Bir hedef ayarlanmýþ ancak yol HENÜZ ÝÞLENMEMÝÞSE döndürülen konum önceden ayarlanan konuma en yakýn olan geçerli
         NavMesh konumu OLUR.
 
      *  Aracýnýn yolu veya istenen yolu yoksa aracýlarýn NavMesh üzerindeki konumunu döndürür.
      
      *  Aracý NavMesh ile eþlenmemiþse ( Örneðin Scene NavMesh ' e SAHÝP DEÐÝL . )  sonsuzda bir pozisyon döndürür.

      *  Aracýdan, istenen hedefe EN YAKIN geçerli Nav Mesh ( Gezinme aðý ) konumuna hareket etmesini ister.
     
      * Yol sonucu ,  birkaç kare sonrasýna kadar mevcut olmayabilir. Olanaðüstü sonuçlarý sorgulamak için pathPending 'i 
        kullanýn.
      
      * Yakýnlarda geçerli bir gezinme konumu bulmak mümkün deðilse ( Örneðin  sahnede Gezinme Aðý ( Nav Mesh ) yok ) yol 
         istenmez.

        Bu durumu daha detaylý anlamak istiyorsanýz SetDestination () metoduna  bakýn..
      
        Documentation 'daki KODLARA MUTLAKA BAK YOKSA ANLAMAZSIN !!!!!!!!!!!!!!!!

        */

        #endregion


        #region 8 ) NavMeshAgent.GetAreaCost ( )


        /*

        Get Area Cost : Alan Maliyetini Al.

        Belirli bir türdeki alanlý geçerken yol hesaplama maliyetini alýr.

        Bir yolun maliyeti onu hesaplamanýn içerdiði  ZORLUK miktarýdýr.En kýsa yol : Çamur, kar, kar vb... gibi zorlu zeminlerin
        üzerinden geçiyorsa EN ÝYÝSÝ OLMAYABÝLÝR.

        Belirli bir alanýn maliyeti mesafe birimi baþýna maliyet birimlerinde verilir.

        Bir yolun maliyetinin YALNIZCA YOL BULMA için geçerli olduðunu ve yolu takip ederken aracýn hareket hýzýný ETKÝLEMEZ !!!
      

        Gerçekten de yolun maliyeti tehlike ( mayýn tarlasýnda güvenli ancak uzun yol ) veya görünürlük ( bir karakteri 
        gölgede tutan uzun yol ) gibi diðer faktörleri gösterebilir.


        float AlanMaliyeti = c_NavMeshAgent.GetAreaCost(0);
        Debug.Log(AlanMaliyeti); // BElirlediðim Nav Mesh alanýna göre ALAN MALÝYETÝ 1 MÝÞ !!!

        */

        #endregion


        #region 9 ) NavMeshAgent.hasPath **

        /*

        Karakterinin þuanda bir YOLU VAR MI ?

        Bu özellik, aracýnýn istenen hedefe hesaplanan bir yolu varsa TRUE  aksi takdirde FALSE dönecektir.

        
        bool YolVarmi = c_NavMeshAgent.hasPath;
        Debug.Log(YolVarmi);

        */

        #endregion


        #region 10 ) NavMeshAgent.isActiveAndEnabled

        //   Debug.Log(c_NavMeshAgent.isActiveAndEnabled);  true döndü


        #endregion


        #region 11 ) NavMeshAgent.isOnNavMesh

        /*
         
        Karakter þuanda NavMesh( Gezebildiðimiz alana )  baðlý mý ?

        Karakter herhangi bir nedenle NavMesh'e ( Gezebildiðimiz alana ) baðlanamazsa FALSE DÖNER.
        Örneðin Scene'de NavMesh ( Gezebildiðimiz Alan ) YOKSA.

        


        bool NavMeshYaniGezebildigimizAlanVarMi = c_NavMeshAgent.isOnNavMesh;
        Debug.Log(NavMeshYaniGezebildigimizAlanVarMi);

        TRUE döndü çünkü sahneme NavMesh ( Gezebildiðim alan ) ayarlamýþtým.
       
        */

        #endregion


        #region 12 ) NavMeshAgent.isOnOffMeshLink TAM ANLAMADIN

        /*
         
         Off Mesh Link : Að dýþý baðlantý.

        Temsilci þuanda bir OffMeshLink'te ( Að dýþý baðlantýda) MÝ  KONUMLANDI ?

        Bu özellik , autoTraverseOffMeshLink ( Að dýþý baðlantýdayken otomatik geçiþ. )  YANLIÞ olduðunda ve baðlantýyý 
        geçerken ÖZEL HAREKET GEREKTÝÐÝNDE KULLANIÞLIDIR ! ! !


        


        bool A = c_NavMeshAgent.isOnOffMeshLink;

        Debug.Log(A);

        */

        #endregion


        #region 13 ) NavMeshAgent.isPathStale

        /*

        Geçerli yol eski mi ?

        Eðer true dönerse yani yol eskiyse, yol artýk geçerli veya optimal olmayabilir. 

        Bu bayrak þu durumlarda ayarlanýr : fieldMask ' te herhangi bir deðiþiklik varsa, herhangi bir OffMeshLink etkinleþ-
        tirildiyse veya devre dýþý býrakýldýysa veya NavMeshAreas maliyetleri deðiþtiyse.

        

        bool mevcutYolEskiMi = c_NavMeshAgent.isPathStale;
        Debug.Log(mevcutYolEskiMi);

        False döndü yani yolumuz eski DEÐÝL. Çünkü Gezindiðim alanda bir deðiþiklik yapmadým ve alan  maliyetler deðiþmedi.

        */


        #endregion


        #region 14 ) NavMeshAgent.isStopped **


        /*
          
        is Stopped :  Karakter Durdu mu veya durduruldu mu ?

        Bu özellik NavMesh karakterinin durdurma veya devam ettirme koþulunu tutar.

        TRUE olarak ayarlanýrsa , NavMesh karakterinin  hareketi  yol boyunca durdurulur.

        NavMesh karakteri durduktan sonra FALSE olarak ayarlanýrsa  karakter hareket etmeye DEVAM EDER.

        Get ve Set iþlemi yapýlabilir.

        
        bool KarakterDurdumu = c_NavMeshAgent.isStopped;
        Debug.Log(KarakterDurdumu);

       */

        #endregion


        #region 15 ) NavMeshAgent.Move ( ) **


        /*
         
          Move   : Taþýnmak

          offset : Göreceli HAREKET VEKTÖRÜ
          
          Geçerli konuma, göreli hareketi uygulayýn. Aracýnýn bir yolu varsa , ayarlanacaktýr.

          Yani Karakterimizi NavMesh'de ( Gezinebildiðimiz Alanda )  KONUMUNU DEÐÝÞTÝREBÝLMEMÝZÝ SAÐLAR.

        
        Vector3 offset = new Vector3(10f, 10f, 0f);
        c_NavMeshAgent.Move(offset);


        */

        #endregion


        #region 16 ) NavMeshAgent.navMeshOwner

        /*

        Nav Mesh Owner : Gezebildiðimiz alanýn sahibi 

        Gezebildiðimiz alanýn sahibi kimse onu döndürür.

        Bir Nav Mesh veya baðlantý örneði için hiçbir sahip ayarlanmamýþsa, dönüþ deðeri null olur.

        Sadece Get iþlemi yapýlabilir. YANÝ BU ÖZELLÝK BÝZE BÝR ÞEY ( DEÐER,FLOAT,STRÝNG BOOL ) VERÝR.

        */





        #endregion


        #region 17 ) NavMeshAgent.nextOffMeshLinkData


        /*

        next off Mesh Link Data : Sonraki að baðlantýsý verileri

        Geçerli yoldaki sonraki Kapalý að baðlantý verilerini YAKALAR.

        Geçerli yolun bir OffMeshLink içermemesi durumunda OffMeshLinkData GEÇERSÝZ OLARAK iþaretlenir.

        
        c_NavMeshAgent.nextOffMeshLinkData

        */

        #endregion


        #region 18 ) NavMeshAgent.nextPosition **


        /*

        Nav Mesh'e  ( Gezebildiðim Alana )  SAHÝP karakterin simülasyon KONUMUNU alýr veya ayarlar.

        Konum vektörü dünya uzay koordinatlarýnda ve birimlerindedir. 

        nexPosition, Transform.position ile birleþtirilir. Varsayýlan durumda , navmesh aracýsýnýn Dönüþtürme konumu, komut
        dosyasý güncelleme iþlevi çaðrýldýðýnda dahili simülasyon konumuyla eþleþir.

        Bu baðlantý updatePosition(BOOL deðer döndürür ) ayarlanarak açýlýp kapatýlabilir. updatePosition true olduðunda,
        Transform.position  benzetilmiþ konumu yansýtýr. false olduðunda, dönüþümün konumu ve navmesh KARAKTERÝ senkronize 
        edilmez ve genel olarak ikisi arasýnda bir FARK görürsünüz.

        updatePosition tekrar açýldýðýnda, Transform.position nextPosition ile eþleþecek þekilde hemen taþýnýr.

        nextPosition'ý ayarlayarak, dahili aracý konumunun nerede olmasý gerektiðini DOÐRUDAN KONTROL EDEBÝLÝRSÝNÝZ !!!!!!!!

        Aracý konuma doðru hareket edecek, ancak NavMesh baðlantýsý ve sýnýrlarý tarafýndan kýsýtlandý. Bu nedenle , yalnýzca
        pozisyonlarýn sürekli olarak güncellenmesi ve deðerlendirilmesi durumunda faydalý olacaktýr.


        Get ve Set iþlemi yapýlabilir.

        DOCUMENTATÝON 'DAKÝ KODLARA MUTLAKA AMA MUTLAKA BAK ÇOK DAHA ÝYÝ ANLAYACAKSIN BU ÖZELLÝÐÝ.ÇÜNKÜ BU ÖZELLÝK ÖNEMLÝ
        BÝR ÖZELLÝK  !  !  !

       


        Debug.Log(c_NavMeshAgent.nextPosition);

        Vector3 KarakterimGelecekKonumuSuOlsun = new Vector3(-5f, 0f, 60f);
        c_NavMeshAgent.nextPosition = KarakterimGelecekKonumuSuOlsun;
            
        */

        #endregion


        #region 19 ) NavMeshAgent.obstacleAvoidanceType **

        /*

        obstacle Avoidance Type : Engellerden kaçýnma türü

        Kaçýnmanýn KALÝTE düzeyi.

        Bu özellik, engelden KAÇINMA HASSASÝYETÝNÝ, bunu baþarmak için gereken iþlemci yüküne karþý takas etmenizi saðlar.
        Kesin kalite/performans deðerleri büyük ölçüde sahnenin karmaþýklýðýna baðlý olacaktýr.

        Ancak genel bir kural olarak , kalite pahasýna daha hýzlý performans elde edilebilir ve bunun terside geçerlidir.

        Get ve Set iþlemi yapýlabilir.

       

          Debug.Log(c_NavMeshAgent.obstacleAvoidanceType);

         UNÝTY VARSAYILAN OLARAK ENGELLERDEN KAÇINMA TÜRÜNÜ YÜKSEK KALÝTEDE ENGELLERDEN KAÇMA OLARAK( HighQualityObstacleAvoidance)
         SEÇMÝÞ.


        c_NavMeshAgent.obstacleAvoidanceType = ObstacleAvoidanceType.LowQualityObstacleAvoidance;

         Gördüðün gibi Set iþlemini yaptýk.Yani ENGELLERDEN KAÇMA TÜRÜ DÜÞÜK KALÝTEDE ENGELLERDEN KAÇSIN DEMÝÞ OLDUK ! ! !

        */

        #endregion


        #region 20 ) NavMeshAgent.path **


        /*

        path : yol

        Geçerli YOLU almak ve ayarlamak için kullandýðýmýz bir özelliktir.

        Bu özellik navigasyon sistemi tarafýndan hesaplanan yolun noktalarýný almak için GUI, hata ayýklama ve diðer amaçlar 
        faydalý olabilir.

        Ek olarak, Karakterin olaðan bir þekilde yolu izlemesi için kullanýcý KODUNDAN  OLUÞTURULAN BÝR YOL AYARLANABÝLÝR.
        Bunun bir örneði, iki nokta arasýndaki optimal mesafeden ziyade kapsama için tasarlanmýþ bir devriye rotasý olabilir.

        Get ve Set iþlemi yapýlabilir.

        

        Debug.Log(c_NavMeshAgent.path);


         Yeni bir yol ayarlayabilmen için :
         http ://answers.unity.com/questions/1579461/how-to-set-navmeshagent-path-with-vector3.html Sitesinde 2 kiþi
         uzun uzun kodlarla ve açýklamalarla anlatmýþ bu siteye git ve ANLAMAYA ÇALIÞ ! ! !

        */

        #endregion


        #region 21 ) NavMeshAgent.pathEndPosition **

        /*

        Karakterimin son Pozisyonunun ( Vector3 ) deðerini yakalar.

        SADECE GET ÝÞLEMÝ YAPILABÝLÝR.

        

        Debug.Log(c_NavMeshAgent.pathEndPosition);

        Vector3 KarakterinSonPozisyonu = c_NavMeshAgent.pathEndPosition;
        TryObject.gameObject.transform.position = KarakterinSonPozisyonu + new Vector3(1f,0f,0f);

         Yani KARAKTERÝM nereye giderse TryObject objeside onunla beraber gidecek çünkü öyle ayarladým.

        */

        #endregion


        #region 22 ) NavMeshAgent.pathPending

        /*

        path Pending : Yol beklemede

        Hesaplanma sürecinde olan ancak henüz hazýr olmayan bir yol mu ?

        
        bool YolHazirDegilMi = c_NavMeshAgent.pathPending;
        Debug.Log(YolHazirDegilMi); 

       False döndü yani YOLUMUZ HAZIRMIÞ !!!


        */
        #endregion


        #region 23 ) NavMeshAgent.pathStatus

        /*

        path status : Yolun durumu

        Geçerli yolun durumu ( Tamamlanmýþ , kýsmi, veya geçersiz )

        SADECE GET iþlemi  yapýlýr ! ! !

       

        Debug.Log(c_NavMeshAgent.pathStatus);

         PathComplete döndü YANÝ YOL HEDEFTE SONA ERER. 

         Bu konuyu daha iyi  anlaman için 3 'üncü sýraya geri dön bak orda daha detaylý bir anlatým var.


        */

        #endregion


        #region 24 ) NavMeshAgent.Raycast ( ) **


        /*

        targetPosition : Ýstenen hareketin son konumu
        hit            : Iþýn tarafýndan tespit edilen engelin özellikleri
        

        Ajan ile hedef arasýnda bir ENGEL VARSA TRUE, ENGEL YOKSA FALSE döner.

        Karakteri hareket ettirmeden Nav Mesh ' te bir hedef konuma doðru düz bir yol izleyin.

        Bu iþlev, karekterin ( Ajanýnýn ) konumu ile belirtilen hedef konumu arasýndaki bir IÞIN yolunu izler.

        Hat boyunca bir engelle karþýlaþýrsa, gerçek bir deðer döndürülür ve engelleyici nesnenin konumu ve diðer ayrýntýlarý
        hit parametresinde saklanýr.

        Bu, bir karakter ile hedef nesne arasýnda bir net bir atýþ veya görüþ hattý olup olmadýðýný kontrol etmek için 
        kullanýlabilir.

        Bu iþlev, benzer Physics.Raycast'e TERCÝH EDÝLÝR ÇÜNKÜ  çizgi izleme, Nav Mesh kullanýlarak daha BASÝT  bir þekilde
        gerçekleþtirilir ve DAHA DÜÞÜK BÝR ÝÞLEM YÜKÜNE sahiptir ! ! !


        
        NavMeshHit m_NavMeshHit;



         bool AjanimIleHedefiminArasindaEngelVarmi = c_NavMeshAgent.Raycast(TargetObject.gameObject.transform.position, out m_NavMeshHit);

     

            if (AjanimIleHedefiminArasindaEngelVarmi == false)
            {
                gameObject.transform.position =m_NavMeshHit. position;
            }

            */


        #endregion


        #region 25 ) NavMeshAgent.ResetPath ( )


        /*

        Geçerli yolu TEMÝZLER.

        Yol temizlendiðinde, aracý SetDestination çaðrýlana kadar yeni bir yol aramaya baþlamaz.

        Bu iþlev çaðrýldýðýnda aracý bir OffMeshLink ( Kapalý Að baðlantýsý ) üzerindeyse, baðlantýyý hemen tamamlayacaðýný
        unutmayýn.



        c_NavMeshAgent.ResetPath();

        */

        #endregion


        #region 26 ) NavMeshAgent.SamplePathPosition ( ) **

        /*

        Sample Path Position : Örnek yol konumu

        areaMask    : Yol izlenirken hangi NavMesh alanlarýnýn geçilebileceðini belirten bir bit alaný maskesi.
        maxDÝstance : Yolu bu mesafeden taramayý sonlandýrýn.
        hit         : Ortaya çýkan konumun özelliklerini tutar.


        maxDistance'daki konuma ulaþmadan önce sonlandýrýlýrsa True döner aksi halde false döner.

        Geçerli yol boyunca bir konumu örnekler.

        Bu iþlev, karakter yolun ilerisindeki konuma ulaþmadan önceden bakmaya ve kontrol etmeye yarar. Bu konumdaki aðýn 
        ayrýntýlarý daha sonra bir NavMeshHit nesnesinde döndürülür.Bu örneðin, karakter oraya ulaþmadan önce önündeki yüzeyin 
        türünü kontrol etmek için kullanýlabilir.
        Örneðin karakter suda yürümek üzereyse silahýný baþýnýn üzerinde kaldýrabilir.

        DOCUMENTATÝON' daki KODLARA bak daha iyi anlarsýn....

        */


        #endregion


        #region 27 ) NavMeshAgent.SetAreaCost ( )



        /*

        Set Area Cost : Alan maliyetini Ayarla

        areaIndex : Alan Maliyeti
        areaCost  : Belirtilen alan dizini için yeni maliyet

        Alan türündeki alanlar üzerinden geçiþ maliyetini ayarlar.

        Aracýyý ( KArakteri ) etkinleþtirir veya devre dýþý býrakýrsanýz , maliyet varsyýlan katman maliyetine sýfýrlanýr.

        */


        #endregion


        #region 28 ) NavMeshAgent.SetDestination ( ) **

        /*

        target : Varýlmasý beklenen HEDEF NOKTA

        Hedef baþarýyla istendiyse True, aksi takdirde false döner.

        Hedefi ayarlar veya günceller, böylece yeni bir yol için hesaplamayý tetikler.

        Yolun birkaç kare sonrasýna kadar kullanýlabilir hale gelmeyebileceðini unutmayýn. Yol hesaplanýrken pathPending özelliði
        true olacaktýr.

        Geçerli bir yol kullanýlabilir hale gelirse, KARAKTER harekete  devam edecektir.

        

         c_NavMeshAgent.SetDestination(TargetObject.transform.position);


        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {

                c_NavMeshAgent.SetDestination(hit.point);
            }
        }


         YANÝ GÖRDÜÐÜN GÝBÝ EKRANDA  TIKLADIÐIN HER YERE EKSÝKSÝZ MANTIKLI BÝR ÞEKÝLDE KARAKTERÝM GÝDÝYOR ! ! ! ! !


        */

        #endregion


        #region 29 ) NavMeshAgent.SetPath ( )

        /*

        path : Ýzlenecek yeni yol

        Yol baþarýyla atanmýþsa true döner.

        Karaktere, YENÝ bir yol atar.

        Yol baþarýyla atanýrsa ajan yeni hedefe doðru harekete devam edecektir. Yol atanamazsa, yol temizlenir.

        

        NavMeshPath pathim = new NavMeshPath();
        NavMesh.CalculatePath(transform.position, TargetObject.transform.position, NavMesh.AllAreas, pathim);

        c_NavMeshAgent.SetPath(pathim);

        Google 'da araþtýrma yapýp https//forum.unity.com/threads/navmeshagent-setpath-doesnt-seem-to-work-properly.553558/ 
        bu siteye girip burdaki kodlarý incele daha iyi anlarsýn ! ! !


        */

        #endregion


        #region 30 ) NavMeshAgent.steeringTarget **

        /*

        steering target : Yönlendirme Hedefi

        Yol boyunca mevcut yönlendirme hedefini alýn.

        Bu genellikle yol boyunca bir sonraki KÖÞE veya yolun BÝTÝÞ NOKTASIDIR.

        Karakter bir OffMeshLink ( Kapalý að baðlantýsý ) üzerinde hareket ETMÝYORSA, karakter ve Yönlendirme Hedefi arasýnda
        düz bir yol vardýr.

        Geçiþ için bir OffMeshLink  ' e ( Kapalý að baðlantýsý ) 'na yaklaþýrken DEÐER karakterin baðlantýya gireceði konumdur.
        Karakter bir OffMeshLink ( Kapalý að baðlantýsý ) üzerinden geçerken DEÐER , karakterin baðlantýdan ayrýlacaðý konumdur.

        Vector3 döner.

        Sadece GET iþlemi yapýlýr.

        
        Debug.Log(c_NavMeshAgent.steeringTarget);

        */

        #endregion


        #region 31 ) NavMeshAgent.updatePosition

        /*

      update Position : Güncelleme konumu

      transform.position : Dönüþtürme konumu 

      Dönüþtürme konumunun benzetilmiþ KARAKTER ( aracý ) konumuyla eþitlenip eþitlenmediðini alýr veya ayarlar. Varsayýlan deðer
      DOÐRUDUR !

      Doðru olduðunda : dönüþtürme konumunun deðiþtirilmesi benzetilmiþ konumu etkiler ve bunun tersi de geçerlidir.

      Yanlýþ olduðunda : simüle edilen konum, dönüþtürme konumuna uygulanmaz ve bunun tersi de geçerlidir.

        updatePosition öðesini FALSE olarak ayarlamak, dönüþtürme konumunun komut dosyasý aracýlýðýyla açýk bir þekilde 
        denetlenmesini saðlamak için kullanýlabilir. Bu baþka bir bileþeni sürmek için aracýnýn benzetilmiþ konumunu kullanmanýza
        olanak tanýr. Bu da dönüþüm konumunu ayarlar.( örneðin kök hareketi veya fizik ile animasyon ).

        updatePosition etkinleþtirilirken ( önceden devre dýþý býrakýldýðýndan ) dönüþüm simüle edilen konuma taþýnacaktýr.
        Bu þekilde ajan, navmesh yüzeyiyle sýnýrlý kalýr ! ! ! ! ! ! ! ! ! ! ! ! ! ! ! ! ! !

        bool bir deðer döndürür.

        Get ve Set iþlemi yapýlabilir.

        


        Debug.Log(c_NavMeshAgent.updatePosition); // VARSAYILAN OLARak TRUE deðerini döndürdü.

        */

        #endregion


        #region 32 ) NavMeshAgent.updateRotation


        /*

        Karakter( Aracý ) dönüþtürme oryantasyonunu güncellemeli mi ?

        Get ve Set iþlemi yapýlabilir.

        

        Debug.Log(c_NavMeshAgent.updateRotation); // VARSAYILAN olarak TRUE deðerini döndürdü.

        */

        #endregion


        #region 33 ) NavMeshAgent.updateUpAxis

        /*

        Karakterin ( Aracýnýn ) yerleþtirildiði NavMesh 'in veya baðlantýnýn yukarý eksenine hizalanmasý gerekip gerekmediðini 
        belirlemenizi saðlar.

        Bu deðer true olarak ayarlandýðýnda  KARAKTER ( Aracý ) her zaman NavMesh 'in veya þuanda üzerinde olduðu baðlantýnýn
        yerel YUKARI  eksenine hizalanýr. Yanlýþ olarak ayarlandýðýnda  Karakterin ( aracýnýn ) yönü NavMesh 'in yöneliminden
        etkilenmez.



        Debug.Log(c_NavMeshAgent.updateUpAxis); VARSAYILAN olarak TRUE deðerini döndürdü. Yani Karakter NavMesh 'in YUKARI
                                                eksenine OTOMATÝK olarak ayarlanmýþ.


        */


        #endregion


        #region 34 ) NavMeshAgent.velocity **


        /*

        NavMeshAgent bileþeninin mevcut hýzýna eriþin veya Karakteri ( Aracýyý ) manuel olarak kontrol etmek için bir HIZ
        ayarlayýn.

        Deðiþkeni okumak, kalabalýk simülasyonuna dayalý olarak aracýnýn mevcut hýzýný döndürür.

        Deðiþkenin ayarlanmasý simülasyonu geçersiz kýlar.( Hedefe doðru hareket etme, çarpýþmadan kaçýnma ve hýzlanma kontrolü
        dahil .) NavMesh Karakterine ( Aracýsýna ) doðrudan belirttiðin  HIZI kullanarak hareket etmesi için komut verir.

        Ajan bir hýz kullanarak KONTROL EDÝLDÝÐÝNDE hareketi hala NavMesh üzerinde KISITLIDIR.

        Hýzý doðrudan ayarlamak , NavMesh üzerinde hareket eden ve simüle eden kalabalýðýn geri kalanýný etkileyen oyuncu 
        karakterlerini uygulamak için kullanýlabilir.Ek olarak önceliði yüksek olarak ayarlamak ( küçük bir deðer daha yüksek
        önceliktir.) Diðer simüle edilmiþ ajanlarýn oyuncu kontrollü ajandan daha da hevesli bir þekilde kaçýnmasýný saðlayacak-
        týr.

        KARAKTERÝ ( Aracýyý ) MANUEL olarak KONTROL ederken hýzýn HER KAREDE ayarlanmasý ve KONTROLÜ simülasyona býrakýyorsanýz
        hýzý SIFIRA ayarlamanýz önerilir ! ! !

        Aracýnýn hýzý bir deðere ayarlanýr ve ardýndan güncellemeyi durdurursa, simülasyon oradan baþlar ve Karakter ( Aracý ) 
        YAVAÞ YAVAÞ YAVAÞLAR. ( HEDEFÝN AYARLANMADIÐI VARSAYIYORUZ ! )

        Hýzý okumanýn her zaman simülasyondan deðer getireceðini unutmayýn.Deðer AYARLARSANIZ , efekt bir sonraki güncellemede
        görünecektir. Döndürülen hýz simülasyondan geldiðinden ( Kaçýnma ve Çarpýþma yöntemi dahil ) ayarladýðýnýzdan FARKLI
        OLABÝLÝR !

        Hýz saniyedeki uzaklýk birimleriyle ( Fizikte olduðu gibi ) belirtilir ve küresel koordinat sisteminde temsil edilir.

        GET ve SET iþlemi yapýlabilir.

        

     1 . DURUM =  Hýzý Unity 'nin KONTRÜLÜNE  BIRAKTIÐIMIZDA HIZIN DEÐERLERÝ  :

        c_NavMeshAgent.SetDestination(TargetObject.transform.position);
        Debug.Log(c_NavMeshAgent.velocity);

         YANÝÝÝÝÝÝ Karakterimiz hýzý  HEDEF objeyi takip ederken OTOMATÝK ( UNÝTY TARAFINDAN BELÝRLENMÝÞ ) bir þekilde hýzlarý
         YAKLAÞIK OLARAK þu aralýk ta oluyor :

         ( Vector3 =

            x yönündeki hýzý : -2 ile 2 arasýnda 

            y yönündeki hýzý : 0
            
            z yönündeki hýzý -3.5 ile 3.5 arasýnda DEÐÝÞÝYOR 

          )

     2. DURUM : Hýzý Bizim MANUEL olarak ayarladýðýmýzda HIZIN DEÐERLERÝ : 

        c_NavMeshAgent.SetDestination(TargetObject.transform.position);
        c_NavMeshAgent.velocity = new Vector3(0.1f,0f,5f);

        Debug.Log(c_NavMeshAgent.velocity);

        HIZ manuel olarak belirlediðimiz deðerlerde çalýþýyor evet ancak belirledigimiz hedefe GÝTMÝYOR belirledðimiz vektör
        hýzlarýna baðlý kaldýðý için karakterimiz  FARKLI YÖNLERDE HEDEFE GÝDÝYOR. 


        YANÝ!!!!!! HIZI MANUEL OLARAK AYARLAMA ( Set iþlemi yapma yani )  SANA TAVSÝYEM ÇÜNKÜ oyunlardaki bu yapay zeka 
        sisteminde  Karakterimiz HEDEFE MANTIKLI VE DÜZGÜN bir þekilde gitmelidir !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!

        */

        #endregion


        #region 35 ) NavMeshAgent.Warp ( ) **

        /*

        Warp : Saptýrmak

        newPosition : Ajaný saptýrmak için yeni pozisyon

        Karakter ( Aracý )  baþarýyla saptýrýlýrsa True , aksi takdirde false döner.

        

        c_NavMeshAgent.SetDestination(TargetObject.transform.position);
          Debug.Log(   c_NavMeshAgent.Warp(TryObject.transform.position)); Karakterim DÝREK TryObject objesinin yanýna gidiyor.


        c_NavMeshAgent.SetDestination(TargetObject.transform.position);
        c_NavMeshAgent.Warp(new Vector3(0.1f, 0f, 0f)); // Karakterim direk olarak dünya üzerindeki x = 0.1f konumuna gitti.

        */



        #endregion



        #endregion




        #region Video Scripti çaðrýþým yapar belki bir konu hakkýnda burda dursun
        
     /*

        void Update()
        {

            if (Input.GetMouseButtonDown(0))
            {
                ClickToOffset();
            }


            if (Vector3.Distance(c_NavMeshAgent.destination, gameObject.transform.position) <= c_NavMeshAgent.stoppingDistance)
            {
                m_Anim.SetBool("IsRun", false);

                
                 Yani ekrana dokunduðumda karakterim dokunduðum yere gidiyor ya ( destination : Varýþ noktasý)
                 Varýþ noktamla( Varýþ noktasýndakide karakterin KARIÞTIRMA ) YÝNE    karakterimin pozisyonu 
                 arasýndaki mesafe ajanýn hedefe durma mesafesinde eþit ve küçükse  KOÞMA ANÝMASYONU DURSUN IDLE GEÇSÝN DEMÝÞ
                 OLDUK !!!!!!!!!!!

                
            }





        }

        void ClickToOffset()
        {

            // ScreenToWorldPoint : Dünya noktasýnda ekran

            // ScreenPointToRay : Ray ( ýþýn ) için EKRAN noktasý

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            bool Hashit = Physics.Raycast(ray, out hit);

            if (Hashit)
            {
                FunctionSetDestination(hit.point);
            }

        }

        void FunctionSetDestination(Vector3 target)
        {
            m_Anim.SetBool("IsRun", true);
            c_NavMeshAgent.SetDestination(target);
        }

    */

        #endregion



    }


}
