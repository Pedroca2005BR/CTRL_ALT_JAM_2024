using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drag : MonoBehaviour
{
    bool drag;
    [SerializeField] float X;
    [SerializeField] float Y;
    [SerializeField] float Z;

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

                transform.position = new Vector3(-11, -30, 0);
            }
            if (gameObject.tag == "prata")
            {

                transform.position = new Vector3(-5.5f, -30, 0);
            }
            if (gameObject.tag == "estanho")
            {

                transform.position = new Vector3(0, -30, 0);
            }
            if (gameObject.tag == "fibra")
            {

                transform.position = new Vector3(5.5f, -30, 0);
            }
            if (gameObject.tag == "copo")
            {

                transform.position = new Vector3(0, -54.8f, 0);
            }
            if (gameObject.tag == "pilha")
            {

                transform.position = new Vector3(5.5f, -55.1f, Z);
            }
            
            if (gameObject.tag == "batata")
            {

                transform.position = new Vector3(0, -80, 0);
            }
            if (gameObject.tag == "salOuro")
            {

                transform.position = new Vector3(-9.5f, -80, 0);
            }
            if (gameObject.tag == "salCarvao")
            {

                transform.position = new Vector3(-11, -80, 0);
            }
        }
    }



}
