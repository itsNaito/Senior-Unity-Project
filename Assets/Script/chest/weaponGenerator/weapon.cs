using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

[Serializable]//allows the class to be serializable
public class weapon//weapon class for creation of every weapon instance
{
    public string weaponName;//name of the weapon
    public string damageType;//what type of weapon(blunt, sharp, firearm, etc.)
    public int damageValue;//how much damage the weapon does
    public int weight;//drop chance of the weapon from a chest

    //constructor
    public weapon(string iWeaponName, string iDamageType, int iDamageValue, int iWeight)//constructor for setting the values of each weapon when created
    {
        this.weaponName = iWeaponName;//sets the name of the weapon
        this.damageType = iDamageType;//sets the dmg type of the weapon
        this.damageValue = iDamageValue;//set the dmg values for the weapon
        this.weight = iWeight;//sets the drop chance for the weapon
    }
}

