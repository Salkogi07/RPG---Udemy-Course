using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Endding : MonoBehaviour
{
    private MainBack mainBack;

    public GameObject dark;
    public GameObject button;
    public GameObject text;

    private void Start()
    {
        mainBack = GetComponentInParent<MainBack>();
    }
    void Update()
    {
        if (!mainBack.isNextStage && Input.GetKeyDown(KeyCode.V))
        {
            mainBack.isNextStage = true;
            dark.SetActive(true);
            button.SetActive(true);
            text.SetActive(true);
        }
    }
}
