using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour
{
    public AudioClip audio;

    void Start()
    {
        GetComponent<AudioSource>().playOnAwake = false;
        GetComponent<AudioSource>().clip = audio;
    }

    void OnCollisionEnter ()  //Plays Sound Whenever collision detected
     {
         GetComponent<AudioSource>().Play();
       }
void Update()
    {
        
    }
}
