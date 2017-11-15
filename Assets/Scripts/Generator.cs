using UnityEngine.UI;
using UnityEngine;
using System.Collections;

public class Generator : MonoBehaviour {

    public Text scoreText;
    public Text highScore;
    private int score;

    public GameObject player;

    public float delay = 2f;
    public GameObject Rock;
    

    // Use this for initialization
    void Start () {

        score = 0;
        InvokeRepeating("Spawn", delay, delay);

	}

    private void Update()
    {
        if (player == null)
        {
            CancelInvoke();
        }
    }


    void Spawn () {

        Instantiate(Rock, new Vector3(Random.Range(-35, -21), 10, -54.7f), Quaternion.identity);
        
	}

    public void AddScore(int newScore)
    {
        score += newScore;
        UpdateScore();
    }

    void UpdateScore()
    {
        scoreText.text = "Score: " + score;

        if (score > PlayerPrefs.GetInt("HighScore"))
        {
            PlayerPrefs.SetInt("HighScore", score);
        }
        highScore.text = "High Score is " + PlayerPrefs.GetInt("HighScore", 0);
    }
}
