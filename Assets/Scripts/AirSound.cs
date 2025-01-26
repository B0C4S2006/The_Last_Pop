using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AirSound : MonoBehaviour
{

    private AudioSource AudioSource;
    // Start is called before the first frame update
    void Start()
    {
        AudioSource = GetComponent<AudioSource>();
        AudioSource.Pause();
    }

}
