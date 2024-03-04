using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController2D controller;

    float horizontalMove = 0f;
    public float walkSpeed = 40f;
    bool jump = false;
    bool crouch = false;
    bool sprint = false;

    public Animator animator;

    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * walkSpeed;

        //Checks for movement for walk animation
        animator.SetFloat("speed", Mathf.Abs(horizontalMove));

        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
            animator.SetBool("isJumping", true);
        }

        if (Input.GetButtonDown("Crouch"))
        {
            crouch = true;
        }
        else if (Input.GetButtonUp("Crouch"))
        {
            crouch = false;
        }

        if (Input.GetButton("Sprint"))
        {
            sprint = true;
            animator.SetBool("isSprinting", true);
        }
        else if (Input.GetButtonUp("Sprint"))
        {
            sprint = false;
            animator.SetBool("isSprinting", false);
        }
    }

    public bool testJump = false;
    public int landCount = 0;
    public void OnLanding()
    { 
            animator.SetBool("isJumping", false);
            testJump = false;
    }

    public void OnCrouching(bool isCrouching)
    {
        animator.SetBool("isCrouching", isCrouching);
    }

    void FixedUpdate()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump, sprint);
        jump = false;
    }

}
