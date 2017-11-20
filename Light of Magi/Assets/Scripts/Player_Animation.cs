using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Animation : MonoBehaviour {
    public float speed;
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
        animator.Play("Magi 1_Back_ Walking_Anim");
        rb.velocity = new Vector2(0, speed);
        idleState = 1;
    }

    public void moveDown()
    {
        animator.Play("Magi 1_Front_Walking_Anim");
        rb.velocity = new Vector2(0, -speed);
        idleState = 2;
    }

    public void moveRight()
    {
        animator.Play("Magi 1_Right_Walking_Anim");
        rb.velocity = new Vector2(speed, 0);
        idleState = 3;
    }

    public void moveLeft()
    {
        animator.Play("Magi 1_Left_Walking_Anim");
        rb.velocity = new Vector2(-speed, 0);
        idleState = 4;
    }

    public void notMove()
    {
        if (Input.touchCount == 0)
        {
            if (idleState == 2)
                animator.Play("Magi 1_Front_Idle_Anim");
            else if (idleState == 1)
                animator.Play("Magi 1_Back_ Idle_Anim");
            else if (idleState == 3)
                animator.Play("Magi 1_Right_Idle_Anim");
            else if (idleState == 4)
                animator.Play("Magi 1_Left_Idle_Anim");
        }
    }
}
