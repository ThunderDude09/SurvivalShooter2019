using UnityEngine;
using System.Collections;

public class EnemyAttack : MonoBehaviour
{
    public float timeBetweenAttacks = 0.5f;
    public int attackDamage = 10;

    GameObject player2;
    PlayerHealth2 playerHealth2;
    bool playerInRange2;

    Animator anim;
    GameObject player;
    PlayerHealth playerHealth;
    EnemyHealth enemyHealth;
    bool playerInRange;
    float timer;


    void Awake ()
    {
        player2 = GameObject.FindGameObjectWithTag("Player2");
        playerHealth2 = player2.GetComponent<PlayerHealth2>();

        player = GameObject.FindGameObjectWithTag ("Player");
        playerHealth = player.GetComponent <PlayerHealth> ();
        enemyHealth = GetComponent<EnemyHealth>();
        anim = GetComponent <Animator> ();
    }


    void OnTriggerEnter (Collider other)
    {
        if(other.gameObject == player)
        {
            playerInRange = true;
        }
        if(other.gameObject == player2)
        {
            playerInRange2 = true;
        }
    }


    void OnTriggerExit (Collider other)
    {
        if(other.gameObject == player)
        {
            playerInRange = false;
        }
        if (other.gameObject == player2)
        {
            playerInRange2 = false;
        }
    }


    void Update ()
    {
        timer += Time.deltaTime;

        if(timer >= timeBetweenAttacks && playerInRange && enemyHealth.currentHealth > 0)
        {
            Attack ();
        }

        if (timer >= timeBetweenAttacks && playerInRange2 && enemyHealth.currentHealth > 0)
        {
            Attack2();
        }

        if (playerHealth.currentHealth <= 0)
        {
            if(playerHealth2.currentHealth2 <=0)
            {
                anim.SetTrigger("PlayerDead");
            }
            
        }
    }


    void Attack ()
    {
        timer = 0f;

        if (playerHealth.currentHealth > 0)
        {
            playerHealth.TakeDamage2 (attackDamage);
        }
    }
    void Attack2()
    {
        timer = 0f;
        if (playerHealth2.currentHealth2 > 0)
        {
            playerHealth2.TakeDamage(attackDamage);
        }
    }
}
