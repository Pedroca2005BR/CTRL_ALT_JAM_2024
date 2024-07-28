using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum ClientState
{
    WantToOrder,
    Ordering,
    Waiting
}

public class RobotClient : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float timeBetweenStates;
    private float currentTime;
    private ClientState state;

    bool angry = false;

    [SerializeField] private int score;

    //Settar no instantiate
    public StrikeDisplayer strikeDisplayer;
    public ScoreDisplayer scoreDisplayer;

    private void Start()
    {
        state = ClientState.WantToOrder;
        currentTime = 0;
    }

    private void Update()
    {
        switch (state)
        {
            case ClientState.WantToOrder:
                WantOrderMode();
                break;

            case ClientState.Waiting:
                WaitingForOrderMode(); 
                break;
        }
    }

    private void WantOrderMode()
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

                Destroy(gameObject);
            }
        }
    }

    private void WaitingForOrderMode()
    {
        currentTime += Time.deltaTime;

        if (currentTime > timeBetweenStates)
        {
            if (!angry)
            {
                // sprite robo bravo
                angry = true;
                currentTime = 0;
            }
            else
            {

                scoreDisplayer.ChangeScore(score * -1);

                Destroy(gameObject);
            }
        }
    }

    public void MakeRequest()
    {
        
    }
}
