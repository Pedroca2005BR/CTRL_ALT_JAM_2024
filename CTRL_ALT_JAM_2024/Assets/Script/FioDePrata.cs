using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class FioDePrata : AbstractIngrediente, ICozinhar, IMolho, IPrato
{
    [SerializeField] public Sprite sprNovo;
    public override void LateStart()

    {
        SetUp(this);
    }
    void Update()
    {

    }
    public void Cozinhar()
    {
        if (!estaProcessado)
        {
            estaProcessado = true;
            spr.sprite = sprNovo;

        }


    }
    public void Molho()
    {
        if (estaProcessado)
        {
            Debug.Log("Seila");
        }
    }


}
