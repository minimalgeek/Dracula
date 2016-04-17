using UnityEngine;
using System.Collections;

public class MovementController : MonoBehaviour
{

    public float speed = 6.0F;
    public float jumpSpeed = 8.0F;
    public float gravity = 20.0F;
    private Vector3 moveDirection = Vector3.zero;
    public float rotSpeed = 10;
    CharacterController cc;
    Animator anim;
    void Start()
    {
        cc = GetComponent<CharacterController>();
        anim = GetComponentInChildren<Animator>();
    }
    bool enable = false;
    void Update()
    {
        if (anim.GetCurrentAnimatorStateInfo(0).IsTag("Start"))
        {
            enable = true;
        }
        if (anim.GetCurrentAnimatorStateInfo(0).IsTag("Stop"))
        {
            enable = false;
        }

        if (enable)
        {
            //if (Input.GetKey(KeyCode.W))
            //{
            //    cc.SimpleMove(transform.forward * speed*Time.deltaTime);
            //}

            Vector3 dir;
           
            if (cc.isGrounded)
            {
                float horizontal = Input.GetAxis("Horizontal");
                float vertical = Input.GetAxis("Vertical");

                //if (0!=Input.GetAxis("Horizontal"))
                //{
                //    moveDirection = transform.forward*Input.GetAxis("Horizontal"); 
                //}
                //transform.Rotate(0, Input.GetAxis("Horizontal") * rotSpeed * Time.deltaTime, 0);
                dir = new Vector3(-horizontal, 0, -vertical);
                moveDirection = transform.TransformDirection(dir);
                moveDirection *= speed;
                anim.SetFloat("Speed", dir.magnitude);
                if (Input.GetButton("Jump"))
                {
                    moveDirection.y = jumpSpeed;
                    anim.SetTrigger("Jump");
                }
                //if (-1==Input.GetAxis("Vertical"))
                //{
                //    // transform.rotation=new Vector3(transform.rotation.x,;
                //    transform.GetChild(0).localRotation = Quaternion.Euler(new Vector3(0,0, 0));
                //}
                //else
                //if (1 == Input.GetAxis("Vertical"))
                //{
                //    // transform.rotation=new Vector3(transform.rotation.x,;
                //    transform.GetChild(0).localRotation = Quaternion.Euler(new Vector3(0, 180, 0));

                if (horizontal > 0 && vertical < 0) //DS
                {
                    transform.GetChild(0).localRotation = Quaternion.Euler(new Vector3(0, -45, 0));
                }
                else if (horizontal > 0 && vertical > 0) //DW
                {
                    transform.GetChild(0).localRotation = Quaternion.Euler(new Vector3(0, 225, 0));
                }
                else if (horizontal > 0 && vertical == 0) //A
                {
                    transform.GetChild(0).localRotation = Quaternion.Euler(new Vector3(0, -90, 0));
                }
                else if (horizontal < 0 && vertical < 0) //AS
                {
                    transform.GetChild(0).localRotation = Quaternion.Euler(new Vector3(0, 45, 0));
                }
                else if (horizontal < 0 && vertical > 0) //AW
                {
                    transform.GetChild(0).localRotation = Quaternion.Euler(new Vector3(0, 135, 0));
                }
                else if (horizontal < 0 && vertical == 0) //D
                {
                    transform.GetChild(0).localRotation = Quaternion.Euler(new Vector3(0, 90, 0));
                }
                else if (horizontal == 0 && vertical > 0)//W
                {
                    transform.GetChild(0).localRotation = Quaternion.Euler(new Vector3(0, 180, 0));
                }
                else//S
                {
                    transform.GetChild(0).localRotation = Quaternion.Euler(new Vector3(0, 0, 0));
                }
               
            }
            moveDirection.y -= gravity * Time.deltaTime;
            cc.Move(moveDirection * Time.deltaTime);
        }
    }
}