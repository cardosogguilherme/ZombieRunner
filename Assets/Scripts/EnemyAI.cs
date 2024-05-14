using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{
    [SerializeField] Transform target;
    [SerializeField] float chaseRange = 5f;

    NavMeshAgent navMeshAgent;
    float distanceToTarget = Mathf.Infinity;

    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
        Debug.Log($"navMeshAgent is: {navMeshAgent}");
    }

    void Update()
    {
        distanceToTarget = Vector3.Distance(target.position, transform.position);

        if (distanceToTarget <= chaseRange)
        {
            navMeshAgent.SetDestination(target.position);
        }
        else
        {
            navMeshAgent.SetDestination(transform.position);
        }
        Debug.Log($"destination is: {target.position}");
    }
}