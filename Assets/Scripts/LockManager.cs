using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockManager : MonoBehaviour
{
    public GameObject[] LockObj;

    public int LockNum;

    private void Start()
    {
        UnLock();
    }
    private void UnLock()
    {
        LockObj[LockNum].SetActive(false);
    }
}
