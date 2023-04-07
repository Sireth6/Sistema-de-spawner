﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterStats : MonoBehaviour
{
    public int currHealth;
    public int maxHealth;

    public int currStamina;
    public int maxStamina;

    public bool isDead = false;

    public void CheckHealth()
    {
        if (currHealth >= maxHealth)
        {
            currHealth = maxHealth;
        }
        if (currHealth <= 0)
        {
            currHealth = 0;
            isDead = true;
        }
    }
    public void CheckStamina()
    {
        if(currStamina >= maxStamina)
        {
            currStamina = maxStamina;
        }
        if(currStamina <= 0)
        {
            currStamina = 0;
        }
    }
    public virtual void Die()
    {

    }
}
