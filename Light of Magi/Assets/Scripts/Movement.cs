using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

[System.Serializable]
public enum eMovementDirection
{
    Up, Down, Left, Right
}

public class Movement : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{

    public eMovementDirection Direction;
    FootSteps walkingSound;
    Player_Animation anim;

    bool pressed = false;

    void Start()
    {
        anim = GameObject.FindGameObjectWithTag("Magi").GetComponent<Player_Animation>();
        walkingSound = GameObject.FindGameObjectWithTag("Magi").GetComponent<FootSteps>();
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        pressed = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        pressed = false;
    }

    void Update()
    {
        if(pressed)
        {
            switch (Direction)
            {
                case eMovementDirection.Up:
                    {
                        anim.moveUp();
                    }
                    break;
                case eMovementDirection.Down:
                    {
                        anim.moveDown();
                    }
                    break;
                case eMovementDirection.Right:
                    {
                        anim.moveRight();
                    }
                    break;
                case eMovementDirection.Left:
                    {
                        anim.moveLeft();
                    }
                    break;
            }
        }
        else
        {
            anim.notMove();
        }
    }
}