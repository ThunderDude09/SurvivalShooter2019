using System.Threading;
using UnityEngine;

public class GameOverManager : MonoBehaviour
{
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
        if (Input.GetKeyDown(KeyCode.T))
        {
            gameOver1();
        }
        else
        {
            gameOver2();
        }
    }

    void gameOver1()
    {
        if (playerHealth.currentHealth <= 0)
        {
            if (playerHealth2.currentHealth2 <= 0)
            {
                anim.SetTrigger("GameOver");

                restartTimer += Time.deltaTime;

                if (restartTimer >= restartDelay)
                {
                    Application.LoadLevel(Application.loadedLevel);
                }

                /*if (playerHealth2.currentHealth <= 0)
                {

                }*/

                /*if(playerCount == 2)
                {

                }*/

            }
        }
    }
    void gameOver2()
    {
        if (playerHealth.currentHealth <= 0)
        {
            anim.SetTrigger("GameOver");

            restartTimer += Time.deltaTime;

            if (restartTimer >= restartDelay)
            {
                Application.LoadLevel(Application.loadedLevel);
            }

            /*if (playerHealth2.currentHealth <= 0)
            {

            }*/

            /*if(playerCount == 2)
            {

            }*/
        }
    }
}
