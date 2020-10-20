using UnityEngine;
using Mirror;

public class EnemyManager : NetworkBehaviour
{
    //public PlayerHealth playerHealth;
    public GameObject enemy;
    public float spawnTime = 3f;
    public Transform[] spawnPoints;


    void Start ()
    {
        GameObject Player = GameObject.Find("Player");
        PlayerHealth playerHealth = Player.GetComponent<PlayerHealth>();
        InvokeRepeating ("Spawn", spawnTime, spawnTime);
    }


    void Spawn ()
    {
        PlayerHealth playerHealth = gameObject.GetComponent<PlayerHealth>();
        if (playerHealth.currentHealth <= 0f)
        {
            Debug.Log("NoEnemies");
            return;
        }

        int spawnPointIndex = Random.Range (0, spawnPoints.Length);

        Instantiate (enemy, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
    }
}
