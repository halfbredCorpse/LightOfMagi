using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reached_Target : MonoBehaviour {

    GameObject target;
    GameObject star;
    GameObject secondCanvas;
    bool entered;

    public bool Entered
    {
        get
        {
            return entered;
        }
    }

    // Use this for initialization
    void Start () {
        secondCanvas = GameObject.FindGameObjectWithTag("SecondCanvas");
        target = GameObject.FindGameObjectWithTag("Goal");
        star = GameObject.FindGameObjectWithTag("Star");
        secondCanvas.GetComponent<Canvas>().enabled = false;
        entered = false;
    }
	
	// Update is called once per frame
	void Update () {
        if (target != null)
        {
            if (Vector2.Distance(transform.position, target.transform.position) <= 0.1)
            {
                entered = true;
                secondCanvas.GetComponent<Canvas>().enabled = true;
                gameObject.SetActive(false);
                target = null;
                star.SetActive(false);
            }
        }
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Goal" || collision.gameObject.tag == "Magi")
        {
            target = collision.gameObject;
            Physics2D.IgnoreCollision(target.GetComponent<Collider2D>(), GetComponent<Collider2D>());
        }
    }
}
