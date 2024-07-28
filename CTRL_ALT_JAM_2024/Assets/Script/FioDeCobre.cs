using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FioDeCobre : AbstractIngrediente, ICozinhar
{
    public bool estaPronto = false;
    [SerializeField] public Sprite sprNovo;
    public override void LateStart()

    {
        SetUp(this);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    void Cozinhar() {
        if (!estaPronto && !estaProcessado) { 
            estaProcessado = true;
            spr.sprite = sprNovo;
        }
    
    
    
    }

}
