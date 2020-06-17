
using UnityEngine;
using UnityEngine.UI;

public class ScoreSystem : MonoBehaviour
{
    [SerializeField]
    float scoreIncrease;
    [SerializeField]
    float scoreDecrease;
    float score;
    public Text text;

    /// <summary>
    /// Start is called before the first frame update
    /// Initialzes score to 0
    /// </summary>
    private void Start()
    {
        score = 0;
        UpdateScore();
    }


    /// <summary>
    /// Updates display with the current score
    /// </summary>
    public void UpdateScore()
    {
        text.text = score.ToString();
    }

    /// <summary>
    /// Gets the current score
    /// </summary>
    /// <returns> A float, the current score</returns>
    public float GetScore()
    {
        return score;
    }

    /// <summary>
    /// Increases the score by 1
    /// and updates the score display
    /// </summary>
    public void IncrementScore()
    {
        score += scoreIncrease;
        UpdateScore();
    }

    /// <summary>
    /// Decreases the score by one
    /// and updates the score display
    /// </summary>
    public void DecrementScore()
    {
        score -= scoreDecrease;
        UpdateScore();
    }


}
