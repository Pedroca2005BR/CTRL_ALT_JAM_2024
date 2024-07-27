using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PedroTester : MonoBehaviour
{
    [SerializeField] private GameObject gameManager;

    private SceneController sceneController;
    private StationMover stationMover;

    private int stationNow = 0;

    private void Start()
    {
        stationMover = gameManager.GetComponent<StationMover>();
        stationMover.GoToStation(0);
    }

    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.N))
        {
            stationNow++;
            stationMover.GoToStation(stationNow);
        }
        else if (Input.GetKeyUp(KeyCode.S))
        {
            stationNow--;
            stationMover.GoToStation(stationNow);
        }
    }
}
