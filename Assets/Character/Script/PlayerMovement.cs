using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float horizontal;
    private float speed = 8f;
    private float jumpingPower = 16f;
    private float isFacingRight = True;

    [SerializeField] private RigidBody2D rb;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask groundLayer;


    // Update is called once per frame

    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal"); 
    }


    private void FixedUpdate()
    {
        rb.velocity = new Vecotor2(horizontal)
    }
}
