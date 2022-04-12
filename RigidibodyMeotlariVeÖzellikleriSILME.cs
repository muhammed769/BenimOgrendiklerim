using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyCharacter : MonoBehaviour
{

    public Camera m_Camera;
    [SerializeField] float max_hiz;
    public Rigidbody rg;
    public GameObject helpingObject;

    private void Start()
    {
        max_hiz = 4f;
    }
    private void Update()
    {
        float a = Input.GetAxis("Horizontal");
        float b = Input.GetAxis("Vertical");
        float c = Input.GetAxis("Jump");
        Vector3 toplam = new Vector3(a*Time.deltaTime, c*Time.deltaTime, b*Time.deltaTime);
        transform.Translate(toplam);

        //Vector3 l = new Vector3(0f, 0f,gameObject.transform.position.z);
        //m_Camera.transform.position= Vector3.SmoothDamp(m_Camera.transform.position, gameObject.transform.position, ref l, 10f, max_hiz, Time.deltaTime);


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

        */

        // Vector3 power = new Vector3(1f, 10f, 1f);

        // rg.AddForce(power, ForceMode.Force);
        // rg.AddForce(power, ForceMode.Acceleration);
        // rg.AddForce(power, ForceMode.Impulse);
        //  rg.AddForce(power, ForceMode.VelocityChange);




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



        #region 4 ) Rigidbody.AddRelativeForce ( )

        //rg.AddRelativeForce()
        #endregion

    }


}













