using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;
public class PlayerHealth : MonoBehaviour
{
    public int startingHealth = 3;                            // The amount of health the player starts the game with.
    public int currentHealth;                                   // The current health the player has.
    public Slider healthSlider;                                 // Reference to the UI’s health bar.
    public Image damageImage;                                   // Reference to an image to flash on the screen on being hurt.
    public AudioClip damageClip;                                 // The audio clip to play when the player gets damaged.
    public AudioClip deathClip;
    public float flashSpeed = 0.75f;                               // The speed the damageImage will fade at.
    public Color flashColour = new Color(225f, 0f, 16f, 225f);     // The colour the damageImage is set to, to flash.
    AudioSource audioSource;
    Animator anim;                                              // Reference to the Animator component.
    bool isDead;                                                // Whether the player is dead.
    bool damaged;                                               // True when the player gets damaged.
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    void Awake()
    {
        // Setting up the references.
        //playerMovement = GetComponent<PlayerMovement>();
        //playerShooting = GetComponentInChildren<PlayerShooting>();
        // Set the initial health of the player.
        currentHealth = startingHealth;
    }
    void Update()
    {
        // If the player has just been damaged...
        if (damaged)
        {
            // ... set the colour of the damageImage to the flash colour.
            damageImage.color = flashColour;
        }
        // Otherwise...
        else
        {
            // ... transition the colour back to clear.
            damageImage.color = Color.Lerp(damageImage.color, Color.clear, flashSpeed * Time.deltaTime);
        }
        // Reset the damaged flag.
        damaged = false;
    }
    public void TakeDamage(int amount)
    {
        // Set the damaged flag so the screen will flash.
        damaged = true;
        //Plays a sound effect when takes damage
        if (currentHealth > 1)
        {
            audioSource.PlayOneShot(damageClip, 1.0f);
        }
        else
        {
            audioSource.PlayOneShot(deathClip, 1.0f);
        }
        // Reduce the current health by the damage amount.
        currentHealth -= amount;
        // Set the health bar’s value to the current health.
        healthSlider.value = currentHealth;
        // If the player has lost all it’s health and the death flag hasn’t been set yet...
        if (currentHealth <= 0 && !isDead)
        {
            // ... it should die.
            StartCoroutine(Death());
        }
    }
    //void Death()
    //{
    // Set the death flag so this function won’t be called again.
    //isDead = true;
    IEnumerator Death()
    {
        isDead = true;
        Time.timeScale = 0.1f;
        yield return new WaitForSeconds(0.1f);
        //SceneManager.LoadScene(“EnterDetails”);
        SceneManager.LoadScene("intro");
    }
    //}
}