using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeFeild]    private float speed;
   private RigidBody2D body;

   private void Awake()
   {
        body = GetComponent<RigidBody2D>();
   }

    private void Update()
    {
        body.velocity   =   new vector2(Input.GetAxis("Horizontal") * speed, body.velocity.y);
    }
}
