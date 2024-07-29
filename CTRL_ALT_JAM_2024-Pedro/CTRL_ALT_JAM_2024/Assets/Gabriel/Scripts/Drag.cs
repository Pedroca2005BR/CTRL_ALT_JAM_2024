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

                transform.position = new Vector3(-14.2f, -22, Z);
            }
            if (gameObject.tag == "prata")
            {

                transform.position = new Vector3(-8, -22, 0);
            }
            if (gameObject.tag == "estanho")
            {

                transform.position = new Vector3(9.3f, -22, 0);
            }
            if (gameObject.tag == "fibra")
            {

                transform.position = new Vector3(13, -22, 0);
            }
            if (gameObject.tag == "copo")
            {

                transform.position = new Vector3(-3, -43.6f, 0);
            }
            if (gameObject.tag == "pilha")
            {

                transform.position = new Vector3(3.35f , -44.3f, Z);
            }
            
            if (gameObject.tag == "batata")
            {

                transform.position = new Vector3(2, -70.4f, 0);
            }
            if (gameObject.tag == "salOuro")
            {

                transform.position = new Vector3(-3f, -70.7f, 0);
            }
            if (gameObject.tag == "salCarvao")
            {

                transform.position = new Vector3(-2, -70.7f, 0);
            }
        }
    }



}
