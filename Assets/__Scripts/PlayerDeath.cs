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
            var playerhealth = collision.collider.GetComponent<PlayerHealth>();
            if (playerhealth)
            {
                playerhealth.UpdateHealth(50);
            }
        }
    }
}
