using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Rigidbody enemyRigidBody;
    [SerializeField] private float speed = 5f;
    private GameObject player;

    private void Awake()
    {
        enemyRigidBody = GetComponent<Rigidbody>();
    }

    private void Start()
    {
        player = GameObject.Find("Player");
    }

    private void Update()
    {
        Vector3 direction = (player.transform.position - transform.position).normalized;
        enemyRigidBody.AddForce(direction * speed);
    }

}
