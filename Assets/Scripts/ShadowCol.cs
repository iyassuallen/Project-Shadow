using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ShadowCol : MonoBehaviour
{
    [SerializeField] string PlayerTag;
    [SerializeField] bool shadowDeathOn = true;
    //public bool isShadow = true;

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == PlayerTag && shadowDeathOn)
        {
            string currentSceneName = SceneManager.GetActiveScene().name;
            SceneManager.LoadScene(currentSceneName);
        }
    }

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
}
