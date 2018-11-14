using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StoneScript : MonoBehaviour
{
    Text stone;

    public int stoneValue = 0;

    // Use this for initialization
    void Start()
    {
        stone = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        UpdateStone();
    }

    void UpdateStone()
    {
        stone.text = "x" + stoneValue;
    }
}
