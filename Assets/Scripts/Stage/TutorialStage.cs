using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialStage : MonoBehaviour
{

    public GameObject spawnManger;

    private void Start()
    {
        spawnEnemy();
    }
    private void spawnEnemy()
    {
        spawnManger.SetActive(true);
    }
}
