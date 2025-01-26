using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopingSoud : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioClip Pop;
    private AudioSource AudioSource;

    private void Start()
    {
        AudioSource = GetComponent<AudioSource>();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        AudioSource.PlayOneShot(Pop);
    }
}
