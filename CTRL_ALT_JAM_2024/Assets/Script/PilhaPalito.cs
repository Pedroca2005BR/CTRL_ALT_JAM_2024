using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PilhaPalito : AbstractIngrediente, IFritar
{
    public bool estaPronto = false;
    [SerializeField] public Sprite sprNovoPilhaPalito;
    public override void LateStart()

    {
        SetUp(this);
    }
    void Update()
    {

    }
    public void Fritar()
    {
        if (!estaPronto && !estaProcessado)
        {
            estaProcessado = true;
            spr.sprite = sprNovoPilhaPalito;
        }



    }

}
