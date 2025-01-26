using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BurningSound : MonoBehaviour
{
    public AudioClip Burn;
    private AudioSource AudioSource;

    private void Start()
    {
        AudioSource = GetComponent<AudioSource>();
    }

    void OnCollisionEnter2D(Collision2D collision) {
        AudioSource.PlayOneShot(Burn);
    }
}
