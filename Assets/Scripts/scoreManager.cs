using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreManager : MonoBehaviour {
    public static scoreManager instance;

    public Text scoreText;
    int score;

    void Awake() {
        if (instance) {
            Destroy(this.gameObject);
        } else {
            instance = this;
        }
        UpdateScore();
    }

    public void IncreaseScore(int amount) {
        score += amount;
        UpdateScore();
    }

    public int GetCurrentScore() {
        return score;
    }

    void UpdateScore() {
        scoreText.text = "Score: " + score.ToString();
    }
}
