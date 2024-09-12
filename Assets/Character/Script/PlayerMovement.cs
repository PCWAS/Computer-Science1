using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float horizontal;
    private float speed = 8f;
    private float jumpingPower = 16f;
    private bool isFacingRight = true;

    [SerializeField] private Rigidbody2D rb; 
    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask groundLayer;

    private bool isGrounded;

    void Update()
    {
        // Input handling
        horizontal = Input.GetAxisRaw("Horizontal"); 
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpingPower);
        }

        // Flip the player sprite if necessary
        Flip();
    }

    private void FixedUpdate()
    {
        // Movement handling
        rb.velocity = new Vector2(horizontal * speed, rb.velocity.y); 

        // Check if the player is grounded
        isGrounded = IsGrounded();
    }

    private bool IsGrounded()
    {
        // Adjust the radius if necessary
        return Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundLayer);
    }

    private void Flip()
    {
        // Flip the sprite when changing direction
        if (isFacingRight && horizontal < 0f || !isFacingRight && horizontal > 0f)
        {
            isFacingRight = !isFacingRight;
            Vector3 localScale = transform.localScale;
            localScale.x *= -1f; 
            transform.localScale = localScale; 
        }
    }
}