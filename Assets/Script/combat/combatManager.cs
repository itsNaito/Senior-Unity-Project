using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class combatManager : MonoBehaviour
{
    public GameObject player;
    public GameObject zombie;
    public Canvas canvas;
    public Text text; 
    // Start is called before the first frame update
    void Start()
    {
        text.text = "The player goes first!";
        player.GetComponent<playerTurn>().myTurn = true;
    }
}
