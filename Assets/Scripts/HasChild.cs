/*
 1. IDENTIFYING INFORMATION
a. Devin Keller, Kentaro Matsui, Tad Kitagushi, Miles Rovenger
b. Student ID: 2368610, 2366951, 2403661, 2343785
c. dkeller@chapman.edu, matsuo@chapman.edu, tkitaguchi@chapman.edu, rovenger@chapman.edu
d. CPSC-245
e. Final Project: PacMan
*/

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