using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class BenimOgrendiklerimIki : MonoBehaviour
{
    public GameObject Tercuman;
    public GameObject m_Karakterim;
    public GameObject a;
    [SerializeField] float speed;

    public NavMeshAgent navmesh;

    
    void Start()
    {

        #region Quaternion.Angle ( )

        /* �ki D�N�� aras�ndaki a��y� DERECE cinsinden HESAPLAR.
        float angle =      Quaternion.Angle(Tercuman.transform.rotation, gameObject.transform.rotation);
        Debug.Log(angle); */

        #endregion


        #region Quaternion.AngleAxis ( ) 

        // Tercuman.gameObject.transform.rotation =    Quaternion.AngleAxis(20f, Vector3.right);
        // Terc�man objesini X ekseni etraf�nda 20 derece D�ND�RM�� OLDUK.

        #endregion


        #region Quaternion.Dot ( ) ANLAMADIN 

        /* �ki d�n�� aras�ndaki nokta �arp�m�

        float IkiDonusArasindakiNoktacarpimi = Quaternion.Dot(Tercuman.transform.rotation, gameObject.transform.rotation);
        Debug.Log(IkiDonusArasindakiNoktacarpimi);

        Vector3 TercumanRotationVectorleri = new Vector3(2f, 1f, 5f);
        Vector3 ObjeminRotationVectorleri = new Vector3(3f, 7f, 4f);
        float IkiVektorunNoktasalCarpimi = Vector3.Dot(TercumanRotationVectorleri, ObjeminRotationVectorleri);
        Debug.Log(IkiVektorunNoktasalCarpimi); // === 33 ��k�yor

        */
        #endregion


        #region Quaternion.Equals

        // Debug.Log(  Quaternion.Equals(transform.rotation, Tercuman.transform.rotation)); 
        // Rotation De�erleri ayn� m� de�il mi kontrol eder.

        #endregion


        #region Quaternion.Euler ( )

        //    gameObject.transform.rotation  =  Quaternion.Euler(20f, 20f, 20f); // z,x,y eksenlerinde objeyi d�nd�r�r.

        #endregion


        #region Quaternion.FromToRotation () Update metoduna yaz.

        /* Objenin KEND� EKSEN� ETRAFINDA d�nmesini istiyorsak bu metodu kullan�r�z.
           Bir vekt�rden di�er bir vekt�re d�nen bir D�N�� olu�turur.

           transform.rotation = Quaternion.FromToRotation(Vector3.up, transform.forward); // kendi ekseni etraf�nda d�nd�.

         Quaternion TercumaninKendiEKseniEtrafindakiDonusu = Quaternion.FromToRotation(Vector3.right, Tercuman.transform.forward * Time.deltaTime);
         Tercuman.transform.rotation = TercumaninKendiEKseniEtrafindakiDonusu;
        */
        #endregion


        #region Quaternion.identity 

        //  Tercuman.transform.rotation = Quaternion.identity;
        // ROTASYONU SIFIRLAR 
        #endregion


        #region Quaternion.Inverse ( )

        //  m_Karakterim.transform.rotation =  Quaternion.Inverse(Tercuman.transform.rotation);
        //  D�n���n TAM TERS�N� YAKALAR.
        #endregion


        #region Quaternion.kEpsilon

        // Debug.Log( Quaternion.kEpsilon ); Epsilonun de�eri 1*10 �zerisi -6 ym��.

        #endregion


        #region Quaternion.Lerp ( ) Update Metoduna yaz.

        // DEFTERDEK� SON A�IKLAMALARA MUTLAKA BAK YOKSA  ANLAMAZSIN BU METODU ! ! 

        // a.transform.rotation = Quaternion.Lerp(Tercuman.transform.rotation, gameObject.transform.rotation,Time.time*0.1f);

        //     a.transform.rotation = Quaternion.Lerp(Tercuman.transform.rotation, gameObject.transform.rotation, Time.time*0.1f);

        // YAN� obje 2 tane rotasyon de�eri gireriz ve t [ 0,1 ] saniye aral���nda OLMAK �ARTIYLA bu rotasyon de�erlerinde d�ner.

        // Yani ZAMANA BA�LI OLARAK B�R OBJEN�N D�NEMES�N� SA�LARIZ.

        #endregion


        #region Quaternion.LerpUnclamped () Update Metoduna yaz.

        // a.transform.rotation = Quaternion.LerpUnclamped(gameObject.transform.rotation, Tercuman.transform.rotation, Time.time * 0.1f);
        // Belirtti�im Rotasyonlarda d�ner ama bunu ( t = [0,1 ] )  'dan B�Y�K DE�ERLERDE ALAB�L�REK YAPAB�L�R. 

      //  LerpUnclamped ' in Lerp 'ten TEK FARKI t =  [0, 1] �ARTI OLMADI�I ���N OBJE S�REKL� D�NER !!

        #endregion


        #region Quaternion.Slerp ( ) Update Metoduna yaz.

        /*            Defterde daha detayl� a��klamalar� yapt�m DEFTERE MUTLAKA BAK ! !

         gameObject.transform.rotation = Quaternion.Slerp(a.transform.rotation, Tercuman.transform.rotation, Time.time * speed);
                     gameobject ( 5 ,5 ,5 ) ten ba�lay�p ( 80,80,80 ) e kadar giderek d�ner ve bunu  t= [ 0 ,1 ] �art�yla yapar. 
      
       Lerp 'le aras�ndaki tek fark Slerp a ve b kuaternioyonlar� aras�nda K�RESEL �NTERPOLASYON YAPAR ve Slerp uzaydaki noktalar yerine y�nleri dikkate al�r.

        */
        #endregion


        #region Quaternion.SlerpUnclamped ( ) Update Metoduna yaz.

        //  gameObject.transform.rotation = Quaternion.SlerpUnclamped(a.transform.rotation, Tercuman.transform.rotation, Time.time * speed);

        // SlerpUnclamped ' in Slerp 'ten TEK FARKI  t =  [ 0,1 ] �ARTI OLMADI�I ���N OBJE S�REKL� D�NER ! ! 

        #endregion


        #region Quaternion.LookRotation ( ) 


        /* YAN� B�R OBJE D��ER�N�  kendi Rotasyonuyla ( Rotation x , y ,z ) TAK�P EDER.

        Vector3 TakipEdecegimYonunIstikameti = Tercuman.transform.position - a.transform.position;
        a.transform.rotation = Quaternion.LookRotation(TakipEdecegimYonunIstikameti);

        Debug.DrawRay(a.transform.position, TakipEdecegimYonunIstikameti, Color.red);

        */
        #endregion


        #region  Quaternion.Normalize

        //   a.transform.rotation =   Quaternion.Normalize(Tercuman.transform.rotation);
        //    Bir obje di�erinin Rotasyon de�erlerini ( Rotation x , y ,z ) al�r ancak b�y�kl��� 1 'dir. Bir objenin Rotasyonu neyse di�erininde o olmu� olur.

        //   Debug.Log(  Quaternion.Normalize(gameObject.transform.rotation)); // gameobject Ba�lang�cta Rotasyon de�erleri =  ( 25 , 25, 25 ).Kodu yazd�ktan sonra ��kt�s� ��yle (0.25, 0.16,0.16,0.94 ) bu d�rt de�erin b�y�kl��� 1 'dir.
        // kodun NE ANLAMA GELD���N� �SPATINI BURDA YAPTIM.

        // Tercuman.transform.rotation =     Quaternion.Normalize(gameObject.transform.rotation);

        #endregion


        #region  Quaternion.RotateTowards ( ) Update metoduna yaz.

        //  gameObject.transform.rotation = Quaternion.RotateTowards(transform.rotation, Tercuman.transform.rotation, Time.deltaTime * 2f);
        //  YAN� objemizi belirledi�imiz Rotasyonda ( x , y ,z ) d�nd�rebiliyoruz bunuda Zaman ayar� Eklentisiyle yap�yoruz.

        #endregion



    }


    void Update()
    {

       



    }
}
