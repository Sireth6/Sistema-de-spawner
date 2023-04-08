using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMotor : MonoBehaviour
{
    float moveSpeed;
    float walkSpeed = 2;
    float sprintSpeed = 4;
    float jumpSpeed = 10;
    float gravity = 1 ;

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
            moveDirection = transform.TransformDirection(moveDirection);
            if(Input.GetKey(KeyCode.LeftShift) && moveZ == 1)
            {
                moveSpeed = sprintSpeed;
            }
            else
            {
                moveSpeed = walkSpeed;
            }

            moveDirection *= moveSpeed;

            if(Input.GetKeyDown (KeyCode.Space))
            {
                moveDirection.y += jumpSpeed;
            }
        }

        moveDirection.y -= gravity;
        controller.Move (moveDirection * Time.deltaTime);
    }
}
