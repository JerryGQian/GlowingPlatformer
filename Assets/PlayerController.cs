using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 200, jumpForce = 5;
    public LayerMask playerMask;
    public bool isGrounded = false;
    Transform myTrans, tagGroundM, tagGroundL, tagGroundR;
    float hInput;
    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        myTrans = this.transform;
        tagGroundM = GameObject.Find(this.name + "/tag_ground").transform;
        tagGroundL = GameObject.Find(this.name + "/tag_ground (L)").transform;
        tagGroundR = GameObject.Find(this.name + "/tag_ground (R)").transform;
    }

    void FixedUpdate()
    {
        isGrounded = Physics.Linecast(myTrans.position, tagGroundM.transform.position, playerMask);
        if (!isGrounded)
        {
            isGrounded = Physics.Linecast(myTrans.position, tagGroundL.transform.position, playerMask);
            if (!isGrounded)
            {
                isGrounded = Physics.Linecast(myTrans.position, tagGroundR.transform.position, playerMask);
            }
        }

        Move(hInput);
    }
    //update end


    //###########################################################################################
    //################################      methods     #########################################
    //###########################################################################################
    void Move (float horizontal_input)
    {
        Vector3 moveVel = rb.velocity;
        moveVel.x = horizontal_input * speed * Time.deltaTime;
        rb.velocity = moveVel;
    }

    public void StartMoving(float horizontalInput)
    {
        hInput = horizontalInput;
    }

    public void Jump()
    {
        if (isGrounded)
            rb.velocity += jumpForce * Vector3.up;
    }

    /*public void onPointerDownMoveButton(string direction)
    {
        if (direction == "left")
        {
            transform.eulerAngles = new Vector3(0, 180, 0); isLeftPressed = true;
        }
        if (direction == "right")
        {
            transform.eulerAngles = new Vector3(0, 0, 0); isRightPressed = true;
        }
        if (direction == "jump")
            isJumpPressed = true;
    }
    public void onPointerUpMoveButton(string direction)
    {
        if (direction == "left")
            isLeftPressed = false;
        if (direction == "right")
            isRightPressed = false;
        if (direction == "jump")
            isJumpPressed = false;
    }*/


    //###########################################################################################
    //#################################    triggers     #########################################
    //###########################################################################################


    Rigidbody rbCrate;
    //player touches crate
    /*void OnTriggerEnter(Collider obj)
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
