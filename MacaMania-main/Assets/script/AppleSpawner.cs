using UnityEngine;
using System.Collections;

public class AppleSpawner : MonoBehaviour
{
    public GameObject applePrefab;          // Prefab para maçã vermelha
    public GameObject goldenApplePrefab;    // Prefab para maçã dourada
    public GameObject rottenFruitPrefab;    // Prefab para fruta podre

    // Frequências de spawn
    public float appleFrequency = 0.7f;       // 70% de chance de maçã vermelha
    public float goldenAppleFrequency = 0.2f; // 20% de chance de maçã dourada
    public float rottenFruitFrequency = 0.1f; // 10% de chance de fruta podre

    void Start()
    {
        StartCoroutine(SpawnApples());
    }

    private IEnumerator SpawnApples()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(0.5f, 2f));
            Vector3 spawnPosition = new Vector3(Random.Range(-7f, 7f), transform.position.y, 0);

            float randomValue = Random.value;
            GameObject appleToSpawn;

            if (randomValue < appleFrequency)
            {
                appleToSpawn = applePrefab; // Maçã vermelha
            }
            else if (randomValue < appleFrequency + goldenAppleFrequency)
            {
                appleToSpawn = goldenApplePrefab; // Maçã dourada
            }
            else
            {
                appleToSpawn = rottenFruitPrefab; // Fruta podre
            }

            Instantiate(appleToSpawn, spawnPosition, Quaternion.identity);
        }
    }
}
