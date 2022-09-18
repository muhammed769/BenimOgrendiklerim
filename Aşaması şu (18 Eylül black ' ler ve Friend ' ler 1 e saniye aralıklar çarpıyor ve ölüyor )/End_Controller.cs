using System.Collections.Generic;
using UnityEngine;

public class End_Controller : MonoBehaviour
{


    [SerializeField] List<GameObject> AllBlacks = new List<GameObject>();
    public static List<GameObject> Friends_End = new List<GameObject>();

    Trigger_Controller a;

    public static GameObject carpanBlack;
    public static GameObject carpanFriend;
    public static int BlackCount;
    public static int FriendCount;
    public static bool IsClear;

    int i;
    int j;

    private void Update()
    {

        BlackCount = AllBlacks.Count;
        FriendCount = Friends_End.Count;

        if (First_Point.IsTrigger)
        {

        //    a.enabled = false;

            if (Friends.IsFriendFinalStage && Black_Controller.IsBlackFinalStage)
            {

                if (BlackCount >= 4 && FriendCount > 0)
                {


                    float ping = Mathf.PingPong(Time.time, 1f);

                    carpanBlack = AllBlacks[i].gameObject;
                    carpanFriend = Friends_End[j].gameObject;

                    Destroy(AllBlacks[i].gameObject, ping);
                    Destroy(Friends_End[j].gameObject, ping);
                    Destroy(AllBlacks[i].gameObject.transform.GetComponent<Animator>(), ping);

                    AllBlacks.RemoveAt(i);
                    Friends_End.RemoveAt(j);
                


                    BlackCount--;
                    FriendCount--;

                    IsClear = true;

                    if (BlackCount > 0 && FriendCount < 1)
                    {
                        Debug.Log("KAYBETTÝNÝZ ! ! ! ! ! ! ! ! !   ");

                    }

                   

                }


             


            }


        }
    }




}
