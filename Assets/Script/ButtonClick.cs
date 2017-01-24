using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonClick : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	}

	// Help Button click
	public void  clickForHelp () {
	    SceneManager.LoadSceneAsync("help_scene");
    }

    // Start Button click
	public void clickForStart () { 
	    SceneManager.LoadSceneAsync("game_scene");
    }

    // Return Button click
	public void clickForReturn () { 
	    SceneManager.LoadSceneAsync("start_scene");
    }
}
