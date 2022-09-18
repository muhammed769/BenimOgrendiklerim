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


    #region BU SCRÝPTÝ ÝLERDE SÝLMEN GEREKEN BÝR DURUM OLURSA BÝLE BU YAZDIÐIM ÞEYLERÝ SAKIN SÝLME - 1  *****************************

    /*

     Enemy ve Friend 'leri DÝZÝ içerisine tanýmlamýþtýk :

     Menzile girdiði zaman Enemy ve Friend Birbirine koþuyor ölme animasyonlarý gerçekleþiyor ve daha sonra bunlarý yok
     ediyorduk.Ancak TAM BU NOKTADA sen bu 2 objeyi yok ettin ancak 2 TANE ÝÇ ÝÇE GEÇMÝÞ FOR DÖNGÜSÜNDE BU objelere
     TEKRAR ULAÞMAYA ÇALIÞIYORSUN HATASINI ALIYORDUN tam 1 HAFTA BOYUNCA BU HATAYI ÇÖZEMEDÝN.

     BU HATAYI ÞÖYLE ÇÖZDÜM  : 

     DÝZÝLERDE  ELEMAN SAYISI BELLÝ OLMAK ZORUNDADIR YANÝ 5 SE OYUNDAN ÝSTER ÖLDÜRME ÝSTER BAÞKA AKSÝYON OLSUN BU DÝZÝ 5 
     ELEMANLI OLARAK DEVAM ETMEK ZORUNDADIR.

     ANCAK biz  LÝST 'LERÝ KULLANIRSAK BU LÝST ' LERDE ELEMAN SAYISI BELLÝ DEÐÝLDÝR OYUNLARDA  ÖLDÜRME VEYA DÝÐER AKSÝYONLARA
     GÖRE ELEMAN SAYISI(ÝSTEDÝÐÝMÝZ YERDE ARTIRABÝLÝR ÝSTEDÝÐÝMÝZ YERDE ) AZALTABÝLÝRÝZ !!!!!!!!!!!!!!!!!!!!!!!!!!


    */

    #endregion


    #region BU SCRÝPTÝ ÝLERDE SÝLMEN GEREKEN BÝR DURUM OLURSA BÝLE BU YAZDIÐIM ÞEYLERÝ SAKIN SÝLME 2 *****************************

    /*

     Hem Really_Meet ' deki Scriptindeki bu kýsmý SAKIN SÝLME HEMDE BU YAZDIKLARIMI SAKIN SÝLME.

     Þimdi sen bazý durumlarda ETKÝLEÞÝMLERÝ  MESAFEDEN  yakalaman gereken durumlar olabilir. Ancak bu durumlarda
     Eðer DEBUG  edersen  o durumun MESAFEDEN yapýlabilip yapýlamadýðýný ANLARSIN. 


    */

    #endregion


    #region 3 haftadýr 2 tane Friend ' in ayný anda Enemy ' e  gitme sorunun çözümünü anlatan KISIM 

    /*

     mesafe 'yi Death distance ' dan küçük olduktan sonra silmedin DÝREK BU HALÝYLE YAPTIN. çünkü diðer denemelerinde hepsinde
     mesafe 1 ' den küçük olduðunda yok olup listelerden siliniyolardý. Þimdi burda ÖYLE BÝR ÞEY YOK  TRÝGGER olduklarýnda
     kendi ( Friends ve Enemys) Scriptlerindeki kodlarýn sayesinde DÝREK SÝLÝNÝP ölecekler.BÖYLECE 3 HAFTADIR ALDIÐIN HATAYI
     ÇÖZMÜÞ OLDUN . !!!  

    */


    #endregion


    #region 4 gündür çözemediðin sorun þu : Friend OBstacle ' ile temasýný yakalayamýyoduk.BUNUN ÇÖZÜMÜ ÞÖYLE : 


    /*

    Biz Scripti ' ý Obstacle 13 ' ün annesine yükledik ve onu baz aldýk. Box Collider ' ý çocuk objelere eklemiþtik.
    Ana obje boþ obje olduðu için ve biz bu objeye bazý componentler ( animator ) eklesekte biz Scripti ANNE OLAN OBJEYE DEÐÝL
    ÇOCUK OLAN OBJELERE eklememiz lazým ÇÜNKÜ ONLAR BOÞ BÝR GAMEOBJECT DEÐÝLLER ! ! ! ! ! ! ! ! 

    */

    #endregion


    #region 1 Haftadýr  AllObstacleController Scriptindeki SORUNUN ÇÖZÜMÜ 

    /*

    SORUN : Allobstacle Scriptinde Objeyi öldürdün fakat Animasyonuna ulaþmaya çalýþýyorsun hatasýný aldýn.

    ÇÖZÜM :  TriggerController Scriptine gidip Animasyon List ' i sildin.ORda gerekli animasyonlara
             gameobject.getComponent<Animator>() ÞEKLÝNDE ulaþarak iþlemleri yaptýn ve böylece SORUNU ÇÖZMÜÞ OLDUN ! ! ! ! ! 


    */

    #endregion
}
