using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class chest : MonoBehaviour
{
    // 4 instance of the weapon pool class and one instance of the drop class
    public weaponPool firearms = new weaponPool();
    public weaponPool melee = new weaponPool();
    public weaponPool goku = new weaponPool();
    public weaponPool consumable = new weaponPool();

    void Start()//runs at the start of the project
    {
        //firearms weapons that are created
        firearms.newWeapon("Makorov","firearm",3, 40);
        firearms.newWeapon("M1911", "firearm", 4, 30);
        firearms.newWeapon("Remmington","firearm",8,20);
        firearms.newWeapon("Hunting Rifle","firearm",10,10);

        //melee weapons that are created
        melee.newWeapon("Bat", "melee", 8,25);
        melee.newWeapon("Crowbar", "melee", 7,20);
        melee.newWeapon("Knife", "melee", 5,18);
        melee.newWeapon("Cleaver", "melee", 6,15);
        melee.newWeapon("Axe", "melee", 9,12);
        melee.newWeapon("Katana", "melee", 12,10);

        //goku weapons that are created
        goku.newWeapon("Bat", "goku", 20, 50);
        goku.newWeapon("makorov", "goku", 20, 22);
        goku.newWeapon("Goku Bat", "goku", 20, 10);
        goku.newWeapon("Vegeta Pistol", "goku", 20, 6);
        goku.newWeapon("Vegeta Bat", "goku", 20, 5);
        goku.newWeapon("Goku Pistol", "goku", 20,4);
        goku.newWeapon("Piccolo Bat", "goku", 20, 3);

        //consumable items that are created
        consumable.newWeapon("sushi", "consumable", 15, 50);
        consumable.newWeapon("pizza", "consumable", 10, 30);
        consumable.newWeapon("ramen", "consumable", 20, 15);
        consumable.newWeapon("steak", "consumable", 25, 5);

        //writes a json file for each set of weapons to be stored inside
        File.WriteAllText(Path.Combine(Application.streamingAssetsPath, "firearms.json"), JsonUtility.ToJson(firearms));
        File.WriteAllText(Path.Combine(Application.streamingAssetsPath, "melee.json"), JsonUtility.ToJson(melee));
        File.WriteAllText(Path.Combine(Application.streamingAssetsPath, "goku.json"), JsonUtility.ToJson(goku));
        File.WriteAllText(Path.Combine(Application.streamingAssetsPath, "consumable.json"), JsonUtility.ToJson(consumable));
    }
}
