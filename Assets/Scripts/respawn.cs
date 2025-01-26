using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class respawn : MonoBehaviour
{
    private Vector2 respawnPoint;
    private Rigidbody2D rb;
    public GameObject PopBubble;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        respawnPoint = transform.position;
        PopBubble.SetActive(false);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Vector2 BubblePos = transform.position;
        if (collision.gameObject.CompareTag("PopZone"))
        { 
            gameObject.SetActive(false);
            PopBubble.SetActive(true);
            PopBubble.transform.position = BubblePos;
            Invoke("Respawn", 1f);
        }
    }

    void Respawn()
    {
        gameObject.SetActive(true);
        transform.position = respawnPoint;
        rb.velocity = Vector2.zero;
        PopBubble.SetActive(false);
    }
}
