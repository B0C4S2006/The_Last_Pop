using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AirController : MonoBehaviour
{
    public float currentStrength = 5f;
    public Vector2 currentDirection = Vector2.up;
    private AudioSource AudioSource;

    private void Start()
    {
        AudioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        Debug.Log("Entry");
        if (other != null)
        {
            Rigidbody2D rb = other.GetComponent<Rigidbody2D>();
            if (rb != null)
            {
                AudioSource.Play();
                rb.AddForce(currentDirection * currentStrength);
            }
            
        }
        
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
            Debug.Log("Exit");
            Rigidbody2D rb = collision.GetComponent<Rigidbody2D>();
            if (rb != null){
                AudioSource.Pause();
            }
    }

}
