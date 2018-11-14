using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonScript : MonoBehaviour
{
    public enum CurrencyType
    {
        Wood,
        Stone,
        Gold
    }

    // dont forget to add in inspector
    public Button tower1;
    public Button tower2;
    public Button tower3;


    // dont forget inspector
    public CurrencyType currencyType;

    private StoneScript _stone;
    private WoodScript _wood;
    //private GoldScript _gold;

    private int stone;

	// Use this for initialization
	void Start ()
    {
        _stone = FindObjectOfType<StoneScript>();
        _wood = FindObjectOfType<WoodScript>();
       // _gold = FindObjectOfType<GoldScript>();
 	}
	
	// Update is called once per frame
	void Update ()
    {
        ToggleUIButtons();
	}



    void ToggleUIButtons()
    {
        // enables/disables ui buttons
        tower1.interactable = _wood.woodValue >= 20 && _stone.stoneValue >= 10;
        tower2.interactable = _wood.woodValue >= 20;
        tower3.interactable = _wood.woodValue >= 10;
    }
}
