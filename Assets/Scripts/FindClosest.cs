using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindClosest : MonoBehaviour
{
    private CursorPos cursor;
    public BuildGround closestBuildGround;

    public float x;
    public float y;

    private void Start()
    {
        cursor = GameObject.Find("Canvas").GetComponent<CursorPos>();
    }

    // Update is called once per frame
    void Update()
    {
        FindClosestBuildGround();
    }

    public void FindClosestBuildGround()
    {
        
        float distanceToClosestBuildGround = Mathf.Infinity;
        BuildGround closestBuildGround = null;
        BuildGround[] allGrounds = FindObjectsOfType<BuildGround>();

        foreach (BuildGround currentBuildGround in allGrounds)
        {
            float distanceToBuildGround = (currentBuildGround.transform.position - cursor.transform.position).sqrMagnitude;
            if (distanceToBuildGround < distanceToClosestBuildGround)
            {
                distanceToClosestBuildGround = distanceToBuildGround;
                closestBuildGround = currentBuildGround;
                x = closestBuildGround.transform.position.x;
                y = closestBuildGround.transform.position.y;
            }
        }

        //Debug.Log(closestBuildGround.transform.position);
        //Debug.DrawLine(cursor.transform.position, closestBuildGround.transform.position);

    }

}
