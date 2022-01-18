using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Linq;
public class saveSystem : MonoBehaviour 
{
    //move the tag system to the saveupdate script which will send it to the saveSystem script everytime a scene is loaded
    //when zombie loses in combat will get transferred to a dead objects scripts that will get destroyed everytime the player is loading that scene
    //when the player moves to the next level it will empty all list 
    private static saveSystem saveInstance;
    public GameObject player;
    public Transform playerPos;
    public List<GameObject> zombies = new List<GameObject>();
    public List<GameObject> chests = new List<GameObject>();

    private string combatEnd;
    void Awake()
    {
        if(saveInstance == null)
        {
            DontDestroyOnLoad(this); 
            saveInstance = this; 
        }
        else
        {
            Destroy(gameObject);
        }
    }
    void LateUpdate()
    {
        if(SceneManager.GetActiveScene().name != "Combat")
        {
            playerPos = player.GetComponent<Transform>();
        }
    }
    public void updateObjects()
    {
        player = GameObject.FindWithTag("Player");
        zombies = GameObject.FindGameObjectsWithTag("zombie").ToList();
        chests = GameObject.FindGameObjectsWithTag("firearms").ToList();
        DontDestroyOnLoad(player);
        for(int i = 0; i < zombies.Count; i++)
        {
            DontDestroyOnLoad(zombies[i]);
        }
        for(int j = 0; j < chests.Count; j++)
        {
            DontDestroyOnLoad(chests[j]);
        }
    }
}
