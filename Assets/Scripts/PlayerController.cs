using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10;

    void Start()
    {
        
    }
    void Update()
    {
        if (!GameManager.Instance.isGameActive)
        {
            return;
        }
        //input values
        bool isPressedLeft = Input.GetKey(KeyCode.LeftArrow);
        bool isPressedRight = Input.GetKey(KeyCode.RightArrow);

        //move player
        if(isPressedLeft == isPressedRight)
        {
            return;
        }

        float movement = speed * Time.deltaTime;
        if (isPressedLeft)
        {
            movement *= -1f;
        }
        transform.position += new Vector3(movement, 0, 0);

        //limit player boundaries
        float movimentLimit = GameManager.Instance.gameWidth / 2;
        if(transform.position.x < -movimentLimit)
        {
            transform.position = new Vector3(-movimentLimit, transform.position.y, transform.position.z);
        }else if (transform.position.x > movimentLimit)
        {
            transform.position = new Vector3(movimentLimit, transform.position.y, transform.position.z);
        }
    }
}
