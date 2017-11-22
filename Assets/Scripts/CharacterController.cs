using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public float rotationSpeed = 200;
    public float jumpHeight = 5;
    public float moveSpeed = 2;
    public int lives = 3;

    [SerializeField]
    private bool isFalling = false;

    private Rigidbody rb;

    [SerializeField]
    private bool isLeftPressed = false;
    private bool isRightPressed = false;
    private bool isJumpPressed = false;


    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (isLeftPressed)
        {
            rb.velocity = new Vector3(-moveSpeed, rb.velocity.y, rb.velocity.z);
        }
            

        if (isRightPressed)
        {
            rb.velocity = new Vector3(moveSpeed, rb.velocity.y, rb.velocity.z);
        }
            

        if (isJumpPressed == true && isFalling == false)
            rb.velocity = new Vector3(rb.velocity.x, jumpHeight, rb.velocity.z);

        if (rb.velocity.y == 0) isFalling = false;
        else isFalling = true;
    }
    //update end


    //###########################################################################################
    //################################      methods     #########################################
    //###########################################################################################


    public void onPointerDownMoveButton(string direction)
    {
        if (direction == "left")
        {
            transform.eulerAngles = new Vector3(0, 180, 0);  isLeftPressed = true;
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
    }


    //###########################################################################################
    //#################################    triggers     #########################################
    //###########################################################################################


    Rigidbody rbCrate;

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
            if (isOtherStackedOver.isStackedOver == true) {
                rbCrate = obj.GetComponent<Rigidbody>();
                rbCrate.isKinematic = true;
            }
        }
    }
}
