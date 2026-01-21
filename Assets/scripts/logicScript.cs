using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class logicScript : MonoBehaviour
{
    public int score;
    public int highestScore;
    public Text scoreText;
    public Text highScoreText;
    public GameObject gameOverScreen;
    public bool gameIsOver = false;


    void Start()
    {
        highestScore = PlayerPrefs.GetInt("HighScore", 0);
        highScoreText.text = "HIGH SCORE: " + highestScore;
    }

    [ContextMenu("Increase score")]
    public void addScore(int points)
    {
        if (gameIsOver) return;
        score += points;
        scoreText.text = score.ToString();

    }

    public void restartGame()
    {
        SceneManager.LoadScene(1);

    }
    public void gameOver()
    {

        gameIsOver = true;

        if (score > highestScore)
        {
            highestScore = score;
            PlayerPrefs.SetInt("HighScore", highestScore);
            PlayerPrefs.Save();
        }

        highScoreText.text = "HIGH SCORE: " + highestScore;
        gameOverScreen.SetActive(true);
    }

}
