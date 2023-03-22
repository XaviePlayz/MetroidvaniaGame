using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    public float hitPoints;
    public float maxHitPoints = 5;
    public HealthBarBehaviour Healthbar;

    void Start()
    {
        hitPoints = maxHitPoints;
        Healthbar.SetEnemyHealth(hitPoints, maxHitPoints);
    }

    public void TakeHit(float damage)
    {
        hitPoints -= damage;
        Healthbar.SetEnemyHealth(hitPoints, maxHitPoints);

        if (hitPoints <= 0)
        {
            Destroy(gameObject);
        }
    }

    public void Die()
    {
        Destroy(gameObject);
    }
}
