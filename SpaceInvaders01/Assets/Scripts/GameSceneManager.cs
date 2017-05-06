using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameSceneManager : MonoBehaviour {

    public Camera mainCamera;
    public Text scoreText;
    public Text gameOverText;
    public PlayerController player;
    public EnemyGroupController enemyGroup;

    int score;
    int enemyCount;
    float gameTimer;
    bool gameOver;

    void Start () {
        Time.timeScale = 1;

        player.OnHitEnemy += OnGameOver;
        player.OnKillEnemy += OnKillEnemy;

        enemyCount = enemyGroup.GetComponentsInChildren<EnemyController>().Length;
    }

	void Update () {
		
	}
}
