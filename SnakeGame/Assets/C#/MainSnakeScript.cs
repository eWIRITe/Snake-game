using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


public class MainSnakeScript : MonoBehaviour
{
    //variables of snake
    public GameObject LastObj;
    public GameObject[] PicePrefs;

    //variables for dead
    public GameObject DeadScreen;

    public void onAddPice()
    {
        //create new pice
        GameObject newPice = Instantiate(PicePrefs[Random.Range(0, PicePrefs.Length)], new Vector3(LastObj.transform.position.x, LastObj.transform.position.y, LastObj.transform.position.z + 1.023f), Quaternion.identity);

        newPice.GetComponent<CharacterJoint>().connectedBody = LastObj.GetComponent<Rigidbody>();

        //set player in "PiceOfSnake" script
        newPice.GetComponent<PiceOfSnake>().PlayerObj = this.gameObject;

        LastObj = newPice;
    }

    public void onDead()
    {
        DeadScreen.SetActive(true);
    }
}
