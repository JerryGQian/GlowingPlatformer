using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WorldManager : MonoBehaviour
{
    public int currentLevel; //[inspector]

    //CANVAS
    public GameObject optionsCanvas; //[inspector]
    public GameObject gameCanvas; //[inspector]
    public GameObject winCanvas; //[inspector]
    //timer stuff
    public Text timerText; //[inspector]
    private float startTime;
    public float t;

    //pressure plate data
    [SerializeField]
    private int PPAmount; //num of reds
    [SerializeField]
    private int totalPPPressed; //num of reds pressed
    public static bool[] PPStatus; //bool array of all red plates
    public static bool isWinPressed = false; //is winplate pressed
    public static bool isRedsPressed = false; //are all reds pressed
    public static bool isWin = false; //level win or not

    public static bool isPaused;

    void Start() {
        isPaused = false;
        //timer
        startTime = Time.time;
        //counts red plate total
        GameObject[] gos;
        gos = GameObject.FindGameObjectsWithTag("RedPressurePlate");
        PPAmount = gos.Length;

        PPStatus = new bool[PPAmount];

        for (int i = 0; i < PPAmount; i++)
        {
            PPStatus[i] = false;
        }
    }

    void Update() {
        if (!isPaused)
        {
            Time.timeScale = 1;
        }
        else if (isPaused)
        {
            Time.timeScale = 0;
        }

        //timer
        t = Time.time - startTime;
        updateTimerText(timerText, false);

        for (int i = 0; i < PPAmount; i++)
        {
            if (PPStatus[i])
            {
                totalPPPressed++;
            }
        }
        //all red plates pressed
        if (totalPPPressed == PPAmount)
        {
            isRedsPressed = true;
        }
        //sets isWin to true
        if (isWinPressed == true && totalPPPressed == PPAmount)
        {
            isWin = true;
        }

        totalPPPressed = 0;
    }

    public void loadWinCanvas ()
    {
        Debug.Log("trying to load Wincanvas");
        gameCanvas.SetActive(false);
        winCanvas.SetActive(true);
    }

    //###########################################################################
    //      BEGINNING OF BUTTON METHODS
    //###########################################################################

    //runs restart button
    public void restartLevel()
    {
        SceneManager.LoadScene("level" + currentLevel);
    }
    //opens and closes options canvas
    public void openOptions()
    {
        isPaused = true;
        optionsCanvas.SetActive(true);
        gameCanvas.SetActive(false);
    }
    public void closeOptions()
    {
        isPaused = false;
        optionsCanvas.SetActive(false);
        gameCanvas.SetActive(true);
    }

    //resumes game from options menu
    public void resume()
    {
        isPaused = false;
        optionsCanvas.SetActive(false);
        gameCanvas.SetActive(true);
    }

    //loads main menu
    public void toMainMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }

    public void updateTimerText(Text textObject, bool displayPrefix)
    {
        //timer
        string minutes = ((int)t / 60).ToString();
        string seconds = (t % 60).ToString("f0");
        if (!displayPrefix)
        {
            if (t % 60 < 10)
            {
                textObject.text = minutes + ":0" + seconds;
            }
            else if (t % 60 >= 10)
            {
                textObject.text = minutes + ":" + seconds;
            }
        }
        if (displayPrefix)
        {
            if (t % 60 < 10)
            {
                textObject.text = "Finishing Time: " + minutes + ":0" + seconds;
            }
            else if (t % 60 >= 10)
            {
                textObject.text = "Finishing Time: " + minutes + ":" + seconds;
            }
        }
        
    }
}