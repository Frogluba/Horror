using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    public float viewDistance;
    public Transform target;
    public float speed = 1;
    public float wanderDistance =10;
    public int wanderChance = 300;
    public Animator animator;
   

    Rigidbody rb;
    NavMeshAgent agent;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        agent = GetComponent<NavMeshAgent>();
        animator.Play("Idle");

    }

    private void Update()
    {
        if (target == null) return;
        

        var distance = Vector3.Distance(transform.position, target.position);
        if (distance<10)
        {
            animator.Play("Run");
            agent.destination = target.position;
        }
        else
        {
            if (Random.Range(0,100) ==1)
            {
                var offset = Random.insideUnitSphere * wanderDistance;
                agent.destination = transform.position + offset;
            }
        }
        if (agent.velocity==Vector3.zero)
        {
            animator.Play("Idle");
        }
        else
        {
            animator.Play("Run");
        }
    }
}
