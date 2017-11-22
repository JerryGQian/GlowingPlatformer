using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrateManagerSide : MonoBehaviour {

    private Rigidbody rbThis;

    public GameObject thisCrate;

    /*void OnTriggerEnter(Collider obj)
    {
        //if hit side of another crate
        if (obj.gameObject.tag == "Crate")
        {
            Debug.Log("side crate set f");
            rbThis = thisCrate.GetComponent<Rigidbody>();
            rbThis.isKinematic = false;
        }

        //environment
        if (obj.gameObject.tag == "Environment")
        {
            Debug.Log("env set f");
            rbThis = thisCrate.GetComponent<Rigidbody>();
            rbThis.isKinematic = false;
        }
    }


    void OnTriggerExit(Collider obj)
    {
        //is leave side of another crate
        if (obj.gameObject.tag == "Crate")
        {
            Debug.Log("side crate set t");
            rbThis = thisCrate.GetComponent<Rigidbody>();
            rbThis.isKinematic = true;
        }

        //environment
        rbThis = obj.GetComponent<Rigidbody>();
        CrateManager thisCM = thisCrate.GetComponent<CrateManager>();
        if (obj.gameObject.tag == "Environment" && thisCM.isStackedOver == true)
        {
            CrateManager isOtherStackedOver = obj.GetComponent<CrateManager>();
            Debug.Log("env set t");
            rbThis = thisCrate.GetComponent<Rigidbody>();
            rbThis.isKinematic = true;
        }
    }*/
}
