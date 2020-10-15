using System.Threading;
using UnityEngine;

public class GameOverManager : MonoBehaviour
{
    public bool playerActive9;

    public PlayerHealth2 playerHealth2;

    public PlayerHealth playerHealth;
	public float restartDelay = 5f;

    int count1 = 2;
    Animator anim;
	float restartTimer;


    void Awake()
    {
        anim = GetComponent<Animator>();
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            playerActive9 = true;
        }
        if (playerHealth.currentHealth <= 0)
        {
            if (playerActive9 == false)
            {
                anim.SetTrigger("GameOver");

                restartTimer += Time.deltaTime;

                if (restartTimer >= restartDelay)
                {
                    Application.LoadLevel(Application.loadedLevel);
                }
            }
            else
            {
                if (playerHealth2.currentHealth2 <= 0)
                {
                    anim.SetTrigger("GameOver");

                    restartTimer += Time.deltaTime;

                    if (restartTimer >= restartDelay)
                    {
                        Application.LoadLevel(Application.loadedLevel);
                    }

                }
            }
            
        }
        
    }
}
