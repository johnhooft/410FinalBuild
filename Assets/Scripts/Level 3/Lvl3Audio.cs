using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lvl3Audio : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip clip;
    public float volume = 0.5f;

    void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void Start()
    {
        audioSource.clip = clip;
        audioSource.Play();
    }

    private void OnDisable()
    {
        audioSource.Stop();
    }
 
}
