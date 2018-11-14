using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManaPoints : MonoBehaviour
{

    Text mana;

    public static int manaValue = 0;


    // Use this for initialization
    void Start()
    {
        mana = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        mana.text = manaValue + "x";
    }
}
