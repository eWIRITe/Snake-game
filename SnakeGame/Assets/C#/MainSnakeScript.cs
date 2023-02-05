using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MainSnakeScript : MonoBehaviour
{
    //variables of snake
    public GameObject[] SnakePices;
    public GameObject[] Pice;

    //variables for dead
    public GameObject DeadScreen;

    public void onAddPice()
    {
        //create new pice
        GameObject newPice = Instantiate(Pice[Random.Range(0, Pice.Length)], 
            new Vector3(SnakePices[-1].transform.position.x, SnakePices[-1].transform.position.y, SnakePices[-1].transform.position.z - 1.023f), 
            Quaternion.identity);


        //add pice in list of pices
        SnakePices[SnakePices.Length+1] = newPice;

        //set player in "PiceOfSnake" script
        newPice.GetComponent<PiceOfSnake>().PlayerObj = this.gameObject;
    }

    public void onDead()
    {
        DeadScreen.SetActive(true);
    }
}
