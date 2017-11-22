using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevelTrigger : MonoBehaviour {

    public string scene;

    void OnTriggerEnter(Collider info)
    {
        if (info.tag == "Player")
        {
            Debug.Log("You win!");
            SceneManager.LoadScene(scene);
        }
    }
}
