using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


public class MainSnakeScript : MonoBehaviour
{
    //variables of snake
    public GameObject lastPice;
    public GameObject PicePref;

    //variables for dead
    public GameObject DeadScreen;

    public void onAddPice()
    {
        lastPice.GetComponent<PiceOfSnake>().AddPice(PicePref);
    }

    public void onDead()
    {
        DeadScreen.SetActive(true);
    }
}
