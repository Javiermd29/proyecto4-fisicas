using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Rigidbody enemyRigidBody;
    [SerializeField] private float speed = 2.5f;
    private GameObject player;

    private float lowerLimit = -3f;

    private SpawnManager spawnManager;

    private void Awake()
    {
        enemyRigidBody = GetComponent<Rigidbody>();
    }

    private void Start()
    {
        player = GameObject.Find("Player");
        spawnManager = FindObjectOfType<SpawnManager>();
    }

    private void Update()
    {
        GoToPlayer();
        if (transform.position.y < lowerLimit)
        {
            spawnManager.EnemyDestroyed();
            Destroy(gameObject);
        }
    }

    private void GoToPlayer()
    {

        Vector3 direction = (player.transform.position - transform.position).normalized;
        enemyRigidBody.AddForce(direction * speed);

    }

}
