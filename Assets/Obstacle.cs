using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Obstacle : MonoBehaviour
{

    public float speed;
    // Start is called before the first frame update
    void OnTriggerEnter2D(Collider2D other)
    {

        Debug.Log("hit");
        if (other.CompareTag("Player"))
        {
            other.GetComponent<Player>().health--;
            SceneManager.LoadScene("GameOver");
            Debug.Log("aaaa");
            Destroy(gameObject);
        } else if (other.name == "ObstacleSpeedAway")
        {
            speed *= 5;
        } else if (other.name == "ScoreManager")
        {
            other.GetComponent<ScoreManager>().score += 0.5f;
        }
    }

    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }
}
