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
    public GameObject idk;

    Rigidbody rb;
    NavMeshAgent agent;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        agent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        var distance = Vector3.Distance(transform.position, target.position);
        if (distance<10)
        {
            agent.speed = speed;
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

        if (distance < 1)
        {
            idk.SetActive(true);
        }
    }
}
