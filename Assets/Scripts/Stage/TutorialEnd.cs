using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TutorialEnd : MonoBehaviour
{
    private MainBack mainBack;

    void Start()
    {
        mainBack = GetComponentInParent<MainBack>();
    }

    void Update()
    {
        if (!mainBack.isNextStage && Input.GetKeyDown(KeyCode.V))
        {
            mainBack.isNextStage = true;
            SceneManager.LoadScene("MainMenu");
        }
    }
}
