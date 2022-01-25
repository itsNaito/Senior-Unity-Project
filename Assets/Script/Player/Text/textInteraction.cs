using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class textInteraction : MonoBehaviour
{
    //set of variables
    public GameObject canvas;
    public bool interaction;
    public bool noInput;
    //public Canvas canvas;
    // Update is called once per frame
    void Update()
    {
        if(SceneManager.GetActiveScene().name == "Tutorial")
        {
            canvas = GameObject.Find("Canvas");
            Canvas render = canvas.GetComponent<Canvas>();//gets the canvas component off the canvas
            if (render.enabled == true)//checks to see if the canvas gameObject is being rendered
            {
                gameObject.GetComponent<movement>().interaction = true;//sets noInput to true stopping the player from moving
            }
            if (render.enabled == true && Input.GetKeyDown(KeyCode.E))//checks to see if the canvas is enabled and the E key has been pressed
            {
                gameObject.GetComponent<movement>().interaction = false;//sets noInput to false allowing the player to move
                render.enabled = false;//turns the renderer off now that the player can move
            }
        }
    }
}
