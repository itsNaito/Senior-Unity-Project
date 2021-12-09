using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class combatInteraction : MonoBehaviour
{
    public GameObject attack;
    public GameObject hit;
    public GameObject player;
    public GameObject zombie;
    private Text console;
    private battleStats playerStats = new battleStats(10,5);
    public void attacking()
    {
        attack.SetActive(false);
        hit.SetActive(true);
    }
    public void dealtDmg()
    {
        console = gameObject.GetComponent<combatManager>().text;
        zombie.GetComponent<zombieTurn>().dmgTaken(playerStats.dmg);
        console.text = "You dealt "+ playerStats.dmg + " damage!!";
        gameObject.GetComponent<combatManager>().playerTurn = false;
        gameObject.GetComponent<combatManager>().zombieAttack();
    }
    public void playerDmgTaken(int dmg)
    {
        playerStats.health -= dmg;
        playerStats.isDead();
        console.text = "The zombie has dealt " + dmg + " damage!";
        if(playerStats.health > 0)
        {
            gameObject.GetComponent<combatManager>().playerTurn = true;
            
        }
        else
        {
            Destroy(player);
        }
    }
}
