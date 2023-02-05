using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Mooveskript : MonoBehaviour
{
    public Rigidbody _rb;

    public float Speed;

    public KeyCode KeyForBeginMoove;

    public bool isCanMoove;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyForBeginMoove)) 
        { 
            isCanMoove = !isCanMoove;
        }
    }

    void FixedUpdate()
    {
        if (isCanMoove) _rb.AddRelativeForce(new Vector3(0, 0, Speed));
        Speed += 0.01f;
    }
}
