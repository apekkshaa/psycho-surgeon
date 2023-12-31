using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField]
    private float heath = 100f;
    private PlayerMovement playerMovement;

    [SerializeField]
    private Slider healthSlider;

    [SerializeField]
    private Timer timer;

    private void Awake()
    {
        playerMovement = GetComponent<PlayerMovement>();
        timer = FindObjectOfType<Timer>();
    }

    private void Update()
    {
        if (timer != null && timer.GetRemainingTime() <= 0)
        {
            // Player dies when the timer reaches zero
            PlayerDied();
            GameplayController.instance.RestartGame();
        }
    }

    public void TakeDamage(float damageAmount)
    {
        if (heath <= 0f)
            return;

        heath -= damageAmount;

        if (heath <= 0)
        {
            //inform that the player has died
            playerMovement.PlayerDied();

            GameplayController.instance.RestartGame();
        }
        healthSlider.value = heath;
    }

    private void PlayerDied()
    {
        playerMovement.PlayerDied();
        GameplayController.instance.RestartGame();
    }
}
