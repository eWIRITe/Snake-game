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

    public GameObject PosToSpawnNextPice;

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

    public void AddPice(GameObject PrefOfPice)
    {
        //create new pice
        GameObject newPice = Instantiate(PrefOfPice, PosToSpawnNextPice.transform.position, PosToSpawnNextPice.transform.rotation);

        newPice.GetComponent<CharacterJoint>().connectedBody = gameObject.GetComponent<Rigidbody>();

        newPice.GetComponent<PiceOfSnake>().PlayerObj = PlayerObj;

        PlayerObj.GetComponent<MainSnakeScript>().lastPice = newPice;

        //set player in "PiceOfSnake" script
        newPice.GetComponent<PiceOfSnake>().PlayerObj = PlayerObj;

    }
}
