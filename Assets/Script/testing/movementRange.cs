using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movementRange : MonoBehaviour
{
    public GameObject player;
    //public GameObject TileController;
    
    public int tileNum;
    private newMovement movement;
    private adjustment adjust;
    void Start()
    {
        movement = player.GetComponent<newMovement>();
        //adjust = TileController.GetComponent<adjustment>();
    }
    void OnMouseOver()
    {
        //If your mouse hovers over the GameObject with the script attached, output this message
        Debug.Log("Mouse is over GameObject.");
        if(Input.GetMouseButtonDown(0))
        {
            movement.MouseOnTile(tileNum);
        }
    }

    void OnMouseExit()
    {
        //The mouse is no longer hovering over the GameObject so output this message each frame
        Debug.Log("Mouse is no longer on GameObject.");
    }
}
