using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject Target;
    public GameObject EnamyPrefab;
    public float Radius;

    public float SpawnTime = 5;
    private float currentTime = 0;


    void Start()
    {
        // >
        // <
        // >=
        // <=
        // ==
        // !=
    }

    void Update()
    {
        CountDownMechanic();
    }
    public void CountDownMechanic()
    {
        currentTime += Time.deltaTime;

        if (currentTime >= SpawnTime)
        {
            SpawnEnemy();
            currentTime = 0;
        }
    }
    public void SpawnEnemy()
    {
        float angle = Random.Range(0, Mathf.PI * 2);

        float x = Target.transform.position.x + (Mathf.Cos(angle) * Radius);
        float y = Target.transform.position.y + Mathf.Sin(angle) * Radius;

        Vector2 spawnPos = new Vector2 (x, y);

        GameObject enemy = Instantiate(EnamyPrefab);
        enemy.transform.position = spawnPos;
            
     }
}
