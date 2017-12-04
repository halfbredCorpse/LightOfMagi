﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fading_Script : MonoBehaviour {

    public Texture2D fadeOutTexture;
    public float fadeSpeed = 0.8f;

    int drawDepth = -1000;
    float alpha = 1.0f;
    int fadeDir = -1;   //-1 fadeIn, 1 fadeOut

    private void OnGUI()
    {
        alpha += fadeDir * fadeSpeed * Time.deltaTime;
        alpha = Mathf.Clamp01(alpha);

        GUI.color = new Color(GUI.color.r, GUI.color.g, GUI.color.b, alpha);
        GUI.depth = drawDepth;
        GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), fadeOutTexture);
    }

    public float BeginFade(int direction)
    {
        fadeDir = direction;
        return (fadeSpeed);
    }

    private void OnLevelWasLoaded(int level)
    {
        //alpha = 1 if not default
        BeginFade(-1);
    }
}
