using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : IDamageable
{
    public int CurrentHealth
    {
        get;
        //The IDamageable interface only declares the getter for currentHealth,
        //so we can declare a private setter
        private set;
    }

    public void ApplyDamage(int damage)
    {
        //Enemy specific applydamage method implementation
        CurrentHealth -= damage;

        if(damage <= 0)
        {
            Die();
        }
    }

    //new members independent from the interface can be declared normally
    private void Die()
    {

    }
}
