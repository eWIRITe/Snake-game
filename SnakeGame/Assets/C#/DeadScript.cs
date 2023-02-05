using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadScript : MonoBehaviour
{
    public string TagOfBlocks;

    //viarebles for dead
    public GameObject DeadCanv;


    public void OnTriggerEnter(Collider other)
    {
        if(other.tag == TagOfBlocks || other.tag == "Player")
        {
            Dead();
        }
    }

    public void Dead()
    {
        DeadCanv.SetActive(true);
    }
}
