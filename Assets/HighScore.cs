using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        GameObject highScore = GameObject.Find("ScoreManager");
        float currentHighScore = highScore.GetComponent<ScoreManager>().highScore;
        gameObject.GetComponent<Text>().text =  "High Score: " + currentHighScore.ToString();
        PlayerPrefs.SetFloat("HighScore", currentHighScore);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
