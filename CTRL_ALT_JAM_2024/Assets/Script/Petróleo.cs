using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Petróleo : MonoBehaviour
{
    //public BoxCollider2D qualquerNome;
    void Start()
    {
        //qualquerNome = GetComponent<BoxCollider2D>();
    }


    void Update()
    {

    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Entrou Trigger molho!");
        IMolho colisor = collision.GetComponent<IMolho>();
        if (colisor != null)
        {            
            colisor.Molho();
            Destroy(this.gameObject, 0.0f);
        }
    }
}
