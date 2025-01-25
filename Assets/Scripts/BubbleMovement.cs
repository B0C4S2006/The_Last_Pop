using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleMovement : MonoBehaviour
{
    public float moveForce = 5f; // The force applied when moving
    public float dampingFactor = 0.98f; // Adjust this to control how quickly the bubble slows down
    private Rigidbody2D rb;
    private Vector2 movement;

    void Start()
    {
        // Get the Rigidbody2D component
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Get input from horizontal and vertical axes (WASD or Arrow keys)
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        // Create a movement vector
        movement = new Vector2(moveX, moveY).normalized;
    }

    void FixedUpdate()
    {
        if (movement.x != 0 || movement.y != 0)
        {
            // Apply force to the Rigidbody2D when there is input
            rb.AddForce(movement * moveForce);
        }
        else
        {
            // Gradually reduce force when there is no input
            rb.velocity = Vector2.Lerp(rb.velocity, Vector2.zero, Time.fixedDeltaTime * dampingFactor);
        }
    }
}
