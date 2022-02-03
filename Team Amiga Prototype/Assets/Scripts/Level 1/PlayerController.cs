using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        PlayerMovement();
    }

    void PlayerMovement()
    {
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            for (int i = 0; i < 10; i++)
            {
                gameObject.transform.position += new Vector3(0f, 0f, 0.01f);
            }
        }

        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            for (int i = 0; i < 10; i++)
            {
                gameObject.transform.position += new Vector3(-0.01f, 0f, 0f);
            }
        }

        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            for (int i = 0; i < 10; i++)
            {
                gameObject.transform.position += new Vector3(0.01f, 0f, 0f);
            }
        }

        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            for (int i = 0; i < 10; i++)
            { 
                gameObject.transform.position += new Vector3(0f, 0f, -0.01f);
            }
        }
    }
}
