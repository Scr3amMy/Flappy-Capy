using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LogicScript : MonoBehaviour
{
    public int score;
    public Text scoreText;
    public int highscore;
    public Text highscoreText;
    public GameObject gameoverscreen;
    public AudioSource point;

    void Start()
    {
        Debug.Log("High Score Loaded: " + highscore);
        Debug.Log("Text Set To: " + highscoreText.text);
        highscore = PlayerPrefs.GetInt("HighScore", 0);
        highscoreText.text = highscore.ToString();
    }


    public void IncreaseScore()
    {
        score = score + 1;
        scoreText.text = score.ToString();
        point.Play();
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {
        gameoverscreen.SetActive(true);

        if (score > highscore)
        {
            highscore = score;
            PlayerPrefs.SetInt("HighScore", highscore);
            PlayerPrefs.Save();
        }

        highscoreText.text = highscore.ToString();

    }
}
