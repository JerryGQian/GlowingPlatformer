using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelButtonScript : MonoBehaviour {
    public int levelNumber;
    public Text textObject;

	// Use this for initialization
	void Start () {
        string levelString = levelNumber.ToString();
        textObject.text = levelString;
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void toLevel ()
    {
        SceneManager.LoadScene("level" + levelNumber);
    }
}
