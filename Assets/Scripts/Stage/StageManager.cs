using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StageManager : MonoBehaviour
{
    public GameObject targetObj;

    public GameObject[] toObj;
    public GameObject[] spawnManger;

    public int mapNum;

    private void Start()
    {
        spawnEnemy();
    }
    private void spawnEnemy()
    {
        spawnManger[mapNum].SetActive(true);
    }


    IEnumerator TeleportRoutine()
    {
        yield return null;

        yield return new WaitForSeconds(.2f);

        targetObj.transform.position = toObj[mapNum].transform.position;
        mapNum++;
        spawnEnemy();

        yield return new WaitForSeconds(.2f);
    }
}
