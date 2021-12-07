using System.Collections;
using System.Collections.Generic;
using UnityEngine;
class playerBattle
{
    int health;
    int dmg;
    public playerBattle(int health, int dmg)
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
