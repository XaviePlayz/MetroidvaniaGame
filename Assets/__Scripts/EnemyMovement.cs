using System.Collections;
using System.Collections.Generic;
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
        transform.LookAt(target.position);
        transform.Rotate(new Vector3(0, -90, 0), Space.Self);


        if (Vector3.Distance(transform.position, target.position) > 2f)
        {
            transform.Translate(new Vector3(speed * Time.deltaTime, 0, 0));
        }

    }
}
