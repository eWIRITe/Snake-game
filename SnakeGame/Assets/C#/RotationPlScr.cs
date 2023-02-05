using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationPlScr : MonoBehaviour
{
    public Camera _camera;

    // Update is called once per frame
    void Update()
    {
        Ray _ray = _camera.ScreenPointToRay(Input.mousePosition);

        RaycastHit hit;

        if (Physics.Raycast(_ray, out hit))
        {
            if (hit.point != null)
            {
                gameObject.transform.LookAt(new Vector3(hit.point.x, gameObject.transform.position.y, hit.point.z));
            }
        }
    }
}