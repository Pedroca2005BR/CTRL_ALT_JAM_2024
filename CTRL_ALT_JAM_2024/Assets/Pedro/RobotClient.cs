using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum ClientState
{
    Ordering,
    Waiting
}

public class RobotClient : MonoBehaviour
{
    [SerializeField] private float timeOrdering;
    [SerializeField] private float speed;
    [SerializeField] private float timeBetweenStates;
    private float currentTime;
    private ClientState state;

    bool angry = false;
    bool timeFlow = true;

    [SerializeField] private int score;

    //Settar no instantiate
    public StrikeDisplayer strikeDisplayer;
    public ScoreDisplayer scoreDisplayer;

    private void Start()
    {
        state = ClientState.Ordering;
        currentTime = 0;
    }

    private void Update()
    {
        if (timeFlow)
        Waiting();
    }

    private void OnMouseDown()
    {
        if (state == ClientState.Ordering)
        {
            StartCoroutine("MakeRequest");
        }
        else
        {
            CheckOrder();
        }
    }



    private void Waiting()
    {
        currentTime += Time.deltaTime;

        if (currentTime > timeBetweenStates)
        {
            if (!angry)
            {
                //sprite robo bravo
                angry = true;
                currentTime = 0;
            }
            else
            {

                scoreDisplayer.ChangeScore(score * -1);
                strikeDisplayer.Strike();

                Destroy(gameObject);
            }
        }
    }


    public IEnumerator MakeRequest()
    {
        timeFlow = false;
        // fazer pedido e parara timbum

        yield return new WaitForSeconds(timeOrdering);

        //settar outras coisas pra seguir o jogo
        currentTime = 0;
        angry = false;

        state = ClientState.Waiting;
        timeFlow = true;
    }

    public void CheckOrder()
    {

    }
}
