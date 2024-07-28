<<<<<<< Updated upstream
=======
using System;
>>>>>>> Stashed changes
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

<<<<<<< Updated upstream
public class FritadeiraDeBatata : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
=======
public class Fritadeira : MonoBehaviour
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
        Debug.Log("Entrou Trigger!");
        IFritar colisor = collision.GetComponent<IFritar>();
        if (colisor != null)
        {
            colisor.Fritar();
        }
>>>>>>> Stashed changes
    }
}
