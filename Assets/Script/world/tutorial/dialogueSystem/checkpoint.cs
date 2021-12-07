using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class checkpoint : MonoBehaviour
{
    //set of variables used
    public Transform player;
    public Canvas canvas;
    public Text dialogue;
    public string dialogueOutput;
    // Start is called before the first frame update
    void Start()
    {
        Canvas render = canvas.GetComponent<Canvas>();//gets the canvas component off the canvas gameObject
        render.enabled = false;//sets the renderer to false
    }

    // Update is called once per frame
    void Update()
    {
        if(player.position == transform.position && !Input.GetKeyDown(KeyCode.E))//checks if the player is standing on the same tile as the checkpoint flag
        {
            Canvas render = canvas.GetComponent<Canvas>();//gets the canvas component off the canvas
            render.enabled = true;//sets the renderer to true
            dialogue.text = dialogueOutput;//outs the dialogue for the text. The dialogue is written publicly for easy changes
        }
        if(player.position == transform.position && Input.GetKeyDown(KeyCode.E))//checks if the player is still on the flag and has pressed E
        {
            gameObject.SetActive(false);//turns the flag gameObject off
        }
    }
}
