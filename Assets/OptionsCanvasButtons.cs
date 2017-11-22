using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OptionsCanvasButtons : MonoBehaviour
{

    public static GameObject wmObj;
    public GameObject MoveJumpCanvas;
    WorldManager wm;

    void Start()
    {
        wmObj = GameObject.Find("_WorldManager");
        wm = wmObj.GetComponent<WorldManager>();
    }

    //resumes game. unpauses.
    public void resume()
    {
        WorldManager.isPaused = false;
        Destroy(gameObject);
        MoveJumpCanvas.SetActive(false);
    }
    //loads main menu
    public void toMainMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }
}
/*
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OptionsCanvasButtons : MonoBehaviour
{

    public static GameObject wmObj;
    WorldManager wm;
    public Text finalTime;

    void Start()
    {
        wmObj = GameObject.Find("_WorldManager");
        wm = wmObj.GetComponent<WorldManager>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    //resumes game. unpauses.
    public void resume()
    {
        WorldManager.isPaused = false;
        Destroy(this);
        //wm = wmObj.GetComponent<WorldManager>();
        //SceneManager.LoadScene("level" + (wm.currentLevel + 1));
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

*/