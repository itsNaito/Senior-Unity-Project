using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public static class universalInventory
{
    public static List<string> weapons = new List<string>();
    public static List<int> damage = new List<int>();
    public static void newItem(string weaponName, int weaponDmg)
    {
        weapons.Add(weaponName);
        damage.Add(weaponDmg);
    }
}
