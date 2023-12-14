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

public class PacManGameManager : MonoBehaviour
{
    
    public GameObject PacMan;

    public float TimeBetweenSpawns = 0;

    public GameObject StartingNode;

    public GameObject[] Ghosts;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnGhosts());
    }

    public IEnumerator SpawnGhosts()
    {
        for(int i = 0; i < 4; i++)
        {
            yield return new WaitForSeconds(TimeBetweenSpawns);
            GameObject Ghost = Instantiate(Ghosts[i], StartingNode.transform);
            Ghost.GetComponent<EnemyNavigation>().PacManGameManager = this;
            Ghost.GetComponent<MovementController>().CurrentNode = StartingNode;
        }
    }
}
