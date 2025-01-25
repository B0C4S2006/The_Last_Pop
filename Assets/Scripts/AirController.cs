using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AirController : MonoBehaviour
{
    public float currentStrength = 5f;
    public Vector2 currentDirection = Vector2.up;

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other != null)
        {
            Rigidbody2D rb = other.GetComponent<Rigidbody2D>();
            if (rb != null)
            {
                rb.AddForce(currentDirection * currentStrength);
            }
        }
    }
}
