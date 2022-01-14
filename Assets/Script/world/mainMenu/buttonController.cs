using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
/*Script used to manage all the buttons on the main menu
All the functions are the same names as the buttons
Currently only the tutorial button has an event that takes the player to the tutorial level that is currently being developed
*/
public class buttonController : MonoBehaviour
{
    public void play()//play function that is attached to button no actions yet
    {
        SceneManager.LoadScene("tutorial");
    }
    public void settings()//settings function that is attached to button no actions yet
    {

    }
    public void quit()
    {
        Application.Quit();
    }
}
