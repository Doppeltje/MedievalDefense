using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile {

	public Tile(Vector2 position, string type = "default", bool isBlocking = false){
		Position = position;
		Type = type;
		IsBlocking = isBlocking;
	}

	public Vector2 Position { get; set; }

	public string Type { get; set; }

	public bool IsBlocking { get; set; }
}
