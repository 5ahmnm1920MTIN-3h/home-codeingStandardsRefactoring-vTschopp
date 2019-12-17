using System.Collections;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public static ObstacleSpawner instance;
    public GameObject[] obstacles;
    public bool gameOver;
    public float minSpawnTime, maxSpawnTime;

    float waitTime = 1f;
    string coroutineSpawn = "Spawn";

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(coroutineSpawn);
    }

    IEnumerator Spawn()
    {
        yield return new WaitForSeconds (waitTime);

        while (!gameOver)
        {
            SpawnObstacle();
            waitTime = Random.Range(minSpawnTime, maxSpawnTime);

            yield return new WaitForSeconds(waitTime);
        }
    }

    void SpawnObstacle()
    {
        int random = Random.Range(0, obstacles.Length); // 0 is okay to use here.
        Instantiate(obstacles[random],transform.position,Quaternion.identity);
    }
}
