using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class playerInventory : MonoBehaviour
{
    private bool openinv;
    public Canvas invCanvas;
    public List<string> inventoryName = new List<string>();//stores the items the player gains from chest
    public List<int> inventoryDmg = new List<int>();
    public void insertInventory(string weapon, int dmg)//adds the item to the player inventory
    {
        inventoryName.Add(weapon);//adds the name of the item to the inventory list
        inventoryDmg.Add(dmg);
        universalInventory.newItem(weapon, dmg);
    }
    void Update()
    {
        openInventory();
    }
    void openInventory()
    {
        Canvas render = invCanvas.GetComponent<Canvas>();
        if(Input.GetKeyDown(KeyCode.I) && SceneManager.GetActiveScene().name != "Combat")
        {
            if(render.enabled == true)
            {
                render.enabled = false;
                gameObject.GetComponent<movement>().interaction = false;
            }
            else if(render.enabled == false)
            {
                render.enabled = true;
                gameObject.GetComponent<movement>().interaction = true;
            }
        }
    }
    public void enterCombat()
    {
        Canvas render = invCanvas.GetComponent<Canvas>();
        render.enabled = false;
    }
}

