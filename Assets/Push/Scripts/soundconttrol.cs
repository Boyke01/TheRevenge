using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundconttrol : MonoBehaviour
{
    public AudioSource source;

    public AudioClip footstep;

    void footsound()
    {
        source.clip = footstep;
        source.Play();
    }
}
