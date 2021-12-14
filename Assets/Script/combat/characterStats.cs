using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterStats : MonoBehaviour
{
    public string unitName;
    public int damage;
    public int currentHealth;
    public int maxHealth;

    public bool takeDamage(int dmg)
    {
        currentHealth -= dmg;
        if(currentHealth <= 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
