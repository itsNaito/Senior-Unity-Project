using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Zombie class that is attached to zombie entity
//currently contains stats like health and damage
//want to include some functions inside of the class after I clean up the combat system
class zombie
{
    public int health;
    public int dmg;

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
        else
        {
           return false; 
        }
    }
}
