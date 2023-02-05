using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PiceOfSnake : MonoBehaviour
{
    //Player
    public GameObject PlayerObj;

    //tags of objects
    public string BonusTag;
    public string[] TagsOfBariers;

    public void OnTriggerEnter(Collider other)
    {
        if(other.tag == BonusTag)
        {
            //if other is bonus
            PlayerObj.GetComponent<MainSnakeScript>().onAddPice();
        }

        else if (inList(BonusTag, TagsOfBariers))
        {
            //if other is barier
            PlayerObj.GetComponent<MainSnakeScript>().onDead();
        }
    }

    public bool inList(string NeedTag, string[] listOfTags)
    {

        //check for need tag

        for (int i = 0; i < listOfTags.Length; i++)
        {
            if (listOfTags[i] == NeedTag)
            {
                return true;
            }
        }
        return false;
    }
}
