using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PiceOfSnake : MonoBehaviour
{
    //Player
    public GameObject PlayerObj;

    //tags of objects
    public string BonusTag;
    public string TagOfBariers;

    public void OnTriggerEnter(Collider other)
    {
        if(other.tag == BonusTag)
        {
            //if other is bonus
            PlayerObj.GetComponent<MainSnakeScript>().onAddPice();
            Destroy(other.gameObject);
        }

        else if (BonusTag == TagOfBariers)
        {
            //if other is barier
            PlayerObj.GetComponent<MainSnakeScript>().onDead();
            Destroy(other.gameObject);
        }
    }
}
