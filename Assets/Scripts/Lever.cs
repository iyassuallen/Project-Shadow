using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lever : MonoBehaviour
{
    [SerializeField] string PlayerTag;
    public bool isOn = false;

    void OnTriggerStay2D(Collider2D col)
    {
        if (col.gameObject.tag == PlayerTag)
        {
            if (Input.GetButtonDown("Interact"))
            {
                isOn = !isOn;
                Debug.Log(isOn);
            }
            
        }
    }
}
