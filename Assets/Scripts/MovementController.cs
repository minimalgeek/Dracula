using UnityEngine;
using System.Collections;

public class MovementController : MonoBehaviour {

    public float speed = 6.0F;
    public float jumpSpeed = 8.0F;
    public float gravity = 20.0F;
    private Vector3 moveDirection = Vector3.zero;
    public float rotSpeed=10;
    CharacterController cc;
    void Start()
    {
        cc = GetComponent<CharacterController>();
    }
	void Update ()
    {
        if (Input.GetKey(KeyCode.W))
        {
            cc.SimpleMove(transform.forward * speed*Time.deltaTime);
        }

        transform.Rotate(0, Input.GetAxis("Horizontal") * rotSpeed * Time.deltaTime, 0);


        CharacterController controller = GetComponent<CharacterController>();
        if (controller.isGrounded)
        {
            //if (0!=Input.GetAxis("Horizontal"))
            //{
            //    moveDirection = transform.forward*Input.GetAxis("Horizontal"); 
            //}
            moveDirection = new Vector3(0, 0, Input.GetAxis("Vertical"));
            moveDirection = transform.TransformDirection(moveDirection);
            moveDirection *= speed;
            if (Input.GetButton("Jump"))
                moveDirection.y = jumpSpeed;

        }
        moveDirection.y -= gravity * Time.deltaTime;
        controller.Move(moveDirection * Time.deltaTime);
    }
}
