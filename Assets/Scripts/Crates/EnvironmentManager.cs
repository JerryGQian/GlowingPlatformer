using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnvironmentManager : MonoBehaviour {

    /*Rigidbody rbCrate;

    void OnTriggerEnter(Collider obj)
    {
        if (obj.gameObject.tag == "Crate")
        {
            rbCrate = obj.GetComponent<Rigidbody>();
            rbCrate.isKinematic = false;
        }
    }

    void OnTriggerExit(Collider obj)
    {
        rbCrate = obj.GetComponent<Rigidbody>();
        if (obj.gameObject.tag == "Crate")
        {
            CrateManager isOtherStackedOver = obj.GetComponent<CrateManager>();
            if (isOtherStackedOver.isStackedOver == true)
            {
                rbCrate = obj.GetComponent<Rigidbody>();
                rbCrate.isKinematic = true;
            }
        }
    }*/
}
