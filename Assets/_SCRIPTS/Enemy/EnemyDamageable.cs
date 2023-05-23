
using UnityEngine;
using static EnemyStats;

public class EnemyDamageable : MonoBehaviour
{
    private EnemyStats enemySts;

    private void Start()
    {
        enemySts = GetComponent<EnemyStats>();
    }
    private void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("Kill enemy with ball");
            EnemyStats kill = collisionInfo.gameObject.GetComponent<EnemyStats>();
            EnemyType enemyType = kill.GetEnemyType();
            Debug.Log("Kill enemy type " + enemyType);
            GameController.NbrTypeEnemy(enemyType);
            Destroy(collisionInfo.transform.parent.gameObject);
        }
    }
}
