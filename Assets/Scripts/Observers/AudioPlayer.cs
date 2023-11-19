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
        Player.playerDied += PlayGameOverSound;
    }
    
    private void OnDisable()
    {
        EatPellet.pelletEaten -= PlayPelletSound;
        Player.playerDied -= PlayGameOverSound;
    }
    
    private void PlayPelletSound()
    {
        sounds.PlayPelletCollectedClip();
    }
    private void PlayGameOverSound()
    {
        sounds.PlayGameOverClip();
    }
}
