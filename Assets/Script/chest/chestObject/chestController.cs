using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chestController : MonoBehaviour
{
    private drop drop = new drop();//instance of the drop object
    public string weaponName;//weaponName variable to store the name of the item pulled
    void Start()//Runs at the start of the game 
    {
        chest();//calls the chest function
    }
    void chest()//obtains the item that the chest will give to the player when opened
    {
        if(gameObject.tag == "consumable")//checks the tag of the chest
        {
            drop.randomValue();//creates a random value used for the dropped function
            weaponName = drop.dropped("consumable.json",4);//runs the dropped function giving the file name and list size
        }

        if(gameObject.tag == "firearms")//checks the tag of the chest
        {
            drop.randomValue();//creates a random value used for the dropped function
            weaponName = drop.dropped("firearms.json",4);//runs the dropped function giving the file name and list size
        }
        
        if(gameObject.tag == "melee")//checks the tag of the chest
        {
            drop.randomValue();//creates a random value used for the dropped function
            weaponName = drop.dropped("melee.json",6);//runs the dropped function giving the file name and list size
        }

        if(gameObject.tag == "goku")//checks the tag of the chest
        {
           drop.randomValue();//creates a random value used for the dropped function
           weaponName = drop.dropped("goku.json",7);//runs the dropped function giving the file name and list size
        }
    }
}
