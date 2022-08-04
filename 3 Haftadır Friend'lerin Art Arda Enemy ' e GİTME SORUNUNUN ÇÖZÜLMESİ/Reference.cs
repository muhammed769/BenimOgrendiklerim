using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Reference : MonoBehaviour
{

    [SerializeField] List<GameObject> o_Enemys = new List<GameObject>();
    [SerializeField] List<GameObject> o_Friends = new List<GameObject>();

    [SerializeField] List<NavMeshAgent> n_Friends = new List<NavMeshAgent>();
    [SerializeField] List<NavMeshAgent> n_Enemys = new List<NavMeshAgent>();

    [SerializeField] List<Animator> a_Friends = new List<Animator>();
    [SerializeField] List<Animator> a_Enemys = new List<Animator>();

    [SerializeField] float DetermineDistance;
    float currentDistance;

    int i;
    int j;
    private void Update()
    {

        for (i = 0; i < o_Friends.Count; i++)
        {
            for (j = 0; j < o_Enemys.Count; j++)
            {

                currentDistance = Vector3.Distance(o_Friends[i].gameObject.transform.position, o_Enemys[j].gameObject.transform.position);

                if (currentDistance < DetermineDistance)
                {
                    ReallyResult();

                }


            }


        }

    }

    void ReallyResult()
    {

        a_Friends[i].SetBool("IsRush", true);
        a_Enemys[j].SetBool("IsRace", true);


        n_Friends[i].SetDestination(n_Enemys[j].gameObject.transform.position);
        n_Enemys[j].SetDestination(n_Friends[i].gameObject.transform.position);

       /* o_Friends[i].gameObject.transform.LookAt(o_Enemys[j].gameObject.transform);
        o_Enemys[j].gameObject.transform.LookAt(o_Friends[i].gameObject.transform); */




        o_Friends.RemoveAt(i);
        n_Friends.RemoveAt(i);

        o_Enemys.RemoveAt(j);
        n_Enemys.RemoveAt(j);

        a_Friends.RemoveAt(i);
        a_Enemys.RemoveAt(j);


        // �STED���N� ALDIN EVET QUATERN�ON ' LARLA �LG�L� TAM G�R�NT�SEL OLARAK �ARPI�MASINI  YAN� G�ZE HO� �ARPI�MALARINI
        // SA�LAYAB�L�RS�N ARA�TIR DENE VE YAP....


    }



    #region 3 haftad�r 2 tane Friend ' in ayn� anda Enemy ' e  gitme sorunun ��z�m�n� anlatan KISIM 

    /*

     mesafe 'yi Death distance ' dan k���k olduktan sonra silmedin D�REK BU HAL�YLE YAPTIN. ��nk� di�er denemelerinde hepsinde
     mesafe 1 ' den k���k oldu�unda yok olup listelerden siliniyolard�. �imdi burda �yle bir �ey yok Triiger olduklar�nda
     kendi ( Friends ve Enemys) Scriptlerindeki kodlar�n sayesinde D�REK S�L�N�P �lecekler.B�YLECE 3 HAFTADIR ALDI�IN HATAYI
     ��ZM�� OLDUN . !!!  

    */


    #endregion




}