using System.Collections;
using System.Collections.Generic;
using UnityEngine.Tilemaps;
using UnityEngine;

/*Currently not happy with the organization of the script
Plans to rewrite a large code is in the works, but might not happen for a bit
The script has become cluttered so steps are being taken to adjust it
*/
public class movement : MonoBehaviour
{
    //set of variable used for the movement
    public Transform forward;
    public Transform back;
    public Tilemap tilemap;

    public List<GameObject> arrows = new List<GameObject>();
    // Update is called once per frame
    void Update()
    {
        gridMovement();//the movement function call that runs every frame
    }
    void gridMovement()//the movement function that houses all the data used for the movement of the player object
    {
        textInteraction interaction = gameObject.GetComponent<textInteraction>();//grabs the textInteraction script off the player gameObject
        Vector3 savePosF = new Vector3(forward.position.x, forward.position.y, 0);//stores the position of the front movePoint
        Vector3 savePosb = new Vector3(back.position.x, back.position.y, 0);//stores the position of the back movePoint

        if (interaction.noInput == false)//checks to see that dialogue isn't active
        {
            if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))//checks for input from D or right arrow
            {
                StartCoroutine(delay("D"));
                Vector3Int gridPos = tilemap.WorldToCell(new Vector3(transform.position.x, transform.position.y, 0));//gets the grid position from the world and converts it to the tilemap grid position
                if (gridPos.y > -17)//checks to see if the y value of the player is greater than the fartherest value the player can go to the right
                {
                    transform.position = new Vector3(forward.position.x + 0.5f, forward.position.y, 0);//moves the player's position
                    forward.position = new Vector3(savePosF.x + 0.5f, savePosF.y - 0.25f, 0);//moves the front movePoint 
                    back.position = new Vector3(savePosb.x + 0.5f, savePosb.y - 0.25f, 0);//moves the back movePoint
                }
            }
        }
        if(interaction.noInput == false)//checks to see that dialogue isn't active
        {
            if (Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow))//checks for input from D or down arrow
            {
                StartCoroutine(delay("S"));
                Vector3Int gridPos = tilemap.WorldToCell(new Vector3(transform.position.x, transform.position.y, 0));//gets the grid position from the world and converts it to the tilemap grid position
                if (gridPos.x > -3)//checks to see if the x value of the player is greater than the fartherest value the player can go down
                {
                    transform.position = new Vector3(forward.position.x - 0.5f, forward.position.y, 0);//moves the player position
                    forward.position = new Vector3(savePosF.x - 0.5f, savePosF.y - 0.25f, 0);//moves the front movePoint
                    back.position = new Vector3(savePosb.x - 0.5f, savePosb.y - 0.25f, 0);//moves the back Movepoint
                }
            }
        }
        if (interaction.noInput == false)//checks to see that dialogue isn't active
        {
            if(Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow))//checks for input from the W or up arrow
            {
                StartCoroutine(delay("W"));
                Vector3Int gridPos = tilemap.WorldToCell(new Vector3(transform.position.x, transform.position.y, 0));//gets the grid position from the world and converts it to the tilemap grid position
                if (gridPos.x < 7)//checks to see if the x value of the player is less than the highest value the player can go up
                {
                    transform.position = new Vector3(back.position.x + 0.5f, back.position.y, 0);//moves the player position
                    forward.position = new Vector3(savePosF.x + 0.5f, savePosF.y + 0.25f, 0);//moves the front movePoint
                    back.position = new Vector3(savePosb.x + 0.5f, savePosb.y + 0.25f, 0);//moves the back movePoint
                }
            }
        }
        if (interaction.noInput == false)//checks to see that dialogue isn't active
        {
            if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))//checks for input from the A or left arrow
            {
                StartCoroutine(delay("A"));
                Vector3Int gridPos = tilemap.WorldToCell(new Vector3(transform.position.x, transform.position.y, 0));//gets the grid position from the world and converts it to the tilemap grid position
                if (gridPos.y < 8)//checks to see if the y value of the player is less than the highest value the player can go to the left
                {
                    transform.position = new Vector3(back.position.x - 0.5f, back.position.y, 0);//moves the player position
                    forward.position = new Vector3(savePosF.x - 0.5f, savePosF.y + 0.25f, 0);//moves the front movePoint
                    back.position = new Vector3(savePosb.x - 0.5f, savePosb.y + 0.25f, 0);//moves the back movePoint
                }
            }
        }
    }
    IEnumerator delay(string keyPressed)
    {
        if(keyPressed == "W")
        {
            arrows[1].GetComponent<Renderer>().enabled =true;
        }
        else if(keyPressed == "D")
        {
            arrows[0].GetComponent<Renderer>().enabled =true;
        }
        else if(keyPressed == "A")
        {
            arrows[2].GetComponent<Renderer>().enabled =true;
        }
        else if(keyPressed == "S")
        {
            arrows[3].GetComponent<Renderer>().enabled =true;
        }
        yield return new WaitForSeconds(0.2f);
        arrows[1].GetComponent<Renderer>().enabled = false;
        arrows[0].GetComponent<Renderer>().enabled = false;
        arrows[2].GetComponent<Renderer>().enabled = false;
        arrows[3].GetComponent<Renderer>().enabled = false;
        gridMovement();
    }
}
