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
