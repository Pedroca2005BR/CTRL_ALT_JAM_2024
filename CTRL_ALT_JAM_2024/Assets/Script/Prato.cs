<<<<<<< Updated upstream
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prato : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
=======
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Prato : MonoBehaviour

{
    public List<MonoBehaviour> ingredientes = new List<MonoBehaviour>();
    void Start()
    {
        //qualquerNome = GetComponent<BoxCollider2D>();
    }


    void Update()
    {
        var posicao = transform.position;
        if (ingredientes.Count > 0)
        {
            foreach (MonoBehaviour item in ingredientes)
            {
                item.transform.position = posicao;
            }
        }
    }
    public void OnTriggerStay2D(Collider2D collision)
    {
        //Debug.Log("Entrou Trigger!");

        MonoBehaviour prop = collision.GetComponent<MonoBehaviour>();
        if (prop != null && !ingredientes.Contains(prop))
        {
            if (prop is AbstractIngrediente ingr && ingr.estaProcessado)
            {
                ingredientes.Add(prop);
            }


        }
        else
        {
            ingredientes.Clear();
        }
>>>>>>> Stashed changes
    }
}
