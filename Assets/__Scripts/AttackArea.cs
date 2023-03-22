using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackArea : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Skeleton")
        {
            var enemy = collision.collider.GetComponent<EnemyBehaviour>();
            if (enemy)
            {
                enemy.TakeHit(1);
            }
        }
    }
}
