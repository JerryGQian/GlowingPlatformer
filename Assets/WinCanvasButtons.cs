using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WinCanvasButtons : MonoBehaviour {

    public static GameObject wmObj;
    WorldManager wm;
    public Text finalTime;

    void Start () {
        wmObj = GameObject.Find("_WorldManager");
        wm = wmObj.GetComponent<WorldManager>();
        wm.updateTimerText(finalTime, true);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    //runs WinCanvas next level button
    public void nextLevel()
    {
        wm = wmObj.GetComponent<WorldManager>();
        SceneManager.LoadScene("level" + (wm.currentLevel + 1));
    }
    //loads main menu
    public void toMainMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }
}
