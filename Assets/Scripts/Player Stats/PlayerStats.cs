using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerStats : MonoBehaviour
{
    [SerializeField] private float maxHealth;

    private float currentHealth;

    public HealthBar healthBar;

    //keycode timer script
    public KeyCode keyToHold = KeyCode.F;
    public float holdTime = 3.0f; // Adjust this value to set the hold time in seconds

    private bool isKeyHeld = false;
    private float timer = 0f;

    private void Start()
    {

        currentHealth = maxHealth;

        healthBar.SetSliderMax(maxHealth);
    }

    public void TakeDamage(float amount)
    {
        currentHealth -= amount;
        healthBar.SetSlider(currentHealth);
    }

    public void HealPlayer(float amount)
    {
        currentHealth += amount;
        healthBar.SetSlider(currentHealth);
    }

    void Update()
    {

        if(currentHealth > maxHealth)
        {
            currentHealth = maxHealth;
        }

        if(currentHealth <= 0)
        {
            SceneManager.LoadScene(3);
        }

        if (Input.GetKeyDown(KeyCode.K))
        {
            TakeDamage(20f);
        }
        //timer for heal
        if (Input.GetKeyDown(keyToHold))
        {
            isKeyHeld = true;
            timer = 0f;
        }

        if (Input.GetKey(keyToHold))
        {
            if (isKeyHeld)
            {
                timer += Time.deltaTime;

                // Check if the key has been held for the specified time
                if (timer >= holdTime)
                {
                    // Call the function you want to initiate
                    InitiateFunction();
                    isKeyHeld = false; // Reset the flag
                }
            }
        }

        if (Input.GetKeyUp(keyToHold))
        {
            isKeyHeld = false;
            timer = 0f; // Reset the timer if the key is released
        }
    }

    void InitiateFunction()
    {
        HealPlayer(20f);
    }
}

