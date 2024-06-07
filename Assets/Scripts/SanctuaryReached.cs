using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SanctuaryReached : MonoBehaviour
{
    public GameObject shadow;
    void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(shadow);
    }
}
