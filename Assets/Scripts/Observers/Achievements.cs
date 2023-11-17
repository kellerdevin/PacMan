using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Sprite))]
[RequireComponent(typeof(AudioSource))]
[RequireComponent(typeof(CanvasGroup))]

public class Achievements : MonoBehaviour
{
    private CanvasGroup canvasGroup;
    private AudioSource audioSource;
    private SpriteRenderer spriteRenderer;
    
    private void Start()
    {
        canvasGroup = GetComponent<CanvasGroup>();
        audioSource = GetComponent<AudioSource>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        canvasGroup.alpha = 0;
        spriteRenderer.enabled = false;
    }
    
    private void OnEnable()
    {
        EatPellet.pelletEaten += ShowAchievement;
    }
    
    private void OnDisable()
    {
        EatPellet.pelletEaten -= ShowAchievement;
    }
    
    private void ShowAchievement()
    {
        canvasGroup.alpha = 1;
        spriteRenderer.enabled = true;
        audioSource.Play();
    }
}
