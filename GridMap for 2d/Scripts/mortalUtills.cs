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
        TextMesh textM = gameOBJ.GetComponent<TextMesh>();
        textM.text = Text;
        textM.color = Color.white;
        textM.fontSize = 20;
        textM.anchor = TextAnchor.MiddleCenter;



        return textM;
    }


    public Vector3 mouseToScreen(Vector3 screenPos)
    {

        Vector3 mouseWorldPos = new Vector3();
        mouseWorldPos = Camera.main.ScreenToWorldPoint(screenPos);
        return(mouseWorldPos);
    }





  
}
