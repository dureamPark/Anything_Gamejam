using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_generator : MonoBehaviour
{
    [SerializeField] GameObject mobPrefabA;
    [SerializeField] GameObject mobPrefabB;
    [SerializeField] GameObject mobPrefabC;
    [SerializeField] GameObject mobPrefabD;

    WaveManager waveManager;
    GameManager gameManager;

    bool isWave;
    float timeSinceLastSpawnA;
    float timeSinceLastSpawnB;
    float timeSinceLastSpawnC;
    float timeSinceLastSpawnD;

    float timeToSpawn_A = 3f;
    float timeToSpawn_B = 3.5f;
    float timeToSpawn_C = 4.5f;
    float timeToSpawn_D = 6f;

    bool mob_A = true;
    bool mob_B = false;
    bool mob_C = false;
    bool mob_D = false;

    void Start()
    {
        waveManager = FindObjectOfType<WaveManager>();
        gameManager = FindObjectOfType<GameManager>();
    }

    void Update()
    {
        UpdateStatus();

        if (isWave)
        {
            timeSinceLastSpawnA += Time.deltaTime;
            timeSinceLastSpawnB += Time.deltaTime;
            timeSinceLastSpawnC += Time.deltaTime;
            timeSinceLastSpawnD += Time.deltaTime;

            GenerateMonsters();
        }
    }

    void UpdateStatus()
    {
        int currentWave = gameManager.Wave;
        isWave = waveManager.Waving;

        if (currentWave >= 2 && !mob_B)
        {
            timeToSpawn_A = 2f;
            mob_B = true;
        }
        if (currentWave >= 4 && !mob_C)
        {
            timeToSpawn_B = 3f;
            mob_C = true;
        }
        if (currentWave >= 6 && !mob_D)
        {
            timeToSpawn_A = 1.5f;
            timeToSpawn_B = 2.5f;
            timeToSpawn_C = 4f;
            mob_D = true;
        }
        if (currentWave >= 8)
        {
            timeToSpawn_D = 5f;
        }
    }

    void GenerateMonsters()
    {
        if (mob_A && timeSinceLastSpawnA >= timeToSpawn_A)
        {
            timeSinceLastSpawnA = 0f;
            Instantiate(mobPrefabA, transform.position, Quaternion.identity);
        }
        else if (mob_B && timeSinceLastSpawnB >= timeToSpawn_B)
        {
            timeSinceLastSpawnB = 0f;
            Instantiate(mobPrefabB, transform.position, Quaternion.identity);
        }
        else if (mob_C && timeSinceLastSpawnC >= timeToSpawn_C)
        {
            timeSinceLastSpawnC = 0f;
            Instantiate(mobPrefabC, transform.position, Quaternion.identity);
        }
        else if (mob_D && timeSinceLastSpawnD >= timeToSpawn_D)
        {
            timeSinceLastSpawnD = 0f;
            Instantiate(mobPrefabD, transform.position, Quaternion.identity);
        }
    }
}
