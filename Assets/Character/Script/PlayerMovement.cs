using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
   private RigidBody2D body;

   private void Awake()
   {
        body = GetComponent<RigidBody2D>();
   }

    private void Update()
    {
        body.velocity   =   new vector3(Input.GetAxis("Horizontal"),0,0);
    }
}
