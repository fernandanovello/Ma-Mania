using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float gameTime = 210f; // 3.5 minutes
    public UIManager uiManager;

    void Start()
    {
        StartCoroutine(GameTimer());
    }

    private IEnumerator GameTimer()
    {
        while (gameTime > 0)
        {
            yield return new WaitForSeconds(1);
            gameTime--;
            uiManager.UpdateTimer(gameTime); // Atualiza o timer na UI
        }
        // Lógica para quando o tempo acabar
    }
}
