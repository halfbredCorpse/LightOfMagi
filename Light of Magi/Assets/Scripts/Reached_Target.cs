using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reached_Target : MonoBehaviour {

    GameObject target;
    GameObject secondCanvas;

	// Use this for initialization
	void Start () {
        secondCanvas = GameObject.FindGameObjectWithTag("SecondCanvas");
        target = GameObject.FindGameObjectWithTag("Goal");
        secondCanvas.GetComponent<Canvas>().enabled = false;
    }
	
	// Update is called once per frame
	void Update () {
        if (target != null)
        {
            if (Vector2.Distance(transform.position, target.transform.position) <= 0.1)
            {
                Debug.Log("Enter");
                secondCanvas.GetComponent<Canvas>().enabled = true;
                gameObject.SetActive(false);
                target = null;
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
