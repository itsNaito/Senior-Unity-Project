using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class instance : MonoBehaviour
{
    private static GameObject newInstance;
    void Awake()
    {
        if(newInstance == null)
        {
            newInstance = gameObject;
        }
        else
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);
    }
}
