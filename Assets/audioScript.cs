using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioScript : MonoBehaviour
{
    // Start is called before the first frame update
    private bool muted = false;
    void Start()
    {
        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
     if (Input.GetKeyUp(KeyCode.T))
        {
            if (!muted)
            {
                gameObject.GetComponent<AudioSource>().mute = true;
                muted = true;

            } else if (muted)
            {
                gameObject.GetComponent<AudioSource>().mute = false;
                muted = false;

            }
        }   
    }
}
