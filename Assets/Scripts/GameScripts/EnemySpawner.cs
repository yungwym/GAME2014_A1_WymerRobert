using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{

    [SerializeField] List<Transform> enemyPrefabs;
    [SerializeField] Transform spawnPoint;

    private float timeBetweenWaves = 5.0f;
    private float countDown = 2.0f;
    private int waveNum = 1;

    // Start is called before the first frame update
    void Start()
    {
     
        
    }

    // Update is called once per frame
    void Update()
    {
        if (countDown <= 0f)
        {
            StartCoroutine(SpawnEnemyWave());
            countDown = timeBetweenWaves;
        }
        countDown -= Time.deltaTime;
    }

    IEnumerator SpawnEnemyWave()
    {
        for (int i = 0; i < waveNum; i++)
        {
            SpawnEnemy();
            yield return new WaitForSeconds(1.0f);
        }
        waveNum++;
    }

    void SpawnEnemy()
    {
        int spawnIndex = Random.Range(0, 2);

        Instantiate(enemyPrefabs[spawnIndex], spawnPoint.position, spawnPoint.rotation);
    }
}
