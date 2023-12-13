using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class EatReverseCollectable : MonoBehaviour
{
    public static event Action reverseCollectableCollected;

    private void OnDisable()
    {
        reverseCollectableCollected?.Invoke();
    }
}
