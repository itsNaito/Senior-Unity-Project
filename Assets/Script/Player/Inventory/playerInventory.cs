using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
public class playerInventory : MonoBehaviour
{
    public List<string> inventoryName = new List<string>();//stores the items the player gains from chest
    public List<int> inventoryDmg = new List<int>();

    public void insertInventory(string weapon, int dmg)//adds the item to the player inventory
    {
        inventoryName.Add(weapon);//adds the name of the item to the inventory list
        inventoryDmg.Add(dmg);
    }
}

