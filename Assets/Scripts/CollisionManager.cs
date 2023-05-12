using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionManager : MonoBehaviour
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
            //increment score
            GameManager.Instance.score++;
            Debug.Log(GameManager.Instance.score);

            Destroy(other.gameObject);
        }
    }
}
