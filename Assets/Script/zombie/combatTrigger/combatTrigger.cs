using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
/*Current combat trigger system
When the player acts the trigger event the combat scene is loaded
This is the final part of the tutorial that needs to be built then the main game can be developed
*/
public class combatTrigger : MonoBehaviour
{
    public GameObject player;
    public GameObject inventory;
    public GameObject saveSys;
    void OnTriggerEnter2D(Collider2D other)//checks for the triggerEnter event
    {
        if(other.gameObject.CompareTag("Player"))//checks to see if the object is the Player
        {
            saveSys.GetComponent<saveSystem>().zombie = gameObject;
            saveSys.GetComponent<saveSystem>().enterCombat();
            inventory.GetComponent<playerInventory>().enterCombat();
            SceneManager.LoadScene("Combat");//loads the combat scene
        }
    }
}
