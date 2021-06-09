using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grid
{

    
    mortalUtills uttills = new mortalUtills();
    private int width, height;
    private int[,] gridArray;
    private TextMesh[,] debugArray;
    private float cellSize;

    public Grid(int width, int height, float cellSize)
    {
        this.width = width;
        this.height = height;
        this.cellSize = cellSize;

        gridArray = new int[width, height];
        debugArray = new TextMesh[width,height];


        for (int x = 0; x < gridArray.GetLength(0); x++)
        {
            for (int z = 0; z < gridArray.GetLength(1); z++)
            {

                debugArray[x, z] = uttills.CreateTextMesh(gridArray[x, z].ToString(), getWorldPos(x, z) + new Vector3(cellSize, 0 , cellSize) * .5f);

                Debug.DrawLine(getWorldPos(x, z), getWorldPos(x, z + 1), Color.white, 100f);
                Debug.DrawLine(getWorldPos(x, z), getWorldPos(x + 1, z), Color.white, 100f);
            }


        }

        Debug.DrawLine(getWorldPos(width, height), getWorldPos(width, 0), Color.white, 100f);
        Debug.DrawLine(getWorldPos(0, height), getWorldPos(width, height), Color.white, 100f);
    }

    public Vector3 getWorldPos(int x, int z)
    {
        return new Vector3(x, 0 , z) * cellSize;

    }



    public void setValue(int x, int z, int value)
    {
        if (x >= 0 && z >= 0 && x < width && z < height)
        {
            gridArray[x, z] = value;
            debugArray[x,z].text = gridArray[x, z].ToString();
        }
    }
    public void getXY(Vector3 loc, out int x, out int z)
    {

        x = Mathf.FloorToInt(loc.x / cellSize);
        z = Mathf.FloorToInt(loc.z / cellSize);

        Debug.Log(x + " , " + z);

    }

    public void setValue(Vector3 location, int value)
    {
        Debug.Log(location);
        int x, z;
        getXY(location, out x, out z);

        setValue(x, z, value);



    }





}
