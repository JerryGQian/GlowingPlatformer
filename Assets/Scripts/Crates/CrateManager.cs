using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrateManager : MonoBehaviour {

    public bool isStackedOver = false;
    public bool isStackedUnder = false;
    Vector3 changePos;
    Vector3 oldPos;
    GameObject childCrate;

    //delete maybe
    Vector3 oldParentPos, newParentPos;
    float changeX;
    Vector3 childLocalPosition;
    Transform parentTrans;
    private Rigidbody rb;


    private void Start()
    {
        /*parentTrans = transform.parent;
        if (isStackedOver)
        oldParentPos = parentTrans.position;*/
    }
    // Update is called once per frame
    void FixedUpdate ()
    {

        if (isStackedUnder)
        {
            if (oldPos == null) oldPos = transform.position;
            changePos = transform.position - oldPos;
            childCrate.transform.position += changePos * Time.deltaTime;
            oldPos = transform.position;

            /*if (oldParentPos == null) oldParentPos = parentTrans.position;
            newParentPos = parentTrans.position;
            changePos = newParentPos - oldParentPos;
            Debug.Log(oldParentPos.x + "oPar," + oldParentPos.y + parentTrans.name);
            Debug.Log(newParentPos.x + "nPar," + newParentPos.y);
            Debug.Log(changePos.x + "chan," + changePos.y);
            //childLocalPosition = transform.localPosition;
            //transform.localPosition = childLocalPosition;
            transform.Translate(changePos);
            //transform.localPosition = new Vector3 (0, 1, 0);

            oldParentPos = parentTrans.position;*/
        }

    }
}
