using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class AbstractIngrediente : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] public SpriteRenderer spr;
    [SerializeField] public string nomeIngrediente = " ";
    public BoxCollider2D boxcollider;
    public new Rigidbody2D rigidbody;
    public bool estaProcessado = false;
    void Start()
    {
        spr = GetComponent<SpriteRenderer>();
        LateStart();
    }
    public virtual void LateStart()
    {

    }
    public void SetUp(AbstractIngrediente gameobject)
    {
        try
        {
            boxcollider = gameObject.AddComponent<BoxCollider2D>(); 
            rigidbody = gameObject.AddComponent<Rigidbody2D>();
            boxcollider.isTrigger = true;
            boxcollider.size = new Vector2(1, 1);
            rigidbody.bodyType = RigidbodyType2D.Kinematic;
            Debug.Log("deu algo?");

        }
        catch
        {
            Debug.Log("deu errado");
            return;
        }
    }
}
