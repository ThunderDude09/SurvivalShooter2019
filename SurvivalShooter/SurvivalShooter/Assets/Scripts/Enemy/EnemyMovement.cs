using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour
{
    bool playerActive3 = false;

    Transform player2;
    PlayerHealth2 playerHealth2;

    Transform player;
    PlayerHealth playerHealth;
    EnemyHealth enemyHealth;
    UnityEngine.AI.NavMeshAgent nav;

    //Transform ClosetPlayer;

    void Awake ()
    {
        player2 = GameObject.FindGameObjectWithTag("Player2").transform;
        playerHealth2 = player2.GetComponent<PlayerHealth2>();

        player = GameObject.FindGameObjectWithTag ("Player").transform;
        playerHealth = player.GetComponent <PlayerHealth> ();
        enemyHealth = GetComponent <EnemyHealth> ();
        nav = GetComponent <UnityEngine.AI.NavMeshAgent> ();
    }


    void Update()
    {
        if (enemyHealth.currentHealth > 0 && playerHealth.currentHealth > 0)
        {
            nav.SetDestination(player.position);
        }
        else if (enemyHealth.currentHealth > 0 && playerHealth2.currentHealth2 > 0 && playerActive3 == true)
        {
            nav.SetDestination(player2.position);
        }
        else if (playerActive3 == false)
        {
            nav.enabled = false;
        }

        if (Input.GetKeyDown(KeyCode.T))
        {
            nav.enabled = true;
            playerActive3 = true;
        }
    }
}
