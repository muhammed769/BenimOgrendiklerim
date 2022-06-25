using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{

    [SerializeField] GameObject[] AllEnemys;
    [SerializeField] GameObject Character;
    [SerializeField] float distanceIdentifier;
    [SerializeField] float LerpSpeed;




    void Update()
    {

        float o_distance = Vector3.Distance(AllEnemys[0].transform.position, Character.transform.position); // 9

        if (o_distance < distanceIdentifier)
        {
            EnemyMove();
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawLine(AllEnemys[0].transform.position, Character.transform.position);
        Gizmos.color = Color.white;
    }


    void EnemyMove()
    {

        AllEnemys[0].transform.position = Vector3.Lerp(AllEnemys[0].transform.position, Character.transform.position, Time.deltaTime * 1f);
 
     
      

    }

}
