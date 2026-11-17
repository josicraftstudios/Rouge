using UnityEngine;
using System;
using System.Collections.Generic;
using Random = UnityEngine.Random;

public class BordManeger : MonoBehaviour
{
    [Serializable]
    public class Count
    {
        public int maxi;
        public int mini;
        public Count(int min,int max)
        {
            mini = min;
            maxi = max;
        }
    }

    public int rows = 8;
    public int cols = 8;
    public Count wallCount = new Count(5, 9);
    public Count FoodCount = new Count(1,5);
    public GameObject Exit;
    public GameObject[] Floortiles;
    public GameObject[] walltiles;
    public GameObject[] outerwalltiles;
    public GameObject[] enemytiles;
    public GameObject[] Foodtiles;

    private Transform bordHolder;
    private List<Vector3> gridPositions = new List<Vector3>();

    void InitializeList()
    {
        gridPositions.Clear();

        for (int x = 1; x < cols - 1; x++)
        {
            for(int y = 1; y < rows - 1; y++)
            {
                gridPositions.Add(new Vector3(x, y, 0f));
            }
        }
    }

    private void BordSetup()
    {

    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
