/*
 1. IDENTIFYING INFORMATION
a. Devin Keller, Kentaro Matsui, Tad Kitagushi, Miles Rovenger
b. Student ID: 2368610, 2366951, 2403661, 2343785
c. dkeller@chapman.edu, matsuo@chapman.edu, tkitaguchi@chapman.edu, rovenger@chapman.edu
d. CPSC-245
e. Final Project: PacMan
*/

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
        EatReverseCollectable.reverseCollectableCollected += PlayPowerUpSound;
        Player.playerDied += PlayGameOverSound;
        Player.ateReversedGhost += PlayGhostEatenSound;
    }
    
    private void OnDisable()
    {
        EatPellet.pelletEaten -= PlayPelletSound;
        EatReverseCollectable.reverseCollectableCollected -= PlayPowerUpSound;
        Player.playerDied -= PlayGameOverSound;
        Player.ateReversedGhost -= PlayGhostEatenSound;
    }
    
    private void PlayPelletSound()
    {
        sounds.PlayPelletCollectedClip();
    }
    private void PlayPowerUpSound()
    {
        sounds.PlayPowerUpClip();
    }
    private void PlayGameOverSound()
    {
        sounds.PlayGameOverClip();
    }
    private void PlayGhostEatenSound()
    {
        sounds.PlayGhostEatenClip();
    }
}
