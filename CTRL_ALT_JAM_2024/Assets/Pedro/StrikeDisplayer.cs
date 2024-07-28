using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class StrikeDisplayer : MonoBehaviour
{
    [SerializeField] private SceneController controller;
    private Image[] strikes;
    private bool[] isStriked;

    private void Start()
    {
        strikes = transform.GetComponentsInChildren<Image>();
        //Debug.Log(strikes[0]);
        isStriked = new bool[strikes.Length];
    }

    public void Strike()
    {
        // procura o primeiro nao striked mark
        for(int i = 0; i < strikes.Length-1; i++)
        {
            if (!isStriked[i])
            {
                isStriked[i] = true;

                //tocar som de strike

                strikes[i].color = Color.red;

                return;
            }
        }

        //Game over
        controller.NextScene();
    }
}
