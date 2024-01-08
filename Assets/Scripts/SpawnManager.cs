using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    [SerializeField] private GameObject enemy;
    [SerializeField] private GameObject poweUp;

    [SerializeField] private float startDelay = 2f;
    [SerializeField] private float spawnInterval = 4f;

    private float spawnLimit = 8f;

    void Start()
    {
        Instantiate(enemy,
               RandomSpawnPos(),
               Quaternion.identity);

        Instantiate(poweUp,
               new Vector3(0,0,3),
               Quaternion.identity);
    }

    private Vector3 RandomSpawnPos()
    {
        float x = Random.Range(-spawnLimit, spawnLimit);
        float z = Random.Range(-spawnLimit, spawnLimit);

        return new Vector3(x, 0, z) ;

    }
}
