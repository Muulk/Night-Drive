using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatingBG : MonoBehaviour
{
    public float backgroundSpeed;
    public float endX, startX;

    // Start is called before the first frame update
    void Start()
    {

    }

    void Update()
    {
        GameObject spawner = GameObject.Find("Spawner");
        backgroundSpeed = spawner.GetComponent<Spawner>().currentSpeed;

        transform.Translate(Vector2.left * backgroundSpeed * Time.deltaTime);

        if (transform.position.x <= endX)
        {
            Vector3 pos = new Vector3(startX, transform.position.y, transform.position.z);

            transform.position = pos;
    
        }       

    }
    /*GameObject spawner = GameObject.Find("Spawner");

    backgroundSpeed = spawner.GetComponent<Spawner>().currentSpeed;

    transform.Translate(Vector2.left * backgroundSpeed * Time.deltaTime);

    if (transform.position.x <= endX)
    {
        Vector3 pos = new Vector3(startX, transform.position.y, transform.position.z);

        transform.position = pos;*/

}
