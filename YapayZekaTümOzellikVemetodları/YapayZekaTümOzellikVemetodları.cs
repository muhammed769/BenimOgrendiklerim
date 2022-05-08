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



        #region Inspector'da Component 'te haz�r olan gelen �zellikler



        #region  1 ) NavMeshAgent.acceleration

        /*  Karakterimizin  maksimum ivmesidir. Speed De�eriyle orant�l� olmal�d�r.
            Get ve Set i�lemi yap�labilir.

        Debug.Log(c_NavMeshAgent.acceleration);

        */

        #endregion


        #region 2 )  NavMeshAgent.angularSpeed

        /*

        Bir yolu takip ederken ( DERECE / SN ) cinsinden maksimum D�N�� HIZIDIR. ( A�ISAL HIZIDIR. )

        Karakterin bir yol noktas� taraf�ndan tna�mlanan  '' K��EY� '' D�NERKEN  d�nebilece�i MAKS�MUM HIZIDIR. 

        Ger�ek d�n�� �emberi ayr�ca arac�n yakla�madaki h�z�ndan ve ayr�ca maksimum h�zlanmadan da etkilenir.

        Get ve Set i�lemi yap�labilir.

        */


        #endregion


        #region 3 ) NavMeshAgent.areaMask

        /* c_NavMeshAgent.areaMask

              Herhangi bir b�lgeyi maskelememizi sa�lar. Yani ajan�n hangi b�lgelere gidip gidemeyece�ini se�ti�imiz yerdir.
              Get ve Set i�lemi yap�labilir. */

        #endregion


        #region 4 ) NavMeshAgent.autoBraking

        /*

        c_NavMeshAgent.autoBraking

        OTOMAT�K FREN ayar�d�r.

        Arac�n�n var�� noktas�na yak�n bir yere inmesi gerekiyorsa, hedef b�lge etraf�nda a��r�ya ka�maktan veya sonsuz 
        "y�r�ngeden" ka��nmak i�in tipik olarak fren yapmas� gerekir. Bu �zellik true olarak ayarlan�rsa, arac� hedefe 
        yakla�t���nda otomatik olarak fren yapar.

        Get ve Set i�lemi yap�labilir.

            */

        #endregion


        #region 5 ) NavMeshAgent.autoRepath

        /*
        c_NavMeshAgent.autoRepath =true

            // Ajan k�smi bir yolun sonuna geldi�inde yolu BULMAYA  �al���r.AKT�F OLMALIDIR.

            // Get ve Set i�lemi yap�labilir.
        */

        #endregion


        #region 6 ) NavMeshAgent.autoTraverseOffMeshLink

        /*
         
        autoTraverseOffMeshLink :  //  A� d��� ba�lant�dan otomatik ge�i�

        A� d��� ba�lant�lar NavMesh'in AYRIK b�lgelerini ba�lamak i�in kullan�l�r.

        Genellikle karakter OTOMAT�K olarak ba�lant�lardan ge�ebilmelidir. Bu �zellik TRUE olarak ayarlan�rsa ger�ekle�ir.
        Ancak hareket �zerinde �ZEL KONTROL�N gerekli oldu�u durumlarda FALSE olarak da ayarlanabilir.

        */

        #endregion


        #region 7 ) NavMeshAgent.avoidancePriority

        /*
         
        avoidance Priority : KA�INMA �NCEL���

        Get ve Set i�lemi yap�labilir.

        Ka��nma s�ras�nda �nceli�i burdan belirleriz. Yani burdaki de�eri D���K OLAN AJAN EN �NEML� �NCEL���E sahip olan ajan 
        olur.

        Ge�erli aral�k 0 �LE 99 ARASINDADIR.

        YAN���  HEDEF OBJEM�Z� HANG� AJANIN DAHA YAKINDAN HANG�S�N�N DAHA UZAKTAN TAK�P ETMES�N� BURDAN BEL�RLEYEB�L�YORUZ.


        c_NavMeshAgent.avoidancePriority=50;

       */

        #endregion


        #region 8 ) NavMeshAgent.baseOffset

        /*
         
        offset : �telemek, kayd�rmak

        Sahip olan objenin g�reli D�KEY YER DE���T�RMES�.

        Ajan�n kendine ait olan �arp��ma �ap�.

        Get ve Set i�lemi yap�labilir.

        

        c_NavMeshAgent.baseOffset = 0.5f;

        */

        #endregion


        #region 9 ) NavMeshAgent.height

        /*

        Engellerin alt�ndan ge�mek i�in etkenin y�ksekli�i.

        YAN� Ajan�n engele �arpma y�kseli�idir.

        Get ve Set i�lemi yap�labilir.

        */


        #endregion


        #region 10 ) NavMeshAgent.radius

        /*

        Ajan�ma engellerin ve di�er ajanlar�n  ge�ebilme veyahut ge�ememe mesafesidir.
        �rne�in Radiusu FAZLA ayarlarsan engeller veya di�er ajanlar ANA AJANIMA yak�nla�salar bile �OK UZAK DURURLAR ��NK�
        Radius fazla oldu�u i�in daha fazla YAKLA�AMAZLAR !!!

        Get ve Set i�lemi yap�labilir.

        

        Debug.Log(c_NavMeshAgent.radius);

        */

        #endregion


        #region 11 ) NavMeshAgent.speed

        /*

        Bir yolu takip ederken maksimum hareket h�z�d�r.

        Bir arac� bir yolu takip ederken tipik olarak h�zlanmas� ve yava�lamas� gerekir.H�z genellikle bir yol par�as�n�n 
        uzunlu�u ve h�zlanma ve frenleme i�in ge�en s�re ile s�n�rl�d�r, ancak h�z,uzun d�z bir yolda bile bu �zellik taraf�ndan
        ayarlanan de�eri a�amaz.

        Get ve Set i�lemi yap�labilir.

        
        c_NavMeshAgent.speed = 2f;

        */


        #endregion


        #region 12 ) NavMeshAgent.stoppingDistance

        /*

        Durma mesafesidir.Yani ajan�n HEDEFE ne kadar mesafede duraca��n� belirtti�imiz yerdir.

        Tam olarak hedef noktaya inmek nadiren m�mk�nd�r, bu nedenle bu �zellik, ajan�n i�inde durmas� gereken kabul edilebilir
        bir yar��ap ayarlamak i�in kullan�labilir. Daha b�y�k bir durma mesafesi , arac�ya yolun sonuna manevra i�in daha 
        fazla alan sa�layacak ve ani frenleme , d�n�� veya ve di�er ikna edici olmayan AI davran��lar�ndan ka��nabilir.

        Get ve Set i�lemi yap�labilir.

        

        c_NavMeshAgent.stoppingDistance = 2f;

        */

        #endregion




        #endregion



        #region Inspector'da Component 'te OLMAYAN �ZELL�K VE METOTLAR !!!!!!!!!!!!!!



        #region 1 ) NavMeshAgent.ActivateCurrentOffMeshLink () 


        /* c_NavMeshAgent.ActivateCurrentOffMeshLink(true);

              // Ge�erli kapal� a� ba�lant�s�n� etkinle�tirir veya devre d��� b�rak�r. Yani a��p kapat�labilir.*/

        #endregion


        #region 2 ) NavMeshAgent.agentTypeID

        /* Debug.Log(c_NavMeshAgent.agentTypeID);

        Ajan tipinin kimlik numaras�d�r.Get ve Set i�lemi yap�labilir. */

        #endregion


        #region 3 ) c_NavMeshAgent.CalculatePath ( ) **

        /*

        Calculate Path : Yolu hesaplar


        targetPosition : �stenen yolun SON konumu
        path           : Ortaya ��kan yol

        Bool : Bir yol bulunursa True d�ner.


        Belirli bir noktaya giden yolu hesaplay�n ve elde edilen yolu saklay�n.

        1 ) Bu metodla bir yol gerekti�inde oyundaki gecikmeyi �NLEMEK i�in  �nceden bir yol planlamak i�in kullan�labilir.

        2 ) Bu metodla Ajan� hareket ettirmeden �nce HEDEF KONUMA ULA�ILAB�L�R OLUP OLMADI�INI kontrol etmek i�in kullan�labilir.

        

        c_NavMeshAgent.CalculatePath()

        NAVMESHPATH CLASS'INA G�D�P ORDAK� �ZELL�KLER� ANLAMAN LAZIM YOKSA BURDAK�LER�   ANLAMAZSIN !!!!!!!!!!!!!!!! 
      


      if (m_navmeshpath.status == NavMeshPathStatus.PathComplete)

        {

         YOL hedefte sona erdiyse bana �u i�lemleri yap ......

        }

      !!!!!!!!!!!!!!!!!!! �OK �NEML� OKU !!!!!!!!!!!!!!!!!!!

         BU KONUNUN DAHA NET ANLA�ILMASI ���N  TumYapayZekaKonularininScripti 'ne bakman laz�m ��nk� o scriptte
         V�DEO'DAN ARGE YAPTIN !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!


        */



        #endregion


        #region 3 ) 'le BA�LANTILI OLAN NavMeshPath CLASS'INDAK� �ZELL�K ve METOTLARIN A�IKLANMASI !!!!!

        /*

            Nav Mesh Path : Gezinme A�� yolu

         ************************************************************************************

          1 ) NavMeshPath.ClearCorners ()

          m_navmeshpath.ClearCorners(); // Yoldaki T�M K��E NOKTALARI siler.


          ************************************************************************************

   
         2 )  NavMeshPath.corners ( TAM ANLAMADIN )


          Yolun k��e nokta'LARI.
          Ara Noktalar olarak bilinen k��eler , bir yol boyunca y�n de�i�tirdi�i yerleri tan�mlar. ( Yani Yol k��eler aras�nda
          bir dizi d�z �izgi hareketinden olu�ur.

         SADECE Get i�lemi yap�labilir.


        ************************************************************************************

        

         3 ) NavMeshPath.GetCornersNonAlloc


         results : Yoldaki k��eleri depolamak i�in kullan�lan bir dizi

         int : Yol �zerindeki k��elerin say�s� ( ba�lang�� ve biti� noktalar� dahil.)

         Yolun k��elerini hesaplay�n.

         Bu metod, sonu�lar�n sa�lanan dizide d�nd�r�lmesi d���nda corners �zelli�ine benzer.

         Bu i�levin sa�lanan dizinin en az 2 ��eye sahip olmas�n� dikkat edin.

        ************************************************************************************

       

         4 ) NavMeshPath.status

         Nav Mesh Path status : Gezinme a�� yolu DURUMU 

             m_navmeshpath.status= NavMeshPathStatus.PathComplete // Yol hedefte SONA ERER.
             m_navmeshpath.status = NavMeshPathStatus.PathPartial // YOL HEDEFE ULA�AMAZ.
             m_navmeshpath.status = NavMeshPathStatus.PathInvalid // Yol GE�ERS�Z.

        ************************************************************************************

        !!!!!!!!!!!!!!!!!!! �OK �NEML� OKU !!!!!!!!!!!!!!!!!!!

         BU KONUNUN DAHA NET ANLA�ILMASI ���N  TumYapayZekaKonularininScripti 'ne bakman laz�m ��nk� o scriptte
         V�DEO'DAN ARGE YAPTIN !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!

      */

        #endregion


        #region 4 ) NavMeshAgent.CompleteOffMeshLink () 

        /*

        Mevcut a� d��� ba�lant� �zerindeki HAREKET� tamamlar.

        Karakteri mevcut a� d��� ba�lant� 'n�n di�er ucundaki EN YAKIN mevcut NAVMESH KONUMUNA( gezinme a�� konumuna )
        hareket edecektir.

        Karakter A� d��� ba�lant� ( OffMeshLink ) �zerinde olmad��� s�rece  CompleteOffMeshLink '�N hi�bir etkisi OLAMAZ.

        autoTraverseOffMeshLink devre d��� b�rak�ld���nda , bir arac� bu i�lev �a�r�lana kadar a� d��� bir ba�lant�da
        duraklayacakt�r. OffMeshLinks genelinde �zel hareket uygulamak i�in kullan��l�d�r.

        

        c_NavMeshAgent.CompleteOffMeshLink();

        */

        #endregion


        #region 5 )  NavMeshAgent.FindClosestEdge ( )

        /*
         
        Find Closest Edge : En yak�n kenar� bul.

        hit : Ortaya ��kan KONUMUN �zelliklerini tutar.

        En yak�n kenar� bulursa TRUE d�ner.

        En yak�n NavMesh ( Gezinme a�� ) kenar�n� bulun.

        D�nd�r�len NavMeshHit nesnesi , NavMesh'in kenar�ndaki en yak�n noktan�n KONUMUNU VE AYRINTILARINI i�erir.
        Bir kenar tipik olarak bir  duvara veya ba�ka bir b�y�k nesneye kar��l�k geldi�inden, bu bir karakterin duvara 
        oldu�unca yak�n bir yerde siper almas�n� sa�lamak i�in kullan�labilir.
        
        YAN� NavMesh ( Gezinebilece�im ALANLARDAK� ) en yak�n KENARI BULUR.


        
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

        Ka��nmadan kaynaklanan herhangi bir potansiyel katk� dahil olmak �zere ajan�n istenen HIZI.

        SADECE   Get i�lemi yap�labilir.

        Vector3 olarak d�ner.

        
        Debug.Log(c_NavMeshAgent.desiredVelocity); 

        SADECE GET ��LEM� YAPILDI�I i�in istenen h�z� varsay�lan olarak kullan�l�r.Varsay�lan olarak istenen h�z�m�z
         (0,0,0) ' m�� !!!!!!!!!!

        */

        #endregion


        #region 7 ) NavMeshAgent.destination ** 

        /*
          
        destination : VARI� NOKTASI 


      *  Ajan�n hedefini d�nya - uzay birimlerinde al�r veya ayarlamaya �al���r.

      *  Bu arac� i�in hedef k�mesini d�nd�r�r.

      *  Bir hedef ayarlanm�� ancak yol HEN�Z ��LENMEM��SE d�nd�r�len konum �nceden ayarlanan konuma en yak�n olan ge�erli
         NavMesh konumu OLUR.
 
      *  Arac�n�n yolu veya istenen yolu yoksa arac�lar�n NavMesh �zerindeki konumunu d�nd�r�r.
      
      *  Arac� NavMesh ile e�lenmemi�se ( �rne�in Scene NavMesh ' e SAH�P DE��L . )  sonsuzda bir pozisyon d�nd�r�r.

      *  Arac�dan, istenen hedefe EN YAKIN ge�erli Nav Mesh ( Gezinme a�� ) konumuna hareket etmesini ister.
     
      * Yol sonucu ,  birka� kare sonras�na kadar mevcut olmayabilir. Olana��st� sonu�lar� sorgulamak i�in pathPending 'i 
        kullan�n.
      
      * Yak�nlarda ge�erli bir gezinme konumu bulmak m�mk�n de�ilse ( �rne�in  sahnede Gezinme A�� ( Nav Mesh ) yok ) yol 
         istenmez.

        Bu durumu daha detayl� anlamak istiyorsan�z SetDestination () metoduna  bak�n..
      
        Documentation 'daki KODLARA MUTLAKA BAK YOKSA ANLAMAZSIN !!!!!!!!!!!!!!!!

        */

        #endregion


        #region 8 ) NavMeshAgent.GetAreaCost ( )


        /*

        Get Area Cost : Alan Maliyetini Al.

        Belirli bir t�rdeki alanl� ge�erken yol hesaplama maliyetini al�r.

        Bir yolun maliyeti onu hesaplaman�n i�erdi�i  ZORLUK miktar�d�r.En k�sa yol : �amur, kar, kar vb... gibi zorlu zeminlerin
        �zerinden ge�iyorsa EN �Y�S� OLMAYAB�L�R.

        Belirli bir alan�n maliyeti mesafe birimi ba��na maliyet birimlerinde verilir.

        Bir yolun maliyetinin YALNIZCA YOL BULMA i�in ge�erli oldu�unu ve yolu takip ederken arac�n hareket h�z�n� ETK�LEMEZ !!!
      

        Ger�ekten de yolun maliyeti tehlike ( may�n tarlas�nda g�venli ancak uzun yol ) veya g�r�n�rl�k ( bir karakteri 
        g�lgede tutan uzun yol ) gibi di�er fakt�rleri g�sterebilir.


        float AlanMaliyeti = c_NavMeshAgent.GetAreaCost(0);
        Debug.Log(AlanMaliyeti); // BElirledi�im Nav Mesh alan�na g�re ALAN MAL�YET� 1 M�� !!!

        */

        #endregion


        #region 9 ) NavMeshAgent.hasPath **

        /*

        Karakterinin �uanda bir YOLU VAR MI ?

        Bu �zellik, arac�n�n istenen hedefe hesaplanan bir yolu varsa TRUE  aksi takdirde FALSE d�necektir.

        
        bool YolVarmi = c_NavMeshAgent.hasPath;
        Debug.Log(YolVarmi);

        */

        #endregion


        #region 10 ) NavMeshAgent.isActiveAndEnabled

        //   Debug.Log(c_NavMeshAgent.isActiveAndEnabled);  true d�nd�


        #endregion


        #region 11 ) NavMeshAgent.isOnNavMesh

        /*
         
        Karakter �uanda NavMesh( Gezebildi�imiz alana )  ba�l� m� ?

        Karakter herhangi bir nedenle NavMesh'e ( Gezebildi�imiz alana ) ba�lanamazsa FALSE D�NER.
        �rne�in Scene'de NavMesh ( Gezebildi�imiz Alan ) YOKSA.

        


        bool NavMeshYaniGezebildigimizAlanVarMi = c_NavMeshAgent.isOnNavMesh;
        Debug.Log(NavMeshYaniGezebildigimizAlanVarMi);

        TRUE d�nd� ��nk� sahneme NavMesh ( Gezebildi�im alan ) ayarlam��t�m.
       
        */

        #endregion


        #region 12 ) NavMeshAgent.isOnOffMeshLink TAM ANLAMADIN

        /*
         
         Off Mesh Link : A� d��� ba�lant�.

        Temsilci �uanda bir OffMeshLink'te ( A� d��� ba�lant�da) M�  KONUMLANDI ?

        Bu �zellik , autoTraverseOffMeshLink ( A� d��� ba�lant�dayken otomatik ge�i�. )  YANLI� oldu�unda ve ba�lant�y� 
        ge�erken �ZEL HAREKET GEREKT���NDE KULLANI�LIDIR ! ! !


        


        bool A = c_NavMeshAgent.isOnOffMeshLink;

        Debug.Log(A);

        */

        #endregion


        #region 13 ) NavMeshAgent.isPathStale

        /*

        Ge�erli yol eski mi ?

        E�er true d�nerse yani yol eskiyse, yol art�k ge�erli veya optimal olmayabilir. 

        Bu bayrak �u durumlarda ayarlan�r : fieldMask ' te herhangi bir de�i�iklik varsa, herhangi bir OffMeshLink etkinle�-
        tirildiyse veya devre d��� b�rak�ld�ysa veya NavMeshAreas maliyetleri de�i�tiyse.

        

        bool mevcutYolEskiMi = c_NavMeshAgent.isPathStale;
        Debug.Log(mevcutYolEskiMi);

        False d�nd� yani yolumuz eski DE��L. ��nk� Gezindi�im alanda bir de�i�iklik yapmad�m ve alan  maliyetler de�i�medi.

        */


        #endregion


        #region 14 ) NavMeshAgent.isStopped **


        /*
          
        is Stopped :  Karakter Durdu mu veya durduruldu mu ?

        Bu �zellik NavMesh karakterinin durdurma veya devam ettirme ko�ulunu tutar.

        TRUE olarak ayarlan�rsa , NavMesh karakterinin  hareketi  yol boyunca durdurulur.

        NavMesh karakteri durduktan sonra FALSE olarak ayarlan�rsa  karakter hareket etmeye DEVAM EDER.

        Get ve Set i�lemi yap�labilir.

        
        bool KarakterDurdumu = c_NavMeshAgent.isStopped;
        Debug.Log(KarakterDurdumu);

       */

        #endregion


        #region 15 ) NavMeshAgent.Move ( ) **


        /*
         
          Move   : Ta��nmak

          offset : G�receli HAREKET VEKT�R�
          
          Ge�erli konuma, g�reli hareketi uygulay�n. Arac�n�n bir yolu varsa , ayarlanacakt�r.

          Yani Karakterimizi NavMesh'de ( Gezinebildi�imiz Alanda )  KONUMUNU DE���T�REB�LMEM�Z� SA�LAR.

        
        Vector3 offset = new Vector3(10f, 10f, 0f);
        c_NavMeshAgent.Move(offset);


        */

        #endregion


        #region 16 ) NavMeshAgent.navMeshOwner

        /*

        Nav Mesh Owner : Gezebildi�imiz alan�n sahibi 

        Gezebildi�imiz alan�n sahibi kimse onu d�nd�r�r.

        Bir Nav Mesh veya ba�lant� �rne�i i�in hi�bir sahip ayarlanmam��sa, d�n�� de�eri null olur.

        Sadece Get i�lemi yap�labilir. YAN� BU �ZELL�K B�ZE B�R �EY ( DE�ER,FLOAT,STR�NG BOOL ) VER�R.

        */





        #endregion


        #region 17 ) NavMeshAgent.nextOffMeshLinkData


        /*

        next off Mesh Link Data : Sonraki a� ba�lant�s� verileri

        Ge�erli yoldaki sonraki Kapal� a� ba�lant� verilerini YAKALAR.

        Ge�erli yolun bir OffMeshLink i�ermemesi durumunda OffMeshLinkData GE�ERS�Z OLARAK i�aretlenir.

        
        c_NavMeshAgent.nextOffMeshLinkData

        */

        #endregion


        #region 18 ) NavMeshAgent.nextPosition **


        /*

        Nav Mesh'e  ( Gezebildi�im Alana )  SAH�P karakterin sim�lasyon KONUMUNU al�r veya ayarlar.

        Konum vekt�r� d�nya uzay koordinatlar�nda ve birimlerindedir. 

        nexPosition, Transform.position ile birle�tirilir. Varsay�lan durumda , navmesh arac�s�n�n D�n��t�rme konumu, komut
        dosyas� g�ncelleme i�levi �a�r�ld���nda dahili sim�lasyon konumuyla e�le�ir.

        Bu ba�lant� updatePosition(BOOL de�er d�nd�r�r ) ayarlanarak a��l�p kapat�labilir. updatePosition true oldu�unda,
        Transform.position  benzetilmi� konumu yans�t�r. false oldu�unda, d�n���m�n konumu ve navmesh KARAKTER� senkronize 
        edilmez ve genel olarak ikisi aras�nda bir FARK g�r�rs�n�z.

        updatePosition tekrar a��ld���nda, Transform.position nextPosition ile e�le�ecek �ekilde hemen ta��n�r.

        nextPosition'� ayarlayarak, dahili arac� konumunun nerede olmas� gerekti�ini DO�RUDAN KONTROL EDEB�L�RS�N�Z !!!!!!!!

        Arac� konuma do�ru hareket edecek, ancak NavMesh ba�lant�s� ve s�n�rlar� taraf�ndan k�s�tland�. Bu nedenle , yaln�zca
        pozisyonlar�n s�rekli olarak g�ncellenmesi ve de�erlendirilmesi durumunda faydal� olacakt�r.


        Get ve Set i�lemi yap�labilir.

        DOCUMENTAT�ON 'DAK� KODLARA MUTLAKA AMA MUTLAKA BAK �OK DAHA �Y� ANLAYACAKSIN BU �ZELL���.��NK� BU �ZELL�K �NEML�
        B�R �ZELL�K  !  !  !

       


        Debug.Log(c_NavMeshAgent.nextPosition);

        Vector3 KarakterimGelecekKonumuSuOlsun = new Vector3(-5f, 0f, 60f);
        c_NavMeshAgent.nextPosition = KarakterimGelecekKonumuSuOlsun;
            
        */

        #endregion


        #region 19 ) NavMeshAgent.obstacleAvoidanceType **

        /*

        obstacle Avoidance Type : Engellerden ka��nma t�r�

        Ka��nman�n KAL�TE d�zeyi.

        Bu �zellik, engelden KA�INMA HASSAS�YET�N�, bunu ba�armak i�in gereken i�lemci y�k�ne kar�� takas etmenizi sa�lar.
        Kesin kalite/performans de�erleri b�y�k �l��de sahnenin karma��kl���na ba�l� olacakt�r.

        Ancak genel bir kural olarak , kalite pahas�na daha h�zl� performans elde edilebilir ve bunun terside ge�erlidir.

        Get ve Set i�lemi yap�labilir.

       

          Debug.Log(c_NavMeshAgent.obstacleAvoidanceType);

         UN�TY VARSAYILAN OLARAK ENGELLERDEN KA�INMA T�R�N� Y�KSEK KAL�TEDE ENGELLERDEN KA�MA OLARAK( HighQualityObstacleAvoidance)
         SE�M��.


        c_NavMeshAgent.obstacleAvoidanceType = ObstacleAvoidanceType.LowQualityObstacleAvoidance;

         G�rd���n gibi Set i�lemini yapt�k.Yani ENGELLERDEN KA�MA T�R� D���K KAL�TEDE ENGELLERDEN KA�SIN DEM�� OLDUK ! ! !

        */

        #endregion


        #region 20 ) NavMeshAgent.path **


        /*

        path : yol

        Ge�erli YOLU almak ve ayarlamak i�in kulland���m�z bir �zelliktir.

        Bu �zellik navigasyon sistemi taraf�ndan hesaplanan yolun noktalar�n� almak i�in GUI, hata ay�klama ve di�er ama�lar 
        faydal� olabilir.

        Ek olarak, Karakterin ola�an bir �ekilde yolu izlemesi i�in kullan�c� KODUNDAN  OLU�TURULAN B�R YOL AYARLANAB�L�R.
        Bunun bir �rne�i, iki nokta aras�ndaki optimal mesafeden ziyade kapsama i�in tasarlanm�� bir devriye rotas� olabilir.

        Get ve Set i�lemi yap�labilir.

        

        Debug.Log(c_NavMeshAgent.path);


         Yeni bir yol ayarlayabilmen i�in :
         http ://answers.unity.com/questions/1579461/how-to-set-navmeshagent-path-with-vector3.html Sitesinde 2 ki�i
         uzun uzun kodlarla ve a��klamalarla anlatm�� bu siteye git ve ANLAMAYA �ALI� ! ! !

        */

        #endregion


        #region 21 ) NavMeshAgent.pathEndPosition **

        /*

        Karakterimin son Pozisyonunun ( Vector3 ) de�erini yakalar.

        SADECE GET ��LEM� YAPILAB�L�R.

        

        Debug.Log(c_NavMeshAgent.pathEndPosition);

        Vector3 KarakterinSonPozisyonu = c_NavMeshAgent.pathEndPosition;
        TryObject.gameObject.transform.position = KarakterinSonPozisyonu + new Vector3(1f,0f,0f);

         Yani KARAKTER�M nereye giderse TryObject objeside onunla beraber gidecek ��nk� �yle ayarlad�m.

        */

        #endregion


        #region 22 ) NavMeshAgent.pathPending

        /*

        path Pending : Yol beklemede

        Hesaplanma s�recinde olan ancak hen�z haz�r olmayan bir yol mu ?

        
        bool YolHazirDegilMi = c_NavMeshAgent.pathPending;
        Debug.Log(YolHazirDegilMi); 

       False d�nd� yani YOLUMUZ HAZIRMI� !!!


        */
        #endregion


        #region 23 ) NavMeshAgent.pathStatus

        /*

        path status : Yolun durumu

        Ge�erli yolun durumu ( Tamamlanm�� , k�smi, veya ge�ersiz )

        SADECE GET i�lemi  yap�l�r ! ! !

       

        Debug.Log(c_NavMeshAgent.pathStatus);

         PathComplete d�nd� YAN� YOL HEDEFTE SONA ERER. 

         Bu konuyu daha iyi  anlaman i�in 3 '�nc� s�raya geri d�n bak orda daha detayl� bir anlat�m var.


        */

        #endregion


        #region 24 ) NavMeshAgent.Raycast ( ) **


        /*

        targetPosition : �stenen hareketin son konumu
        hit            : I��n taraf�ndan tespit edilen engelin �zellikleri
        

        Ajan ile hedef aras�nda bir ENGEL VARSA TRUE, ENGEL YOKSA FALSE d�ner.

        Karakteri hareket ettirmeden Nav Mesh ' te bir hedef konuma do�ru d�z bir yol izleyin.

        Bu i�lev, karekterin ( Ajan�n�n ) konumu ile belirtilen hedef konumu aras�ndaki bir I�IN yolunu izler.

        Hat boyunca bir engelle kar��la��rsa, ger�ek bir de�er d�nd�r�l�r ve engelleyici nesnenin konumu ve di�er ayr�nt�lar�
        hit parametresinde saklan�r.

        Bu, bir karakter ile hedef nesne aras�nda bir net bir at�� veya g�r�� hatt� olup olmad���n� kontrol etmek i�in 
        kullan�labilir.

        Bu i�lev, benzer Physics.Raycast'e TERC�H ED�L�R ��NK�  �izgi izleme, Nav Mesh kullan�larak daha BAS�T  bir �ekilde
        ger�ekle�tirilir ve DAHA D���K B�R ��LEM Y�K�NE sahiptir ! ! !


        
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

        Ge�erli yolu TEM�ZLER.

        Yol temizlendi�inde, arac� SetDestination �a�r�lana kadar yeni bir yol aramaya ba�lamaz.

        Bu i�lev �a�r�ld���nda arac� bir OffMeshLink ( Kapal� A� ba�lant�s� ) �zerindeyse, ba�lant�y� hemen tamamlayaca��n�
        unutmay�n.



        c_NavMeshAgent.ResetPath();

        */

        #endregion


        #region 26 ) NavMeshAgent.SamplePathPosition ( ) **

        /*

        Sample Path Position : �rnek yol konumu

        areaMask    : Yol izlenirken hangi NavMesh alanlar�n�n ge�ilebilece�ini belirten bir bit alan� maskesi.
        maxD�stance : Yolu bu mesafeden taramay� sonland�r�n.
        hit         : Ortaya ��kan konumun �zelliklerini tutar.


        maxDistance'daki konuma ula�madan �nce sonland�r�l�rsa True d�ner aksi halde false d�ner.

        Ge�erli yol boyunca bir konumu �rnekler.

        Bu i�lev, karakter yolun ilerisindeki konuma ula�madan �nceden bakmaya ve kontrol etmeye yarar. Bu konumdaki a��n 
        ayr�nt�lar� daha sonra bir NavMeshHit nesnesinde d�nd�r�l�r.Bu �rne�in, karakter oraya ula�madan �nce �n�ndeki y�zeyin 
        t�r�n� kontrol etmek i�in kullan�labilir.
        �rne�in karakter suda y�r�mek �zereyse silah�n� ba��n�n �zerinde kald�rabilir.

        DOCUMENTAT�ON' daki KODLARA bak daha iyi anlars�n....

        */


        #endregion


        #region 27 ) NavMeshAgent.SetAreaCost ( )



        /*

        Set Area Cost : Alan maliyetini Ayarla

        areaIndex : Alan Maliyeti
        areaCost  : Belirtilen alan dizini i�in yeni maliyet

        Alan t�r�ndeki alanlar �zerinden ge�i� maliyetini ayarlar.

        Arac�y� ( KArakteri ) etkinle�tirir veya devre d��� b�rak�rsan�z , maliyet varsy�lan katman maliyetine s�f�rlan�r.

        */


        #endregion


        #region 28 ) NavMeshAgent.SetDestination ( ) **

        /*

        target : Var�lmas� beklenen HEDEF NOKTA

        Hedef ba�ar�yla istendiyse True, aksi takdirde false d�ner.

        Hedefi ayarlar veya g�nceller, b�ylece yeni bir yol i�in hesaplamay� tetikler.

        Yolun birka� kare sonras�na kadar kullan�labilir hale gelmeyebilece�ini unutmay�n. Yol hesaplan�rken pathPending �zelli�i
        true olacakt�r.

        Ge�erli bir yol kullan�labilir hale gelirse, KARAKTER harekete  devam edecektir.

        

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


         YAN� G�RD���N G�B� EKRANDA  TIKLADI�IN HER YERE EKS�KS�Z MANTIKLI B�R �EK�LDE KARAKTER�M G�D�YOR ! ! ! ! !


        */

        #endregion


        #region 29 ) NavMeshAgent.SetPath ( )

        /*

        path : �zlenecek yeni yol

        Yol ba�ar�yla atanm��sa true d�ner.

        Karaktere, YEN� bir yol atar.

        Yol ba�ar�yla atan�rsa ajan yeni hedefe do�ru harekete devam edecektir. Yol atanamazsa, yol temizlenir.

        

        NavMeshPath pathim = new NavMeshPath();
        NavMesh.CalculatePath(transform.position, TargetObject.transform.position, NavMesh.AllAreas, pathim);

        c_NavMeshAgent.SetPath(pathim);

        Google 'da ara�t�rma yap�p https//forum.unity.com/threads/navmeshagent-setpath-doesnt-seem-to-work-properly.553558/ 
        bu siteye girip burdaki kodlar� incele daha iyi anlars�n ! ! !


        */

        #endregion


        #region 30 ) NavMeshAgent.steeringTarget **

        /*

        steering target : Y�nlendirme Hedefi

        Yol boyunca mevcut y�nlendirme hedefini al�n.

        Bu genellikle yol boyunca bir sonraki K��E veya yolun B�T�� NOKTASIDIR.

        Karakter bir OffMeshLink ( Kapal� a� ba�lant�s� ) �zerinde hareket ETM�YORSA, karakter ve Y�nlendirme Hedefi aras�nda
        d�z bir yol vard�r.

        Ge�i� i�in bir OffMeshLink  ' e ( Kapal� a� ba�lant�s� ) 'na yakla��rken DE�ER karakterin ba�lant�ya girece�i konumdur.
        Karakter bir OffMeshLink ( Kapal� a� ba�lant�s� ) �zerinden ge�erken DE�ER , karakterin ba�lant�dan ayr�laca�� konumdur.

        Vector3 d�ner.

        Sadece GET i�lemi yap�l�r.

        
        Debug.Log(c_NavMeshAgent.steeringTarget);

        */

        #endregion


        #region 31 ) NavMeshAgent.updatePosition

        /*

      update Position : G�ncelleme konumu

      transform.position : D�n��t�rme konumu 

      D�n��t�rme konumunun benzetilmi� KARAKTER ( arac� ) konumuyla e�itlenip e�itlenmedi�ini al�r veya ayarlar. Varsay�lan de�er
      DO�RUDUR !

      Do�ru oldu�unda : d�n��t�rme konumunun de�i�tirilmesi benzetilmi� konumu etkiler ve bunun tersi de ge�erlidir.

      Yanl�� oldu�unda : sim�le edilen konum, d�n��t�rme konumuna uygulanmaz ve bunun tersi de ge�erlidir.

        updatePosition ��esini FALSE olarak ayarlamak, d�n��t�rme konumunun komut dosyas� arac�l���yla a��k bir �ekilde 
        denetlenmesini sa�lamak i�in kullan�labilir. Bu ba�ka bir bile�eni s�rmek i�in arac�n�n benzetilmi� konumunu kullanman�za
        olanak tan�r. Bu da d�n���m konumunu ayarlar.( �rne�in k�k hareketi veya fizik ile animasyon ).

        updatePosition etkinle�tirilirken ( �nceden devre d��� b�rak�ld���ndan ) d�n���m sim�le edilen konuma ta��nacakt�r.
        Bu �ekilde ajan, navmesh y�zeyiyle s�n�rl� kal�r ! ! ! ! ! ! ! ! ! ! ! ! ! ! ! ! ! !

        bool bir de�er d�nd�r�r.

        Get ve Set i�lemi yap�labilir.

        


        Debug.Log(c_NavMeshAgent.updatePosition); // VARSAYILAN OLARak TRUE de�erini d�nd�rd�.

        */

        #endregion


        #region 32 ) NavMeshAgent.updateRotation


        /*

        Karakter( Arac� ) d�n��t�rme oryantasyonunu g�ncellemeli mi ?

        Get ve Set i�lemi yap�labilir.

        

        Debug.Log(c_NavMeshAgent.updateRotation); // VARSAYILAN olarak TRUE de�erini d�nd�rd�.

        */

        #endregion


        #region 33 ) NavMeshAgent.updateUpAxis

        /*

        Karakterin ( Arac�n�n ) yerle�tirildi�i NavMesh 'in veya ba�lant�n�n yukar� eksenine hizalanmas� gerekip gerekmedi�ini 
        belirlemenizi sa�lar.

        Bu de�er true olarak ayarland���nda  KARAKTER ( Arac� ) her zaman NavMesh 'in veya �uanda �zerinde oldu�u ba�lant�n�n
        yerel YUKARI  eksenine hizalan�r. Yanl�� olarak ayarland���nda  Karakterin ( arac�n�n ) y�n� NavMesh 'in y�neliminden
        etkilenmez.



        Debug.Log(c_NavMeshAgent.updateUpAxis); VARSAYILAN olarak TRUE de�erini d�nd�rd�. Yani Karakter NavMesh 'in YUKARI
                                                eksenine OTOMAT�K olarak ayarlanm��.


        */


        #endregion


        #region 34 ) NavMeshAgent.velocity **


        /*

        NavMeshAgent bile�eninin mevcut h�z�na eri�in veya Karakteri ( Arac�y� ) manuel olarak kontrol etmek i�in bir HIZ
        ayarlay�n.

        De�i�keni okumak, kalabal�k sim�lasyonuna dayal� olarak arac�n�n mevcut h�z�n� d�nd�r�r.

        De�i�kenin ayarlanmas� sim�lasyonu ge�ersiz k�lar.( Hedefe do�ru hareket etme, �arp��madan ka��nma ve h�zlanma kontrol�
        dahil .) NavMesh Karakterine ( Arac�s�na ) do�rudan belirtti�in  HIZI kullanarak hareket etmesi i�in komut verir.

        Ajan bir h�z kullanarak KONTROL ED�LD���NDE hareketi hala NavMesh �zerinde KISITLIDIR.

        H�z� do�rudan ayarlamak , NavMesh �zerinde hareket eden ve sim�le eden kalabal���n geri kalan�n� etkileyen oyuncu 
        karakterlerini uygulamak i�in kullan�labilir.Ek olarak �nceli�i y�ksek olarak ayarlamak ( k���k bir de�er daha y�ksek
        �nceliktir.) Di�er sim�le edilmi� ajanlar�n oyuncu kontroll� ajandan daha da hevesli bir �ekilde ka��nmas�n� sa�layacak-
        t�r.

        KARAKTER� ( Arac�y� ) MANUEL olarak KONTROL ederken h�z�n HER KAREDE ayarlanmas� ve KONTROL� sim�lasyona b�rak�yorsan�z
        h�z� SIFIRA ayarlaman�z �nerilir ! ! !

        Arac�n�n h�z� bir de�ere ayarlan�r ve ard�ndan g�ncellemeyi durdurursa, sim�lasyon oradan ba�lar ve Karakter ( Arac� ) 
        YAVA� YAVA� YAVA�LAR. ( HEDEF�N AYARLANMADI�I VARSAYIYORUZ ! )

        H�z� okuman�n her zaman sim�lasyondan de�er getirece�ini unutmay�n.De�er AYARLARSANIZ , efekt bir sonraki g�ncellemede
        g�r�necektir. D�nd�r�len h�z sim�lasyondan geldi�inden ( Ka��nma ve �arp��ma y�ntemi dahil ) ayarlad���n�zdan FARKLI
        OLAB�L�R !

        H�z saniyedeki uzakl�k birimleriyle ( Fizikte oldu�u gibi ) belirtilir ve k�resel koordinat sisteminde temsil edilir.

        GET ve SET i�lemi yap�labilir.

        

     1 . DURUM =  H�z� Unity 'nin KONTR�L�NE  BIRAKTI�IMIZDA HIZIN DE�ERLER�  :

        c_NavMeshAgent.SetDestination(TargetObject.transform.position);
        Debug.Log(c_NavMeshAgent.velocity);

         YAN������ Karakterimiz h�z�  HEDEF objeyi takip ederken OTOMAT�K ( UN�TY TARAFINDAN BEL�RLENM�� ) bir �ekilde h�zlar�
         YAKLA�IK OLARAK �u aral�k ta oluyor :

         ( Vector3 =

            x y�n�ndeki h�z� : -2 ile 2 aras�nda 

            y y�n�ndeki h�z� : 0
            
            z y�n�ndeki h�z� -3.5 ile 3.5 aras�nda DE����YOR 

          )

     2. DURUM : H�z� Bizim MANUEL olarak ayarlad���m�zda HIZIN DE�ERLER� : 

        c_NavMeshAgent.SetDestination(TargetObject.transform.position);
        c_NavMeshAgent.velocity = new Vector3(0.1f,0f,5f);

        Debug.Log(c_NavMeshAgent.velocity);

        HIZ manuel olarak belirledi�imiz de�erlerde �al���yor evet ancak belirledigimiz hedefe G�TM�YOR belirled�imiz vekt�r
        h�zlar�na ba�l� kald��� i�in karakterimiz  FARKLI Y�NLERDE HEDEFE G�D�YOR. 


        YAN�!!!!!! HIZI MANUEL OLARAK AYARLAMA ( Set i�lemi yapma yani )  SANA TAVS�YEM ��NK� oyunlardaki bu yapay zeka 
        sisteminde  Karakterimiz HEDEFE MANTIKLI VE D�ZG�N bir �ekilde gitmelidir !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!

        */

        #endregion


        #region 35 ) NavMeshAgent.Warp ( ) **

        /*

        Warp : Sapt�rmak

        newPosition : Ajan� sapt�rmak i�in yeni pozisyon

        Karakter ( Arac� )  ba�ar�yla sapt�r�l�rsa True , aksi takdirde false d�ner.

        

        c_NavMeshAgent.SetDestination(TargetObject.transform.position);
          Debug.Log(   c_NavMeshAgent.Warp(TryObject.transform.position)); Karakterim D�REK TryObject objesinin yan�na gidiyor.


        c_NavMeshAgent.SetDestination(TargetObject.transform.position);
        c_NavMeshAgent.Warp(new Vector3(0.1f, 0f, 0f)); // Karakterim direk olarak d�nya �zerindeki x = 0.1f konumuna gitti.

        */



        #endregion



        #endregion




        #region Video Scripti �a�r���m yapar belki bir konu hakk�nda burda dursun
        
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

                
                 Yani ekrana dokundu�umda karakterim dokundu�um yere gidiyor ya ( destination : Var�� noktas�)
                 Var�� noktamla( Var�� noktas�ndakide karakterin KARI�TIRMA ) Y�NE    karakterimin pozisyonu 
                 aras�ndaki mesafe ajan�n hedefe durma mesafesinde e�it ve k���kse  KO�MA AN�MASYONU DURSUN IDLE GE�S�N DEM��
                 OLDUK !!!!!!!!!!!

                
            }





        }

        void ClickToOffset()
        {

            // ScreenToWorldPoint : D�nya noktas�nda ekran

            // ScreenPointToRay : Ray ( ���n ) i�in EKRAN noktas�

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
