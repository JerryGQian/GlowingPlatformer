using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrateManagerTop : MonoBehaviour
{
    private Rigidbody rbOther;
    private Rigidbody rbThis;
    public GameObject thisCrate;
    public static GameObject childCrate;
    bool thisIsStackedUnder;
    bool thisIsStackedOver;

    private void Start()
    {
        
    }

    private void Update()
    {

    }

    void OnTriggerEnter(Collider obj)
    {
        CrateManager thisCM = thisCrate.GetComponent<CrateManager>();
        if (obj.gameObject.tag == "Crate" && !thisCM.isStackedOver)
        {
            obj.transform.parent = transform.parent;
            childCrate = obj.gameObject;
            //sets this crate status
            //CrateManager thisCM = thisCrate.GetComponent<CrateManager>();
            thisCM.isStackedUnder = true;

            //sets other crate status
            CrateManager otherCM = obj.GetComponent<CrateManager>();
            otherCM.isStackedOver = true;

            //rbOther = obj.GetComponent<Rigidbody>();
            //rbOther.isKinematic = true;

            
        }
    }

    void OnTriggerExit(Collider obj)
    {
        if (obj.gameObject.tag == "Crate")
        {
            //sets this crate status
            CrateManager thisCM = thisCrate.GetComponent<CrateManager>();
            thisCM.isStackedUnder = false;
            //sets other crate status
            CrateManager otherCM = obj.GetComponent<CrateManager>();
            otherCM.isStackedOver = false;

            obj.transform.parent = null;
        }
    }

    // Update is called once per frame
    /*void Update()
    {
        CrateManager thisCM = thisCrate.GetComponent<CrateManager>();
        if (thisCM.isStackedOver == false)
        {
            rbThis = thisCrate.GetComponent<Rigidbody>();
            rbThis.isKinematic = false;
        }
    }*/
}
