using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraInstance : MonoBehaviour
{
    private static GameObject newCameraInstance;
    void Awake()
    {
        if(newCameraInstance == null)
        {
            newCameraInstance = gameObject;
        }
        else
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);
    }
}
