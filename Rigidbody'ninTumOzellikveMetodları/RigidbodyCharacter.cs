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

           NEDEN 2 FARKLI SINIFI VE METODU B�RL�KTE KULLANDIK ? 
           ��NK� �K�S�N� B�RB�R�YLE BA�LANTILI ! ! ! A�A�IDAK� KODLARDAN DA BUNU ANLAYAB�L�RS�N.





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

          Force : D�nya koordinatlar�ndaki KUVVET vekt�r�
          mode: Kuvvet T�r�

          ForceMode.Force: Girdiyi kuvvet(Newton cinsinden �l��l�r) olarak yorumlar ve h�z� kuvvet* DT / k�tle de�eriyle de�i�tirir.
          Etki, sim�lasyon ad�m uzunlu�una ve cismin K�TLES�NE BA�LIDIR.

          ForceMode.Acceleration: Parametreyi ivme olarak yorumlar(metre b�l� saniye kare olarak �l��l�r) ve h�z� kuvvet* DT de�eriyle de�i�tirir.
          Etki, sim�lasyon ad�m uzunlu�una ba�l�d�r, ancak cismin k�tlesine ba�l� DE��LD�R.

          ForceMode.Impulse: Parametreyi bir darbe(Newton / saniye cinsinden �l��l�r) olarak yorumlar ve h�z� kuvvet / k�tle de�erine g�re de�i�tirir.
          Etki, v�cudun k�tlesine ba�l�d�r ancak sim�lasyon ad�m uzunlu�una ba�l� DE��LD�R.

          ForceMode.VelocityChange: Parametreyi do�rudan h�z de�i�ikli�i(saniyede metre cinsinden �l��l�r) olarak yorumlar ve h�z� kuvvet de�eriyle de�i�tirir.
          Etki, v�cudun k�tlesine veya sim�lasyon ad�m uzunlu�una ba�l� DE��LD�R.
        
         Kuvvet yaln�zca aktif bir Sert G�vdeye uygulanabilir.Bir GameObject etkin de�ilse, AddForce'un hi�bir etkisi yoktur. Ayr�ca, Rigidbody kinematik olamaz.
         Varsay�lan olarak, Rigidbody'nin durumu, kuvvet Vector3.zero olmad��� s�rece, bir kuvvet uyguland���nda uyanacak �ekilde ayarlan�r.

        

        // Vector3 power = new Vector3(1f, 10f, 1f);

         rg.AddForce(power, ForceMode.Force);
         rg.AddForce(power, ForceMode.Acceleration);
         rg.AddForce(power, ForceMode.Impulse);
         rg.AddForce(power, ForceMode.VelocityChange);

        */


        #endregion


        #region 3 ) Rigidbody.AddForceAtPosition ( )

        /*
         Pozisyonda kuvvet uygular.Sonu� olarak bu nesneye bir TORK VE KUVVET  uygular.

         - Ger�ek�i efektler position i�in yakla��k olarak kat� cismin y�zeyinin aral���nda olmal�d�r.Bu genellikle PATLAMALAR i�in kullan�l�r. Patlamalar� 
           uygularken kuvvetleri tek bir kare yerine birka� kareye uygulamak en iyisidir. position Rijit g�vdenin merkezinden uzakta oldu�unda uygulanan torkun ger�ek
           olamayacak kadar  B�Y�K OLACA�INI unutmay�n.

        float distance = Vector3.Distance(gameObject.transform.position, helpingObject.transform.position);

        Vector3 m_Force = new Vector3(8f, 0f, 0f);
        rg.AddForceAtPosition(m_Force, gameObject.transform.position);
       
            
         Debug.Log(" Fizik MOTORUNUN konumu :  " + rg.transform.position + " Karakterimin kendi pozisyonu :  " + gameObject.transform.position); 
         Hem F�Z�K MOTORUNUN hemde karakterin pozisyonu AYNI DE�ERLERDE  �IKIYOR.
         
        */

        #endregion


        #region  4 ) Rigidbody.AddRelativeForce ( ) 

        /* Rigidbody 'e sahip objemize KOORD�NAT S�STEM�NE G�RE bir kuvvet ekler.

         m_Rigidbody.AddRelativeForce(Vector3.right*deger);
        m_Rigidbody.AddRelativeForce(Vector3.forward * deger);

        YAN�  Rigidbody ' sahip objeye belirtti�in EKSENDE  bir belirtti�in DE�ERDE bir kuvvet uygular. 
        ( Bu �rnekte  KUVVET� SADECE 1 KERE UYGULADI . ) 
        
        */

        #endregion


        #region 5 ) Rigidbody.AddTorque ()

        /*
         
        Bu fonksiyonla uygulanan torklar�n etkileri, �a�r� an�nda toplan�r. Fizik sistemi, etkileri bir sonraki sim�lasyon 
        �al��t�rmas� s�ras�nda uygular.(Ya FixedUpdate'den sonra ya da komut dosyas� a��k�a Physics.Simulate y�ntemini �a��rd���nda)
        Bu fonksiyonun farkl� modlar� oldu�u i�in, fizik sistemi ge�en tork de�erlerini de�il, sadece ortaya ��kan a��sal h�z 
        de�i�imini biriktirir. DeltaTime'�n (DT) sim�lasyon ad�m uzunlu�una ( Time.fixedDeltaTime ) ve k�tlenin torkun uyguland���
        Sert Cismin k�tlesine e�it oldu�unu varsayarsak, t�m modlar i�in a��sal h�z de�i�imi �u �ekilde hesaplan�r:


         ForceMode.Force: Girdiyi tork (Newton-metre cinsinden �l��l�r) olarak yorumlar ve a��sal h�z� tork * DT / k�tle de�eriyle 
                          de�i�tirir. Etki, sim�lasyon ad�m uzunlu�una ve cismin k�tlesine ba�l�d�r.

         ForceMode.Acceleration: Parametreyi a��sal h�zlanma (derece/saniye kare cinsinden �l��l�r) olarak yorumlar ve a��sal h�z� 
                                 tork * DT de�eriyle de�i�tirir. Etki, sim�lasyon ad�m uzunlu�una ba�l�d�r ancak cismin k�tlesine
                                 ba�l� de�ildir.
 
         ForceMode.Impulse: Parametreyi a��sal momentum (kilogram-metre-kare/saniye cinsinden �l��l�r) olarak yorumlar ve a��sal
                            h�z� tork/k�tle de�eriyle de�i�tirir. Etki, v�cudun k�tlesine ba�l�d�r ancak sim�lasyon ad�m uzunlu�una
                            ba�l� de�ildir.

         ForceMode.VelocityChange: Parametreyi do�rudan a��sal h�z de�i�imi olarak yorumlar (derece/saniye olarak �l��l�r) ve 
                                   a��sal h�z� tork de�eriyle de�i�tirir. Etki, v�cudun k�tlesine ve sim�lasyon ad�m uzunlu�una 
                                    ba�l� de�ildir.
       

        
       

        float yatay = Input.GetAxis("Horizontal");

      m_Rigidbody.AddTorque(transform.up * deger *yatay); // Sa� ve sol tu�larla bir nesneyi Y ( yukar� ) ekseninde d�nd�rd�k.
                                                             

      m_Rigidbody.AddTorque(transform.right * deger * yatay);// Sa� ve sol tu�larla bir nesneyi x EKSEN�NDE d�nd�rerek �LERLETT�K ! !


        */

        #endregion


        #region 6 ) Rigidbody.AddRelativeTorque

        /* Rigidbody ' sahip objeye KOORD�NAT S�STEM�NE g�re bir TORK  ekler.
         
          Tork ( D�nd�rme Kuvveti ) : Kuvvet * Kuvvet Kolu ( Nm = Newton * Metre )   T = F * d 
          Aralar�nda a�� varsa Tork : F * ( r * sin@ )

        // m_Rigidbody.AddRelativeTorque(Vector3.forward * deger);

        // m_Rigidbody.AddRelativeTorque(Vector3.right * deger);


        �NEML� : AddRelativeForce ( ) ' de objeye sadece 1 kere kuvvet uygularken BURDA obje S�REKL� BEL�RTT���N EKSENDE
                 VE BEL�RTT���N TORK DE�ER�NDE S�REKL� D�NEREK G�D�YOR.

        */
        #endregion


        #region 7) Rigidbody.angularDrag

        /* 

         Nesnenin a��sal s�r�klemesidir.

         A�ISAL S�R�KLEME, bir nesnenin D�N���N�  YAVA�LATMAK i�in kullan�labilir. S�r�kleme ne kadar y�ksek olursa objenin
         d�n��� o kadar yava�lar.

         Debug.Log(m_Rigidbody.angularDrag); // objeye hi� bir �ey yapmam�� haliyle A�ISAL S�R�KLEMES� 0.05 M��

        if (Input.GetKeyDown(KeyCode.P))
        {
            m_Rigidbody.angularDrag = 0.8f;

        }

        */

        #endregion


        #region 8 ) Rigidbody.angularVelocity

        /*

        Saniyede radyan cinsinden �l��len kat� cismin A�ISAL HIZ VEKT�R�.

        �o�u durumda ger�ek�i olmayan davran��lara yol a�abilece�inden do�rudan de�i�tirmemelisiniz.

        Rigidbody ayarlanm��, d�nme k�s�tlamalar� varsa kar��l�k gelen a��sal h�z bile�enlerinin �a�r� s�ras�nda k�tle uzay�nda
        ( yani atalet tens�r d�n���ne g�re ) s�f�ra ayarland���na dikkat edin.



        Debug.Log ( m_Rigidbody.angularVelocity ); // Ham haliyle ( 0,0,0 ) ��kt�s�n� ald�m.

        float yatay =  Input.GetAxis("Horizontal");
        transform.Translate(new Vector3(yatay * Time.deltaTime, 0f, 0f));

       Debug.Log(m_Rigidbody.angularVelocity); // Sadece hareket ederken e�er biriyle temas ediyorsam sadece x ekseninde de�erleri
                                               // -0.1 vb de�erlerini ald�m.  [ �rnek : (  -0.1 ,0 , 0 ) ]

        Debug.Log(m_Rigidbody.angularVelocity.magnitude); // Hareket etti�imde 1.59 * 10 �zeri -6 ��kt�s�n� ald�m vb.. ��kt�lar�n�
        ald�m.


        */
        #endregion


        #region 9 ) Rigidbody.centerOfMass

        /*
         
         D�n���m�n k�kenine g�re k�tle merkezi.

         Bir komut dosyas�ndan k�tle merkezini ayarlamazsan�z bu kat� cisme ba�l� cisme ba�l� cisim t�m �arp��t�r�c�lardan otomatik
         olarak hesaplanacakt�r.�zel bir k�tle merkezi ayarland�ktan sonra �arp��t�r�c� ekleme veya ��karma bunlar : �evirme, 
         �l�ekleme vb.. gibi de�i�ikliklerde art�k otomatik olarak yeniden HESAPLANMAYACAKTIR. Otomatik olarak hesaplanan k�tle
         merkezine geri d�nmek i�in Rigidbody.ResetCenterOfMass ' i kullan�n.
            
            Arabalar� daha kararal� hale getirmek i�in sim�le ederken k�tle merkezini ayarlamak genellikle yararl�d�r. K�tle 
            merkezi daha d���k olan bir arab�n�n devrilme olas�l��� daha d���kt�r.

         Vector3 RigidbodyeSahipObjeninKutleMerkezi = m_Rigidbody.centerOfMass;
         Debug.Log(RigidbodyeSahipObjeninKutleMerkezi); // Hi�bir �ey yapmazken k�tle merkezi  0,0,0 m��.


        m_Rigidbody.centerOfMass = centerOffMassPoint.transform.position;
        Debug.Log(m_Rigidbody.centerOfMass);

             Hi�bir hareket kodu YAZMAMAMA ra�men obje bir sola bir sa�a gidiyor s�rekli.

        */
        #endregion


        #region 10 ) Rigidbody.ClosestPointOnBounds ( ) 

        /*
        
        Ekli �arp��t�r�c�lar�n s�n�rlay�c� kutusuna en yak�n nokta.

        Vector3 a = m_Rigidbody.ClosestPointOnBounds(transform.position);
        Debug.Log(a);

        Objenin konumu  ( -1.97 , 0.509 , 0.77 ) buydu. Biz bu kodu yazd�ktan sonra bu de�erleri yuvarlad� en yak�n say�y� baz ald�
        Yani  ( -2.0 , 0.5 , 0.8 ) oldu ! ! !

        */


        #endregion


        #region 11 ) Rigidbody.collisionDetectionMode


        /*

        Kat� cismin �ARPI�MA ALGILAMA MODUDUR.

        Bunu h�zl� hareket eden nesnelerin �arp��malar� alg�lamadan di�er nesnelerden ge�mesini �nlemek i�in kullan�lan S�REKL�
        �ARPILMA  ALGILAMASI   i�in kullan�r�z.

        -- �NEML� 

        En iyi sonu�lar i�in, h�zl� hareket eden nesneler i�in bu de�eri CollisionDetectionMode.ContinulousDynamic olarak
        ayarlay�n ve bunlar�n �arp��mas� gereken di�er nesneler i�in CollisionDetectionMode.Continuous olarak ayarlay�n. 
        Bu iki se�ene�in fizik performans� �zerinde b�y�k etkisi vard�r. 

        Alternatif olarak, genellikle daha ucuz olan ve kinematik nesneler �zerinde de kullan�labilen 
        CollisionDetectionMode.ContinulousSpeculative'i kullanabilirsiniz.

        H�zl� nesnelerin �arp��mas�yla ilgili sorunlar�n�z yoksa, CollisionDetectionMode.Discrete varsay�lan de�erine ayarlanm��
        olarak b�rak�n. S�rekli �arp��ma Alg�lama yaln�zca Sphere-, Capusle- veya BoxColliders'l� Sert G�vdeler i�in desteklenir.



            1 ) CollisionDetectionMode.Continuous : SADECE STAT�K a� geometirisi ile �arp��ma i�in s�rekli �arp��ma alg�lama modu
                                                    a��k olur.

            2 ) CollisionDetectionMode.ContinuousDynamic : STAT�K VE D�NAM�K geometri ile �arp��ma i�in s�rekli �arp��ma alg�lama
                                                           a��k olur.

            3 ) CollisionDetectionMode.ContinuousSpeculative :  STAT�K VE D�NAM�K geometriler i�in SPEK�LAT�F  s�rekli �arp��ma 
                                                                alg�lama a��k olur.

            4 ) CollisionDetectionMode.Discrete : Bu Rigidbody i�in s�rekli �arp��ma alg�lama KAPALI olur.


        */


        #endregion


        #region 12 ) Rigidbody.detectCollisions

        /* �ARPI�MA ALGILAMA ETK�NLE�T�R�LS�N M� ? 

        Debug.Log(m_Rigidbody.detectCollisions); // Default olarak TRUE yani �arp��ma alg�lama ETK�N bir �ekilde geliyor.

        */

        #endregion


        #region 13 ) Rigidbody.constraints 

        /*
         Bu Rigidbody i�in hangi serbestlik derecelerine izin verildi�ini kontrol eder.

         Unity taraf�nda Constraints k�sm�ndan da istedi�in SINIRLAMAYI  yapabilirsin KOD TARAFINDADA istedi�in SINIRLAMAYI 
         yapabilirsin.

        
        m_Rigidbody.constraints = RigidbodyConstraints.FreezePositionX;

        */

        #endregion


        #region 14 ) Rigidbody.drag


        /*
        
        Objenin S�RT�NMES�D�R ! ! !

        Debug.Log(m_Rigidbody.drag); // HAM ( Default ) HAL�YLE  Rigidbody 'nin S�RT�NMES� 0 m�� ! ! !


        m_Rigidbody.velocity = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
        m_Rigidbody.drag = 200f;
        m_Rigidbody.drag = 2f;

        Debug.Log(m_Rigidbody.drag);

        G�rd���n gibi objenin Rigidbody'sindeki S�rt�nmeyi art�rd���nda obje yava� hareket ediyor ! ! !

        */

        #endregion


        #region 15 ) Rigidbody.freezeRotation

        /*
         
        Fizi�in nesnenin D�N���N�  de�i�tirip de�i�tirmeyece�ini belirler.
        ETK�NLE�T�R�L�RSE D�ND�RME , Fizik( Rigidbody ) taraf�ndan DE���T�R�LEMEZ ! ! !
         
           Bu Birinci �ah�s Ni�anc� ( FPS ) ayarlar� olu�turmak i�in kullan��l�d�r, ��nk� oyuncunun fareyi kullanarak d�n���n
           tam kontrol�ne ihtiyac� vard�r.

        

        Debug.Log(m_Rigidbody.freezeRotation); // HAM ( DEfault ) HAL�YLE F�Z�K NESNEN�N D�N���N� DE���T�REB�L�R.


        m_Rigidbody.freezeRotation = true;
        m_Rigidbody.velocity = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);

        obje sa�a sola giderken D�NEREK G�D�YORDU ancak biz bu �zelli�i AKT�FLE�T�RD���M�Z ���N D�NEREK SA�A SOLA G�DEMEZ 
        SADECE SA�A SOLA G�DER ! ! !


        */
        #endregion


        #region 16 ) Rigidbody.GetPointVelocity ( ) 

        /* K�resel uzayda nokta d�nya noktas�nda kat� cismin HIZINI HESAPLAR YAN� YAKALAR.
           
            GetPointVelocity (), HIZI hesaplarken kat� cismin A�ISAL HIZINI ( angular Velocity 'sini ) HESABA KATAR ! ! ! ! !

        m_Rigidbody.velocity = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
        Debug.Log(  m_Rigidbody.GetPointVelocity(transform.position) );
         

        */

        #endregion


        #region 17 ) Rigidbody.GetRelativePointVelocity ( )

        /*
         
         Nokta g�reli noktas�nda kat� cisme G�RE HIZINI hesaplar.
         H�z� hesaplarken kat� cismin A�ISAL h�z�n� hesaba katar.

        G�recelik : Varl��� bir ba�ka �eyin varl���na ba�l� bulunan, mutlak olmayan , g�reli , ba�lant�l� , izafi ,nispi, r�latif...

        m_Rigidbody.velocity = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
        Debug.Log( m_Rigidbody.GetRelativePointVelocity(transform.position));

        */
        #endregion


        #region 18 ) Rigidbody.inertiaTensor

        /*
         
        m_Rigidbody.velocity = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
        Debug.Log(m_Rigidbody.inertiaTensor); // Hi�bir i�lem yapmadan Objenin Eylemsizlik tens�r�  ( 0.2  , 0.2 , 0.2 )' ymi�.


        Bu cismin k�tle merkezine yerle�tirilmi� ve Rigidbody.inerttiaTensorRotation taraf�ndan d�nd�r�len bir referans 
        �er�evesindeki diyagonal matris olarak tan�mlanan bu cismin EYLEMS�ZL�K TENS�R�D�R.

            Eylemsizlik ( ATALET ) : Bir nesnenin bir d�� etki olmad��� s�rece DE���MEME �zelli�idir.

                                     E�er bir cismin �zerine etki eden net/toplam kuvvet s�f�r ise, durmakta olan bir cisim 
                                     durmay�, hareket etmekte olan bir cisim ise ayn� y�nde ve h�zda hareket etmeyi s�rd�r�r.

                                     Fizikte bu, "eylemsizlik" ya da "atalet" olarak tan�mlan�r. Daha basit bir tan�m�yla 
                                     eylemsizlik, cisimlerin o anda bulunduklar� hareket durumunu korumaya olan e�ilimleridir. 
                                     Duran bir cisim durmay� s�rd�rmek ister. Hareket halindeki bir cisimse ayn� �ekilde hareket 
                                     etmeyi... 

         TENS�R : Matematikte, tens�r, �ok boyutlu verinin simgelenebildi�i geometrik bir nesnedir. Skaler denilen y�ns�z nicel
                  b�y�kl�kler, vekt�r denilen y�nl� b�y�kl�kler ve matris denilen iki boyutlu nesneler birer tens�rd�r. 
                  Tens�r, t�m bu nesnelerin genelle�tirilmi� halidir ve �ok boyutlu veri k�meleri i�in kullan�l�r.

     
         MOMENT NED�R : Bir kuvvetin bir cisim �zerinde yaratt��� D�ND�RME etkisine MOMENT denir. Bir kuvvetin bir noktaya g�re 
                        momentinin b�y�kl���, kuvvetle o noktaya olan dik uzakl���n�n �arp�m�d�r.
        Atalet tens�r�, k�tlenin d�n��sel bir analo�udur: belirli bir eksen etraf�ndaki atalet bile�eni ne kadar b�y�kse, 
        o eksen etraf�nda ayn� a��sal ivmeyi elde etmek i�in gereken torkta o kadar fazlad�r.

        S�f�r, ge�erli bir atalet tens�r� bile�eni de�il. Bu nedenle, fizik sistemi bunun yerine s�f�rlar� sonsuz de�erler 
        olarak yorumlar. Dolay�s�yla, �rne�in (0, 1, 1) atalet tens�r�ne sahip bir cismin X etraf�nda d�nmesi imkans�zd�r.

        D�nel K�s�tlamalar�n Rigidbody K�s�tlamalar�n�n Rigidbody'nin ger�ekte atalet tens�r� bile�enlerini kilitli
        serbestlik dereceleri hakk�nda s�f�ra ayarlayarak uyguland���na dikkat edin.

        Atalet tens�r�n� bir komut dosyas�ndan ayarlamazsan�z, Rigidbody'ye ba�l� t�m �arp��t�r�c�lardan otomatik olarak 
        hesaplan�r. Atalet tens�r�n� otomatik olarak hesaplanan de�ere s�f�rlamak i�in Rigidbody.ResetInertiaTensor'u kullan�n.

        */

        #endregion


        #region 19 ) Rigidbody.inertiaTensorRotation


        /*
         
          Eylemsizlik tens�r�n�n D�N���D�R.
          Bir komut dosyas�ndan eylemsizlik tens�r� d�n���n� ayarlayamazs�n�z, bu kat� cisme ba�l� olan �arp��t�r�c�lardan otomatik 
          olarak hesaplan�r.

        m_Rigidbody.velocity = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);

        Quaternion a = transform.rotation;
        m_Rigidbody.inertiaTensorRotation = a;

        Debug.Log(m_Rigidbody.inertiaTensorRotation);

        Hareket ettirmeden  ( 0.0, 0.0 0.0 , 1.0  ) de�erini ald�  haraket ettirdikten sonra  ( 0.0 , 0.0 , 0.6 , - 0.8 ),
        ( 0.0 , 0.0 , 0.3 , -1.0 ) vb.. de�erlerini  ald�.
                                                      

        Debug.Log(m_Rigidbody.inertiaTensorRotation); 

         HAM HAL�YLE ( 0.0 , 0.0 , 0.0 , 1.0 ) de�erleri ald�.
         HAREKET ETT�RD�KTEN  SONRADA (  0.0 , 0.0 , 0.0 , 1.0 ) de�erini ald�.                                              


        */
        #endregion


        #region 20 ) Rigidbody.interpolation

        /*
         
        �nterpolasyon, sabit bir kare h�z�nda �al��an fizi�in etkisini YUMU�ATMAMIZA olanak tan�r.

        Varsay�lan olarak interpolasyon kapal�d�r. Oyuncunun karakterinde genellikle kat� cisim interpolasyonu kullan�l�r. 
        Grafikler de�i�ken kare h�zlar�nda olu�turulurken, fizik ayr� zaman ad�mlar�nda �al���r. Bu, fizik ve grafikler tamamen
        senkronize olmad��� i�in titrek g�r�nen nesnelere yol a�abilir. Efekt incedir, ancak �zellikle kamera ana karakteri 
        takip ediyorsa, oyuncu karakterinde s�kl�kla g�r�l�r. Ana karakter i�in enterpolasyonu a�man�z, ancak di�er her �ey i�in 
        devre d��� b�rakman�z �nerilir.


        1 ) RigidbodyInterpolation.Extrapolate : EKSTRAPOLASYON, MEVCUT HIZA  dayal� olarak kat� cismin KONUMUNU tahmin edecektir.

        2 ) RigidbodyInterpolation.Interpolate : INTERPOLASYON, her zaman biraz geride kalabilir ancak ekstrapolasyondan daha
                                                 yumu�ak olabilir.

        3 ) RigidbodyInterpolation.None : Interpolasyon YOKTUR.


        

        Debug.Log(m_Rigidbody.interpolation);
            PROJE VE OBJE ham ( default ) haliyle NONE 'm��.YAN�  Interpolasyon YOKMU� ! ! !

        m_Rigidbody.interpolation = RigidbodyInterpolation.Interpolate;
        Debug.Log(m_Rigidbody.interpolation);
           INTERPOLATE ��kt�s�n� bize verdi.

        m_Rigidbody.interpolation = RigidbodyInterpolation.Extrapolate;
        Debug.Log(m_Rigidbody.interpolation);
            EXTRAPOLATE ��kt�s�n� bize verdi.

        */


        #endregion


        #region 21 ) Rigidbody.isKinematic

        /*

        isKinematic ETK�NLE�T�R�L�RSE, Kuvvetler, �arp��malar veya eklemler art�k kat� cismi ETK�LEMEYECEKT�R. 
        
        Kat� cisim, 
        transform.position de�i�tirilerek animasyonun veya komut dosyas�n�n tam kontrol� alt�nda olacakt�r. Kinematik cisimler,
        �arp��malar veya eklemler yoluyla di�er kat� cisimlerin hareketini de etkiler. �rne�in. kinematik bir rijit cismi normal 
        bir rijit cisme bir eklem ile ba�layabilir ve rijit cisim kinematik cismin hareketi ile s�n�rland�r�lacakt�r. Kinematik 
        kat� cisimler, normalde bir animasyon taraf�ndan y�nlendirilen karakterleri yapmak i�in �zellikle yararl�d�r, ancak 
        belirli olaylarda, isKinematic'i false olarak ayarlayarak h�zl� bir �ekilde bir bez bebek haline getirilebilir.

        K�NEMAT�K NED�R ? 

        Kinematik, cisimlerin K�TLELER� ve cisme etkiyen  KUVVETLER ele ALINMADAN onlar�n SADECE HAREKETLER� incelenir. 
        Burada sadece zaman ile al�nan yol aras�ndaki ili�kiyi veren hareket denkleminin kurulmas�na �al���l�r.

        Kinematik, belli bir ZAMAN sonundaki bir cismin KONUMU ara�t�r�ld���ndan, iki temel fiziksel b�y�kl��e ihtiya� duyulur.
        Bunlardan biri zaman birimi di�eri de uzunluk birimidir. SI birim sistemine g�re, zaman birimi s (saniye) ve uzunluk 
        birimi m (metre)dir.

        
        m_Rigidbody.velocity = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);

          m_Rigidbody.isKinematic = true;   OBJE H��B�R �EK�LDE HAREKET EDEM�YOR !
          m_Rigidbody.isKinematic = false;  Obje hareket EDEB�L�YOR.

        */
        #endregion


        #region 22 ) Rigidbody.IsSleeping ()

        /*
         
        m_Rigidbody.velocity = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
        Debug.Log(m_Rigidbody.IsSleeping());

         Objeyi Rigidbody ile hareket ettirmezsen TRUE  yani Rigidbody UYUYOR ANLAMINA GEL�YOR.
         Objeyi Rigidbody ile hareket ettirirsen FALSE yani Rigidbody UYUMUYOR �ALI�IYOR anlam�na geliyor.

        */

        #endregion


        #region 23 ) Rigidbody.mass

        /*
         
          Kat� cismin K�TLES�D�R.

        B�y�k k�tle farkl�l�klar�na sahip farkl� Rijit cisimler, fizik sim�lasyonunu karars�z hale getirebilir.

        Daha y�ksek k�tleli nesneler, �arp���rken daha d���k k�tleli nesneleri daha fazla iter. K���k bir arabaya �arpan b�y�k 
        bir kamyon d���n�n.

        Yayg�n bir hata, a��r nesnelerin hafif olanlardan daha h�zl� d��t���n� varsaymakt�r. H�z yer�ekimine ve s�r�klemeye
        ba�l� oldu�undan bu do�ru de�ildir.

        
        Debug.Log(m_Rigidbody.mass);

        */

        #endregion


        #region 24 ) Rigidbody.maxAngularVelocity 

        /*

        Saniyede radyan cinsinden �l��len kat� cismin MAKS�MUM A�ISAL HIZI. (Varsay�lan 7) { 0, sonsuz } aral���.

        H�zl� d�nen g�vdelerde SAYISAL KARARSIZLI�I �nlemek i�in kat� cisimlerin a��sal h�z� maxAngularVelocity'ye kenetlenir.
        Bu, tekerlekler gibi nesneler �zerinde kas�tl� olarak h�zl� d�n��leri engelleyebilece�inden, kat� cisim ba��na bu de�eri
        ge�ersiz k�labilirsiniz.

        

        m_Rigidbody.velocity = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);

        Debug.Log(m_Rigidbody.maxAngularVelocity);

         HAM(Default)  haliyle maxAngularVelocity Yani MAKS�MUM  A�ISAL HIZ 7 de�eri al�yormu� ! ! !
         OBJEYLE HAREKET ETSENDE maxAngularVelocity 7 de�erini al�r. Sadece sen  maksimum a��sal h�z de�erine DI�ARIDAN B�R
         DE�ER VER�RSEN ANCAK �YLE DE����R.

        m_Rigidbody.maxAngularVelocity = 2f;
        Debug.Log(m_Rigidbody.maxAngularVelocity);

        */


        #endregion


        #region 25 ) Rigidbody.maxDepenetrationVelocity ***

        /*
         
       Bir kat� cismin n�fuz etme durumundan ��karken maksimum h�z�.

       V�cutlar�n�z�n �ARPI�MA  durumundan varsay�landan daha D�ZG�N bir �ekilde ��kmas�n� sa�lamak istedi�inizde bu �zelli�i 
       kullan�n.


          m_Rigidbody.velocity = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);

          Debug.Log(m_Rigidbody.maxDepenetrationVelocity);

        Rigidbody 'nin HAM ( Default ) haliyle �arp��ma durumundan ��kma h�z� 10 ' MU� ! ! !
       Ama tabiki biz bu �arp��ma durumunda ��kma h�z�n� kendimiz de belirleyebiliriz. ( atayabiliriz. )

        */


        #endregion


        #region 26 ) Rigidbody.MovePosition ( )

        /*
        MovePosition : Haraket Pozisyonu 

        Kinematik kat� cismi KONUMA do�ru hareket ETT�R�R (TA�IR ).

        Rigidbody.MovePosition bir Rigidbody 'Yi ta��r ve enterpolasyon ayarlar�yla uyumludur. Rigidbody enterpolasyonu 

        etkinle�tirildi�inde, Rigidbody.MovePosition �er�eveler aras�nda yumu�ak bir ge�i� olu�turur. Unity , her �a�r�da bir

        RigidbodyFixedUpdate ta��r . D�nya position uzay�nda ger�ekle�ir. Bir Rigidbody'yi bir konumdan di�erine ���nlamak, 

        MovePosition yerine Rigidbody.position kullan�n ! ! ! 

        
        Vector3 m_Input = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        m_Rigidbody.MovePosition(gameObject.transform.position + m_Input* Time.deltaTime*2f);
      
        Bu metodun i�inde Rigidbody ' e sahip objenin KEND� KONUMUNU G�RMEN �ART. 

        Bunu  ��nk� Metodun isminden ( MovePosition : Hareket Pozisyonu ) anlars�n. 

        */

        #endregion


        #region 27 ) Rigidbody.MoveRotation ( )

        /*
         
        KATI C�SM� D�ND�R�R.

         Bir Rigidbody ��esini d�nd�rmek i�in Rigidbody.MoveRotation ��esini Rigidbody'nin enterpolasyon ayar�na uygun olarak
         kullan�n.

        - Rigidbody �zerinde Rigidbody enterpolasyonu etkinle�tirilirse, Rigidbody.MoveRotation ��esinin �a�r�lmas� , olu�turulan 
          herhangi bir ara karede iki d�nd�rme aras�nda yumu�ak bir ge�i� sa�lar. 

        - Her bir FixedUpdate i�inde bir kat� cismi S�REKL�  olarak D�ND�RMEK  istiyorsan�z bu kullan�lmal�d�r !!!!!

        - Bir kat� cismi hi�bir ara konum olu�turulmadan bir d�n��ten di�erine  ���nlamak istiyorsan�z, bunun yerine
          Rigidbody.rotation �zelli�ini kullan�n.

        
        Vector3 eulerDondurmeVektoru = new Vector3(0f, 20f, 0f);
        Quaternion euler = Quaternion.Euler(eulerDondurmeVektoru * Time.deltaTime);
        m_Rigidbody.MoveRotation(m_Rigidbody.rotation * euler );

          G�rd���n gibi obje S�REKL� D�N�YOR.

        */

        #endregion


        #region 28 ) Rigidbody.name

        // Debug.Log(m_Rigidbody.name);

        // Rigidbody' e sahip objenin Unity 'de Hierarchy 'deki ismini YAKALAR ! ! !


        #endregion


        #region 29 ) Rigidbody.position

        /*
         
        Debug.Log(m_Rigidbody.position);

      -- Rigidbody ' sahip objenin konumu = ( -1.97, 0.509 , 0.77 ) 'ymi�. BU KODU YAZDIKTAN SONRA �IKTIMIZ AYNEN ��YLE : 
         ( -2.0 , 0.5 , 0.8 ). Yani burdan �unu anl�yoruz yuvarlak say�lar� en yak�n say�ya YUVARLIYOR.

      -- Rigidbody.position, fizik motorunu kullanarak bir Rigidbody'nin KONUMUNU alman�z� ve ayarlaman�z� sa�lar. 
         Bir Rigibody'nin konumunu Rigidbody.position kullanarak de�i�tirirseniz, d�n���m sonraki fizik sim�lasyonu ad�m�ndan 
         sonra g�ncellenecektir.Bu, Transform.position'� kullanarak konumu g�ncellemekten daha HIZLIDIR ! ! !
         ��NK� ikincisi t�m ba�l� �arp��t�r�c�lar�n konumlar�n� Rigidbody'ye g�re yeniden hesaplamas�na neden olacakt�r.

         Bir kat� cismi S�REKL� olarak ta��mak istiyorsan�z, bunun yerine enterpolasyonu hesaba katan MovePosition'� kullan�n.

        

        Vector3 anlayisObjesininKonumu = o_Anlayis.transform.position;
        m_Rigidbody.position = anlayisObjesininKonumu;

        */

        #endregion


        #region 30 ) Rigidbody.ResetCenterOfMass ( )

        /*
         
        Kat� cismin K�TLE MERKEZ�N� SIFIRLAR.

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

        
         
        Rigidbody.position, fizik motorunu kullanarak bir Rigidbody'nin D�N���N�  alman�z� ve ayarlaman�z� sa�lar. 

        Bir Rigidbody'nin d�n���n� Rigidbody.rotation kullanarak de�i�tirmek, sonraki fizik sim�lasyon ad�m�ndan sonra 
        D�n���m'� g�nceller. Bu, Transform.rotation kullanarak d�n��� g�ncellemekten daha HIZLIDIR, ��nk� Transform.rotation
        t�m ba�l� �arp��t�r�c�lar�n d�n��lerini Rigidbody'ye g�re yeniden hesaplamas�na neden olurken, Rigidbody.rotation de�erleri
        do�rudan fizik sistemine ayarlar.

         Bir kat� cismi S�REKL� d�nd�rmek istiyorsan�z, bunun yerine enterpolasyonu hesaba katan MoveRotation'� kullan�n.

        

        Debug.Log(m_Rigidbody.rotation); // HAM ( DEFAULT ) haliyle ( 0.0, 0.0 , 0.0 , 1.0 ) De�erini al�yormu�.

        */

        #endregion


        #region 33 ) Rigidbody.SetDensity ( )

        /*
           SAB�T bir yo�unlu�u varsayarak ekli �arp��t�r�c�lara dayal� olarak K�TLEY� ayarlar.

           Bu, k�tleyi �arp��t�r�c�lar�n boyutuna g�re �l�eklenen bir de�ere ayarlamak i�in kullan��l�d�r.
         
           YAN�  Rigidbody 'N�N K�TLES�N� ayarlamam�z� sa�lar ! ! ! ! !
        
      

        m_Rigidbody.SetDensity(setDensityYaniKutleDegeri);
        Debug.Log(m_Rigidbody.mass);
      
        */

        #endregion


        #region 34 ) Rigidbody.Sleep ( )

        /*
          Rigidbody ' i EN AZ B�R KARE UYUMAYA ZORLAR.
          Projemi �al��t�rd���m objede rigidbody olmas�na ra�men obje y�kseklikte duruyor ve yere d��m�yor. 30 saniye , 40 saniye
           belki dahada fazla yere d��meden havada beklicek. ��te method bu i�e yar�yor ! ! 

        m_Rigidbody.Sleep();

        */
        #endregion


        #region 35 ) Rigidbody. sleepThreshold

        /*
         
         sleepThreshold : Uyku e�i�i
          
         Alt�nda nesnelerin uyumaya ba�lad��� k�tle olarak NORMAL�ZE edilmi� ENERJ� E����.
        
         Debug.Log(m_Rigidbody.sleepThreshold);  HAM ( DEFAULT ) haliyle rigidbody 'nin UYKU E����  0.005 De�erindeymi�.

         B�Z bu uyku e�i�ini KEND�M�Z DE BEL�RLEYEB�L�R�Z.

        */


        #endregion


        #region 36 ) Rigidbody.solverIterations

        /*

       ( solver Iterations : ��z�c� yineleme say�s� )

         -- solventIterations, Rigidbody eklemlerinin ve �arp��ma temaslar�n�n ne kadar do�ru ��z�mlendi�ini belirler.
              Physics.defaultSolverIterations'� ge�ersiz k�lar. Olumlu olmal�.

          --  Ba�l� Sert G�vdelerle ilgili sorun ya��yorsan�z, sal�n�m yap�yor ve karars�z davran�yorsan�z, daha y�ksek bir ��Z�C� 
              Y�NELEME SAYISI ayarlamak kararl�l�klar�n� art�rabilir (ancak daha yava�t�r).

        YAN� Rigidbody 'nin �arp��mada daha KARARLI olabilmesini sa�lar ! ! !



        Debug.Log(m_Rigidbody.solverIterations); 
        
        HAM ( DEFAULT ) haliyle Rigidbody 'nin �arp��malarda kararl� olma de�eri  6 'ym��.
       

        m_Rigidbody.solverIterations = 30; 

        i�te biz bu default 6 de�erini art�rarak Rigidbody ' i �arp��malarda daha kararl� hale getirebiliyoruz.

            
            */

        #endregion


        #region 37 ) Rigidbody.solverVelocityIterations

        /*
           solverVelocityIterations : ��z�c� HIZ Yinelemeleri
         
            ��z�c� h�z yinelemeleri , Rigidbody eklemlerinin ve �arp��ma temaslar�n�n ne kadar do�ru ��z�mlendi�ini etkiler.
            Physics.defaultSolverVelocityIterations ' � ge�ersiz k�lar. Olumlu olmal�.
         
         

        Debug.Log(m_Rigidbody.solverVelocityIterations);
        HAM (DEFAULT) HAL�YLE  Rigidbody 'nin �arp��malarda H�z kararl�l��� de�eri 1 mi� ! ! ! ! ! ! 

        m_Rigidbody.solverVelocityIterations = 5;

        i�te biz bu default 1 de�erini art�rarak Rigidbody 'nin �arp��malarda HIZ KARARLI�INI art�rabiliyoruz.

        YAN����� bu de�erin artt�r�lmas�, bir Rigidbody s��ramas�ndan sonra ortaya ��kan ��k�� h�z�n�n daha y�ksek do�rulu�u ile 
        sonu�lanacakt�r. �arp��malardan sonra eklemli Rigidbodies veya Ragdoll'lar�n �OK FAZLA  HAREKET ETMES�YLE ilgili sorunlar 
        ya��yorsan�z, bu de�eri ARTIRIN !!!

        */

        #endregion


        #region  38 ) Rigidbody.SweepTest ( )

        /*
         
          Kat� bir cisim sahnede hareket ettirilirse herhangi bir �eyle �arp���p �arp��mayaca��n� test eder.

          Bu, Rigidbody'nin �arp��t�r�c�lar�ndan herhangi birinde bulunan t�m noktalar i�in bir Physics.Raycast yapmaya ve rapor 
          edilen t�m isabetlerin (varsa) en yak�n�n� d�nd�rmeye benzer. Bu, AI kodu i�in yararl�d�r, �rne�in bir nesnenin hi�bir 
          �eyle �arp��madan bir bo�lu�a s��aca��n� bilmeniz gerekiyorsa.

          Bu i�levin yaln�zca kat� cisim nesnesine ilkel bir �arp��t�r�c� t�r� (k�re, k�p veya kaps�l) veya d��b�key bir a� 
          eklendi�inde �al��t���n� unutmay�n - i�b�key a� �arp��t�r�c�lar�, tarama taraf�ndan Sahnede alg�lanabilmelerine ra�men 
          �al��mayacakt�r.

          Sert cisim taramas� herhangi bir �arp��t�r�c�yla kesi�ti�inde True, aksi takdirde false d�ner.

         direction : Kat� cismin s�p�r�lece�i y�n.

         hitInfo   : hitInfo true d�nd�r�l�rse, hitInfo �arp��t�r�c�n�n vuruldu�u yer hakk�nda daha fazla bilgi i�erir. 
        
         maxDistance : S�p�rmenin uzunlu�u.

         queryTriggerInteraction : Bu sorgunun tetikleyicileri vurup vurmayaca��n� belirtir.
        


        
        m_Rigidbody.velocity = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);

        RaycastHit hit;
        bool dogruMu = m_Rigidbody.SweepTest(transform.forward, out hit, 200f);

        if (dogruMu)
        {
            Debug.Log(" �al��t�.");
        }

         YAN� Rigidbody ' e sahip obje ba�ka bir objeyle ( yukar�daki a��klamalar� sa�layan objeler olmas� laz�m )  �arp��aca��n�
         ���n g�nderek anlamam�z� sa�lar.

         Mesela oyunu �al��t�rd���mda characterim ilk ba�ta uzak oldu�u i�in �ALI�MADI ama biraz daha ba�ka objelere yakla��nca
         �ALI�TI ! ! ! ! ! ! 
        
        */

        #endregion


        #region 39 ) Rigidbody.SweepTestAll ( )

        /*

        Rigidbody.SweepTest gibi, ancak t�m isabetleri d�nd�r�r.

        E�er kat� cismin ekli �arp��t�r�c�lar�ndan biri �arparsa, tarama ayn� �ARPI�TIRICIYA birden fazla isabet verebilir.

        Bu i�levin yaln�zca kat� cisim nesnesine ilkel bir �arp��t�r�c� t�r� (k�re, k�p veya kaps�l) veya d��b�key bir a� 
        eklendi�inde �al��t���n� unutmay�n - i�b�key a� �arp��t�r�c�lar�, tarama taraf�ndan Sahnede alg�lanabilmelerine ra�men
        �al��mayacakt�r.

        Bu i�lev yaln�zca 128'e kadar isabet d�nd�rebilir.
        

        m_Rigidbody.velocity = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);

        RaycastHit[] a =  m_Rigidbody.SweepTestAll(transform.forward, 200f);
    
        Debug.Log(a);
       

        */
        #endregion


        #region 40 ) Rigidbody.velocity 

        /*
         
        m_Rigidbody.velocity = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
        Debug.Log(m_Rigidbody.velocity);

        
        Kat� cismin h�z vekt�r�. Rigidbody pozisyonunun de�i�im oran�n� temsil eder.

        �o�u durumda h�z� do�rudan de�i�tirmemelisiniz, ��nk� bu ger�ek�i olmayan davran��lara neden olabilir  bunun yerine

        AddForce ( ) KULLANIN ! ! Bir nesnenin h�z�n� her fizik ad�m�nda AYARLAMAYIN, bu ger�ek�i olmayan fizik sim�lasyonuna yol 

        a�acakt�r. Tipik bir kullan�m, birinci �ah�s ni�anc� ( FPS ) oyununda h�z� de�i�tirece�iniz yerdir, ��nk� h�zda an�nda bir 
        de�i�iklik istersiniz.


        */
        #endregion


        #region 41 ) Rigidbody.WakeUp ( )

        /* Rigidbody 'i UYANDIRIR.
         
        m_Rigidbody.WakeUp();

        */


        #endregion


    }













}