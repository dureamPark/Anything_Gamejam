using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_generator : MonoBehaviour
{
    //몹 프리펩 받는 함수
    [SerializeField] GameObject mobPrefabA;
    [SerializeField] GameObject mobPrefabB;
    [SerializeField] GameObject mobPrefabC;
    [SerializeField] GameObject mobPrefabD;

    WaveManager waveManager;

    bool isWave; //웨이브 on
    int E_Num; //e_num으로 적 수확인
    int generated_E;
    bool generated;
    bool mob_A;
    bool mob_b;
    bool mob_c;
    bool mob_d;
    float timeSinceLastSpawn; //스폰시간
    float spawnInterval = 0.5f; //스폰대기

    void Start()
    {
        generated = true;
        waveManager = FindObjectOfType<WaveManager>();
        timeSinceLastSpawn = 0f; 
    }

    void Update()
    {
        UpdateStatus(); //wavemanager코드 업뎃

        if (isWave) //iswave true면,
        {
            timeSinceLastSpawn += Time.deltaTime;
            if (timeSinceLastSpawn >= spawnInterval)
            {
                GenerateMonsters();
                generated_E--;
                if(generated_E == 0)
                {
                    isWave = false;
                }
                timeSinceLastSpawn = 0f;

            }
        }
    }

    void UpdateStatus()
    {
        isWave = waveManager.Waving;
        if (generated)
        {
            generated_E = waveManager.Enemy_Num;
            generated = !generated;
        }
        E_Num = waveManager.Enemy_Num;
        mob_A = waveManager.EnemyA_N;
        mob_b = waveManager.EnemyB_N;
        mob_c = waveManager.EnemyC_N;
        mob_d = waveManager.EnemyD_N;
    }

    void GenerateMonsters()
    {
        List<GameObject> activePrefabs = new List<GameObject>();

        if (mob_A)
        {
            activePrefabs.Add(mobPrefabA);
        }
        if (mob_b)
        {
            activePrefabs.Add(mobPrefabB);
        }
        if (mob_c)
        {
            activePrefabs.Add(mobPrefabC);
        }
        if (mob_d)
        {
            activePrefabs.Add(mobPrefabD);
        }

        int totalActivePrefabs = activePrefabs.Count;

        for (int i = 0; i < E_Num; i++)
        {
            if (i < totalActivePrefabs)
            {
                float spawnProbability = Random.value;
                GameObject prefabToSpawn = activePrefabs[i];

                if (spawnProbability <= 0.6f && prefabToSpawn == mobPrefabA)
                {
                    Instantiate(prefabToSpawn, transform.position, Quaternion.identity);
                }
                else if (spawnProbability <= 0.4f && prefabToSpawn == mobPrefabB)
                {
                    Instantiate(prefabToSpawn, transform.position, Quaternion.identity);
                }
                else if (spawnProbability <= 0.3f && prefabToSpawn == mobPrefabC)
                {
                    Instantiate(prefabToSpawn, transform.position, Quaternion.identity);
                }
                else if (spawnProbability <= 0.2f && prefabToSpawn == mobPrefabD)
                {
                    Instantiate(prefabToSpawn, transform.position, Quaternion.identity);
                }
            }
        }
    }
}
