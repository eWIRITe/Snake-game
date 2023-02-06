using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerSnakeScript : MonoBehaviour
{
    public string TagOfBlocks;
    public GameObject Player;

    //varebles for dead
    public GameObject DeadCanv;

    //varebles for Bonus
    public string TagOfBonus;

    void Start()
    {
        DeadCanv = GameObject.Find("Dead");
    }

    public void OnTriggerEnter(Collider other)
    {
        //when we touth something, we start function "Dead"

        if(other.tag == TagOfBlocks || other.tag == "Player")
        {
            Dead();
        }
        if(other.tag == TagOfBonus)
        {
            Player.GetComponent<Mooveskript>().AddBodyPice();
            Destroy(other.gameObject);
        }
    }

    public void Dead()
    {
        DeadCanv.SetActive(true);
    }
}
