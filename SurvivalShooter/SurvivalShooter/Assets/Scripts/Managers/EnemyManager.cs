using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    bool playerActive6;

    public PlayerHealth2 playerHealth2;

    public PlayerHealth playerHealth;
    public GameObject enemy;
    public float spawnTime = 3f;
    public Transform[] spawnPoints;


    void Start ()
    {
        InvokeRepeating ("Spawn", spawnTime, spawnTime);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            playerActive6 = true;
        }
    }

    void Spawn ()
    {
        if (playerHealth.currentHealth <= 0f)
        {
            if (playerActive6 == false)
            {
                return;
            }
            else if (playerHealth2.currentHealth2 <= 0f)
            {
                return;
            }
        }

        

        int spawnPointIndex = Random.Range (0, spawnPoints.Length);

        Instantiate (enemy, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
    }

}
