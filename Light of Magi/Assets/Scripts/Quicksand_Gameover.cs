using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quicksand_Gameover : MonoBehaviour {

    GameObject[] qkSands;

	// Use this for initialization
	void Start () {
        if (qkSands == null)
            qkSands = GameObject.FindGameObjectsWithTag("Quicksand");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<Collider2D>().tag == "Quicksand")
            Debug.Log("Quicksand");
    }
}
