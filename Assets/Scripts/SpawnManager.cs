using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    [SerializeField] private GameObject enemy;
    [SerializeField] private GameObject poweUp;

    //[SerializeField] private float startDelay = 2f;
    //[SerializeField] private float spawnInterval = 4f;

    private float spawnLimit = 8f;

    private int enemiesInScene;

    private int enemiesPerWave = 1;

    private PlayerController playerController;

    void Start()
    {

        playerController = FindFirstObjectByType<PlayerController>();

        SpawnEnemyWave(enemiesPerWave);

        Instantiate(poweUp,
               RandomSpawnPos(),
               Quaternion.identity);
    }

    private void Update()
    {

        enemiesInScene = FindObjectsOfType<Enemy>().Length;
        if (enemiesInScene <= 0)
        {
            enemiesPerWave++;
            if (!playerController.GetIsGameOver())
            {
                SpawnEnemyWave(enemiesPerWave);
            }
            
        }

    }

    private Vector3 RandomSpawnPos()
    {
        float x = Random.Range(-spawnLimit, spawnLimit);
        float z = Random.Range(-spawnLimit, spawnLimit);

        return new Vector3(x, 0, z) ;

    }

    private void SpawnEnemyWave(int enemiesToSpawn)
    {
        for (int i = 0; i < enemiesToSpawn; i++)
        {
            Instantiate(enemy,
               RandomSpawnPos(),
               Quaternion.identity);

            enemiesInScene++;

        }
    }

    public void EnemyDestroyed()
    {
        enemiesInScene--;
    }

}
