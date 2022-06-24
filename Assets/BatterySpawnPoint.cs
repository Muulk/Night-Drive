using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatterySpawnPoint : MonoBehaviour
{
    public GameObject battery;
    // Start is called before the first frame update
    void Start()
    {
        GameObject spawner = GameObject.Find("Spawner");

        battery.GetComponent<Battery>().speed = spawner.GetComponent<Spawner>().currentSpeed;

        Instantiate(battery, transform.position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
