using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField]
    private float heath = 100f;
    private Enemy enemyScript;

    [SerializeField]
    private Slider enemyHealthSlider;

    private void Awake()
    {
        enemyScript = GetComponent<Enemy>();
    }

    public void TakeDamage(float damageAmount)
    {
        Debug.Log("Enemy took damage: " + damageAmount);
        if (heath <= 0)
            return;

        heath -= damageAmount;

        if (heath <= 0f)
        {
            heath = 0;
            //kill the enemy
            enemyScript.EnemyDied();

            EnemySpawner.instance.EnemyDied(gameObject);

            GameplayController.instance.EnemyKilled();
        }
        enemyHealthSlider.value = heath;
    }
}
