using UnityEngine;
using UnityEngine.SceneManagement;

public class EndRound : MonoBehaviour
{
    [SerializeField]
    string leaderBoardScene;
    [SerializeField]
    string environmentScore;

    /// <summary>
    /// Update is called once per frame
    /// If the end condition is true, switch to the leaderboard
    /// </summary>
    private void Update()
    {
        if (EndCondition())
        {
            SwitchToLeaderboard();
        }
    }


    /// <summary>
    /// Checks if maximum number of targets have been spawned and no targets remain in the scene
    /// </summary>
    /// <returns>bool true if the round is over </returns>
    bool EndCondition()
    {
        SpawnTarget spawnTarget = GameObject.Find("Spawner").GetComponent<SpawnTarget>();
        return (spawnTarget.GetNumberOfCurrentTargets() == 0) && spawnTarget.IsMaxTargetsReached();
    }

    /// <summary>
    /// Switch to LeaderBoard when game is finished
    /// </summary>
    void SwitchToLeaderboard()
    {
        SaveScoreInformation();
        SceneManager.LoadScene(leaderBoardScene);
    }

    /// <summary>
    /// Stores the score information of this game
    /// </summary>
    void SaveScoreInformation()
    {
        PlayerPrefs.SetFloat(environmentScore, GameObject.Find("GameManager").GetComponent<ScoreSystem>().GetScore());

    }
}
