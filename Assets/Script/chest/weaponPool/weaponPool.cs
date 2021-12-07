using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

[System.Serializable]//allows the class to be serializable
public class weaponPool//name of the class in charge of adding weapons to an organized list to be stored in a json file for later use
{
    public List<weapon> pool;//list that stores weapon objects created from the weapon class.

    //constructor
    public weaponPool()//constructor that declares the value of pool
    {
        pool = new List<weapon>();//pool declared as an object reference to the class List
    }

    public void newWeapon(string name, string type, int dmg, int weight)//function that takes the parameters needed to create a new weapon and makes one
    {
        weapon newWeapon = new weapon(name, type, dmg, weight);//creates a new weapon object using the passed in parameters
        pool.Add(newWeapon);//puts the object inside of a list to then be inserted into a json file
    }
}
