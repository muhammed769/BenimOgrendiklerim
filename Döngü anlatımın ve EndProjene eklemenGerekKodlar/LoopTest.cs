using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopTest : MonoBehaviour
{

    [SerializeField] GameObject[] ElementsArray;
    int i;

    public Rigidbody Rg;
    //public Rigidbody[] rgArray;

    float refYVelocity = 0f;
    float refXVelocity = 0f;

    float StartTime;
   [SerializeField]  float my_Time ; // S�re ne kadar fazla olursa obje o kadar yumu�ak  bir �ekilde hedefe gider.

    /*
    [SerializeField] float IdentifierDistance;
    [SerializeField] float RayMaxDistance;
    [SerializeField] bool IsAction;
    RaycastHit hit;
    bool IsHit */



    void Start()
    {
        //IsAction = false;
        StartTime = 0f;


    }
    void Update()
    {


        #region While D�ng�s� �rnek 1 

        /*  Debug.Log(ElementsArray.Length);

        while (i<=ElementsArray.Length)
        {
            Debug.Log(i);
            i++;

        }

        */

        #endregion


        #region While D�ng�s� �rnek 2 

        /*

        while (i<ElementsArray.Length)
        {
            gameObject.transform.position = ElementsArray[i].transform.position + new Vector3(0f,0f,3f);
            i++;

        }

        */

        #endregion


        #region Foreach d�ng�s� END projenende kullanaca��n �eyler var silme.

        /*

        float horiz = Input.GetAxis("Horizontal");
        float vertic = Input.GetAxis("Vertical");
        transform.Translate(new Vector3(horiz, 0f, vertic) * Time.deltaTime*2f);

        foreach (var elemanlar in ElementsArray)
     {

            // Debug.Log(ElementsArray[i].transform.name);

            

             Ne istiyorsun ? 

       1 )  objem birinci d��man�ma yakla��nca ikinci d��man ���nc� d��man�n yan�na gitsin ve yukar� dogru z�plas�n.  

                float m_Distance = Vector3.Distance(gameObject.transform.position, ElementsArray[0].transform.position);

            if (m_Distance < IdentifierDistance)
            {
                Vector3 SecondElementPoint=  ElementsArray[2].transform.TransformPoint(Vector3.forward * 2f);

                ElementsArray[1].transform.position = Vector3.Lerp(ElementsArray[1].transform.position, SecondElementPoint, Time.deltaTime * 0.5f);


       2 ) Objem birinci objeye yakla��nca 2 obje kendi etraflar�nda d�ns�nler.       

             
              float m_Distance = Vector3.Distance(gameObject.transform.position, ElementsArray[2].transform.position);

            if (m_Distance < IdentifierDistance)
            {
                //ElementsArray[1].transform.RotateAround(ElementsArray[2].transform.position, Vector3.up, 25 * Time.deltaTime);

                ElementsArray[2].transform.RotateAround(ElementsArray[1].transform.position, Vector3.up, 25 * Time.deltaTime);

            }


       3 ) 
            BUNU KULLAN END oyununda......

           

            // Yeni bir mekanik buldun SAKIN S�LME ! ! ! ! ! ! ! ! ! ! 

            // Debug.Log(gameObject.transform.localScale);
               IsHit = Physics.Raycast(gameObject.transform.position, Vector3.left, out hit, RayMaxDistance); 
         
            if (IsHit)
            {

                Vector3 SecondElementPos=    ElementsArray[2].transform.TransformPoint(Vector3.forward * 5f);
                ElementsArray[1].transform.position = Vector3.Lerp(ElementsArray[1].transform.position,SecondElementPos , Time.deltaTime * 0.5f);

                IsAction = true;
            }
            else
            {
                IsAction = false;
            }
            if (IsAction)
            {
                ElementsArray[2].transform.position = Vector3.Lerp(ElementsArray[2].transform.position, ElementsArray[1].transform.position, Time.deltaTime * 0.5f);
            }

    }
            */

        #endregion


        #region For D�ng�s�

        /*
           for (int i = 0; i < ElementsArray.Length; i++)
           {

               // Debug.Log(ElementsArray[i].name);

               for (int j = 0; j < rgArray.Length; j++)
               {
                   rgArray[j].velocity = Vector3.right;

                   if (j >= 2)
                   {
                       rgArray[j].velocity = -Vector3.right;
                   }

               }

           }


         �� ��E FOR D�NG�S�NDE i�teki for d�ng�s� tamam� �al���r sonra d��taki for d�ng�s�nde i 1 art�r�l�r ve bu �ekilde devam
         edilir.

        
        for (int i = 0; i < 3; i++)
        {
            Debug.Log("D��taki for �al��t�.");

            for (int j = 0; j < 5; j++)
            {
                Debug.Log("��teki for �al��t�");
            }

        }

        /*
        D��taki
         i�teki
         i�teki
         i�teki
         i�teki
         i�teki
        D��taki
         i�teki
         i�teki
         i�teki
         i�teki
         i�teki
        D��taki
         ��teki
         i�teki
         i�teki
         i�teki
         i�teki
        
        ��kt�y� bu �ekilde bize vermi�tir.Burdan anlamaya �al��.

        Bunu Start Metoduna yazarsan daha net olarak anlars�n.

        */

        #endregion


        #region �� ��e For D�ng�s�

        /*

        i = 0;

        while (i < ElementsArray.Length)
        {
            float mesafe = Vector3.Distance(gameObject.transform.position, ElementsArray[0].transform.position);
            if (mesafe < 3f)
            {
                Debug.Log("Mesafe azald� HERHANG� bir i�lem yapay�m m�  ? ");
                for (int j = 0; j <ElementsArray.Length; j++)
                {
                    if (ElementsArray[j].transform.CompareTag("Sag"))
                    {
                        ElementsArray[j].transform.GetComponent<Rigidbody>().AddForce(new Vector3(0f, 0.3f, 0f), ForceMode.Force);
                    }
                }
            }
            i++;

            // bu k�s�mda baz� d�zenlemeler yapacaks�n.....

        }

        */

        #endregion


        #region Bunu oyunda MUTLAKA Kullan.


        /* ************************************************************************************
          1.�rnek

            float newPos =   Mathf.SmoothDamp(transform.position.y, ElementsArray[0].transform.position.y, ref refYVelocity, .5f);
            transform.position = new Vector3(transform.position.x, newPos, transform.position.z);

           obje s�rekli di�er objenin y�ksekli�ine ula�mak i�in z�pl�yor....
        
        ************************************************************************************
          2.�rnek
      Vector3 SixUpPos=  gameObject.transform.TransformPoint(Vector3.up * 4f);

        float newPosition =   Mathf.SmoothDamp(gameObject.transform.position.y, SixUpPos.y, ref refYVelocity, 0.5f);
        gameObject.transform.position = new Vector3(gameObject.transform.position.x, newPosition, gameObject.transform.position.z);

        ************************************************************************************
        
        */

        #endregion


        #region Bunuda Oyunda MUTLAKA kullan.

        /*
         
        float t = (Time.time - StartTime) / my_Time;

        float ObjenimYumusakIlerletilmesi = Mathf.SmoothStep(gameObject.transform.position.x, ElementsArray[0].transform.position.x, t);
        gameObject.transform.position = new Vector3(ObjenimYumusakIlerletilmesi, gameObject.transform.position.y, gameObject.transform.position.z);

        */

        #endregion




    }



}
