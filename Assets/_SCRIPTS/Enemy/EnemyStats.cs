using UnityEngine;

public class EnemyStats : MonoBehaviour
{
    [SerializeField]
    private EnemyType enemyType;

    private CharacterStats player;

    [SerializeField] private int damage;

    private void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.gameObject.CompareTag("Player"))
        {
            player = collisionInfo.gameObject.GetComponent<CharacterStats>();
            player.TakeDamage(damage);
            Debug.LogError("we hit Player");
        }
    }
    public EnemyType GetEnemyType()
    {
        return this.enemyType;
    }
   
}
