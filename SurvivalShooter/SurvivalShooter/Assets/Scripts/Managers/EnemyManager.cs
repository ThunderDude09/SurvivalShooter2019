using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public bool playerActive2 = false;

    public PlayerHealth2 playerHealth2;

    public PlayerHealth playerHealth;
    public GameObject enemy;
    public float spawnTime = 3f;
    public Transform[] spawnPoints;


    void Start ()
    {
        InvokeRepeating ("Spawn", spawnTime, spawnTime);
    }


    void Spawn ()
    {
        if (playerHealth.currentHealth <= 0f)
        {
            if (playerHealth2.currentHealth2 <= 0f & playerActive2 == false)
            {
                return;
            }
            else if (playerActive2 == true)
            {
                return;
            }
        }

        int spawnPointIndex = Random.Range (0, spawnPoints.Length);

        Instantiate (enemy, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
    }
    public void Spawned3()
    {
        playerActive2 = true;
    }
}
