using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AIEnemy : MonoBehaviour
{
    public Transform player;
    private float detectionRange = 10f;
    private float attackRange = 2.5f;
    private int damage = 10;

    private float lastAttackTime = 0;
    public float attackCoolTime = 2f;


    private NavMeshAgent nav;
    private HpSystem hpSystem;
    private HpSystem playerHpSystem;

    private void Start()
    {
        nav = GetComponent<NavMeshAgent>();
        hpSystem = GetComponent<HpSystem>();
        playerHpSystem = player.GetComponent<HpSystem>();
    }

    private void Update()
    {
        if (player == null)
        {
            return;
        }
        
        float distancePlayer = Vector3.Distance(player.position, transform.position);
        if (distancePlayer < attackRange)
        {
            nav.ResetPath();
            AttackPlayer();
        }
        else if (distancePlayer < detectionRange)
        {
            nav.SetDestination(player.position);
            Debug.Log("Following Player");
        }
    }

    public void AttackPlayer()
    {
        if (Time.time - lastAttackTime >= attackCoolTime)
        {
            Debug.Log("Attack Player");
            playerHpSystem.Damage(damage);
            lastAttackTime = Time.time;
        }
        
    }
}
