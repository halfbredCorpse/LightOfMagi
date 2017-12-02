using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootSteps : MonoBehaviour {
  
    Rigidbody2D ch;

    // Use this for initialization
    void Start () {
        ch = GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update () {
        if (ch.velocity.magnitude > 0 && GetComponent<AudioSource>().isPlaying == false)
        {
            GetComponent<AudioSource>().Play();
        }
        else if (ch.velocity.magnitude < 0.15f)
            GetComponent<AudioSource>().Stop();
    }
}
