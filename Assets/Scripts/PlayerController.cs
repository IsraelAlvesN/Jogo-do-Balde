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
        //input values
        bool isPressedLeft = Input.GetKey(KeyCode.LeftArrow);
        bool isPressedRight = Input.GetKey(KeyCode.RightArrow);

        //move player
        if (isPressedLeft)
        {
            float movement = speed * Time.deltaTime;
            transform.position += new Vector3(0, 0, -movement);
        }
        if(isPressedRight)
        {
            float movement = speed * Time.deltaTime;
            transform.position += new Vector3(0, 0, movement);
        }
    }
}
