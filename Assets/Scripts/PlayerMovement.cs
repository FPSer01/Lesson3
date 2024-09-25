using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed;

    [SerializeField] Vector2 moveInput;
    [SerializeField] Vector3 moveDirection;
    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        LimitSpeed();
        PlayerInput();
    }

    private void FixedUpdate()
    {
        PlayerMove();
    }

    void PlayerInput()
    {
        moveInput.x = Input.GetAxisRaw("Horizontal");
        moveInput.y = Input.GetAxisRaw("Vertical");

        moveDirection = transform.forward * moveInput.y + transform.right * moveInput.x;
    }

    void PlayerMove()
    {
        rb.AddForce(moveDirection.normalized * moveSpeed, ForceMode.Force);
    }

    void LimitSpeed()
    {
        if (rb.velocity.magnitude > moveSpeed / 10)
        {
            Vector3 newVel = rb.velocity.normalized * moveSpeed / 10;
            rb.velocity = new Vector3(newVel.x, rb.velocity.y, newVel.z);
        }
    }
}
