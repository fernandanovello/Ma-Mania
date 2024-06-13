using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour
{
    public int score;
    public int lives = 3;
    public float gameTime = 100f;
    private bool gameOver = false;
   // public UIManager uiManager;

    void Start()
    {
        // Inicialização do jogo
        //uiManager.UpdateLives(lives);
        //uiManager.UpdateScore(score);
        StartCoroutine(GameTimer());
    }

    void Update()
    {
        if (gameOver) return;
        // Verificar condições de vitória e derrota
    }

    public void AddScore(int points)
    {
        score += points;
        //uiManager.UpdateScore(score);
        if (score >= 300) // 20 maçãs vermelhas
        {
            WinGame();
        }
    }

    public void LoseLife()
    {
        lives--;
        //uiManager.UpdateLives(lives);
        if (lives <= 0)
        {
            GameOver();
        }
    }

    private void WinGame()
    {
        gameOver = true;
        //uiManager.ShowWinScreen();
    }

    private void GameOver()
    {
        gameOver = true;
        //uiManager.ShowGameOverScreen(score);
    }

    private IEnumerator GameTimer()
    {
        while (gameTime > 0)
        {
            yield return new WaitForSeconds(1);
            gameTime--;
            //uiManager.UpdateTimer(gameTime);
        }
        if (!gameOver)
        {
            GameOver();
        }
    }
}