using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClientSpawner : MonoBehaviour
{
    [SerializeField] private float spawnDelay;
    [SerializeField] private float difficultyFactor;
    private float spawnTimer;

    private void StartSpawnCooldown()
    {
        // O delay entre pedidos vai diminuir gradativamente
        spawnDelay -= difficultyFactor;
        spawnTimer = spawnDelay;
    }

    private void Update()
    {
        spawnTimer -= Time.deltaTime;

        if (spawnTimer < 0)
        {
            //Spawn();
        }
    }
}
