using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Color_Changer : MonoBehaviour
{
    public float redFade = 1;
    public float blueFade = 1;
    public float greenFade = 1;
    public float opacity = 1;

    public Renderer rend;

    // Use this for initialization
    void Start()
    {
        rend = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        Color fade = new Color(redFade, blueFade, greenFade, opacity);

        rend.material.color = fade;
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "arrow(Clone)")
        {
            blueFade = blueFade - .2f;
            greenFade = greenFade - .2f;
        }
    }
}