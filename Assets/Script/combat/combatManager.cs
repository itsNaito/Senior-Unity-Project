using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class combatManager : MonoBehaviour
{
    public GameObject player;
    public GameObject zombie;
    public GameObject playerHud;
    public bool playerTurn;
    public Text text; 
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
            playerHud.SetActive(true);
        }
    }
}
