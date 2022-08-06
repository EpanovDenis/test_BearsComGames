using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    [SerializeField] private GameObject _trap;
    [SerializeField] private Transform[] targetsPoint;

    private NavMeshAgent agent;
    public Transform target;

    public static int pointForKill = 200;
    
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.updateRotation = false;
        agent.updateUpAxis = false;
    }
        
    void Update()
    {
        if (Vector2.Distance(transform.position, target.position) < 0.2f)
        {
            RandomTarget();
        }
        else
        {
            agent.SetDestination(target.position);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "PlayerBlue" || collision.gameObject.name == "PlayerRed")
        {
            Instantiate(_trap, collision.transform.position, Quaternion.identity);
            //GameOver
        }
    }

    private Transform RandomTarget()
    {
        target = targetsPoint[Random.Range(0, targetsPoint.Length)];        
        return target;
    }
}
