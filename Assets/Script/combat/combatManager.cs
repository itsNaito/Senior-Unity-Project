using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class combatManager : MonoBehaviour
{
    int starting;
    //public GameObject player;
    //public GameObject enemy;
    // Start is called before the first frame update
    void Start()
    {
        System.Random rand = new System.Random();
        starting = rand.Next(0, 2);
        Debug.Log(starting);
        if(starting == 0)
        {
            Debug.Log("Player First");
        }
        if(starting == 1)
        {
            Debug.Log("Enemy First");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
