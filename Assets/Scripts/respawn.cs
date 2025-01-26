using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class respawn : MonoBehaviour
{
    private Vector2 respawnPoint;
    private Rigidbody2D rb;
    private AudioSource AudioSource;
    public AudioClip Pop;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        AudioSource = GetComponent<AudioSource>();
        respawnPoint = transform.position;
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("PopZone"))
        {
            AudioSource.PlayOneShot(Pop);
            Respawn();
        }
    }
    void Respawn()
    {
        transform.position = respawnPoint;
        rb.velocity = Vector2.zero;
    }
}
