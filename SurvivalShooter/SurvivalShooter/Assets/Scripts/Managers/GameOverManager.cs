using UnityEngine;
using Mirror;

public class GameOverManager : NetworkBehaviour
{
    Transform player;
    PlayerHealth playerHealth;

    //public PlayerHealth playerHealth;
	public float restartDelay = 5f;


    Animator anim;
	float restartTimer;


    void Awake()
    {
        player = GameObject.Find("Player").transform;
        playerHealth = player.GetComponent<PlayerHealth>();

        anim = GetComponent<Animator>();
    }


    void Update()
    {
        if (playerHealth.currentHealth <= 0)
        {
            anim.SetTrigger("GameOver");

			restartTimer += Time.deltaTime;

			if (restartTimer >= restartDelay) {
				Application.LoadLevel(Application.loadedLevel);
			}
        }
    }
}
