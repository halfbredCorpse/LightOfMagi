using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene_Selector : MonoBehaviour {

    // Use this for initialization
    public void LoadScene(string scene)
    {
        SceneManager.LoadScene(scene);
        Debug.Log(scene);
    }
}
