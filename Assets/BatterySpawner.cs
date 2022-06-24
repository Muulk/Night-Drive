using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatterySpawner : MonoBehaviour
{
    public GameObject[] batteryPattern;
    GameObject[] batteries;
    public float timeBetweenSpawn;
    public float startTimeBetweenSpawn, decreaseTime, minTime;
    public int currentSpeed, maxSpeed, setSpeed;
    private bool oneShot = true;

    public bool spawnable = false;
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
                int rand = Random.Range(0, batteryPattern.Length);
                Instantiate(batteryPattern[rand], transform.position, Quaternion.identity);
                Debug.Log("battery spawned");

                timeBetweenSpawn = startTimeBetweenSpawn;
              
                oneShot = true;
            }

        }
        else
        {
            timeBetweenSpawn -= Time.deltaTime;
        }
    }
}
