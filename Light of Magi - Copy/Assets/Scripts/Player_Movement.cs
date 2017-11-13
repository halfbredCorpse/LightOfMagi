using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    public Transform player;
    public float speed;
    private Animator animator;
    private KeyCode recKey;

    // Use this for initialization
    void Start()
    {
        animator = this.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        /*
         * Direction = 0; Front/Idle
         * Direction = 1; Back/Idle
         * Direction = 2; Right/Idle
         * Direction = 3; Left/Idle
         * Direction = 4; Front/Walking
         * Direction = 5; Back/Walking
         * Direction = 6; Right/Walking
         * Direction = 7; Left/Walking
         */

        if (Input.GetKey(KeyCode.UpArrow))
        {
            recKey = KeyCode.UpArrow;
            animator.Play("Magi 1_Back_ Walking_Anim");
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, speed);
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            recKey = KeyCode.DownArrow;
            animator.Play("Magi 1_Front_Walking_Anim");
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, -speed);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            recKey = KeyCode.RightArrow;
            animator.Play("Magi 1_Right_Walking_Anim");
            GetComponent<Rigidbody2D>().velocity = new Vector2(speed, 0);
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            recKey = KeyCode.LeftArrow;
            animator.Play("Magi 1_Left_Walking_Anim");
            GetComponent<Rigidbody2D>().velocity = new Vector2(-speed, 0);
        }
        else if (recKey == KeyCode.UpArrow)
        {
            animator.Play("Magi 1_Back_ Idle_Anim");
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
        }
        else if (recKey == KeyCode.DownArrow)
        {
            animator.Play("Magi 1_Front_Idle_Anim");
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
        }
        else if (recKey == KeyCode.RightArrow)
        {
            animator.Play("Magi 1_Right_Idle_Anim");
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
        }
        else if (recKey == KeyCode.LeftArrow)
        {
            animator.Play("Magi 1_Left_Idle_Anim");
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
        }
    }
}