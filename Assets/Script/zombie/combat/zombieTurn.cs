using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zombieTurn : MonoBehaviour
{
    zombie zombie = new zombie(10,5);
    private bool dead;
    // Start is called before the first frame update
    public void dmgTaken(int dmg)
    {
        zombie.health -= dmg;
        dead = zombie.isDead();
        if(dead)
        {
            Destroy(gameObject);
        }
    }
    public int attack()
    {
        return zombie.dmg;
    }
}
