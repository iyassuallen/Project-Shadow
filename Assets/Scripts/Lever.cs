using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lever : MonoBehaviour
{
    [SerializeField] string PlayerTag;
    private bool inRange = false;
    public bool isOn = false;

    private void Update()
    {
        Debug.Log(inRange);
        if (true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                isOn = true;
            }
            else
            {
                isOn = false;
            }
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == PlayerTag)
        {
            inRange = true;
        }
    }

    void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.tag == PlayerTag)
        {
            inRange = false;
        }
    }
}
