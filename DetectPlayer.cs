using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectPlayer : MonoBehaviour
{
    EnemyStats statsController;
    VoidDemonAttack voidDemonAttack;

    void Start()
    {
        statsController = GetComponentInParent<EnemyStats>();
        voidDemonAttack = GetComponentInParent<VoidDemonAttack>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.name == "Player")
        {
            if (!statsController.animator.GetBool("Hurt"))
            {
                voidDemonAttack.prepAttack = true;
            }
            else
            {
                voidDemonAttack.prepAttack = false;
            } 

        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
       
        if (collision.name == "Player")
        {
            if (!statsController.animator.GetBool("Hurt"))
            {
                voidDemonAttack.prepAttack = true;
            }
            else
            {
                voidDemonAttack.prepAttack = false;
            }

        }
    }
    

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.name == "Player")
        {
            voidDemonAttack.prepAttack = false;
        }
    }
}
