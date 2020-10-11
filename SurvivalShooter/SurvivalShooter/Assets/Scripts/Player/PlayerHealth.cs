using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEditor;

public class PlayerHealth : MonoBehaviour
{
    public int Player = 1;

    public AudioClip HeartBeatClip;
    public AudioClip HurtClip;
    public AudioClip menu;


    /*public int startingHealth2 = 100;
    public int currentHealth2;

    public Slider healthSlider2;*/

    public int startingHealth = 100;
    public int currentHealth;
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


    void Awake ()
    {

        anim = GetComponent <Animator> ();
        playerAudio = GetComponent <AudioSource> ();
        playerAudio.clip = menu;
        playerAudio.loop = false;
        playerMovement = GetComponent <PlayerMovement> ();
        playerShooting = GetComponentInChildren <PlayerShooting> ();
        currentHealth = startingHealth;
    }


    void Update ()
    {
        if(damaged)
        {
            damageImage.color = flashColour;
        }
        else
        {
            damageImage.color = Color.Lerp (damageImage.color, Color.clear, flashSpeed * Time.deltaTime);
        }
        damaged = false;
    }


    public void TakeDamage (int amount)
    {
        damaged = true;


        currentHealth -= amount;

        healthSlider.value = currentHealth;

        playerAudio.clip = HurtClip;
        playerAudio.Play();


        if (currentHealth <= 30)
        {
            playerAudio.clip = HeartBeatClip;
            playerAudio.loop = true;
            playerAudio.Play();
        }

        if (currentHealth <= 0 && !isDead)
        {
            Death();
        }

    }


    void Death ()
    {
        Time.timeScale = 0.26f;
        isDead = true;

        playerShooting.DisableEffects ();

        anim.SetTrigger ("Die");

        playerAudio.clip = deathClip;
        playerAudio.loop = false;
        playerAudio.Play ();

        playerMovement.enabled = false;
        playerShooting.enabled = false;
    }


    public void RestartLevel ()
    {
        SceneManager.LoadScene (0);
    }


    /*currentHealth2 -= amount;

            healthSlider2.value = currentHealth2;

            playerAudio.clip = HurtClip;
            playerAudio.Play();*/
}
