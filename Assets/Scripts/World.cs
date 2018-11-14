using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class World : MonoBehaviour
{
    //to enable the option in the world object to drop tiles
    [SerializeField]
    private GameObject[] tilePrefabs;

    //[SerializeField]
    //private int gridX = 14;
    //[SerializeField]
    //private int gridY = 8;

    private float groundPositionX;
    

    public float TileSize
    {
        //get width of sprite
        get { return tilePrefabs[0].GetComponent<SpriteRenderer>().sprite.bounds.size.x; }
    }


    // Use this for initialization
    void Start()
    {
        // call function to create level
        CreateLevel();

        // Output the current screen window width in the console
        //Debug.Log("Screen Width : " + Screen.width);
        //Debug.Log("Screen Height : " + Screen.height);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void CreateLevel()
    {   //get info from text function
        string[] mapData = ReadLevelText();

        int XSize = mapData[0].ToCharArray().Length;
        int YSize = mapData.Length;

        Vector3 worldStart = Camera.main.ScreenToWorldPoint(new Vector3(0, Screen.height));

        //tilemap 
        for (int y = 0; y < YSize; y++)
        {
            char[] mapTiles = mapData[y].ToCharArray();

            for (int x = 0; x < XSize; x++)
            {
                PlaceTile(mapTiles[x].ToString(), x, y, worldStart);
            }
        }
    }

    private void PlaceTile(string tileType, int x, int y, Vector3 worldStart)
    {
        int tileIndex = int.Parse(tileType);
        //access the tile
        GameObject newTile = Instantiate(tilePrefabs[tileIndex]);
        //place tiles
        newTile.transform.position = new Vector3(worldStart.x + (TileSize * x), worldStart.y - (TileSize * y), 0);
        //float groundPositionX = (worldStart.x + (TileSize * x), worldStart.y - (TileSize * y), 0);
    }

    private string[] ReadLevelText()
    {
        TextAsset bindData = Resources.Load("Level_00") as TextAsset;

        string data = bindData.text.Replace(Environment.NewLine, string.Empty);

        return data.Split('-');
    }
}
