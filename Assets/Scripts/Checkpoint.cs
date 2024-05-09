using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    //public GameMaster gm;
    public PlayerHealth ph;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            //gm.lastCheckPointPos = transform.position;
            ph.respawnPoint = transform.position;
            Debug.Log("Checkpoint Touched");
            Debug.Log(ph.respawnPoint);
        }
    }
}
