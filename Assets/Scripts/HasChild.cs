using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HasChild : MonoBehaviour
{
    public GameObject ChildObject;

    public bool bSpawnsChild;
    
    // Start is called before the first frame update
    void Start()
    {
        if (bSpawnsChild)
        {
            Instantiate(ChildObject, transform);
        }
    }
}