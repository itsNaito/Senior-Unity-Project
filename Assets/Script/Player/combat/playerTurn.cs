using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerTurn : MonoBehaviour
{
    public bool myTurn;
    // Start is called before the first frame update
    void Start()
    {
        playerBattle player = new playerBattle(10,5);
    }
    public void playerAction()
    {
        while(myTurn)
        {
            Debug.Log("it worked");
        }
    }
}
