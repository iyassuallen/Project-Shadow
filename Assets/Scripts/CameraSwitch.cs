using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitch : MonoBehaviour
{
    public CameraCol camCol;
    Camera thisCam;

    private void Start()
    {
        thisCam = gameObject.GetComponent<Camera>();
    }

    void FixedUpdate()
    {
        if (camCol.isColliding)
        {
            thisCam.enabled = true;
        } else
        {
            thisCam.enabled = false;
        }
    }
}
