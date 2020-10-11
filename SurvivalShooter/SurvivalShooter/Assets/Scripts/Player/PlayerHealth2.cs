using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEditor;

public class PlayerHealth2 : MonoBehaviour
{
    public int PlayerIndex3 = 1;

    //public int startingHealth2 = 100;
    //public int currentHealth2;

    public AudioClip HeartBeatClip;
    public AudioClip HurtClip;
    public AudioClip menu;

    public int startingHealth2 = 100;
    public int currentHealth2;
    public Slider healthSlider;
    public Image damageImage;
    public AudioClip deathClip;
    public float flashSpeed = 5f;
    public Color flashColour = new Color(1f, 0f, 0f, 0.1f);


    Animator anim;
    AudioSource playerAudio;
    PlayerMovement playerMovement;
    PlayerShooting playerShooting;
    bool isDead;
    bool damaged;


    void Awake()
    {

        anim = GetComponent<Animator>();
        playerAudio = GetComponent<AudioSource>();
        playerAudio.clip = menu;
        playerAudio.loop = false;
        playerMovement = GetComponent<PlayerMovement>();
        playerShooting = GetComponentInChildren<PlayerShooting>();

        currentHealth2 = startingHealth2;
    }


    void Update()
    {

        if (PlayerIndex3 == 2)
        {
            if (damaged)
            {
                damageImage.color = flashColour;
            }
            else
            {
                damageImage.color = Color.Lerp(damageImage.color, Color.clear, flashSpeed * Time.deltaTime);
            }
            damaged = false;
        }

    }


    public void TakeDamage(int amount)
    {
        if (PlayerIndex3 == 2)
        {
            damaged = true;


            currentHealth2 -= amount;

            healthSlider.value = currentHealth2;

            playerAudio.clip = HurtClip;
            playerAudio.Play();


            if (currentHealth2 <= 30)
            {
                playerAudio.clip = HeartBeatClip;
                playerAudio.loop = true;
                playerAudio.Play();
            }

            if (currentHealth2 <= 0 && !isDead)
            {
                Death();
            }
        }

    }

    void Death()
    {
        //Time.timeScale = 0.26f;
        isDead = true;

        playerShooting.DisableEffects();

        anim.SetTrigger("Die");

        playerAudio.clip = deathClip;
        playerAudio.loop = false;
        playerAudio.Play();

        playerMovement.enabled = false;
        playerShooting.enabled = false;
    }

}