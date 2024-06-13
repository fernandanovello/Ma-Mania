using UnityEngine;
using UnityEngine.UI; // Adicione esta linha para referenciar os componentes UI

public class UIManager : MonoBehaviour // Descomente e corrija a declaração da classe
{
    public Text scoreText;
    public Text livesText;
    public Text timerText;
    public GameObject winScreen;
    public GameObject gameOverScreen;

    public void UpdateScore(int score)
    {
        scoreText.text = "Score: " + score;
    }

    public void UpdateLives(int lives)
    {
        livesText.text = "Lives: " + lives;
    }

    public void UpdateTimer(float time)
    {
        timerText.text = "Time: " + Mathf.FloorToInt(time).ToString();
    }

    public void ShowWinScreen()
    {
        winScreen.SetActive(true);
    }

    public void ShowGameOverScreen(int score)
    {
        gameOverScreen.SetActive(true);
        // Mostrar pontuação final
    }
}
