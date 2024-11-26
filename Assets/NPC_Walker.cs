using UnityEngine;
using UnityEngine.AI;

public class NPC_Walker : MonoBehaviour
{
    public NavMeshAgent agent;
    public Transform target; // Target to follow
    public Animator animator;

    public Animator Animator 
    {
        get 
        {
            if(animator == null)
            {
                animator = GetComponent<Animator>();
            }

            return animator;
        }
    }

    private void Start()
    {
        agent.destination = target.position;
    }

    private void Update()
    {
        if (Vector3.Distance(transform.position, target.position) > 6f)
        {
            agent.destination = target.position;
        }

        Animator.SetBool("walk", agent.velocity.magnitude > 0.1f);
    }
}
