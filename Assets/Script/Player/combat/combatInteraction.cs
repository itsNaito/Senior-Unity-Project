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
    }
}
