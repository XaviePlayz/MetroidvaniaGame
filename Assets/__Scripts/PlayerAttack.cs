using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public Animator anim;
    public GameObject attackArea;

    private bool Attacked = false;
    private int timeOutAttack = 0;


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
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Attacked = true;

            attackArea.SetActive(true);
            anim.SetBool("Attack", true);
            timeOutAttack = 1;
        }
        else if (Input.GetKeyUp(KeyCode.Mouse0))
        {
            attackArea.SetActive(false);
        }
        else if (timeOutAttack == 1)
        {
            anim.SetBool("Attack", false);
        }
    }
}
