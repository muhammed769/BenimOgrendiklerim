using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Black_Controller : MonoBehaviour
{


    public  GameObject o_ThirdPoint;
    [SerializeField] float offsetFloat;
    [SerializeField] float distance_Identifier;

    [SerializeField] List<GameObject> Black_Enemys = new List<GameObject>();
    [SerializeField] GameObject[] AllPoint;
    

    public static bool IsBlackFinalStage;

    public static int BlackEnemysNumber;
    float WithDistance;


    private void Start()
    {
        BlackEnemysNumber = Black_Enemys.Count;
        IsBlackFinalStage = false;
    }

    void Update()
    {
        if (First_Point.IsTrigger)
        {

            ControllerEnd();

        }

    }



    void ControllerEnd()
    {

        for (int i = 0; i < Black_Enemys.Count; i++)
        {

            int j = Random.Range(0, 5);

            if (End_Controller.IsClear)
            {
                Black_Enemys.Remove(End_Controller.carpanBlack);
            }

            Black_Enemys[i].gameObject.transform.GetComponent<Animator>().enabled = true;


               Black_Enemys[i].gameObject.transform.GetComponent<NavMeshAgent>().SetDestination(AllPoint[j].gameObject.transform.position);
      

            WithDistance = Vector3.Distance(Black_Enemys[i].gameObject.transform.position, o_ThirdPoint.transform.position);

            if (WithDistance < distance_Identifier)
            {           

                Black_Enemys[i].gameObject.transform.GetComponent<Animator>().SetBool("IsPunch", true);
                Black_Enemys[i].gameObject.transform.LookAt(o_ThirdPoint.gameObject.transform.position, Vector3.up);

                //  Black_Enemys[i].gameObject.transform.GetComponent<NavMeshAgent>().enabled = false;


                IsBlackFinalStage = true;

            }

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


}