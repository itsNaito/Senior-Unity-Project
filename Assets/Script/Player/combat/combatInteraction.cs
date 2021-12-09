using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class combatInteraction : MonoBehaviour
{
    public GameObject attack;
    public GameObject hit;

    public void attacking()
    {
        attack.SetActive(false);
        hit.SetActive(true);
    }
    public void hit()
    {
        
    }
}
