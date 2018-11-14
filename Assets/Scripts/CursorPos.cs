using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorPos : World
{
    public GameObject cursor;

	// Use this for initialization
	void Start () {
        cursor = GetComponent<GameObject>();
	}
	
	// Update is called once per frame
	void Update () {

        Vector3 pz = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        pz.z = 0;
        gameObject.transform.position = pz;
    }

    public void UpdateCursorPosition()
    {
        Vector3 pz = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        pz.z = 0;
        gameObject.transform.position = pz;
    }
}
