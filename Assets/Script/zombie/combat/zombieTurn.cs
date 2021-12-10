using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//script attached to an object
public class zombieTurn : MonoBehaviour
{
    zombie zombie = new zombie(10,5);//object based off the zombie class
    private bool dead;
    // Start is called before the first frame update
    public int dmgTaken(int dmg)//dmgTaken function reduces the health off the zombie object
    {
        zombie.health -= dmg;
        dead = zombie.isDead();
        if(dead)
        {
            Destroy(gameObject);
        }
        return zombie.health;
    }
    public int attack()
    {
        return zombie.dmg;
    }
}
