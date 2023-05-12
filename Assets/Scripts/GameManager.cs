using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    public float gameWidth = 15f;
    [HideInInspector] public int score = 0;

    //if game is active
    [HideInInspector] public bool isGameActive = true;

    //Singleton
    private void Awake()
    {
        //it's possible only one Instance, the first Instance in the scene
        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }
    }
}
