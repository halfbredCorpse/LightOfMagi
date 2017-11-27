using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Animation : MonoBehaviour {
    public float speed;
    public byte magi = 0;

    int idleState = 0;

    Animator animator;
    Rigidbody2D rb;

    // Use this for initialization
    void Start()
    {
        animator = this.GetComponent<Animator>();
        rb = this.GetComponent<Rigidbody2D>();
    }

    public void moveUp()
    {
        if (magi == 1)
            animator.Play("Magi 1_Back_ Walking_Anim");
        else if (magi == 2)
            animator.Play("Magi 2_Back_Walking_Anim");
        else if (magi == 3)
            animator.Play("Magi 3_Back_Walking_Anim");
        rb.velocity = new Vector2(0, speed);
        idleState = 1;
    }

    public void moveDown()
    {
        if (magi == 1)
            animator.Play("Magi 1_Front_Walking_Anim");
        else if (magi == 2)
            animator.Play("Magi 2_Front_Walking_Anim");
        else if (magi == 3)
            animator.Play("Magi 3_Front_Walking_Anim");
        rb.velocity = new Vector2(0, -speed);
        idleState = 2;
    }

    public void moveRight()
    {
        if (magi == 1)
            animator.Play("Magi 1_Right_Walking_Anim");
        else if (magi == 2)
            animator.Play("Magi 2_Right_Walking_Anim");
        else if (magi == 3)
            animator.Play("Magi 3_Right_Walking_Anim");
        rb.velocity = new Vector2(speed, 0);
        idleState = 3;
    }

    public void moveLeft()
    {
        if (magi == 1)
            animator.Play("Magi 1_Left_Walking_Anim");
        else if (magi == 2)
            animator.Play("Magi 2_Left_Walking_Anim");
        else if (magi == 3)
            animator.Play("Magi 2_Left_Walking_Anim");
        rb.velocity = new Vector2(-speed, 0);
        idleState = 4;
    }

    public void notMove()
    {
        if (Input.touchCount == 0)
        {
            /*
            if (idleState == 2)
                animator.Play("Magi 1_Front_Idle_Anim");
            else if (idleState == 1)
                animator.Play("Magi 1_Back_ Idle_Anim");
            else if (idleState == 3)
                animator.Play("Magi 1_Right_Idle_Anim");
            else if (idleState == 4)
                animator.Play("Magi 1_Left_Idle_Anim");
                */
            switch (idleState)
            {
                case 2:
                    if(magi == 1)
                        animator.Play("Magi 1_Front_Idle_Anim");
                    else if(magi == 2)
                        animator.Play("Magi 2_Front_Idle_Anim");
                    else if(magi == 3)
                        animator.Play("Magi 3_Front_Idle_Anim");
                    break;
                case 1:
                    if (magi == 1)
                        animator.Play("Magi 1_Back_ Idle_Anim");
                    else if (magi == 2)
                        animator.Play("Magi 2_Back_Idle_Anim");
                    else if (magi == 3)
                        animator.Play("Magi 3_Back_Idle_Anim");
                    break;
                case 3:
                    if(magi == 1)
                        animator.Play("Magi 1_Right_Idle_Anim");
                    else if(magi == 2)
                        animator.Play("Magi 2_Right_Idle_Anim");
                    else if (magi == 3)
                        animator.Play("Magi 3_Right_Idle_Anim");
                    break;
                case 4:
                    if(magi == 1)
                        animator.Play("Magi 1_Left_Idle_Anim");
                    else if(magi == 2)
                        animator.Play("Magi 2_Left_Idle_Anim");
                    else if (magi == 3)
                        animator.Play("Magi 3_Left_Idle_Anim");
                    break;
            }
        }
    }
}
