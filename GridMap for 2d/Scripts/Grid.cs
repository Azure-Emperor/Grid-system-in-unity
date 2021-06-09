using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Grid
{
    mortalUtills uttills = new mortalUtills();
    private int width;
    private int height;
    private int[,] gridArray;
    private float cellSize;
    private TextMesh[,] textArray;



    public Grid(int width, int height, float cellSize)
    {

        this.width = width;
        this.height = height;
        this.cellSize = cellSize;

        gridArray = new int[width, height];
        textArray = new TextMesh[width, height];
        

        for (int x = 0; x < gridArray.GetLength(0); x++) {
            for (int y = 0; y < gridArray.GetLength(1); y++)
            {

               textArray[x,y] = uttills.CreateTextMesh(gridArray[x, y].ToString(), getWorldPos(x, y) + new Vector3(cellSize, cellSize) * .5f) ;

                Debug.DrawLine(getWorldPos(x, y), getWorldPos(x, y + 1), Color.white, 100f) ;
                Debug.DrawLine(getWorldPos(x, y), getWorldPos(x + 1, y), Color.white, 100f);




            }
        }

        Debug.DrawLine(getWorldPos(width , height), getWorldPos(width, 0), Color.white, 100f);
        Debug.DrawLine(getWorldPos(0, height), getWorldPos(width, height), Color.white, 100f);

       // setValue(0, 0, 100);
    
    }

    public Vector3 getWorldPos(int x , int y)
    {
        return new Vector3(x, y) * cellSize;

    }



    public void setValue(int x, int y, int value)
    {
        if (x >= 0 && y >= 0 && x < width && y < height)
        {
            gridArray[x, y] = value;
            textArray[x, y].text = gridArray[x, y].ToString();
        }
    }
    public void getXY(Vector3 loc, out int x, out int y)
    {

        x = Mathf.FloorToInt(loc.x / cellSize);
        y = Mathf.FloorToInt(loc.y / cellSize);

        Debug.Log(x + " , " + y);
    
    }

    public void setValue(Vector3 location, int value)
    {
        int x, y;
        getXY(location, out x, out y);

        setValue(x, y, value);



    }


}
