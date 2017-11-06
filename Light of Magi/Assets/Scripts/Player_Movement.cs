using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    public Transform player;
    public float speed;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKey(KeyCode.UpArrow))
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, speed);
        else if (Input.GetKey(KeyCode.DownArrow))
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, -speed);
        else if (Input.GetKey(KeyCode.RightArrow))
            GetComponent<Rigidbody2D>().velocity = new Vector2(speed, 0);
        else if (Input.GetKey(KeyCode.LeftArrow))
            GetComponent<Rigidbody2D>().velocity = new Vector2(-speed, 0);
        else
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
    }
}