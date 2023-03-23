using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class EnemyMovement : MonoBehaviour
{

    public Transform target;
    public float speed = 3f;


    void Start()
    {

    }

    void Update()
    {
        if (Vector3.Distance(transform.position, target.position) > 2f)
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        }
        if (Vector3.Distance(transform.position, target.position) == 2.5f)
        {
            target.GetComponent<PlayerHealth>().UpdateHealth(10f);
        }
        if (transform.position.x < target.position.x)
        {
            transform.localScale = new Vector3(-7, 7, 1);
        }
        else
        {
            transform.localScale = new Vector3(7, 7, 1);
        }
    }
}
