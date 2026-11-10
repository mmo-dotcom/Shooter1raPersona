using System;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using static UnityEngine.Rendering.DebugUI;

public class GameController : MonoBehaviour
{
    public TextMeshProUGUI textEnemies;
    public GameObject panelVictory;
    private int enemiesLeft;
    public GameObject message;

    void Start()
    {
        enemiesLeft = GameObject.FindGameObjectsWithTag("enemy").Length;
        panelVictory.SetActive(false);
        textEnemies.text = "Zombies to kill: " + enemiesLeft;
        UpdateUI();
    }
    private void UpdateUI()
    {
        textEnemies.text = "Zombies to kill: " + enemiesLeft;
    }
    void Update()
    {
        EnemiesLefttoKill();
    }
    public void EnemiesLefttoKill()
    {
        enemiesLeft = GameObject.FindGameObjectsWithTag("enemy").Length;
        UpdateUI();
        if (enemiesLeft <= 0)
        {
            Win();
        }
    }
    public void Win()
    {
        panelVictory.SetActive(true);
        message.SetActive(false);
        textEnemies.gameObject.SetActive(false);
        Time.timeScale = 0f;
    }

}