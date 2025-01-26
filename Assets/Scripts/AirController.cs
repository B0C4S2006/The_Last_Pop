using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AirController : MonoBehaviour
{
    public float currentStrength = 15f;
    public Vector2 currentDirection = Vector2.up;
    public GameObject AudioSource;

    private void Start()
    {
        AudioSource.SetActive(false);
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other != null)
        {
            Rigidbody2D rb = other.GetComponent<Rigidbody2D>();
            if (rb != null)
            {
                AudioSource.SetActive(true);
                rb.AddForce(currentDirection * currentStrength);
            }
            
        }
        
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
            Rigidbody2D rb = collision.GetComponent<Rigidbody2D>();
            if (rb != null){
            AudioSource.SetActive(false);
            }
    }

}
