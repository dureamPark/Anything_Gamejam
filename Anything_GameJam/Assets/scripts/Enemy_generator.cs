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
    float timeSinceLastSpawn;
    float spawnInterval;
    int WaveCount;

    float spawnInterval_A;
    float spawnInterval_B;
    float spawnInterval_C;
    float spawnInterval_D;

    void Start()
    {
        waveManager = FindObjectOfType<WaveManager>();
        gameManager = FindObjectOfType<GameManager>();
        timeSinceLastSpawn = Random.Range(0.5f, 2f);
        spawnInterval = Random.Range(0.5f, 2.5f);
        spawnInterval_A = 3f;
        spawnInterval_B = 3.5f;
        spawnInterval_C = 4.5f;
        spawnInterval_D = 6f;
        bool mob_A = true;
        bool mob_B = false;
        bool mob_C = false;
        bool mob_D = false;
    }

    void Update()
    {
        UpdateStatus();

        if (isWave)
        {
            timeSinceLastSpawn += Time.deltaTime;
            if (timeSinceLastSpawn >= spawnInterval)
            {
                Invoke("GenerateMonsters", spawnInterval);
                timeSinceLastSpawn = 0f;
                spawnInterval = Random.Range(0.5f, 2.5f);
            }
        }
    }

    void UpdateStatus()
    {
        WaveCount = gameManager.Wave;
        isWave = waveManager.Waving;

        if(WaveCount <= 2)
        {
            spawnInterval_A = 2f;
        }else if(WaveCount <= 4)
        {
            spawnInterval_B = 3f;
        }
        else if(WaveCount <= 6)
        {
            spawnInterval_A = 1.5f;
            spawnInterval_B = 2.5f;
            spawnInterval_C = 4f;
        }
        else if(WaveCount <= 8)
        {
            spawnInterval_D = 5f;
        }else if(WaveCount == 9)
        {
            spawnInterval_A = 1.5f;
            spawnInterval_B = 2.5f;
            spawnInterval_C = 3.5f;
            spawnInterval_D = 4.5f;
        }

    }

    void GenerateMonsters()
    {
        float spawnProbability = Random.value;

        if (spawnProbability <= 0.8f)
        {
            Instantiate(mobPrefabA, transform.position, Quaternion.identity);
        }
        else if (spawnProbability <= 0.8f + 0.1f) 
        {
            Instantiate(mobPrefabB, transform.position, Quaternion.identity);
        }
        else if (spawnProbability <= 0.8f + 0.1f + 0.2f) 
        {
            Instantiate(mobPrefabC, transform.position, Quaternion.identity);
        }
        else if (spawnProbability <= 0.8f + 0.1f + 0.2f + 0.2f) 
        {
            Instantiate(mobPrefabD, transform.position, Quaternion.identity);
        }
        else
        {
            Instantiate(mobPrefabA, transform.position, Quaternion.identity);
        }
    }
}
