using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


public class MainSnakeScript : MonoBehaviour
{
    //variables of snake
    public GameObject lastPice;
    public GameObject PicePref;


    //function, to get the last one pice
    public void onAddPice()
    {
        lastPice.GetComponent<PiceOfSnake>().AddPice(PicePref);
    }
}
