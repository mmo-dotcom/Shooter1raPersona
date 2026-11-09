using UnityEngine;
using UnityEngine.AI;

public class EnemyNavigation : MonoBehaviour
{
    public NavMeshAgent agent;
    public Transform target;
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        target = GameObject.FindGameObjectWithTag("Player").transform;
        InvokeRepeating("UpdateTarget", 3f, 3f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void UpdateTarget()
    {
        agent.destination = target.position;
    }
}
