using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Friends : MonoBehaviour
{


    public GameObject Character;
    [SerializeField] GameObject ThirdPoint;
    [SerializeField] List<GameObject> E_enemys = new List<GameObject>();
    [SerializeField] List<GameObject> o_BlackEnemys = new List<GameObject>();
    [SerializeField] GameObject[] AllPoint;

    [SerializeField] Animator F_Anim;

    [SerializeField] float IdentifierDistance;
    [SerializeField] float f_DeathDistance;


    public static bool IsObstacleContact;
    [SerializeField] bool IsMySelfContact;
    [SerializeField] bool IsCharacterContact;
    [SerializeField] float ThirdPoint_Identifier;

    public static bool  IsFriendFinalStage;

      Touch AllTouch;
    int i;

    public static bool IsObstacle;
    public static GameObject CarpanObje;

 

    void Start()
    {
        IsObstacleContact = false;
        IsMySelfContact = false;
        IsCharacterContact = false;

        IsFriendFinalStage = false;

       
    }

   

    private void Update()
    {

        if (IsCharacterContact)
        {
            CharacterAndFriendContact();
        }

        if (IsMySelfContact)
        {
            FriendAndFriendContact();
        }

    
    }


    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.transform.CompareTag("Character"))
        {
            IsCharacterContact = true;
        }


        if (other.gameObject.transform.CompareTag("Player"))
        {
            IsMySelfContact = true;
        }

        if (other.gameObject.transform.CompareTag("Enemy"))
        {
            F_Anim.Play("Death");
            Destroy(gameObject, 0.2f);

        }

        if(other.gameObject.transform.CompareTag("Obstacle"))
        {
            CarpanObje = gameObject;
            F_Anim.Play("Death");
            Destroy(CarpanObje, 0.9f);
            Destroy(F_Anim, 0.9f);
            IsObstacle = true;
        }


    }


   

    void CharacterAndFriendContact()
    {
        gameObject.GetComponentInChildren <SkinnedMeshRenderer>().material.color = Color.yellow;

        Character.transform.position = new Vector3(Character.transform.position.x, 0f, Character.transform.position.z);
        gameObject.transform.SetParent(Character.transform);

        Vector3 aBs = Character.transform.eulerAngles;
        gameObject.transform.rotation = Quaternion.Euler(aBs.x, aBs.y, aBs.z);

        AllAnimasyonController();


        if (First_Point.IsTrigger)
        {
            EndGameFriendsAction();
        }

      
    }


    void FriendAndFriendContact()
    {

        gameObject.GetComponentInChildren<SkinnedMeshRenderer>().material.color = Color.yellow;

        Character.transform.position = new Vector3(Character.transform.position.x, 0f, Character.transform.position.z);
        gameObject.transform.SetParent(Character.transform);

        Vector3 RBs = Character.transform.eulerAngles;
        gameObject.transform.rotation = Quaternion.Euler(RBs.x, RBs.y, RBs.z);


        AllAnimasyonController();


        if (First_Point.IsTrigger)
        {
            EndGameFriendsAction();
        }



    }


    void AllAnimasyonController()
    {

        if (Input.touchCount > 0)
        {

            AllTouch = Input.GetTouch(0);

            if (AllTouch.phase == TouchPhase.Began)
            {
                F_Anim.SetBool("IsRush", true);
            }

            if (AllTouch.phase == TouchPhase.Moved)
            {
                F_Anim.SetBool("IsRush", true);
            }

            if (AllTouch.phase == TouchPhase.Stationary)
            {
                F_Anim.SetBool("IsRush", true);

            }

            if (AllTouch.phase == TouchPhase.Ended)
            {
                F_Anim.SetBool("IsRush", false);

            }


        }


    }


    void EndGameFriendsAction()
    {

        int j = Random.Range(0, 4);


        F_Anim.SetBool("IsRush", true);

        gameObject.transform.GetComponent<NavMeshAgent>().SetDestination(AllPoint[j].gameObject.transform.position);


        if (Vector3.Distance(gameObject.transform.position, ThirdPoint.transform.position) < ThirdPoint_Identifier)
        {

            F_Anim.SetBool("IsPunch", true);
            gameObject.transform.LookAt(o_BlackEnemys[i].gameObject.transform, Vector3.up);

           IsFriendFinalStage = true;
          
        }

        IsFriendFinalStage = true;

    }


    #region BU SCR�PT� �LERDE S�LMEN GEREKEN B�R DURUM OLURSA B�LE BU YAZDI�IM �EYLER� SAKIN S�LME - 1  *****************************

    /*

     Enemy ve Friend 'leri D�Z� i�erisine tan�mlam��t�k :

     Menzile girdi�i zaman Enemy ve Friend Birbirine ko�uyor �lme animasyonlar� ger�ekle�iyor ve daha sonra bunlar� yok
     ediyorduk.Ancak TAM BU NOKTADA sen bu 2 objeyi yok ettin ancak 2 TANE �� ��E GE�M�� FOR D�NG�S�NDE BU objelere
     TEKRAR ULA�MAYA �ALI�IYORSUN HATASINI ALIYORDUN tam 1 HAFTA BOYUNCA BU HATAYI ��ZEMED�N.

     BU HATAYI ��YLE ��ZD�M  : 

     D�Z�LERDE  ELEMAN SAYISI BELL� OLMAK ZORUNDADIR YAN� 5 SE OYUNDAN �STER �LD�RME �STER BA�KA AKS�YON OLSUN BU D�Z� 5 
     ELEMANLI OLARAK DEVAM ETMEK ZORUNDADIR.

     ANCAK biz  L�ST 'LER� KULLANIRSAK BU L�ST ' LERDE ELEMAN SAYISI BELL� DE��LD�R OYUNLARDA  �LD�RME VEYA D��ER AKS�YONLARA
     G�RE ELEMAN SAYISI(�STED���M�Z YERDE ARTIRAB�L�R �STED���M�Z YERDE ) AZALTAB�L�R�Z !!!!!!!!!!!!!!!!!!!!!!!!!!


    */

    #endregion


    #region BU SCR�PT� �LERDE S�LMEN GEREKEN B�R DURUM OLURSA B�LE BU YAZDI�IM �EYLER� SAKIN S�LME 2 *****************************

    /*

     Hem Really_Meet ' deki Scriptindeki bu k�sm� SAKIN S�LME HEMDE BU YAZDIKLARIMI SAKIN S�LME.

     �imdi sen baz� durumlarda ETK�LE��MLER�  MESAFEDEN  yakalaman gereken durumlar olabilir. Ancak bu durumlarda
     E�er DEBUG  edersen  o durumun MESAFEDEN yap�labilip yap�lamad���n� ANLARSIN. 


    */

    #endregion


    #region 3 haftad�r 2 tane Friend ' in ayn� anda Enemy ' e  gitme sorunun ��z�m�n� anlatan KISIM 

    /*

     mesafe 'yi Death distance ' dan k���k olduktan sonra silmedin D�REK BU HAL�YLE YAPTIN. ��nk� di�er denemelerinde hepsinde
     mesafe 1 ' den k���k oldu�unda yok olup listelerden siliniyolard�. �imdi burda �YLE B�R �EY YOK  TR�GGER olduklar�nda
     kendi ( Friends ve Enemys) Scriptlerindeki kodlar�n sayesinde D�REK S�L�N�P �lecekler.B�YLECE 3 HAFTADIR ALDI�IN HATAYI
     ��ZM�� OLDUN . !!!  

    */


    #endregion


    #region 4 g�nd�r ��zemedi�in sorun �u : Friend OBstacle ' ile temas�n� yakalayam�yoduk.BUNUN ��Z�M� ��YLE : 


    /*

    Biz Scripti ' � Obstacle 13 ' �n annesine y�kledik ve onu baz ald�k. Box Collider ' � �ocuk objelere eklemi�tik.
    Ana obje bo� obje oldu�u i�in ve biz bu objeye baz� componentler ( animator ) eklesekte biz Scripti ANNE OLAN OBJEYE DE��L
    �OCUK OLAN OBJELERE eklememiz laz�m ��NK� ONLAR BO� B�R GAMEOBJECT DE��LLER ! ! ! ! ! ! ! ! 

    */

    #endregion


    #region 1 Haftad�r  AllObstacleController Scriptindeki SORUNUN ��Z�M� 

    /*

    SORUN : Allobstacle Scriptinde Objeyi �ld�rd�n fakat Animasyonuna ula�maya �al���yorsun hatas�n� ald�n.

    ��Z�M :  TriggerController Scriptine gidip Animasyon List ' i sildin.ORda gerekli animasyonlara
             gameobject.getComponent<Animator>() �EKL�NDE ula�arak i�lemleri yapt�n ve b�ylece SORUNU ��ZM�� OLDUN ! ! ! ! ! 


    */

    #endregion
}
