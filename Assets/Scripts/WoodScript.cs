using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WoodScript : MonoBehaviour
{
    Text wood;

    public int woodValue = 10;
    
    // Use this for initialization
    void Start()
    {
        wood = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        UpdateWood();
    }

    void UpdateWood()
    {
        wood.text = "x" + woodValue;
    }
}
