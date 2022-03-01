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

        /* Ýki DÖNÜÞ arasýndaki açýyý DERECE cinsinden HESAPLAR.
        float angle =      Quaternion.Angle(Tercuman.transform.rotation, gameObject.transform.rotation);
        Debug.Log(angle); */

        #endregion


        #region Quaternion.AngleAxis ( ) 

        // Tercuman.gameObject.transform.rotation =    Quaternion.AngleAxis(20f, Vector3.right);
        // Tercüman objesini X ekseni etrafýnda 20 derece DÖNDÜRMÜÞ OLDUK.

        #endregion


        #region Quaternion.Dot ( ) ANLAMADIN 

        /* Ýki dönüþ arasýndaki nokta çarpýmý

        float IkiDonusArasindakiNoktacarpimi = Quaternion.Dot(Tercuman.transform.rotation, gameObject.transform.rotation);
        Debug.Log(IkiDonusArasindakiNoktacarpimi);

        Vector3 TercumanRotationVectorleri = new Vector3(2f, 1f, 5f);
        Vector3 ObjeminRotationVectorleri = new Vector3(3f, 7f, 4f);
        float IkiVektorunNoktasalCarpimi = Vector3.Dot(TercumanRotationVectorleri, ObjeminRotationVectorleri);
        Debug.Log(IkiVektorunNoktasalCarpimi); // === 33 çýkýyor

        */
        #endregion


        #region Quaternion.Equals

        // Debug.Log(  Quaternion.Equals(transform.rotation, Tercuman.transform.rotation)); 
        // Rotation Deðerleri ayný mý deðil mi kontrol eder.

        #endregion


        #region Quaternion.Euler ( )

        //    gameObject.transform.rotation  =  Quaternion.Euler(20f, 20f, 20f); // z,x,y eksenlerinde objeyi döndürür.

        #endregion


        #region Quaternion.FromToRotation () Update metoduna yaz.

        /* Objenin KENDÝ EKSENÝ ETRAFINDA dönmesini istiyorsak bu metodu kullanýrýz.
           Bir vektörden diðer bir vektöre dönen bir DÖNÜÞ oluþturur.

           transform.rotation = Quaternion.FromToRotation(Vector3.up, transform.forward); // kendi ekseni etrafýnda döndü.

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
        //  Dönüþün TAM TERSÝNÝ YAKALAR.
        #endregion


        #region Quaternion.kEpsilon

        // Debug.Log( Quaternion.kEpsilon ); Epsilonun deðeri 1*10 Üzerisi -6 ymýþ.

        #endregion


        #region Quaternion.Lerp ( ) Update Metoduna yaz.

        // DEFTERDEKÝ SON AÇIKLAMALARA MUTLAKA BAK YOKSA  ANLAMAZSIN BU METODU ! ! 

        // a.transform.rotation = Quaternion.Lerp(Tercuman.transform.rotation, gameObject.transform.rotation,Time.time*0.1f);

        //     a.transform.rotation = Quaternion.Lerp(Tercuman.transform.rotation, gameObject.transform.rotation, Time.time*0.1f);

        // YANÝ obje 2 tane rotasyon deðeri gireriz ve t [ 0,1 ] saniye aralýðýnda OLMAK ÞARTIYLA bu rotasyon deðerlerinde döner.

        // Yani ZAMANA BAÐLI OLARAK BÝR OBJENÝN DÖNEMESÝNÝ SAÐLARIZ.

        #endregion


        #region Quaternion.LerpUnclamped () Update Metoduna yaz.

        // a.transform.rotation = Quaternion.LerpUnclamped(gameObject.transform.rotation, Tercuman.transform.rotation, Time.time * 0.1f);
        // Belirttiðim Rotasyonlarda döner ama bunu ( t = [0,1 ] )  'dan BÜYÜK DEÐERLERDE ALABÝLÝREK YAPABÝLÝR. 

      //  LerpUnclamped ' in Lerp 'ten TEK FARKI t =  [0, 1] ÞARTI OLMADIÐI ÝÇÝN OBJE SÜREKLÝ DÖNER !!

        #endregion


        #region Quaternion.Slerp ( ) Update Metoduna yaz.

        /*            Defterde daha detaylý açýklamalarý yaptým DEFTERE MUTLAKA BAK ! !

         gameObject.transform.rotation = Quaternion.Slerp(a.transform.rotation, Tercuman.transform.rotation, Time.time * speed);
                     gameobject ( 5 ,5 ,5 ) ten baþlayýp ( 80,80,80 ) e kadar giderek döner ve bunu  t= [ 0 ,1 ] þartýyla yapar. 
      
       Lerp 'le arasýndaki tek fark Slerp a ve b kuaternioyonlarý arasýnda KÜRESEL ÝNTERPOLASYON YAPAR ve Slerp uzaydaki noktalar yerine yönleri dikkate alýr.

        */
        #endregion


        #region Quaternion.SlerpUnclamped ( ) Update Metoduna yaz.

        //  gameObject.transform.rotation = Quaternion.SlerpUnclamped(a.transform.rotation, Tercuman.transform.rotation, Time.time * speed);

        // SlerpUnclamped ' in Slerp 'ten TEK FARKI  t =  [ 0,1 ] ÞARTI OLMADIÐI ÝÇÝN OBJE SÜREKLÝ DÖNER ! ! 

        #endregion


        #region Quaternion.LookRotation ( ) 


        /* YANÝ BÝR OBJE DÝÐERÝNÝ  kendi Rotasyonuyla ( Rotation x , y ,z ) TAKÝP EDER.

        Vector3 TakipEdecegimYonunIstikameti = Tercuman.transform.position - a.transform.position;
        a.transform.rotation = Quaternion.LookRotation(TakipEdecegimYonunIstikameti);

        Debug.DrawRay(a.transform.position, TakipEdecegimYonunIstikameti, Color.red);

        */
        #endregion


        #region  Quaternion.Normalize

        //   a.transform.rotation =   Quaternion.Normalize(Tercuman.transform.rotation);
        //    Bir obje diðerinin Rotasyon deðerlerini ( Rotation x , y ,z ) alýr ancak büyüklüðü 1 'dir. Bir objenin Rotasyonu neyse diðerininde o olmuþ olur.

        //   Debug.Log(  Quaternion.Normalize(gameObject.transform.rotation)); // gameobject Baþlangýcta Rotasyon deðerleri =  ( 25 , 25, 25 ).Kodu yazdýktan sonra çýktýsý þöyle (0.25, 0.16,0.16,0.94 ) bu dört deðerin büyüklüðü 1 'dir.
        // kodun NE ANLAMA GELDÝÐÝNÝ ÝSPATINI BURDA YAPTIM.

        // Tercuman.transform.rotation =     Quaternion.Normalize(gameObject.transform.rotation);

        #endregion


        #region  Quaternion.RotateTowards ( ) Update metoduna yaz.

        //  gameObject.transform.rotation = Quaternion.RotateTowards(transform.rotation, Tercuman.transform.rotation, Time.deltaTime * 2f);
        //  YANÝ objemizi belirlediðimiz Rotasyonda ( x , y ,z ) döndürebiliyoruz bunuda Zaman ayarý Eklentisiyle yapýyoruz.

        #endregion



    }


    void Update()
    {

       



    }
}
