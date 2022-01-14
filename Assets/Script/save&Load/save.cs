using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class save
{
    public float[] playerPosititon;

    public save(movement player)
    {
        playerPosititon = new float[3];
        playerPosititon[0] = player.transform.position.x;
        playerPosititon[1] = player.transform.position.y;
        playerPosititon[2] = player.transform.position.z;
    }
}
