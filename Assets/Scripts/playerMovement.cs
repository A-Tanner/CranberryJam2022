using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class playerMovement : MonoBehaviour
{
    [SerializeField]
    private float speed;
    [SerializeField]
    private float jumpStrength;
    [SerializeField]
    private float gravity = 2.0f;
    [SerializeField]
    private Animator animator;
    [SerializeField]
    private Transform camera;
    private float rotationVelocity=0;
    [SerializeField]
    private float rotateTime;

    private float upwardsAcceleration=0;

    CharacterController controller;
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        bool moving = false;
        float mult = Time.deltaTime * speed;
        float xMove = Input.GetAxisRaw("Horizontal")*mult;
        float zMove = Input.GetAxisRaw("Vertical")*mult;
        float yMove = 0;
        
        JumpHandle();
        yMove = upwardsAcceleration;
        Vector3 inputDir = new Vector3(xMove, yMove, zMove);
        
        if (xMove !=0 || zMove != 0)
        {
            moving = true;
        }

        if (moving)
        {
            float targetAngle = Mathf.Atan2(inputDir.x, inputDir.z) * Mathf.Rad2Deg + camera.eulerAngles.y;
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref rotationVelocity, rotateTime);

            transform.rotation = Quaternion.Euler(0f, angle, 0f);
            Vector3 moveDir = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward;


            controller.Move(moveDir*speed*Time.deltaTime);
        }

        
        controller.Move( new Vector3 (0, upwardsAcceleration, 0));

        animator.SetBool("moving", moving);
    }

    private void JumpHandle()
    {
        if (!controller.isGrounded)
        {
            upwardsAcceleration -= gravity * Time.deltaTime;
        } else
        {
            upwardsAcceleration = 0;
        }

        if (Input.GetAxisRaw("Jump") > 0 && controller.isGrounded)
        {
            upwardsAcceleration = jumpStrength;
        }

    }
}
