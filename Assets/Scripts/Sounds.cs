using UnityEngine;

public class Sounds : MonoBehaviour
{
    public AudioSource AudioSource;
    public AudioClip StartButtonClip;
    public AudioClip GameOverClip;
    public AudioClip PelletCollectedClip;
    public AudioClip PowerUpClip;
    public AudioClip BackgroundMusic;
    public AudioClip GhostEatenClip;
   
    public void PlayStartButtonSound()
    {
        AudioSource.clip = StartButtonClip;
        AudioSource.Play();
    }
    
    
    public void PlayPelletCollectedClip()
    {
        AudioSource.PlayOneShot(PelletCollectedClip);
    }
    
    public void PlayPowerUpClip()
    {
        AudioSource.PlayOneShot(PowerUpClip);
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
        // AudioSource.loop = true;
    }
    
    public void PlayGhostEatenClip()
    {
        AudioSource.clip = GhostEatenClip;
        AudioSource.Play();
    }
}
