using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicManagerScript : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;
    public GameObject gameOverScreen;
    public bool showGameplay = true;

    [ContextMenu("increase score")]
    public void AddScore(int scoreToAdd) {
        playerScore = playerScore + scoreToAdd;
        scoreText.text = playerScore.ToString();
    }

    public void startGame()
    {
        showGameplay = true;
        SceneManager.LoadScene("Gameplay");
    }

    public void restartGame() {
        SceneManager.LoadScene("Gameplay");
    }


    public void gameOver() {
        gameOverScreen.SetActive(true);
    }

    public void quitGame() {
        showGameplay = false;

        SceneManager.LoadScene("MainMenu");

    }

}
