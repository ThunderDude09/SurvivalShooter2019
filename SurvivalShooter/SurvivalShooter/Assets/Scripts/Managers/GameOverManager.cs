using System.Threading;
using UnityEngine;

public class GameOverManager : MonoBehaviour
{
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
        /*if (playerHealth.currentHealth <= 0)
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

            }
            
        }*/
    }
}
