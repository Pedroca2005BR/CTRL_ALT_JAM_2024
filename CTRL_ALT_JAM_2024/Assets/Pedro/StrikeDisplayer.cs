using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class StrikeDisplayer : MonoBehaviour
{
    [SerializeField] private SceneController controller;
    [SerializeField] private Image[] strikes;
    private bool[] isStriked;

    private void Start()
    {
        isStriked = new bool[strikes.Length];
    }

    public void Strike()
    {
        // procura o primeiro nao striked mark
        for(int i = 0; i < strikes.Length; i++)
        {
            if (!isStriked[i])
            {
                isStriked[i] = true;

                //tocar som de strike

                strikes[i].tintColor = Color.red;

                return;
            }
        }

        //Game over
        controller.NextScene();
    }
}
