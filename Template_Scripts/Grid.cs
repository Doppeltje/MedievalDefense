using System.Collections.Generic;
using UnityEngine;

public class Grid
{
    /// <summary>
    /// The tiles for this grid.
    /// </summary>
    private readonly Tile[,] _grid;

    /// <summary>
    /// Constructor.
    /// </summary>
    /// <param name="width">Width of the grid (amount of columns)</param>
    /// <param name="height">Height of the grid (amount ofrows)</param>
    public Grid(int width, int height)
    {
        if (width < 0 || height < 0)
        {
            throw new System.InvalidOperationException("width and height cannot be smaller than zero");
        }

        Width = width;
        Height = height;

        _grid = new Tile[Width, Height];

        for (var x = 0; x < Width; x++)
        {
            for (var y = 0; y < Height; y++)
            {
                var currentPosition = new Vector2(x, y);
                _grid[x, y] = new Tile(currentPosition);
            }
        }
    }

    /// <summary>
    /// The width of the grid.
    /// </summary>
    public int Width { get; set; }

    /// <summary>
    /// The height of the grid.
    /// </summary>
    public int Height { get; set; }

    /// <summary>
    /// Gets a Tile from the grid.
    /// </summary>
    /// <param name="x">x position of the tile.</param>
    /// <param name="y">y position of the tile.</param>
    /// <returns></returns>
    public Tile GetTile(int x, int y)
    {
		// todo 1: ik return nu 'null'. Zorg ervoor dat jullie de Tile returnen die op plek x en y staat in ons grid

        // todo 2: bouw een check in of de x en y wel binnen het grid valt

        return null;
    }

    /// <summary>
    /// Determines if a x & y position is within the grid
    /// </summary>
    /// <param name="x"></param>
    /// <param name="y"></param>
    /// <returns></returns>
    public bool IsOnGrid(int x, int y)
    {
        // todo: nu return ik altijd true. Zorg ervoor dat er echt gecheckt wordt of de x en y binnen het grid vallen

        // return true;

        if (GetTile.x < 0 || GetTile.y < 0)
        {
            Debug.log("Out of bounds.");
        }
        else
        {
            Debug.log("On the grid.");
        }
    }

    void Update ()
    {
        if(
    }

		
}