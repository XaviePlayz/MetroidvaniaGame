using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackArea : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collider)
    {
        if (collider.gameObject.tag == "Skeleton")
        {
            Destroy(collider.gameObject);
        }
    }
}
