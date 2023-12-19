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

        bool enemyFound = false; // 적이 발견되었는지 여부를 나타내는 변수

        foreach (Collider2D collider in collider2Ds)
        {
            if (collider.CompareTag("Enemy"))
            {
                enemyFound = true;
                break; // 적을 찾았으면 루프 종료
            }
        }

        if (enemyFound)
        {
            gameObject.SetActive(true);
        }
        else
        {
            gameObject.SetActive(false); // 적이 없으면 오브젝트 비활성화
            playerManager.currency += 300;
        }

    }

    private void OnDrawGizmos() //범위 표시
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawWireCube(searchPos.position, searchbox);
    }
}
