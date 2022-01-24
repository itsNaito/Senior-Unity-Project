using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Linq;
public class saveSystem : MonoBehaviour 
{
    private static saveSystem saveInstance;
    public GameObject player;

    public GameObject zombie;

    public GameObject chests;

    public GameObject zombies;
    public Transform playerPos;

    public GameObject camera;

    //public GameObject checkpoints;

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
    void Update()
    {
        /*if(SceneManager.GetActiveScene().name == "Combat")
        {
            player.SetActive(false);
            zombies.SetActive(false);
            chests.SetActive(false);
            camera.SetActive(false);
        }
        if(SceneManager.GetActiveScene().name != "Combat")
        {
            player.SetActive(true);
            zombies.SetActive(true);
            chests.SetActive(true);
            camera.SetActive(true);
        }*/
    }
    public void enterCombat()
    {
        player.SetActive(false);
        zombies.SetActive(false);
        chests.SetActive(false);
        camera.SetActive(false);
    }
    public void exitCombat()
    {
        player.SetActive(true);
        zombies.SetActive(true);
        chests.SetActive(true);
        camera.SetActive(true);
    }

    public void updateObjects()
    {
        player = GameObject.FindWithTag("Player");
        zombies = GameObject.FindGameObjectWithTag("zombie");
        chests = GameObject.FindGameObjectWithTag("chest");
        camera = GameObject.FindGameObjectWithTag("MainCamera");
        //checkpoints = GameObject.FindGameObjectWithTag("checkpoint");
        DontDestroyOnLoad(player);
        DontDestroyOnLoad(zombies);
        DontDestroyOnLoad(chests);
        DontDestroyOnLoad(camera);
        //DontDestroyOnLoad(checkpoints);
    }
    public void battleWinner(battleState battleState)
    {
        if(battleState == battleState.won)
        {
            Destroy(zombie);
            Debug.Log("Worked");
        }
        if(battleState == battleState.lost)
        {
            Debug.Log("Game Over");
            Debug.Log("Lost worked");
        }
    }
}
