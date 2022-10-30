using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Friends : MonoBehaviour
{

    [SerializeField] Trigger_Controller b;

    [SerializeField] List<GameObject> o_BlackEnemys = new List<GameObject>();


    public GameObject Character;
    [SerializeField] Animator F_Anim;
    [SerializeField] GameObject ThirdPoint;
    [SerializeField] float ThirdPoint_Identifier;


    [SerializeField] float IdentifierDistance;
    [SerializeField] float f_DeathDistance;

    public static bool IsObstacleContact;
    [SerializeField] bool IsMySelfContact;
    [SerializeField] bool IsCharacterContact;


    public static bool IsFriendFinalStage;

    public static bool IsObstacle;
    public static GameObject CarpanObje;


    public static GameObject FollowUpCameraObject;


    Touch AllTouch;
    int i;

 
    void Start()
    {
        IsObstacleContact = false;
        IsMySelfContact = false;
        IsCharacterContact = false;

        IsFriendFinalStage = false;

        FollowUpCameraObject = GameObject.FindGameObjectWithTag("FollowUp");
        

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

        if (IsFriendFinalStage)
        {
            DeathFriend();
        }

    }



    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.transform.CompareTag("Character"))
        {
            IsCharacterContact = true;
        }


        if (collision.gameObject.transform.CompareTag("Player"))
        {
            IsMySelfContact = true;
        }

        if (collision.gameObject.transform.CompareTag("Enemy"))
        {
            F_Anim.Play("Death");
            Destroy(gameObject, 0.2f);

        }

        if (collision.gameObject.transform.CompareTag("Obstacle"))
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
        gameObject.GetComponentInChildren<SkinnedMeshRenderer>().material.color = Color.yellow;

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

        gameObject.transform.SetParent(null);
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
       
        gameObject.transform.SetParent(null);
        gameObject.transform.SetParent(FollowUpCameraObject.gameObject.transform); // ==> FollowUp Script

        FollowUpCameraObject.transform.GetComponent<NavMeshAgent>().SetDestination(ThirdPoint.gameObject.transform.position);
       
        F_Anim.SetBool("IsRush", true);

        gameObject.transform.GetComponent<Rigidbody>().isKinematic = true; // BU KODU YENÝ YAZDIN.
        gameObject.transform.GetComponent<NavMeshAgent>().SetDestination(ThirdPoint.gameObject.transform.position);
     

        if (Vector3.Distance(gameObject.transform.position, ThirdPoint.transform.position) < ThirdPoint_Identifier)
        {

            F_Anim.SetBool("IsPunch", true);
            //  gameObject.transform.LookAt(o_BlackEnemys[i].gameObject.transform, Vector3.up);

            gameObject.transform.LookAt(ThirdPoint.gameObject.transform, Vector3.up);
          
        }

        IsFriendFinalStage = true;

      
    }


    void DeathFriend()
    {
        b.enabled = false;
        F_Anim.SetBool("IsDeath", true);
        Destroy(gameObject, 8f);
    }


    #region  BU SCRÝPTÝ ÝLERDE SÝLMEN GEREKEN BÝR DURUM OLURSA BÝLE BU YAZDIÐIM ÞEYLERÝ SAKIN SÝLME - 1  *****************************

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


    #region 15 EKÝM : Bir gün boyunca çözemediðin sorunun çözümü

    /*

    SORUN :  Projede çok fazla deneme yapmamdan dolayý Projede olmasý gereken  önemli olaylardan  biri saçmaladý. Bu olay þuydu :

             Friend kendi içinde temas ettiði zaman PROJEDE NEKADAR FRÝEND VARSA hepsi ayný ANDA HAREKET EDÝYORDU. 

    ÇÖZÜM : Bu sorunun kaynaðý þu : Sen deðiþkenlerden IsMySelfContact deðiþkenini public static bool olarak deðiþtirdin.Ýþte
            sorun buydu. PEKÝ NEDEN public static bool IsMySelfContact olunca böyle bir hata aldýn bunu ARAÞTIR ÇÜNKÜ ÖNEMLÝ ! ! ! ! !

    */

    #endregion




    // NOT 1 : Static OLMAYAN bir metotun içinde  static OLAN bir metot çaðrýlabilir.
    // NOT 2 : Static OLAN bir metotta ise static OLMAYAN bir baþka metot ÇAÐRILAMAZ.Yani static olan metotlarda sadece
    //         StaTÝC OLAN metotlar çaðrýlabilir ! ! ! ! ! ! ! ! ! ! 

    /*  YAPILMASI GEREKENLER : 

     1 ) Character 'in ENEMY VE BLACK LE ETKÝLEÞÝME GÝRMESÝ
     2 ) ÖLDÜKLERÝNDE efektin çýkmasý
     3 ) Screen ayarlarýnýn yapýlmasý... 



    1 ) CHARACTERÝN TEMAS EDEBÝLMESÝNÝ SAVAÞA GÝTMESÝNÝ VE MENÜ SÝSTEMÝNÝ YAP ......

    2 ) Friend 'in Enemy ' e çarpýþmak için giderkenki  HIZINI ARTIR ! ! ! ! ! ! ! !

    3 ) Friend Enemy 'le çarpýþma anýnda bazen ÇARPIÞAMIYOR KOÞU ANÝMASYONUNUNDA TAKILI KALIYOR .....



        OYUN OYNANIRKEN YAPILAN HATALAR : 

        1) Bazý anlarda Enemy ve Friend düzgün çarpýþamýyor ve Ölmesi gereken Friend Ölmüyor. Bu hatayý düzelt.

        2 ) Black Ve Friend ' ler birbirleriyle KAVGA ETMEYE BAÞLAMADAN ÖNCE  TouchController ' u SÝLMEN  YA DA PASÝF YAPMAN LAZIM.

    */


    #region HATIRLATMA BÝLGÝ

    // Eðer IEnumerator ' leri kullanmak istiyorsan kodun taaa EN BAÞINA GÝDÝP using.System.Collections ' u YAZMAN GEREKÝYOR ! ! ! ! ! ! 

    #endregion

    #region Bu scriptte 1 haftadýr çözemediðin sorunun ÇÖZÜMÜ  


    // SORUN: Black ' lerin ölme animamasyonu ve yok olmasý göze hoþ gelen ve mantýklý bir þekilde deðil.

    // ÇÖZÜM : Unity Tarafýnda Animator componentinde  Exit Time süresi artýrýldý ve bu scriptte Death time Süresi 2.5 ' den 3 yapýldý. 

    #endregion






}
