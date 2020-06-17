using UnityEngine;
using UnityEngine.UI;

public class LeaderboardScores : MonoBehaviour
{

    public Text scoreText;
    public Text highScoreText;
    public string environmentScore;
    public string environmentHighScore;
    float score;
    float highScore;

    /// <summary>
    /// Get the scores for this environment and display them
    /// </summary>
    void Start()
    {
        SetHighScore();
        UpdateScoreText();

    }


    /// <summary>
    /// Gets the highscore and score the player recieved
    /// if the score is a new highscore the high score is updated
    /// </summary>
    void SetHighScore()
    {
        score = PlayerPrefs.GetFloat(environmentScore, -50);

        if (PlayerPrefs.GetFloat(environmentHighScore, -50) <= score)
        {
            PlayerPrefs.SetFloat(environmentHighScore, score);
            highScore = PlayerPrefs.GetFloat(environmentHighScore);
        }

        else
        {
            highScore = PlayerPrefs.GetFloat(environmentHighScore, -50);
        }
    }

    /// <summary>
    /// Update display of scores
    /// </summary>
    private void UpdateScoreText()
    {
        scoreText.text = score.ToString();
        highScoreText.text = highScore.ToString();
    }

    /// <summary>
    /// Resets the highscore
    /// </summary>
    public void ResetHighScore()
    {
        PlayerPrefs.SetFloat(environmentHighScore, -50);
        highScore = PlayerPrefs.GetFloat(environmentHighScore, -50);

        UpdateScoreText();
    }

}
