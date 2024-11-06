using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class MapScript : MonoBehaviour
{
    //creating the tilemap and tilebases for the player, chests and doors.
    public Tilemap Tilemap;
    public TileBase Player;
    public TileBase Chest;
    public TileBase Door;
    
    //Creating the x and y sizes of the map
    int[,] Map = new int[15, 10];
    private void Start()
    {
        for (int y = 0; y < Map.GetLength(1); y++)
        {
            for (int x = 0; x < Map.GetLength(0); x++)
            {
                Map[x, y] = Random.Range(0, 2);
            }
        }
        //Loading the premade map in start
        LoadPremadeMap();
    }

    void GenerateMapString()
    {

    }

   void ConvertMapToTileMap()
    {

    }

    void LoadPremadeMap()
    {
        
    }
  
}
