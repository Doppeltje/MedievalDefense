using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Keyboard_Reader : MonoBehaviour {
    [SerializeField]
    private bool w = false;
    private bool a = false;
    private bool s = false;
    private bool d = false;
    private bool space = false;
    private bool k = false;

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        checkKeycodes();

    }


    public bool W{
        get { return w; }
        }
    public bool A
    {
        get { return a; }
    }
    public bool S
    {
        get { return s; }
    }

    public bool D
    {
        get { return d; }
    }
    public bool K
    {
        get { return k; }
    }
    public bool Space
    {
        get { return space; }
    }


public void checkKeycodes() {
        if (Input.GetKey(KeyCode.W)) { w = true; } else w = false;
        if (Input.GetKey(KeyCode.A)) { a = true; } else a = false;
        if (Input.GetKey(KeyCode.S)) { s = true; } else s = false;
        if (Input.GetKey(KeyCode.D)) { d = true; } else d = false;
        if (Input.GetKey(KeyCode.Space)) { space = true; } else space = false;
        if (Input.GetKey(KeyCode.K)) { k = true; } else k = false;



    }
}

