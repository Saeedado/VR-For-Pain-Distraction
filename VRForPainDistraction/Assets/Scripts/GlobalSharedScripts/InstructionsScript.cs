using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstructionsScript : MonoBehaviour
{
    public GameObject videoPlayer;
    public GameObject headTracking;
    public GameObject fullBody;
    public GameObject instructionsHome;
    private bool active = true;




    private void Start()
    {
        instructionsHome.SetActive(active);
        videoPlayer.SetActive(!active);
        headTracking.SetActive(!active);
        fullBody.SetActive(!active);
    }
    /// <summary>
    /// Switch to the video player scene
    /// </summary>
    public void SwitchToVideoPlayer()
    {
        instructionsHome.SetActive(!active);
        videoPlayer.SetActive(active);
        headTracking.SetActive(!active);
        fullBody.SetActive(!active);
    }



    /// <summary>
    /// Switch to the Full body firing range scene
    /// </summary>
    public void SwitchToFullBody()
    {
        instructionsHome.SetActive(!active);
        videoPlayer.SetActive(!active);
        headTracking.SetActive(!active);
        fullBody.SetActive(active);
    }

    /// <summary>
    /// Switch to the head tracking shooter scene
    /// </summary>
    public void SwitchToHeadTrackingFPS()
    {
        instructionsHome.SetActive(!active);
        videoPlayer.SetActive(!active);
        headTracking.SetActive(active);
        fullBody.SetActive(!active);
    }


    /// <summary>
    /// Switch to the Instructions scene
    /// </summary>
    public void SwitchToInstructionsHome()
    {
        instructionsHome.SetActive(active);
        videoPlayer.SetActive(!active);
        headTracking.SetActive(!active);
        fullBody.SetActive(!active);
    }

}
