using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fogao : MonoBehaviour
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
        ICozinhar colisor = collision.GetComponent<MonoBehaviour>() as ICozinhar;
        if (colisor is ICozinhar cozinhar)
        {
            cozinhar.Cozinhar();
        }
    }
}
