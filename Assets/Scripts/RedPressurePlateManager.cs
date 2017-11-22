using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedPressurePlateManager : MonoBehaviour
{

    public int redPPID;
    public bool isPressed = false;
    int total = 0;

    public Transform lightEffect;
    Transform padLight1;
    Transform padLight2;

    void OnTriggerEnter(Collider info)
    {
        total++;

        if (total == 1)
        {
            //spawns light-
            Vector3 lightPos = transform.position;
            lightPos = new Vector3(0, .8f, -.7f);
            padLight1 = Instantiate(lightEffect, lightPos, transform.rotation);
            lightPos = new Vector3(0, .8f, .7f);
            padLight2 = Instantiate(lightEffect, lightPos, transform.rotation);

            padLight1.SetParent(gameObject.transform, false);
            padLight2.SetParent(gameObject.transform, false);

            //shifts plate down
            Vector3 pos = transform.position;
            pos.y -= .12f;
            transform.position = pos;

            isPressed = true;
        }
    }

    void OnTriggerExit(Collider info)
    {
        total--;

        if (total == 0)
        {
            isPressed = false;

            //destroys light
            GameObject.Destroy(padLight1.gameObject, 1);
            GameObject.Destroy(padLight2.gameObject, 1);

            //shifts plate back up
            Vector3 pos = transform.position;
            pos.y += .12f;
            transform.position = pos;
        }

    }

    void Update()
    {
        //Sends plate status to world manager
        WorldManager.PPStatus[redPPID] = isPressed;

    }

}