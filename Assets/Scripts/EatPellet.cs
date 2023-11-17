using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EatPellet : MonoBehaviour
{
    public static event Action pelletEaten;

    private void OnDisable()
    {
        pelletEaten?.Invoke();
    }
}
