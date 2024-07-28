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
    [SerializeField] private float timeOrdering; //tempo q demora pra fazer o pedido
    [SerializeField] private float timeBetweenStates; //tempo ate ficar bravo

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

    //
    private void OnMouseDown()
    {
        // inicia a corotina MakeRequest se o cliente nao pediu nada ainda
        if (state == ClientState.Ordering)
        {
            StartCoroutine("MakeRequest");
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

    // MakeRequest roda e pausa a passagem do tempo para o timer enquanto o robo faz o pedido
    public IEnumerator MakeRequest()
    {
        timeFlow = false;
        
        //Precisa adicionar ele fazendo o pedido aqui///////////////////////////////////////////////////////////////////////

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
