using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : CharacterStats
{
    PlayerUI playerUI;
 

    void Start()
    {
        playerUI = GetComponent<PlayerUI>();

        maxHealth = 100;
        currHealth = maxHealth;

        maxStamina = 100;
        currStamina = maxStamina;

        SetStats();
    }

    public override void Die ()
    {
        Debug.Log("You Died");
  
    }
    void SetStats()
    {
        playerUI.healthAmount.text = currHealth.ToString();
        playerUI.staminaAmount.text = currStamina.ToString();
    }
    public override void CheckHealth()
    {
        base.CheckHealth();
        SetStats();
    }

    public override void CheckStamina()
    {
        base.CheckStamina();
        SetStats();
    }

}
