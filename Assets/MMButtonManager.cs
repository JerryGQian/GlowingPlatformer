using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MMButtonManager : MonoBehaviour {

    public int nextLevel = 1;
    //loads main menu
    public void toNextLevel()
    {
        SceneManager.LoadScene("level" + nextLevel);
    }

    public void toLevelSelect()
    {
        SceneManager.LoadScene("Level Select");
    }
}
