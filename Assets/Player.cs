using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;


public class Player : MonoBehaviour
{
    private Vector2 targetPos;
    public int speed, health;
    public AudioClip move;
    private AudioSource audioSource;

    public float maxHeight, minHeight, minLight, maxLight, lightIncrement;
    public GameObject flashlight;
    // Start is called before the first frame update
    void Start()
    {
        flashlight = GameObject.Find("Flashlight");
        flashlight.GetComponent<Light2D>().pointLightOuterRadius = maxLight;
        targetPos = new Vector2(-7, 0);
        audioSource = gameObject.GetComponent<AudioSource>();
        GameObject scoreManager = GameObject.Find("ScoreManager");
        scoreManager.GetComponent<ScoreManager>().score = 0;

    }

    public void chargeLight()
    {
        flashlight.GetComponent<Light2D>().pointLightOuterRadius = maxLight;

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, targetPos, speed*Time.deltaTime);
        if (Input.GetKeyDown(KeyCode.UpArrow) && transform.position.y < maxHeight)
        {
            targetPos = new Vector2(transform.position.x, transform.position.y + 3);
            //audioSource.PlayOneShot(move, 0.1f);
          if (flashlight.GetComponent<Light2D>().pointLightOuterRadius > minLight)
            {
                flashlight.GetComponent<Light2D>().pointLightOuterRadius -= lightIncrement;
            }  

        }
        else if (Input.GetKeyDown(KeyCode.DownArrow) && transform.position.y > minHeight)
        {
            targetPos = new Vector2(transform.position.x, transform.position.y - 3);
            //audioSource.PlayOneShot(move, 0.1f);

            if (flashlight.GetComponent<Light2D>().pointLightOuterRadius > minLight)
            {
                flashlight.GetComponent<Light2D>().pointLightOuterRadius -= lightIncrement;
            }
        }
    }


}
