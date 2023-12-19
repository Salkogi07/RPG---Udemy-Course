using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainBack : MonoBehaviour
{
    public GameObject interaction;

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
                SceneManager.LoadScene("MainMenu");
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
