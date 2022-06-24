using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    // Start is called before the first frame update

    public float score, highScore = 0;
    public GameObject scoreDisplay;

    private void Start()
    {
        DontDestroyOnLoad(gameObject);
        if (PlayerPrefs.HasKey("HighScore"))
        {
            highScore = PlayerPrefs.GetFloat("HighScore");
            Debug.Log(highScore);
        }
    }


    // Update is called once per frame
    void Update()
    {
        if (scoreDisplay == null)
        {
            scoreDisplay = GameObject.Find("ScoreText");
        }
        if (scoreDisplay != null)
        {
            scoreDisplay.GetComponent<Text>().text = score.ToString();
            if (score > highScore)
            {
                highScore = score;
            }
        }

        /*if (Input.GetKeyUp(KeyCode.Escape))
        {
            Application.Quit();
        }*/

    }
}
