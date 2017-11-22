using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fading : MonoBehaviour {

    public Texture2D fadeOutTexture;
    public float fadeSpeed = 0.8f;

    private int drawDepth = -1000;
    private float alpha = 1.0f;
    private int fadeDir = -1;

    private void OnGUI()
    {
        alpha += fadeDir * fadeSpeed * Time.deltaTime;
        //force (clamp) the number b/t 0 and 1
        alpha = Mathf.Clamp01(alpha);

        //set color of GUI
        GUI.color = new Color(GUI.color.r, GUI.color.g, GUI.color.b, alpha);
        GUI.depth = drawDepth;
        GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), fadeOutTexture);
    }

    // sets fadeDir to the direction param making scene fade in if -1 and out if 1
    public float BeginFade (int direction)
    {
        fadeDir = direction;
        return (fadeSpeed);
    }

    //OnLevelWasLoaded is called when level is loaded
    void OnLevelWasLoaded()
    {
        BeginFade(-1);
    }
}
