using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextStage : MonoBehaviour
{
    public GameObject targetObj;

    public GameObject toObj;

    public GameObject interaction;
    public StageManager stageManager;

    bool isNextStage = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            interaction.SetActive(true);
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (!isNextStage && Input.GetKeyDown(KeyCode.F))
            {
                isNextStage = true;
                stageManager.StartCoroutine("TeleportRoutine");
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            interaction.SetActive(false);
            isNextStage = false;
        }
    }
}
