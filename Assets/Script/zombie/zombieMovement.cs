using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zombieMovement : MonoBehaviour
{
    private int randomTime;
    private int randomPos;
    public List<GameObject> movePoints = new List<GameObject>();
    // Start is called before the first frame update
    void Start()
    {
        randomTime = Random.Range(1,5);
        randomPos = Random.Range(0,3);
        StartCoroutine(move());
    }
    IEnumerator move()
    {
        yield return new WaitForSeconds(randomTime);
        transform.position = movePoints[randomPos].transform.position;
        randomTime = Random.Range(1,5);
        randomPos = Random.Range(0,3);
        StartCoroutine(move());
    }
}
