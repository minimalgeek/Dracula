using UnityEngine;
using System.Collections;
using System;

public class PlayerController : MonoBehaviour
{
    public float speed = 30f;
    public float tilt = 0.1f;
    public float jumpForce = 500f;
    public float verticalVelocityThreshold;
    private Rigidbody myRigidBody;
    private ShapeShiftController shapeShiftController;
    private Animator currentAnimator;
    private bool enabledToMoveAndShift = false;

    void Start()
    {
        myRigidBody = GetComponent<Rigidbody>();
        shapeShiftController = GetComponent<ShapeShiftController>();
        FindActiveAnimator();
        currentAnimator.SetTrigger("GetUp");
        Invoke("Enable", 5);
    }

    public void FindActiveAnimator()
    {
        currentAnimator = GetComponentInChildren<Animator>(false);
    }
    
    public void Enable()
    {
        enabledToMoveAndShift = true;
    }

    public void Disable()
    {
        enabledToMoveAndShift = false;
    }

    void FixedUpdate()
    {
        if (enabledToMoveAndShift)
        {
            float moveHorizontal = Input.GetAxis("Horizontal");
            float moveVertical = Input.GetAxis("Vertical");

            Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
            myRigidBody.velocity = movement * speed;

            Vector3 lookAt = transform.position;
            lookAt.x += myRigidBody.velocity.x;
            lookAt.z += myRigidBody.velocity.z;
            lookAt = Vector3.Lerp(transform.position, lookAt, tilt * Time.deltaTime);
            transform.LookAt(lookAt);

            if (Input.GetButton("Jump") && (Mathf.Abs(myRigidBody.velocity.y) < verticalVelocityThreshold))
            {
                myRigidBody.AddForce(new Vector3(0, jumpForce, 0), ForceMode.Impulse);
                currentAnimator.SetTrigger("Jump");
            }

            currentAnimator.SetFloat("Speed", myRigidBody.velocity.magnitude);
        }
    }

    
}