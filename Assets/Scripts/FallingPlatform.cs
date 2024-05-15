using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingPlatform : MonoBehaviour
{
    private float fallDelay = 1f;
    //private float resetDelay = 1f;
    private float destroyDelay = 2f;
    public Vector2 ogPos;

    [SerializeField] private Rigidbody2D rb;

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            StartCoroutine(Fall());
        }
    }

    private IEnumerator Fall()
    {
        yield return new WaitForSeconds(fallDelay);
        rb.bodyType = RigidbodyType2D.Dynamic;
        //StartCoroutine(Reset());
        //Destroy(gameObject, destroyDelay);
        yield return new WaitForSeconds(2f);
        rb.bodyType = RigidbodyType2D.Kinematic;
        transform.position = ogPos;
    }

    /*private IEnumerator Reset()
    {
        yield return new WaitForSeconds(resetDelay);
        rb.bodyType = RigidbodyType2D.Kinematic;
        transform.position = ogPos;
    }*/
}

