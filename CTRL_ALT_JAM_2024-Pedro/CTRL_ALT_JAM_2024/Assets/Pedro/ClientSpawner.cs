using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClientSpawner : MonoBehaviour
{
    [Header("Cooldown Settings")]
    [SerializeField] private float spawnDelay;
    [SerializeField] private float difficultyFactor;
    private float spawnTimer;

    [Header("Spawn Conditions")]
    [SerializeField] private GameObject roboPrefab;
    [SerializeField] private Vector3 spawnPosition;
    [SerializeField] private Transform parentRobot;

    [Header("References to robots")]
    [SerializeField] private StrikeDisplayer strikeDisplayer;
    [SerializeField] private ScoreDisplayer scoreDisplayer;

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
            Spawn();
            StartSpawnCooldown();
        }
    }

    private void Spawn()
    {
        GameObject robotObject = Instantiate(roboPrefab, spawnPosition, Quaternion.identity, parentRobot);
        RobotClient robot = robotObject.GetComponent<RobotClient>();

        robot.strikeDisplayer = strikeDisplayer;
        robot.scoreDisplayer = scoreDisplayer;
    }
}
