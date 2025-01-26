using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenBounce : MonoBehaviour
{
    public float bounceForce = 10f;
    private Rigidbody2D rb;
    private Camera mainCamera;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        mainCamera = Camera.main;
    }

    void Update()
    {
        // Calculate screen boundaries
        Vector2 screenBounds = mainCamera.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height));
        // Check if the object is outside the screen boundaries
        if (transform.position.x > screenBounds.x || transform.position.x < -screenBounds.x)
        {
            Debug.Log("Off Bounds");
            rb.velocity = new Vector2(-rb.velocity.x * bounceForce, rb.velocity.y);
        }

        if (transform.position.y > screenBounds.y || transform.position.y < -screenBounds.y)
        {
            Debug.Log("Off Bounds");
            rb.velocity = new Vector2(rb.velocity.x, -rb.velocity.y * bounceForce);
        }
    }
}
