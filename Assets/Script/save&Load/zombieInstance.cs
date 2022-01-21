using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zombieInstance : MonoBehaviour
{
    private static GameObject newZombieInstance;
    void Awake()
    {
        if(newZombieInstance == null)
        {
            newZombieInstance = gameObject;
        }
        else
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);
    }
}
