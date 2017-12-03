using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityStandardAssets.CrossPlatformInput;

public class Player_Movement : MonoBehaviour
{
    [Range(0.1f, 1f)]
    public float speed;

    Animator animator;
    Rigidbody2D rb;
    GUIContent btn;

    int idleState;

    // Use this for initialization
    void Start()
    {
        animator = this.GetComponent<Animator>();
        rb = this.GetComponent<Rigidbody2D>();
    } 

    // Update is called once per frame
    void Update()
    {
        rb.WakeUp();

        var vertical = CrossPlatformInputManager.GetAxis("Vertical") * speed * Time.deltaTime;
        var horizontal = CrossPlatformInputManager.GetAxis("Horizontal") * speed * Time.deltaTime;

        //transform.position = new Vector2(transform.position.x + horizontal, transform.position.y + vertical);
        rb.velocity = new Vector2(horizontal * speed, vertical * speed);
        rb.velocity = rb.velocity.normalized * speed;

        /*
        * idleState = 1; Front
        * idleState = 2; Back
        * idleState = 3; Right
        * idleState = 4; Left
        */

        if (vertical > 0)
        {
            animator.Play("Magi 1_Back_ Walking_Anim");
            idleState = 2;
        }
        else if(vertical < 0)
        {
            animator.Play("Magi 1_Front_Walking_Anim");
            idleState = 1;
        }
        else if(horizontal > 0)
        {
            animator.Play("Magi 1_Right_Walking_Anim");
            idleState = 3;
        }
        else if (horizontal < 0)
        {
            animator.Play("Magi 1_Left_Walking_Anim");
            idleState = 4;
        }

        if (Input.touchCount == 0)
        {
            //transform.position = new Vector2(transform.position.x, transform.position.y);
            rb.Sleep();

            Debug.Log(idleState);
            if (idleState == 1)
                animator.Play("Magi 1_Front_Idle_Anim");
            else if (idleState == 2)
                animator.Play("Magi 1_Back_ Idle_Anim");
            else if (idleState == 3)
                animator.Play("Magi 1_Right_Idle_Anim");
            else if (idleState == 4)
                animator.Play("Magi 1_Left_Idle_Anim");
        }
    }
}