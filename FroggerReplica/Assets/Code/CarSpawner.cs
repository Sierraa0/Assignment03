using UnityEngine;

public class CarSpawner : MonoBehaviour
{
    public float spawnDelay = .3f;

    float nextTimeToSpawn = 0f;

    public GameObject car;

    public Transform[] spawnPoints;

    //float countDownTimer = 3f;

    /*void Start()
    {
        InvokeRepeating("SpawnCar", 0f, 3f);
    }*/

    void Update()
    {
        /*if (countDownTimer <= 0f)
        {
            SpawnCar();
            countDownTimer = 3f;
        } else
        {
            countDownTimer -= Time.deltaTime;
        }*/

        if (nextTimeToSpawn <= Time.time)
        {
            SpawnCar();
            nextTimeToSpawn = Time.time + spawnDelay;
        }
    }

    void SpawnCar()
    {
        int randomIndex = Random.Range(0, spawnPoints.Length);
        Transform spawnPoint = spawnPoints[randomIndex];

        Instantiate(car, spawnPoint.position, spawnPoint.rotation);
    }
}
