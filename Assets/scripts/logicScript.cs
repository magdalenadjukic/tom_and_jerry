using UnityEngine;
using UnityEngine.UI;
public class logicScript : MonoBehaviour
{
    public int score;
    public Text scoreText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [ContextMenu("Increase score")]
    public void addScore(int points)
    {
        score += points;
        scoreText.text = score.ToString();
    }
}
