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


        // ÝSTEDÝÐÝNÝ ALDIN EVET QUATERNÝON ' LARLA ÝLGÝLÝ TAM GÖRÜNTÜSEL OLARAK ÇARPIÞMASINI  YANÝ GÖZE HOÞ ÇARPIÞMALARINI
        // SAÐLAYABÝLÝRSÝN ARAÞTIR DENE VE YAP....


    }



    #region 3 haftadýr 2 tane Friend ' in ayný anda Enemy ' e  gitme sorunun çözümünü anlatan KISIM 

    /*

     mesafe 'yi Death distance ' dan küçük olduktan sonra silmedin DÝREK BU HALÝYLE YAPTIN. çünkü diðer denemelerinde hepsinde
     mesafe 1 ' den küçük olduðunda yok olup listelerden siliniyolardý. Þimdi burda öyle bir þey yok Triiger olduklarýnda
     kendi ( Friends ve Enemys) Scriptlerindeki kodlarýn sayesinde DÝREK SÝLÝNÝP ölecekler.BÖYLECE 3 HAFTADIR ALDIÐIN HATAYI
     ÇÖZMÜÞ OLDUN . !!!  

    */


    #endregion




}