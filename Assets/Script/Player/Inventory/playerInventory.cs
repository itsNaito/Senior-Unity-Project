using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerInventory : MonoBehaviour
{
    public List<string> inventory = new List<string>();//stores the items the player gains from chest

    public void insertInventory(string itemName)//adds the item to the player inventory
    {
        inventory.Add(itemName);//adds the name of the item to the inventory list
        Debug.Log(itemName);
    }
}

