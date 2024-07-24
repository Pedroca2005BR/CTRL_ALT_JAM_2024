using System.Collections;
using System.Collections.Generic;
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
            transform.Translate(MousePos);
        }
        else {
            if (gameObject.tag == "cobre") {

                transform.position = new Vector3(-8, 3, 0);
            }
            if (gameObject.tag == "batata")
            {

                transform.position = new Vector3(-8, 0, 0);
            }
            if (gameObject.tag == "suco")
            {

                transform.position = new Vector3(-8, -3, 0);
            }
        }
    }



}
