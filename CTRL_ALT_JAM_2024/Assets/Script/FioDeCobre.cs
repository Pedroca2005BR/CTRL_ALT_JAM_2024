<<<<<<< Updated upstream
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FioDeCobre : AbstractIngrediente, ICozinhar
{
    public bool estaPronto = false;
=======
using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class FioDeCobre : AbstractIngrediente, ICozinhar, IMolho, IPrato
{
>>>>>>> Stashed changes
    [SerializeField] public Sprite sprNovo;
    public override void LateStart()

    {
        SetUp(this);
    }
<<<<<<< Updated upstream
    // Update is called once per frame
    void Update()
    {
        
    }
    public void Cozinhar() {
        if (!estaPronto && !estaProcessado) { 
            estaProcessado = true;
            spr.sprite = sprNovo;
        }
    
    
    
    }

}
=======
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

>>>>>>> Stashed changes
