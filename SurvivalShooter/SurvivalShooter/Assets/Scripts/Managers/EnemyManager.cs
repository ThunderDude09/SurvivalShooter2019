﻿using UnityEngine;
using Mirror;

public class EnemyManager : NetworkBehaviour
{
    Transform player;
    PlayerHealth playerHealth;

    //public PlayerHealth playerHealth;
    public GameObject enemy;
    public float spawnTime = 3f;
    public Transform[] spawnPoints;


    void Start ()
    {
        InvokeRepeating ("Spawn", spawnTime, spawnTime);
    }

    void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        playerHealth = player.GetComponent<PlayerHealth>();
    }


    void Spawn ()
    {
        /*if(playerHealth.currentHealth <= 0f)
        {
            return;
        }*/

        int spawnPointIndex = Random.Range (0, spawnPoints.Length);

        Instantiate (enemy, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
    }
}
