using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Next : MonoBehaviour
{
    private NextStage nextStage;

    public StageManager stageManager;

    void Start()
    {
        nextStage = GetComponentInParent<NextStage>();
    }

    void Update()
    {
        if (!nextStage.isNextStage && Input.GetKeyDown(KeyCode.V))
        {
            nextStage.isNextStage = true;
            stageManager.StartCoroutine("TeleportRoutine");
        }
    }
}
