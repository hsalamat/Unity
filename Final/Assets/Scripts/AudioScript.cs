using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioScript : MonoBehaviour
{
    public AudioSource source;
    public AudioClip clip;

    //Start is called before the first frame update
    public void Awake()
    {
        source = GetComponent<AudioSource>();
    }

    public void OnTriggerEnter(Collider other)
    {
        source.Play();      
    }
}
