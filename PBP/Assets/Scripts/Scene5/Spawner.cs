using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject prefabToSpawn;
    [SerializeField] private Transform[] spawnPoints;
    [SerializeField] private float minTimeBwtSpawn;
    [SerializeField] private float maxTimeBwtSpawn;
    [SerializeField] private float radius;
    private float timeBwtSpawn;
    private float timeInterval;


    private void Start()
    {
        timeBwtSpawn = Random.Range(minTimeBwtSpawn,maxTimeBwtSpawn);
       
    }

    private void Update()
    {
        
        if (timeBwtSpawn <= 0)
        {
            SpawnPrefab();
            timeBwtSpawn = Random.Range(minTimeBwtSpawn, maxTimeBwtSpawn);
        }
        else
        {
            timeBwtSpawn -= Time.deltaTime;
        }
    }

    private void SpawnPrefab()
    {
        Transform spawnPoint = GetRandomSpawnPoint();

        if (spawnPoint != null)
        {
            Collider[] colliders = Physics.OverlapSphere(spawnPoint.position, radius);

            if (colliders.Length == 0)
            {
                Instantiate(prefabToSpawn, spawnPoint.position, Quaternion.identity);
            }
            else
            {
                SpawnPrefab();
            }
        }
    }

    private Transform GetRandomSpawnPoint()
    {
        if (spawnPoints.Length > 0)
        {
            int randomIndex = Random.Range(0, spawnPoints.Length);
            return spawnPoints[randomIndex];
        }

        return null;
    }
}
