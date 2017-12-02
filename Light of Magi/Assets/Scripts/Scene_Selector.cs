using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene_Selector : MonoBehaviour {

    public Color color;

    // Use this for initialization
    public void LoadScene(string scene)
    {
        color = Color.black;
        //Fade Animation
        color.a = 0.5f;
        Initiate.Fade(scene, color, 50.0f);

        SceneManager.LoadScene(scene);
    }

    public void ReloadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
