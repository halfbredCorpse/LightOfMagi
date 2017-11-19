using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class Player_Movement : MonoBehaviour
{
    private static ILogger logger = Debug.unityLogger;
    public Transform player;
    public float speed;
    private Animator animator;
    private KeyCode recKey;
    float dirX;
    float dirY;
    bool forward, backward, right, left;

    // Use this for initialization
    void Start()
    {
        animator = this.GetComponent<Animator>();

        forward = false;
        backward = false;
        right = false;
        left = false;
    }

    public void moveForward()
    {
        animator.Play("Magi 1_Back_ Walking_Anim");
        forward = true;
        backward = false;
        right = false;
        left = false;
    }

    public void moveBackward()
    {
        animator.Play("Magi 1_Front_Walking_Anim");
        forward = false;
        backward = true;
        right = false;
        left = false;
    }

    public void moveRight()
    {
        animator.Play("Magi 1_Right_Walking_Anim");
        forward = false;
        backward = false;
        right = true;
        left = false;
    }

    public void moveLeft()
    {
        animator.Play("Magi 1_Left_Walking_Anim");
        forward = false;
        backward = false;
        right = false;
        left = true;
    }

    public void StopMovement()
    {
        if(Input.GetTouch(0).phase == TouchPhase.Ended || Input.GetTouch(0).phase == TouchPhase.Canceled)
        {
            if (recKey == KeyCode.UpArrow)
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

    // Update is called once per frame
    void Update()
    {  
        //if(Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        //{
            var vertical = CrossPlatformInputManager.GetAxis("Vertical");
            var horizontal = CrossPlatformInputManager.GetAxis("Horizontal");

            if (forward)
            {
                recKey = KeyCode.UpArrow;
                GetComponent<Rigidbody2D>().velocity = new Vector2(0, speed);
                logger.Log("Vertical", vertical);
                logger.Log("Horizontal", horizontal);
            }
            else if (backward)
            {
                recKey = KeyCode.DownArrow;
                GetComponent<Rigidbody2D>().velocity = new Vector2(0, -speed);
                logger.Log("Vertical", vertical);
                logger.Log("Horizontal", horizontal);
            }
            else if (right)
            {
                recKey = KeyCode.RightArrow;
                GetComponent<Rigidbody2D>().velocity = new Vector2(speed, 0);
                logger.Log("Vertical", vertical);
                logger.Log("Horizontal", horizontal);
            }
            else if (left)
            {
                recKey = KeyCode.LeftArrow;
                GetComponent<Rigidbody2D>().velocity = new Vector2(-speed, 0);
                logger.Log("Vertical", vertical);
                logger.Log("Horizontal", horizontal);
            }

            //StopMovement();
        //}
    }
}