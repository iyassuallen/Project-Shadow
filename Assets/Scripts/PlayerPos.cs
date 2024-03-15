using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayerPos : MonoBehaviour
{
    public GameMaster gm;

    void Start()
    {
        transform.position = gm.lastCheckPointPos;
    }
}
