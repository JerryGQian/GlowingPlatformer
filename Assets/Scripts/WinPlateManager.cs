using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinPlateManager : MonoBehaviour
{
    public bool isPressed = false;
    private int total = 0;
    public Canvas winCanvas;
    public Transform lightEffect;
    Transform padLight1;
    Transform padLight2;
    public Transform particleEffect;

    public static GameObject wmObj;
    WorldManager wm;


    private void Start()
    {
        wmObj = GameObject.Find("_WorldManager");
        wm = wmObj.GetComponent<WorldManager>();
    }

    void OnTriggerEnter(Collider info) {
        total++;
        if (total == 1)
        {
            //shifts plate down when any object touches
            Vector3 pos = transform.position;
            pos.y -= .12f;
            transform.position = pos;
        }
        if (info.gameObject.tag == "Player" && WorldManager.isRedsPressed)
        {
            var effect = Instantiate(particleEffect, transform.position, transform.rotation);
            Destroy(effect.gameObject, 3);

            //spawns light when player touches
            Vector3 lightPos = transform.position;
            lightPos = new Vector3(0, .8f, -.7f);
            padLight1 = Instantiate(lightEffect, lightPos, transform.rotation);
            lightPos = new Vector3(0, .8f, .7f);
            padLight2 = Instantiate(lightEffect, lightPos, transform.rotation);

            padLight1.SetParent(gameObject.transform, false);
            padLight2.SetParent(gameObject.transform, false);

            isPressed = true;

            //spawn canvas
            Debug.Log("trying to access laod method");
            wm.loadWinCanvas();
            //Canvas winCanv = Instantiate(winCanvas, new Vector2(390f, 350f), transform.rotation);
        }
    }

    void OnTriggerExit(Collider info)
    {
        total--;

        if (total == 0)
        {
            //shifts plate back up when anything leaves
            Vector3 pos = transform.position;
            pos.y += .12f;
            transform.position = pos;
        }

        if (info.gameObject.tag == "Player" && !WorldManager.isWin)
        {
            isPressed = false;
            //destroys light when player exit
            GameObject.Destroy(padLight1.gameObject, 1);
            GameObject.Destroy(padLight2.gameObject, 1);
        }

    }

    void Update()
    {
        //Sends plate status to world manager
        WorldManager.isWinPressed = isPressed;
    }

}