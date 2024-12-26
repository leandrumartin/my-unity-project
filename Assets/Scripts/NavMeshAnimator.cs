using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavMeshAnimator : MonoBehaviour
{
    private Animator animator;
    private NavMeshAgent agent;
    
    void Awake()
    {
        animator = GetComponent<Animator>();
        agent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        animator.SetFloat("Velocity", agent.velocity.magnitude);
    }
}
