using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class saveUpdate : MonoBehaviour 
{
    public GameObject saveSys;
    void Awake()
    {
        saveSys.GetComponent<saveSystem>().updateObjects();
    }
}
