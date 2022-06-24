using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    public GameObject obstacle;
    // Start is called before the first frame update
    void Start()
    {
        GameObject spawner = GameObject.Find("Spawner");

        obstacle.GetComponent<Obstacle>().speed = spawner.GetComponent<Spawner>().currentSpeed;

        Instantiate(obstacle, transform.position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
