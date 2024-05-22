using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingPlatform : MonoBehaviour
{
    private float fallDelay = 1f;
    //private float resetDelay = 1f;
    private float destroyDelay = 2f;
    private Vector2 ogPos;

    [SerializeField] private Rigidbody2D rb;

    private bool isFalling = false;

    public void Start()
    {
        ogPos = transform.position;
        rb.bodyType = RigidbodyType2D.Kinematic;
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            isFalling = true;
            StartCoroutine(Fall());
        }
    }

    private IEnumerator Fall()
    {
        yield return new WaitForSeconds(fallDelay);
        if (isFalling)
        {
            rb.bodyType = RigidbodyType2D.Dynamic;
        }
    }

    public void ResetPlatform()
    {
        isFalling = false;
        rb.velocity = Vector2.zero;
        rb.bodyType = RigidbodyType2D.Kinematic;
        transform.position = ogPos;
    }
}

