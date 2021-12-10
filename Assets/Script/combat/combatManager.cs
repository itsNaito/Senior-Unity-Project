using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class combatManager : MonoBehaviour
{
    public GameObject player;
    public GameObject zombie;
    public GameObject Menus;
    public GameObject options;
    public bool playerTurn;
    public Text text;
    private int zomDmg;
    // Start is called before the first frame update
    void Start()
    {
        text.text = "The player goes first!";
        playerTurn = true;
    }
    void Update()
    {
        activeUI();
    }
    void activeUI()
    {
        if(playerTurn)
        {
            Menus.SetActive(true);
            options.SetActive(true);
            //need to set it so the attack button appears everytime the player turn is reset
            //also need to add delay to the actions from the zombie just a second or two to slow down
            //the rate of action in combat
            //need to be able to access player weapon data to grab the damage of the weapon the player is using
        }
        else
        {
            Menus.SetActive(false);
            options.SetActive(false);
        }
    }
    public void zombieAttack()
    {
        zomDmg = zombie.GetComponent<zombieTurn>().attack();
        gameObject.GetComponent<combatInteraction>().playerDmgTaken(zomDmg);
    }
}
