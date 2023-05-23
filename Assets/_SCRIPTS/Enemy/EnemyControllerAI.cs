using UnityEngine;
using UnityEngine.AI;

public class EnemyControllerAI : MonoBehaviour
{
    public float lookRadius = 10f;
    [SerializeField] private Transform target;
    [SerializeField] private NavMeshAgent agent;

    void Start()
    {
        target = PlayerManager.Instance.player.transform;
        agent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        DistanceTarget();

    }
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, lookRadius);
    }
    
    private void FaceTarget()
    {
        Vector3 direction = (target.position - transform.position).normalized;
        Quaternion lookRotation = Quaternion.LookRotation(new Vector3(direction.x, 0, direction.z));
        transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime * 5f);//lookRotation
    }
    private void DistanceTarget()
    {
        float distance = Vector3.Distance(target.position, transform.position);

        if (distance < lookRadius)
        {
            agent.SetDestination(target.position);
            if (distance <= agent.stoppingDistance)
            {
                FaceTarget();
            }
        }
    }

}






