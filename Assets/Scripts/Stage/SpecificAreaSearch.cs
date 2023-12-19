using System.Collections;
using System.Collections.Generic;
using System.Net;
using UnityEngine;

public class SpecificAreaSearch : MonoBehaviour
{
    public Transform searchPos;
    public Vector2 searchbox;

    public PlayerManager playerManager;

    void Update()
    {
        Collider2D[] collider2Ds = Physics2D.OverlapBoxAll(searchPos.position, searchbox, 0);

        bool enemyFound = false; // ���� �߰ߵǾ����� ���θ� ��Ÿ���� ����

        foreach (Collider2D collider in collider2Ds)
        {
            if (collider.CompareTag("Enemy"))
            {
                enemyFound = true;
                break; // ���� ã������ ���� ����
            }
        }

        if (enemyFound)
        {
            gameObject.SetActive(true);
        }
        else
        {
            gameObject.SetActive(false); // ���� ������ ������Ʈ ��Ȱ��ȭ
            playerManager.currency += 300;
        }

    }

    private void OnDrawGizmos() //���� ǥ��
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawWireCube(searchPos.position, searchbox);
    }
}
