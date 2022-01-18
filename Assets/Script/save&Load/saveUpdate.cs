using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class saveUpdate : MonoBehaviour 
{
    public GameObject saveSys;
    void Start()
    {
        saveSys.GetComponent<saveSystem>().updateObjects();
    }
}
