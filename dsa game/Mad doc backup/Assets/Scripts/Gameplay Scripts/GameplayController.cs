using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameplayController : MonoBehaviour
{
    public static GameplayController instance;

    [SerializeField]
    private TextMeshProUGUI enemyKillCountTxt;
    private int enemyKillCount;

    private void Awake()
    {
        if (instance == null)
            instance = this;
    }

    public void EnemyKilled()
    {
        enemyKillCount++;
        enemyKillCountTxt.text = "Enemies Killed: " + enemyKillCount;
    }

    public void RestartGame()
    {
        Invoke("Restart", 3f);
    }

    void Restart()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("MadDoc");
    }
}
