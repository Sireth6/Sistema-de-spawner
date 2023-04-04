using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMotor : MonoBehaviour
{
    float moveSpeed;
    float walkSpeed = 2;
    float sprintSpeed = 6;
    float gravity = 4 ;

    Vector3 moveDirection;

    CharacterController controller;

    void Start()
    {
        controller = GetComponent<CharacterController> ();
    }

    void Update()
    {
        Move(); 
    }

    void Move()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");

        if (controller.isGrounded)
        {
            moveDirection = new Vector3(moveX, 0, moveZ);
            if(Input.GetKey(KeyCode.LeftShift))
            {
                moveSpeed = sprintSpeed;
            }
            else
            {
                moveSpeed = walkSpeed;
            }

            moveDirection *= moveSpeed;
        }

        moveDirection.y -= gravity;
        controller.Move (moveDirection * Time.deltaTime);
    }
}
