using UnityEngine;

public class Collectible : MonoBehaviour
{
    public int points = 15;  // Pontos padrão para maçã vermelha
    private GameManager gameManager;

    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            if (gameObject.CompareTag("GoldenApple"))
            {
                gameManager.AddScore(0); // Atualize para a lógica correta (caso haja uma pontuação específica)
                // Lógica específica para maçã dourada
                //gameManager.AddGoldenApple(); // Método que adiciona uma maçã dourada capturada
            }
            else if (gameObject.CompareTag("RottenFruit"))
            {
                gameManager.LoseLife();
            }
            else
            {
                gameManager.AddScore(points); // Pontuação padrão para maçãs vermelhas
            }
            Destroy(gameObject);
        }
    }
}
