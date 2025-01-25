using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleMovement : MonoBehaviour
{
    public float moveForce = 5f; // The force applied when moving
    private Rigidbody2D rb;
    private Vector2 movement;
    public AudioClip JumpSFX;
    private AudioSource AudioSource;
    void Start()
    {
        // Get the Rigidbody2D component
        rb = GetComponent<Rigidbody2D>();
        AudioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        // Get input from horizontal and vertical axes (WASD or Arrow keys)
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");
        AudioSource.PlayOneShot(JumpSFX);

        // Create a movement vector
        movement = new Vector2(moveX, moveY).normalized;
    }

    void FixedUpdate()
    {
        // Apply force to the Rigidbody2D
        rb.AddForce(movement * moveForce);
        
    }
}
