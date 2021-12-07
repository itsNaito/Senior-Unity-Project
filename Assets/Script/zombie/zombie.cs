using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class zombie
{
    int health;
    int dmg;

    public zombie(int health, int dmg)
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
        return false;
    }
}
