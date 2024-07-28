using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Drag : MonoBehaviour
{
    bool drag;

    private void OnMouseDown()
    {
        drag = true;
    }

    private void OnMouseUp()
    {
        drag = false; 
    }

    private void Update()
    {
        if (drag)
        {
            Vector2 MousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
            transform.position = MousePos;


        }
        else {
            if(gameObject.tag == "Cobre")transform.position = new Vector3(-320, -325, 1);
            if (gameObject.tag == "Prata") transform.position = new Vector3(-100, -325, 1);
            if (gameObject.tag == "Verde") transform.position = new Vector3(120, -325, 1);
            if (gameObject.tag == "Colorido") transform.position = new Vector3(340, -325, 1);
        }
    }
}


