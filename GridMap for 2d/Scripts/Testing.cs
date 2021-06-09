using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Testing : MonoBehaviour
{

    Grid grid;
    mortalUtills utills = new mortalUtills();
    private void Start()
    {
        
        grid = new Grid(4, 2, 10f);
    }


    private void Update()
    {
        
        if (Input.GetMouseButtonDown(0))
        {


            grid.setValue(utills.mouseToScreen(Input.mousePosition), 123);

        }


    }


}
