using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] obstaclePattern;
    GameObject[] obstacles;
    private float timeBetweenSpawn;
    public float startTimeBetweenSpawn, decreaseTime, minTime, currentSpeed, speedIncrement;
    public int maxSpeed, setSpeed;
    private bool oneShot = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timeBetweenSpawn <= 0)
        {
            if (oneShot)
            {
                oneShot = false;
                int rand = Random.Range(0, obstaclePattern.Length);
                Instantiate(obstaclePattern[rand], transform.position, Quaternion.identity);
                timeBetweenSpawn = startTimeBetweenSpawn;
                if (startTimeBetweenSpawn > minTime)
                {
                    startTimeBetweenSpawn -= decreaseTime;

                }
                if (currentSpeed < maxSpeed)
                {
                    currentSpeed += speedIncrement;
                    obstacles = GameObject.FindGameObjectsWithTag("Obstacle");
                    foreach (GameObject obstacle in obstacles)
                    {
                        obstacle.GetComponent<Obstacle>().speed = currentSpeed;
                    }

                }
                oneShot = true;
            }

        } else
        {
            timeBetweenSpawn -= Time.deltaTime;
        }
    }
}
