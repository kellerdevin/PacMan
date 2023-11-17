using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Sounds))]
public class AudioPlayer : MonoBehaviour
{
    private Sounds sounds;
    
    private void Start()
    {
        sounds = GetComponent<Sounds>();
    }
    
    private void OnEnable()
    {
        EatPellet.pelletEaten += PlayPelletSound;
        
    }
    
    private void OnDisable()
    {
        EatPellet.pelletEaten -= PlayPelletSound;
    }
    
    private void PlayPelletSound()
    {
        sounds.PlayPelletCollectedClip();
    }
}
