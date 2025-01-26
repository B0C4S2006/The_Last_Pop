using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleMovement : MonoBehaviour
{
    public float moveForce = 7f; // The force applied when moving
    public float dampingFactor = 0.98f; // Adjust this to control how quickly the bubble slows down

    private Rigidbody2D rb;
    private Vector2 movement;
    public AudioClip JumpSFX;
    private AudioSource AudioSource;

    public GameObject victoryMessage;

    void Start()
    {
        // Get the Rigidbody2D component
        rb = GetComponent<Rigidbody2D>();
        AudioSource = GetComponent<AudioSource>();
        AudioSource.Pause();

        victoryMessage.SetActive(false);

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
            if (!AudioSource.isPlaying)
            {
                AudioSource.Play();
            }
        }
        else
        {
            // Gradually reduce force when there is no input
            rb.velocity = Vector2.Lerp(rb.velocity, Vector2.zero, Time.fixedDeltaTime* dampingFactor);

            // Pause the audio when not moving
            AudioSource.Pause();
        }
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Goal"))
        {
            // Display the victory message
            victoryMessage.SetActive(true);
        }
    }

}
