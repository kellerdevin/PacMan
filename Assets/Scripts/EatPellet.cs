using System;
using UnityEngine;

public class EatPellet : MonoBehaviour
{
    public static event Action pelletEaten;

    private void OnDisable()
    {
        pelletEaten?.Invoke();
    }
}
