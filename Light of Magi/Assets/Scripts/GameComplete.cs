using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameComplete : MonoBehaviour {

    Text endTxt;
    Image scroll;
    Reached_Target rt;
    Fade fade;

    // Use this for initialization
    void Start()
    {
        fade = GetComponent<Fade>();
        rt = GameObject.FindGameObjectWithTag("Magi").GetComponent<Reached_Target>();
        endTxt = GameObject.FindGameObjectWithTag("End Text").GetComponent<Text>();
        scroll = GameObject.FindGameObjectWithTag("Scroll").GetComponent<Image>();
        scroll.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (rt.Entered)
        {
            fade.FadeIn();
        }
    }
}
