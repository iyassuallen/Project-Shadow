using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class EndCredits : MonoBehaviour
{
    public float transitionTime = 3f;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            StartCoroutine(LoadCredits());
            Debug.Log("tocuh credits");
        }
    }

    IEnumerator LoadCredits()
    {
        Debug.Log("lading credits");
        yield return new WaitForSeconds(transitionTime);
        SceneManager.LoadScene("Credits");
    }
}
