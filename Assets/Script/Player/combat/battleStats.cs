using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class battleStats
{
    public int health;
    public int dmg;
    public battleStats(int health, int dmg)
    {
        this.health = health;
        this.dmg = dmg;
    }
    public bool isDead()
    {
        if(health <= 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
