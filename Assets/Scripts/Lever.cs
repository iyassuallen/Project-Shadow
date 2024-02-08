using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lever : MonoBehaviour
{
    [SerializeField] string PlayerTag;
    public bool isOn;
    public GameObject interObject;

    void Start()
    {
        interObject.GetComponent<Collider2D>().enabled = false;
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == PlayerTag)
        {

            if (interObject.activeSelf)
            {
                
            }
            else
            {
                
            }
        }
    }
}
