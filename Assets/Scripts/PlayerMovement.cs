using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5f; // Movement speed of the player
    [SerializeField] private float jumpForce = 5f; // Force applied when the player jumps
    private bool isJumping = false; // Flag indicating if the player is jumping
    private Rigidbody2D rb; // Reference to the player's Rigidbody2D component
 
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>(); // Get the Rigidbody2D component of the player
    }
 
    // Update is called once per frame
    void Update()
    {
        //Handles Movement
        float moveX = Input.GetAxis("Horizontal"); // Get the horizontal input axis
        // Move the player horizontally based on the input
        rb.velocity = new Vector2(moveX * moveSpeed, rb.velocity.y);
 
        // Flip the player sprite based on the movement direction
       

        /*if (moveX < 0)
            transform.localScale = new Vector2(-1f, 1f);
        else if (moveX > 0)
            transform.localScale = new Vector2(1f, 1f);
 */
       
        // Check if the jump button is pressed and the player is not already jumping
        if (Input.GetButtonDown("Jump") && !isJumping)
        {
            Jump(); // Make the player jump
        }
    }
 
    private void Jump()
    {
        // Apply an upward force to the player for jumping
        rb.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
        isJumping = true; // Set the jumping flag to true
    }
 
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Check if the player collides with the ground
        if (collision.gameObject.CompareTag("Ground"))
        {
            ResetJumpFlag(); // Reset the jumping flag
        }
    }
 
    private void ResetJumpFlag()
    {
        isJumping = false; // Set the jumping flag to false
    }
}