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

        */

        // Vector3 power = new Vector3(1f, 10f, 1f);

        // rg.AddForce(power, ForceMode.Force);
        // rg.AddForce(power, ForceMode.Acceleration);
        // rg.AddForce(power, ForceMode.Impulse);
        //  rg.AddForce(power, ForceMode.VelocityChange);




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



        #region 4 ) Rigidbody.AddRelativeForce ( )

        //rg.AddRelativeForce()
        #endregion

    }


}













