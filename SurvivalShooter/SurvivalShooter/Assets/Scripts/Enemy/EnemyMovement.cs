﻿using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour
{
    /*Transform player2;
    PlayerHealth playerHealth2;*/

    Transform player;
    PlayerHealth playerHealth;
    EnemyHealth enemyHealth;
    UnityEngine.AI.NavMeshAgent nav;


    void Awake ()
    {
        /*player2 = GameObject.FindGameObjectWithTag("Player2").transform;
        playerHealth2 = player2.GetComponent<PlayerHealth>();*/

        player = GameObject.FindGameObjectWithTag ("Player").transform;
        playerHealth = player.GetComponent <PlayerHealth> ();
        enemyHealth = GetComponent <EnemyHealth> ();
        nav = GetComponent <UnityEngine.AI.NavMeshAgent> ();
    }


    void Update ()
    {
        if(enemyHealth.currentHealth > 0 && playerHealth.currentHealth > 0)
        {
            nav.SetDestination (player.position);
        }
        else
        {
            nav.enabled = false;
        }
    }



}
