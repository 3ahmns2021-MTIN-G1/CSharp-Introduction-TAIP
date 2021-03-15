using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayPauseAudio : MonoBehaviour
{
    public AudioSource audioSource;

    public void AudioSource()
    {
        if(audioSource.isPlaying == true){
            audioSource.Pause();
        }
        else
        {
            audioSource.Play();
        }
    }
}
