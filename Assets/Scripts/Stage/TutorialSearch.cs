using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialSearch : MonoBehaviour
{
    public int enemyCount = 0;

    public GameObject nextDoor;
    TutorialStage tutorialStage;

    private void Awake()
    {
        tutorialStage = GetComponent<TutorialStage>();
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
            if (enemyCount == 0)
            {
                nextDoor.SetActive(true);
            }
            else
            {
                nextDoor.SetActive(false);
            }
    }
}
