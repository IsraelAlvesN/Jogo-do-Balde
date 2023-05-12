using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision other)
    {
        if (!GameManager.Instance.isGameActive)
        {
            return;
        }
        if (other.gameObject.CompareTag("Ball"))
        {
            Debug.Log("Game Over!!!");
            Destroy(other.gameObject);

            GameManager.Instance.isGameActive = false;
            //SceneManager.LoadScene("Jogo");

        }
    }
}
