using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject pipePrefab;
    public float spawnRate = 2f;
    public float heightOffset = 10f;

    private float timer;

    void Start()
    {
        timer = 0;
    }

    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= spawnRate)
        {
            SpawnPipe();
            timer = 0f;
        }
    }

    void SpawnPipe()
    {
        float lowest = transform.position.y - heightOffset;
        float highest = transform.position.y + heightOffset;
        float y = Random.Range(lowest, highest);

        Instantiate(pipePrefab, new Vector3(transform.position.x, Random.Range(lowest, highest), 0f), Quaternion.identity);
    }
}

