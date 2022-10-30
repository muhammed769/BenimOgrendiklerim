using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Black_Controller : MonoBehaviour
{

    [SerializeField] HyperController Script_Hyper_Controller;

    public static List<GameObject> CurrentBlacks = new List<GameObject>();
    public static List<GameObject> friends = new List<GameObject>();
    [SerializeField] List<GameObject> Black_Enemys = new List<GameObject>();


    public GameObject o_ThirdPoint;

    [SerializeField] float offsetFloat;
    [SerializeField] float distance_Identifier;
    float WithDistance;


    public static bool IsBlackFinalStage;
  public static  bool IsDeath;

    int i;

    private void Start()
    {
        IsBlackFinalStage = false;
        IsDeath = false;

        foreach (var item in Black_Enemys)
        {
            CurrentBlacks.Add(item);
        }

    }

    void Update()
    {
       
        if (First_Point.IsTrigger)
        {
            ControllerEnd();
        }


        if (IsBlackFinalStage)
        {
            DeathBlack();
        }

    }


    void ControllerEnd()
    {
        Script_Hyper_Controller.enabled = false;

        for (int i = 0; i < CurrentBlacks.Count; i++)
        {

            CurrentBlacks[i].gameObject.GetComponent<Animator>().SetBool("IsRun", true);
            CurrentBlacks[i].gameObject.transform.GetComponent<NavMeshAgent>().SetDestination(o_ThirdPoint.transform.position);
            WithDistance = Vector3.Distance(CurrentBlacks[0].gameObject.transform.position, o_ThirdPoint.transform.position);

            if (WithDistance < distance_Identifier)
            {
                CurrentBlacks[i].gameObject.transform.GetComponent<Animator>().SetBool("IsPunch", true);
                CurrentBlacks[i].gameObject.transform.LookAt(o_ThirdPoint.gameObject.transform.position, Vector3.up);

                IsBlackFinalStage = true;
            }

            if (IsDeath)
            {
                CurrentBlacks.RemoveAt(i);
            }

        }

    }

    void DeathBlack()
    {

        for (int i = 0; i < CurrentBlacks.Count-1; i++)
        {
            CurrentBlacks[i].gameObject.GetComponent<Animator>().SetBool("DeathIs", true);
            Destroy(CurrentBlacks[i].gameObject, 3f);
            CurrentBlacks.RemoveAt(i);
        }

        IsDeath = true;

    }

}




#region KODLARI S�LSEN B�LE SAKIN BURAYI S�LME - 1 ��NK� B�R HATANIN ��Z�M�N� ANLATIYORSUN ! ! ! ! ! ! ! ! ! ! ! 

/*

Hata ( Bug ) : Set Destination on can only be called on an active agent that has been placed on a navmesh.
               [ Hedef Ayarla YALNIZCA  bir NavMesh ' e yerle�tirilmi� aktif bir ajanda �a�r�labilir . ]

��Z�M�       :  Unity taraf�nda herbir Black Enemy objelerinin NAVMESH COMPONENT�NDE => Obstacle Avoidance => Radius ' u 0.5 'DEN
                0.6  olarak DE���T�RD�N  ve BlackEnemy ' lerin birbirlerini aras�ndaki bo�luklar� biraz daha ARTIRDIN ! ! !

*/

#endregion


