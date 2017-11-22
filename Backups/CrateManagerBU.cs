using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrateManager : MonoBehaviour
{

    public bool isStackedOver = false;
    public bool isStackedUnder = false;

    private Rigidbody rb;
    private Rigidbody rbCrate;
    private Rigidbody rbThisCrate;

    // Update is called once per frame
    void Update()
    {
        if (isStackedOver == false)
        {
            rb = GetComponent<Rigidbody>();
            rb.isKinematic = false;
        }

        //transform.position = Crate.transform.position;
    }
}
