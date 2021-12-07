using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using System.IO;

public class drop//manages the item drops 
{
    //set of variables used
    public int random;
    public string file;
    public List<int> rates;
    public List<string> weaponName;

    //constructor
    public drop()
    {
        random = 0;
        rates = new List<int>();
        weaponName = new List<string>(); 
    }
    public void randomValue()//generates a random value
    {
        random = UnityEngine.Random.Range(0, 100);//random value used to pick an item to be dropped from a chest
    }
    public string dropped(string fileName, int jsonSize)//runs the random value through to find an item for the chest to drop. The function requires the file to search and the size of the file list 
    {
        file = File.ReadAllText(Path.Combine(Application.streamingAssetsPath, fileName));//reads the file that is gonna be used
        for (int i = 0; i < jsonSize; i++)//first for loop that adds the weights and names of the item to two list that are matched with eachother
        {
            rates.Add(JsonUtility.FromJson<weaponPool>(file).pool[i].weight);//adds each item's weight
            weaponName.Add(JsonUtility.FromJson<weaponPool>(file).pool[i].weaponName);//adds each item's name
        }
        for(int j = 0; j < jsonSize; j++)//second for loop that runs the random number through each item's weight until boolean operation is true
        {
            if (random <= rates[j])//checks if the random value is less than or equal to the weight of the item
            {
                return weaponName[j];//returns the item if the operation is true back to the chestController script
            }
            else//else statement for when the operation returns false
            {
                random -= rates[j];//subtracts the weight of the item matched from random
            }
            //Doing this reduces the number before have the loop check another item in the list
        }
        return null;//returns null just incase something breaks
    }
}

