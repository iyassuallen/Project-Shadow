using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageCol : MonoBehaviour
{
    bool shadowCol;
    bool spikeCol;

    public bool isShadow;
    public bool isSpike;

    public PlayerHealth health;

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            if (isShadow && !col.isTrigger)
            {
                shadowCol = true;
            }

            if (isSpike)
            {
                spikeCol = true;
            }
        }
    }

    void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player" && isShadow) 
        {
            shadowCol = false;
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        health.Damage(spikeCol, shadowCol);
    }
}
