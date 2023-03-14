using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerDeath : MonoBehaviour
{

    private GameObject player;
    void Start()
    {
        player = GameObject.FindWithTag("Player");
    }


    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            player.transform.position = new Vector2(-15.71f, -5.31f);
        }

        if (collision.gameObject.tag == "Skeleton")
        {
            var enemy = collision.collider.GetComponent<EnemyBehaviour>();
            if (enemy)
            {
                enemy.Die();
            }
        }
    }
}
