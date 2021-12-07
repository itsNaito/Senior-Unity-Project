using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class detector : MonoBehaviour
{
    //set of variables used
    public bool inRange;
    public GameObject player;
    private string weaponName;
    void Update()//runs at the start of every frame
    {
        playerInRange();//call the playerInRange function
    }
    void playerInRange()//function that checks when the player is close to the chest
    {
        if(inRange)//checks to see if the boolean is true
        {
            if(Input.GetKeyDown(KeyCode.E))//waits for an input press on the E key which means that the player is interacting with the chest
            {
                player.GetComponent<playerInventory>().insertInventory(gameObject.GetComponent<chestController>().weaponName);//gets the player inventory component and sends the weaponName of the item pulled 
                Destroy(gameObject);//destroys the chest object
            }
        }
    }
    void OnTriggerEnter2D(Collider2D other)//checks to see when something has entered the trigger around the chest
    {
        if(other.gameObject.CompareTag("Player"))//checks to see if the object in the trigger is the player
        {
            inRange = true;//sets the inRange boolean to true
        }
    }
        void OnTriggerExit2D(Collider2D other)//checks when the object has walked out of the trigger
    {
        if(other.gameObject.CompareTag("Player"))//checks to see if the object leaving the trigger is the player
        {
            inRange = false;//sets the inRange boolean to false
        }
    }
}
