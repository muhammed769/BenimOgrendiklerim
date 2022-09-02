using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class m_Control : MonoBehaviour
{
    [SerializeField] Trigger_Controller trigger_Controller;
    [SerializeField] Friends[] FriendsScripts;

    public static List<GameObject> End_Friends = new List<GameObject>();
    [SerializeField] List<GameObject> Black = new List<GameObject>();

    [SerializeField] int EndFriendNumber;
    [SerializeField] int EndBlackNumber;

    [SerializeField] float j;                  // Referans Art�� = 1 ya da 2 
    [SerializeField] float FinalFunctionTime;  // Referans = 2f
    [SerializeField] float RepeatingTime;      // Referans = 0.8f

    private void Start()
    {
        j = 1;
    }

    private void Update()
    {

        if (Friends.IsFriendFinalStage && Black_Controller.IsBlackFinalStage)
        {

            AnimationMy();


        }

    }


    void AnimationMy()
    {

        foreach (var item in End_Friends)
        {
            item.gameObject.GetComponent<Animator>().SetBool("IsDeath", true);
            InvokeRepeating("FinalFunction", FinalFunctionTime, RepeatingTime);
        }

    }
    void FinalFunction()
    {

        for (int i = 0; i < End_Friends.Count; i++)
        {

            Destroy(End_Friends[i].gameObject, i + 2.5f + j);
            End_Friends.RemoveAt(i);
            trigger_Controller.enabled = false;

            j += 0.75f;

        }

       
    }

    // denemey yapmaya devam et Youtube ' dan ara�t�r... 


    #region HATALAR 


    /*

     HATA 1 :
     
     Friend ' ler Characterin �n�ne �P G�B� D�Z�LD�KLER�NDE Punch Animasyona ge�emiyor ko�ma animasyonu tak�l� kal�yor
     ve haliyle burdaki �lme animasyonuda d�zg�n �al��m�yor 


    */
    #endregion


}






