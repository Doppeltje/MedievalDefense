using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Parent_Tower : MonoBehaviour
{
    // dont forget to attach in Inspector
    public Button m_Tower01, m_Tower02, m_Tower03;
    public ChangeCursor changeCursor;

    public bool uiButtonActive = false;

    private StoneScript _stone;
    private WoodScript _wood;
    //private GoldScript _gold;

    public enum TowerType
    {
        Tower_01,
        Tower_02,
        Tower_03
    }

    public TowerType towerType;


    // Use this for initialization
    void Start ()
    {
        changeCursor = GetComponent<ChangeCursor>();

        m_Tower01.onClick.AddListener(OnClickTower01);
        m_Tower02.onClick.AddListener(OnClickTower02);
        m_Tower03.onClick.AddListener(OnClickTower03);
        _stone = FindObjectOfType<StoneScript>();
        _wood = FindObjectOfType<WoodScript>();
        //_gold = FindObjectOfType<GoldScript>();
    }
	
	// Update is called once per frame
	void Update () {
		if (!uiButtonActive)
        {
            changeCursor.OnMouseEnter(3);
        }
	}

    void OnClickTower01()
    {
        Tower01();
        //Debug.Log("Clicked Tower_01");
    }

    void OnClickTower02()
    {
        Tower02();
    }

    void OnClickTower03()
    {
        Tower03();
    }

    void Tower01()
    {
        towerType = TowerType.Tower_01;
        changeCursor.OnMouseEnter(0);
        uiButtonActive = true;
    }

    void Tower02()
    {
        towerType = TowerType.Tower_02;
        changeCursor.OnMouseEnter(1);
        uiButtonActive = true;
    }

    void Tower03()
    {
        towerType = TowerType.Tower_03;
        changeCursor.OnMouseEnter(2);
        uiButtonActive = true;
    }

    public void TowerCost()
    { // werkt
        switch (towerType)
        {
            case TowerType.Tower_01:
                _wood.woodValue -= 20;
                _stone.stoneValue -= 10;
                break;
            case TowerType.Tower_02:
                _wood.woodValue -= 20;
                break;
            case TowerType.Tower_03:
                _wood.woodValue -= 10;
                break;
            default:
                Debug.Log("No towerType found.");
                break;
        }
    }
}
