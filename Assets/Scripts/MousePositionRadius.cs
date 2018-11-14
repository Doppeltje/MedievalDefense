using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MousePositionRadius : MonoBehaviour
{
    private GameObject bg;
    private ChangeCursor towerArray;
    private Parent_Tower pT;
    private FindClosest close;

    float placeX;
    float placeY;
      
    private int towerIndex;

    public bool canBuildTower = false;

    // Use this for initialization
    void Start()
    {
        bg = GameObject.FindGameObjectWithTag("BuildGround");
        towerArray = FindObjectOfType<ChangeCursor>();
        pT = FindObjectOfType<Parent_Tower>();
        close = GetComponent<FindClosest>();


    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnMouseDown()
    {
        if (bg.tag == "BuildGround")
        {
            canBuildTower = true;
        }
        else
        {
            return;
        }


        if (canBuildTower && pT.uiButtonActive)
        {
            PlaceTower();
            //Debug.Log("canBuildTower = " + canBuildTower);
            canBuildTower = false;
            pT.uiButtonActive = false;
            //Debug.Log("mouseposradius pT.uibuttonactive = " + pT.uiButtonActive);
        }
        else
        {
            return;
        }    

        
    }

     void PlaceTower()
    {
        // get x and y from FindClosest script
        float x = close.x + 1;
        float y = close.y;
        towerIndex = towerArray.towerIndex;

        GameObject newTower = Instantiate(towerArray.BuildTowers[towerIndex]);

        // place new tower
        newTower.transform.position = new Vector2(x, y);
        //Debug.Log("x = " + x);

        pT.TowerCost();

    }

    
}
