using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class StationMover : MonoBehaviour
{
    [SerializeField] private List<CinemachineVirtualCamera> cameras = new List<CinemachineVirtualCamera>();

    public void GoToStation(int index)
    {
        if (index >= cameras.Count || index < 0)
        {
            Debug.LogError("Index Out Of Range!", this);
            return;
        }


        CinemachineVirtualCamera virtualCamera = cameras[index];

        virtualCamera.Priority = 100;

        foreach (CinemachineVirtualCamera c in cameras)
        {
            if (c != virtualCamera)
            {
                c.Priority = 0;
            }
        }
    }
}
