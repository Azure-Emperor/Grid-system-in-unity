using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mortalUtills
{

    public TextMesh CreateTextMesh(string Text, Vector3 location)
    {
        GameObject gameOBJ = new GameObject("world_text", typeof(TextMesh));
        Transform transform = gameOBJ.transform;
        transform.localPosition = location;
        transform.rotation = Quaternion.Euler(90,0,0);
        TextMesh textM = gameOBJ.GetComponent<TextMesh>();
        textM.text = Text;
        textM.color = Color.white;
        textM.fontSize = 20;
        textM.anchor = TextAnchor.MiddleCenter;



        return textM;
    }


    public GameObject createSprite(GameObject sprite , Vector3 location,  float cellSize)
    {
        GameObject gameObj = GameObject.Instantiate(sprite , location, Quaternion.identity);
        gameObj.transform.localScale = new Vector3(cellSize, cellSize);
        return gameObj;
    }


    public Vector3 mouseToScreen(Vector3 screenPos)
    {

        Vector3 mouseWorldPos = new Vector3();
        mouseWorldPos = Camera.main.ScreenToWorldPoint(screenPos);
        return(mouseWorldPos);
    }


    public Vector3 mouseToScreen3d(Vector3 screenPos)
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out RaycastHit raycasthit, 999f))
        {
            return raycasthit.point;
        }

        else {
            return Vector3.zero;
                }
    
    }



    }
