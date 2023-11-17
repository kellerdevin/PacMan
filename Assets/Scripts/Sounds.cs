using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sounds : MonoBehaviour
{
    public AudioSource AudioSource;
    public AudioClip StartButtonClip;
    public AudioClip GameOverClip;
    public AudioClip PelletCollectedClip;
    public AudioClip BackgroundMusic;
    public AudioClip GhostEatenClip;
   
    public void PlayStartButtonSound()
    {
        AudioSource.clip = StartButtonClip;
        AudioSource.Play();
        AudioSource.loop = true;
    }
    
    
    public void PlayPelletCollectedClip()
    {
        AudioSource.clip = PelletCollectedClip;
        AudioSource.Play();
    }
    
    public void PlayGameOverClip()
    {
        AudioSource.clip = GameOverClip;
        AudioSource.Play();
    }
    
    public void PlayBackgroundMusic()
    {
        AudioSource.clip = BackgroundMusic;
        AudioSource.Play();
    }
    
    public void PlayGhostEatenClip()
    {
        AudioSource.clip = GhostEatenClip;
        AudioSource.Play();
    }
}
