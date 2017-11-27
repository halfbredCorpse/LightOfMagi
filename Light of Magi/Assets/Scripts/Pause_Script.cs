using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause_Script : MonoBehaviour {

    GameObject pauseCanvas;
    GameObject star;

	// Use this for initialization
	void Start () {
        pauseCanvas = GameObject.FindGameObjectWithTag("PauseCanvas");
        star = GameObject.FindGameObjectWithTag("Star");
	}
	
	public void OpenPauseMenu()
    {
        pauseCanvas.GetComponent<Canvas>().enabled = true;
        //Magi object
        gameObject.SetActive(false);
        //Shining Star
        star.SetActive(false);
    }

    public void ClosePauseMenu()
    {
        pauseCanvas.GetComponent<Canvas>().enabled = false;
        //Magi object
        gameObject.SetActive(true);
        //Shining Star
        star.SetActive(true);
    }
}
