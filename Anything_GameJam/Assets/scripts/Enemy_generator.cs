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

    void Start()
    {
        // Assuming you get references to WaveManager and GameManager somehow
        waveManager = GetComponent<WaveManager>();
        gameManager = GetComponent<GameManager>();

        // Your other initialization code here
    }

    // Update is called once per frame
    void Update()
    {
        UpdateStatus();
        if (waveManager.Waving)
        {
            GenerateMonsters();
        }
    }

    void UpdateStatus()
    {
        int wave = gameManager.Wave;
        bool isWave = waveManager.Waving;
        int E_Num = waveManager.Enemy_Num;
        bool mob_A = waveManager.EnemyA_N;
        bool mob_b = waveManager.EnemyB_N;
        bool mob_c = waveManager.EnemyC_N;
        bool mob_d = waveManager.EnemyD_N;
    }

    void GenerateMonsters()
    {
        int wave = gameManager.Wave;
        int enemyCount = waveManager.Enemy_Num;

        List<GameObject> activePrefabs = new List<GameObject>();

        // Adding active monster prefabs based on their bool flags
        if (waveManager.EnemyA_N)
        {
            activePrefabs.Add(mobPrefabA);
        }
        if (waveManager.EnemyB_N)
        {
            activePrefabs.Add(mobPrefabB);
        }
        if (waveManager.EnemyC_N)
        {
            activePrefabs.Add(mobPrefabC);
        }
        if (waveManager.EnemyD_N)
        {
            activePrefabs.Add(mobPrefabD);
        }

        int totalActivePrefabs = activePrefabs.Count;

        for (int i = 0; i < enemyCount; i++)
        {
            if (i < totalActivePrefabs)
            {
                // Adjusting spawn probabilities
                float spawnProbability = Random.value;

                if (spawnProbability <= 0.6f && activePrefabs.Contains(mobPrefabA))
                {
                    Instantiate(activePrefabs[activePrefabs.IndexOf(mobPrefabA)], transform.position, Quaternion.identity);
                }
                else if (spawnProbability <= 0.4f && activePrefabs.Contains(mobPrefabB))
                {
                    Instantiate(activePrefabs[activePrefabs.IndexOf(mobPrefabB)], transform.position, Quaternion.identity);
                }
                else if (spawnProbability <= 0.3f && activePrefabs.Contains(mobPrefabC))
                {
                    Instantiate(activePrefabs[activePrefabs.IndexOf(mobPrefabC)], transform.position, Quaternion.identity);
                }
                else if (spawnProbability <= 0.2f && activePrefabs.Contains(mobPrefabD))
                {
                    Instantiate(activePrefabs[activePrefabs.IndexOf(mobPrefabD)], transform.position, Quaternion.identity);
                }
            }
        }
    }
}
