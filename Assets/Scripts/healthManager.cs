using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class healthManager : MonoBehaviour {
    public static healthManager instance;

    public Text healthText;

    public Text scoreText;
    public Text highScoreText;

    int health = 5;

    public GameObject explosionPrefab;

    void Awake() {
        if (instance) {
            Destroy(this.gameObject);
        } else {
            instance = this;
        }
        UpdateHealth();
    }

    public void ChangeHealth(int amount) {
        health += amount;
        UpdateHealth();
    }

    void UpdateHealth() {
        if (health <= 0) { GameOver(); return; }
        healthText.text = "Health: " + health.ToString();
    }

    void GameOver() {
        healthText.text = "Health: 0";
        Instantiate(explosionPrefab, transform.position, explosionPrefab.transform.rotation);
        Destroy(this.gameObject);

        scoreText.transform.parent.parent.gameObject.SetActive(true);

        int score = scoreManager.instance.GetCurrentScore();
        scoreText.text = score.ToString();

        int highScore = PlayerPrefs.GetInt("HighScore", 0);
        if (score > highScore) {
            highScore = score;
            PlayerPrefs.SetInt("HighScore", highScore);
        }
        highScoreText.text = highScore.ToString();
    }
}
