using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class newMovement : MonoBehaviour
{
    public Camera cam;
    public Tilemap map;
    public float speed = 2;

    public bool onMouse;
    Vector3 mousePos;
    Vector3Int gridPos;
    Vector3 destination;
    void Start()
    {
        Vector3Int startpoint = new Vector3Int(0,0,0);
        gridPos = map.WorldToCell(startpoint);
        destination = map.CellToWorld(gridPos);
    }
    void Update()
    {
        mouseClicked();
        if(Vector3.Distance(transform.position, destination) > 0.1f)
        {
            transform.position = Vector3.MoveTowards(transform.position,destination,speed * Time.deltaTime);
        }    
    }
    private void mouseClicked()
    {
        /*if(Input.GetMouseButtonDown(0))
        {
            mousePos = Input.mousePosition;
            mousePos.z = 0;
            mousePos = cam.ScreenToWorldPoint(mousePos);
            gridPos = map.WorldToCell(mousePos);
            mousePos.z = 0;
            gridPos.z = 0;
            if(map.HasTile(gridPos))
            {
                destination = mousePos;
            }
        }*/
    }
    public void MouseOnTile(int tileNum)
    {
        if(tileNum == 0)
        {  
            gridPos.y -= 1;
            Debug.Log(gridPos);
        }
        destination = map.CellToWorld(gridPos);
    }
}
