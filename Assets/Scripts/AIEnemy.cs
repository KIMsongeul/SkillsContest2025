using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AIEnemy : MonoBehaviour
{
    public Transform player;
    private float detectionRange = 8f;
    private float attackRange = 3f;


    private NavMeshAgent nav;

    private void Start()
    {
        nav = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        float distancePlayer = Vector3.Distance(player.position, transform.position);
        if (distancePlayer < attackRange)
        {
            Debug.Log("Attack Player");
        }
        else if (distancePlayer < detectionRange)
        {
            nav.SetDestination(player.position);
            Debug.Log("Following Player");
        }
    }
}
