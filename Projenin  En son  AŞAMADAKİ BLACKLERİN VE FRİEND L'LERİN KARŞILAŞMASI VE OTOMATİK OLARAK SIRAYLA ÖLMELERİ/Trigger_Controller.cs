using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Trigger_Controller : MonoBehaviour
{

    [SerializeField] List<GameObject> o_Friends = new List<GameObject>();
    [SerializeField] List<GameObject> o_enemys = new List<GameObject>();
    [SerializeField] List<GameObject> o_Black = new List<GameObject>();


    [SerializeField] List<Animator> a_Friends = new List<Animator>();
    [SerializeField] List<Animator> a_Enemys = new List<Animator>();

    [SerializeField] float d_Identifier;

    Vector3 m_EnemyDestinationPoint;
    Vector3 m_FriendDestinationPoint;
    float m_distance;
    int i;
    int j;

    public static bool tetikleyici;


    private void Start()
    {

        i = 0;
        j = 0;
        tetikleyici = false;
    }

    private void Update()
    {


        for (i = 0; i < o_Friends.Count; i++)
        {

            for (j = 0; j < o_enemys.Count; j++)
            {

                m_distance = Vector3.Distance(o_Friends[i].gameObject.transform.position, o_enemys[j].gameObject.transform.position);

                if (m_distance < d_Identifier)
                {
                    tetikleyici = true;
                    if (tetikleyici)
                    {
                        Encounter();

                    }
                }

            }

        }



    }

    public void Encounter()
    {

        o_Friends[i].gameObject.GetComponent<Friends>().enabled = false;

        o_Friends[i].gameObject.transform.SetParent(null);
        a_Friends[i].gameObject.transform.SetParent(null);

       
        a_Friends[i].SetBool("IsRush", true);
        a_Enemys[j].SetBool("IsRace", true);

        o_enemys[j].gameObject.transform.LookAt(o_Friends[i].gameObject.transform);
        o_Friends[i].gameObject.transform.LookAt(o_enemys[j].gameObject.transform, Vector3.up);

        m_EnemyDestinationPoint = o_enemys[j].gameObject.transform.TransformPoint(Vector3.forward * 3f);
        m_FriendDestinationPoint = o_enemys[j].gameObject.transform.TransformPoint(Vector3.forward * 2.8f);

        o_Friends[i].gameObject.GetComponent<NavMeshAgent>().SetDestination(m_FriendDestinationPoint);
        o_enemys[j].gameObject.GetComponent<NavMeshAgent>().SetDestination(m_EnemyDestinationPoint);

        o_Friends.RemoveAt(i);
        o_enemys.RemoveAt(j);
        a_Friends.RemoveAt(i);
        a_Enemys.RemoveAt(j);


    }



  


    #region SON A�AMA GELD���M�Z BU NOKTADA  �unlar� yap�caks�n : 

    /* 
    
  1 ) Friend ve Black 'ler kar��la��p Punching Animasyonlar� oynad�ktan SONRA [ 1.5 ] saniyede bir  teker teker �ls�nler.

  2 ) E�er Friend ve Black ' lerin say�s� e�itse GAL�P OLAN  taraf Black olsun.

  3 ) Black ve Friend ' lerin say�s�n� nas�l YAKALICAM ? 
    
          --- Black ' lerin say�s� zaten oyunda belli.

          --- Friend ' lerin say�s� Trigger olduklar�nda yakalayabilir miyim bunu bir [ DENE. ]

          
  4 ) ZAMAN k�sm�n� nas�l yap�caz d���n ve ARA�TIR ......

    */

    #endregion


}
