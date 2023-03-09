using System;
using System.Collections;
using System.Collections.Generic;
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



    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (attackSpeed <= canAttack)
            {
                collision.gameObject.GetComponent<PlayerHealth>().UpdateHealth(-attackDamage);
                canAttack = 0;
            }
            else
            {
                canAttack += Time.deltaTime;
            }
        }
        StartCoroutine(WaitForSec());
    }
    private IEnumerator WaitForSec()
    {
        gameObject.GetComponent<EnemyMovement>().enabled = false;
        yield return new WaitForSeconds(2f);
        gameObject.GetComponent<EnemyMovement>().enabled = true;
    }
}
