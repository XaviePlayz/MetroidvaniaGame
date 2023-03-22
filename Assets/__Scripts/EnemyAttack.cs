using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEngine.EventSystems.EventTrigger;

public class EnemyAttack : MonoBehaviour
{
    [SerializeField]
    private float attackDamage = 10f;
    [SerializeField]
    private float attackSpeed;
    [SerializeField]
    private float canAttack;
    [SerializeField]
    private Animator anim;


    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (attackSpeed <= canAttack)
            {
                collision.gameObject.GetComponent<PlayerHealth>().UpdateHealth(attackDamage);
                canAttack = 0;
                StartCoroutine(WaitForSec());
            }
            else
            {
                canAttack += Time.deltaTime;
            }
        }
    }
    private IEnumerator WaitForSec()
    {
        anim.SetBool("Attack", true);
        gameObject.GetComponent<EnemyMovement>().speed = 0;
        yield return new WaitForSeconds(2f);
        gameObject.GetComponent<EnemyMovement>().speed = 3;
        anim.SetBool("Attack", false);
    }
}
