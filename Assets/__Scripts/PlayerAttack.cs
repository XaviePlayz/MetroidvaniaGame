using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public Animator anim;
    public GameObject attackArea;

    private bool Attacked = false;
    public float attackRate = 0.5F;
    private float nextAttack = 0.0F;


    void Start()
    {
        attackArea.SetActive(false);
    }

    void Update()
    {
        Attack();
    }

    private void Attack()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0) && Time.time > nextAttack)
        {
            nextAttack = Time.time + attackRate;
            Attacked = true;

            attackArea.SetActive(true);
            anim.SetBool("Attack", true);
        }
        else if (Input.GetKeyUp(KeyCode.Mouse0))
        {
            attackArea.SetActive(false);
        }
        else
        {
            anim.SetBool("Attack", false);
        }
    }
}
