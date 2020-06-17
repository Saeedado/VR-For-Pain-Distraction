using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// Allows switching betweens scenes when certain conditions are met inide the application
/// </summary>
public class SwitchScene : MonoBehaviour
{
    /// <summary>
    /// Update is called every frame
    /// If the start button is pressed on the controller
    /// switch to the main menu scene
    /// </summary>
    private void Update()
    {
        if (OVRInput.GetDown(OVRInput.Button.Start))
        {
            SwitchToMainMenu();
        }
    }

    /// <summary>
    /// Switch to the video player scene
    /// </summary>
    public void SwitchToVideoPlayer()
    {
        SceneManager.LoadScene("VideoPlayerScene");
    }

    /// <summary>
    /// Switch to the main menu scene
    /// </summary>
    public void SwitchToMainMenu()
    {
        SceneManager.LoadScene("MainMenuScene");
    }

    /// <summary>
    /// Switch to the Full body firing range scene
    /// </summary>
    public void SwitchToFullBody()
    {
        SceneManager.LoadScene("FullBodyScene");
    }

    /// <summary>
    /// Switch to the head tracking shooter scene
    /// </summary>
    public void SwitchToHeadTrackingFPS()
    {
        SceneManager.LoadScene("HeadTrackingScene");
    }


    /// <summary>
    /// Switch to the Instructions scene
    /// </summary>
    public void SwitchToInstructions()
    {
        SceneManager.LoadScene("InstructionsScene");
    }


}
