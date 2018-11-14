using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoldScript : MonoBehaviour
{
    Text gold;

    public int goldValue = 0;
    
    // Use this for initialization
    void Start()
    {
        gold = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        UpdateGold();
    }

    void UpdateGold()
    {
        gold.text = "x" + goldValue;
    }
}
