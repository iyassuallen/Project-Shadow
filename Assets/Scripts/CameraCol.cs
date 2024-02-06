using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraCol : MonoBehaviour
{
    [SerializeField] string PlayerTag;
    public bool isColliding = false;

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == PlayerTag)
        {
            isColliding = true;
        }
    }

    void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.tag == PlayerTag)
        {
            isColliding = false;
        }
    }
}
