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
    private float upwardsAcceleration=0;

    CharacterController controller;
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        float mult = Time.deltaTime * speed;
        float xMove = Input.GetAxisRaw("Horizontal")*mult;
        float zMove = Input.GetAxisRaw("Vertical")*mult;
        float yMove = 0;
        JumpHandle();
        yMove = upwardsAcceleration;

        controller.Move(new Vector3(xMove,yMove,zMove));
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
