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
    public bool spawned = false;

    public void OnTriggerEnter(Collider other)
    {
        //when we touthing bonus, we starting th function onAddPice
        if(other.tag == BonusTag)
        {
            //if other is bonus
            PlayerObj.GetComponent<MainSnakeScript>().onAddPice();
            Destroy(other.gameObject);
        }
    }

    public void AddPice(GameObject PrefOfPice)
    {
        //function for spawn obj
        if (!spawned)
        {
            //create new pice
            GameObject newPice = Instantiate(PrefOfPice, PosToSpawnNextPice.transform.position, PosToSpawnNextPice.transform.rotation);

            //set connectBody
            newPice.GetComponent<CharacterJoint>().connectedBody = gameObject.GetComponent<Rigidbody>();

            //set Player
            newPice.GetComponent<PiceOfSnake>().PlayerObj = PlayerObj;

            //set lastPce
            PlayerObj.GetComponent<MainSnakeScript>().lastPice = newPice;

            //set player in "PiceOfSnake" script
            newPice.GetComponent<PiceOfSnake>().PlayerObj = PlayerObj;


            //counter to avoid bugs
            spawned = true;
        }
    }
}
