using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chestInstance : MonoBehaviour
{
    private static GameObject newChestInstance;
    void Awake()
    {
        if(newChestInstance == null)
        {
            newChestInstance = gameObject;
        }
        else
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);
    }
}
