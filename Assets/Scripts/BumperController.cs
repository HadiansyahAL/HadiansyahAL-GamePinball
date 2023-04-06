using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BumperController : MonoBehaviour
{
   public Collider ball;
   public float multiplier;
   public Color color;
   private Renderer renderer;
   private Animator animator;


   private void Start() 
   {
        renderer = GetComponent<Renderer>();
        animator = GetComponent<Animator>();

        renderer.material.color = color;

   }


   private void OnCollisionEnter(Collision collision) {
        if (collision.collider == ball)
        {
            Rigidbody ballRig = ball.GetComponent<Rigidbody>();
            ballRig.velocity *= multiplier;

            //animasi
            animator.SetTrigger("Hit");
        }
   }
}
