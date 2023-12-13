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
