using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManeger : MonoBehaviour
{
   

    private AudioSource AudioSource;


    private void Start()
    {
        AudioSource = GetComponent<AudioSource>();

    }
    public void chooseAudio(AudioClip ColectablaudioClip)
    {
        AudioSource.clip=ColectablaudioClip;
        AudioSource.Play();
    }
}
