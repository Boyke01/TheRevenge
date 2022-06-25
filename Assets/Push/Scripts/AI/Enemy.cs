using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int HP = 100;
    public Animator anim;
    public static bool death;

    void Start()
    {
        death = false;
    }

    public void TakeDamage(int damageAmount)
    {
        HP -= damageAmount;
        if(HP <= 0)
        {
            anim.SetTrigger("die");
            death = true;
        }
    }
}
