using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    private float timeBtwAttack;
    public float startTimeBtAttack;

    public Transform attackPos;
    public float attackRange;
    public LayerMask whatIsEnemy;
    public int damage;

    void Update()
    {
        if(timeBtwAttack <= 0)
        {
            if (Input.GetKey(KeyCode.Space) || Input.GetKey(KeyCode.Joystick1Button2))
            {
                Collider2D[] enemiesToDamage = Physics2D.OverlapCircleAll(attackPos.position,attackRange, whatIsEnemy );
                for (int i = 0; i < enemiesToDamage.Length; i++)
                {
                    enemiesToDamage[i].GetComponent<Enemy>().TakeDamage(damage);
                }
            }
            timeBtwAttack = startTimeBtAttack;
        }
        else
        {
            timeBtwAttack -= Time.deltaTime;
        }
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(attackPos.position, attackRange);
    }
}
