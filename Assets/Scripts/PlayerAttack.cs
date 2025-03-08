using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public int damage = 20;
    private float attackRange = 4f;
    public LayerMask enemyLayer;
    public Camera cam;
    private Ray ray;
    
    private float lastAttack = 0;
    private float attackCoolTime = 1f;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Attack();
        }
    }

    void Attack()
    {
        if (Time.time - lastAttack >= attackCoolTime)
        {
            //Debug.Log("Trying Attack");
            ray = cam.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));
            RaycastHit hit;

            if (Physics.Raycast(ray,out hit,attackRange,enemyLayer))
            {
                HpSystem enemyHp = hit.collider.GetComponent<HpSystem>();
                Debug.Log("Attack Enemy");
                enemyHp.Damage(damage);
            }
            lastAttack = Time.time;
        }
        
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position,attackRange);
    }
}
