using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifePoints : MonoBehaviour
{

    Text life;

    public int lifeValue = 20;
    

	// Use this for initialization
	void Start () {
        life = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
        life.text = lifeValue + "x";
	}
}
