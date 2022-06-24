using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Battery : MonoBehaviour
{
    public float speed;
    public GameObject batterySpawner;
    // Start is called before the first frame update
    void OnTriggerEnter2D(Collider2D other)
    {
        GameObject flashlight = GameObject.Find("Flashlight");

        if (other.CompareTag("Player"))
        {
            other.GetComponent<Player>().chargeLight();
            Destroy(gameObject);
        } else 
        {
            batterySpawner = GameObject.Find("BatterySpawner");
            batterySpawner.GetComponent<BatterySpawner>().timeBetweenSpawn = 0;
            Debug.Log("bink");
            Destroy(gameObject);

        }
    }

    private void OnDestroy()
    {


        //batterySpawner.GetComponent<BatterySpawner>().destroyedOnSpawn = false;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);

    }
}
