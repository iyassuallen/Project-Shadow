using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ShadowCol : MonoBehaviour
{
    [SerializeField] string PlayerTag;
    [SerializeField] bool shadowDeathOn = true;
    public float transitionTime = 2f;

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == PlayerTag && shadowDeathOn)
        {
            StartCoroutine(LoadLevel());
        }
    }

    void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.tag == PlayerTag && shadowDeathOn)
        {
            StopCoroutine(LoadLevel());
        }
    }

    //Delete later
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            string currentSceneName = SceneManager.GetActiveScene().name;
            SceneManager.LoadScene(currentSceneName);
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            shadowDeathOn = !shadowDeathOn;
        }
    }

    IEnumerator LoadLevel()
    {
        yield return new WaitForSeconds(transitionTime);

        string currentSceneName = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(currentSceneName);
    }
}
