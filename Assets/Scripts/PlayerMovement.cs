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
        bool crouchCheck = animator.GetCurrentAnimatorStateInfo(0).IsName("Player_CrouchWalk");
        bool crouchCheck2 = animator.GetCurrentAnimatorStateInfo(0).IsName("Player_Crouch");

        //Checks for movement for walk animation
        animator.SetFloat("speed", Mathf.Abs(horizontalMove));
       
        if (Input.GetButtonDown("Jump") && crouch != true && crouchCheck != true && crouchCheck2 != true)
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

        if (Input.GetButton("Sprint") && crouch != true && jump != true)
        {
            sprint = true;
            animator.SetBool("isSprinting", true);
        }
        else if (Input.GetButtonUp("Sprint"))
        {
            sprint = false;
            animator.SetBool("isSprinting", false);
        }

        if (animator.GetCurrentAnimatorStateInfo(0).IsName("isCrouching"))
        {
            crouch = true;
            jump = false;
        }
    }


    public void OnLanding()
    {
        animator.SetBool("isJumping", false);
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
