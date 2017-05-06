using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameSceneController : MonoBehaviour
{
    public Player player;
    public GameObject enemyPrefab;
    public float enemyCountdown = 2f;

    public float minimunEnemyCountdown = 1f;

    private float enemyTimer;

    public Text gameText;
    private float gameTimer;

    private bool isGameOver;

    void Start()
    {

    }

    void Update()
    {
        gameClock();
        spawnEnemy();
        checkIfGameIsOver();
    }

    void spawnEnemy()
    {
        enemyTimer -= Time.deltaTime;
        if (enemyTimer <= 0 && player != null)
        {
            enemyTimer = enemyCountdown;

            enemyCountdown *= 0.9f;

            if (enemyCountdown < minimunEnemyCountdown)
            {
                enemyCountdown = minimunEnemyCountdown;
            }

            Vector3[] spawnPositions = new Vector3[]
            {
                new Vector3(13, 6, 0),
                new Vector3(-13, -6, 0),
                new Vector3(13, -6, 0),
                new Vector3(-13, 6, 0)
            };

            foreach(var spawnPosition in spawnPositions)
            {
                GameObject enemyObject = Instantiate(enemyPrefab);
                enemyObject.transform.position = spawnPosition;

                enemyObject.transform.SetParent(this.transform);

                Enemy enemy = enemyObject.GetComponent<Enemy>();
                enemy.movementDirection = (player.transform.position - spawnPosition).normalized;
            }
        }
    }

    void gameClock()
    {
        if(player != null)
        {
            gameTimer += Time.deltaTime;
            gameText.text = "Time: " + Mathf.Floor(gameTimer);
        }
    }

    void checkIfGameIsOver()
    {
        if (player == null)
        {
            if (!isGameOver)
            {
                isGameOver = true;

                gameText.text += "\nGame Over, press R to restart.";
            }

            restartGame();
        }
    }

    void restartGame()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene("GameScene");
        }
    }
}
