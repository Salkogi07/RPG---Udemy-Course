using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SearchEnemy : MonoBehaviour
{
    public int enemyCount = 0;

    public GameObject[] nextDoor;
    StageManager stageManager;

    private void Awake()
    {
        stageManager = GetComponent<StageManager>();
    }
    void Update()
    {
        GameObject[] enemies;
        enemies = GameObject.FindGameObjectsWithTag("Enemy");
        enemyCount = enemies.Length;
        NextLevelDoor();
    }

    void NextLevelDoor()
    {
        if (stageManager.mapNum + 1 <= nextDoor.Length)
        {
            if (enemyCount == 0)
            {
                nextDoor[stageManager.mapNum].SetActive(true);
            }
            else
            {
                nextDoor[stageManager.mapNum].SetActive(false);
            }
        }
    }
}
