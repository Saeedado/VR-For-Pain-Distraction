using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class VideoPlayerController : MonoBehaviour
{
    public Dropdown dropdown;
    List<string> videoNames;
    public VideoPlayer videoPlayer;
    public VideoClip[] videoClip;
    int videoPlayerIndex;

    public Slider timeSlider;
    public Slider seekSlider;

    float increasePlayback = 1f;
    float decreasePlayback = 0.1f;
    float maxIncrease = 3;
    float minDecrease = 0.3f;
    float skipTime = 10;



    /// <summary>
    /// Start is called before the first frame update
    /// Initializes the drop down menu with video options
    /// </summary>
    void Start()
    {
        videoNames = new List<string>() { "Please Select a Video" };
        PopulateDropdown();

    }


    /// <summary>
    /// Update is called every frame
    /// If the video is not ready, nothing will happen
    /// The time slider will move with the video time
    /// </summary>
    private void Update()
    {
        if (!IsPrepared())
        {
            return;
        }
        timeSlider.value = (float)NTime();

    }


    /// <summary>
    /// The drop down menu is populated with the names
    /// of video clips that have been added to the scene
    /// </summary>
    void PopulateDropdown()
    {
        foreach (VideoClip vc in videoClip)
        {
            videoNames.Add(vc.ToString());
        }

        dropdown.AddOptions(videoNames);
    }


    /// <summary>
    /// When a different drop down menu item is selected
    /// the video is changed associated with that menu item begins to play
    /// </summary>
    /// <param name="index"></param>
    public void DropDownChanged(int index)
    {
        videoPlayerIndex = index;
        if (index != 0)
        {
            videoPlayer.clip = videoClip[index - 1];
            videoPlayer.Play();
        }
        // Recalibrates the seek slider for the new video
        seekSlider.minValue = 0f;
        seekSlider.maxValue = 0.99f;

    }


    /// <summary>
    /// When the seek slider is moved,
    /// the time of the video is moved to 
    /// correspond with the seek slider
    /// </summary>
    public void MoveSlider()
    {
        Seek(seekSlider.value);
    }


    /// <summary>
    /// Pauses the video and resets the playback speed
    /// </summary>
    public void PauseVideo()
    {
        if (!IsPrepared())
            return;
        videoPlayer.Pause();
        videoPlayer.playbackSpeed = 1;
    }


    /// <summary>
    /// Plays the video and resets the playback speed
    /// </summary>
    public void PlayVideo()
    {
        if (!IsPrepared())
            return;
        videoPlayer.Play();
        videoPlayer.playbackSpeed = 1;
    }


    /// <summary>
    /// Restarts the current video
    /// </summary>
    public void RestartVideo()
    {
        DropDownChanged(videoPlayerIndex);

        Seek(0);
    }


    /// <summary>
    /// Changes the point in time of the video
    /// </summary>
    /// <param name="nTime"> float, between 0-1</param>
    void Seek(float nTime)
    {
        if (!videoPlayer.canSetTime)
            return;
        if (!IsPrepared())
            return;
        nTime = Mathf.Clamp(nTime, 0, 1);

        /*
         * nTime is multiplied by the duration of the current video
         * this will set the time of the video to it's real value
         */
        videoPlayer.time = nTime * Duration();
    }


    /// <summary>
    /// Increases the speed at which the video plays
    /// </summary>
    public void IncreaseVideoPlayerPlaybackSpeed()
    {

        if (!videoPlayer.canSetPlaybackSpeed) return;

        //if max playback speed is reached you can increase playback speed by anymore
        if (videoPlayer.playbackSpeed >= maxIncrease) return;


        if (videoPlayer.playbackSpeed < increasePlayback)
        {
            videoPlayer.playbackSpeed += decreasePlayback;
        }
        else
        {
            videoPlayer.playbackSpeed += increasePlayback;
        }

        videoPlayer.playbackSpeed = Mathf.Clamp(videoPlayer.playbackSpeed, 0, 10);
    }


    /// <summary>
    /// Reduces the playback speed of the video
    /// </summary>
    public void ReduceVideoPlayerPlaybackSpeed()
    {
        if (!videoPlayer.canSetPlaybackSpeed) return;

        // if min decrease is reached you cant decrease playback by anymore
        if (videoPlayer.playbackSpeed <= -minDecrease)
            return;

        if (videoPlayer.playbackSpeed <= increasePlayback)
        {
            videoPlayer.playbackSpeed -= decreasePlayback;
        }
        else
        {
            videoPlayer.playbackSpeed -= increasePlayback;
        }

        videoPlayer.playbackSpeed = Mathf.Clamp(videoPlayer.playbackSpeed, 0, 10);
    }


    /// <summary>
    /// Skips forward in the video by a number of seconds
    /// </summary>
    public void SkipForward()
    {
        videoPlayer.time += skipTime;
    }

    /// <summary>
    /// Skips backwards in the video by a number of seconds
    /// </summary>
    public void SkipBack()
    {
        videoPlayer.time -= skipTime;
    }


    /// <summary>
    /// Checks to see if the video is ready
    /// </summary>
    /// <returns> A bool, if a video is ready </returns>
    bool IsPrepared()
    {
        return videoPlayer.isPrepared;
    }


    /// <summary>
    /// Gets the current time of the video that is playing
    /// </summary>
    /// <returns> A double, the current time of the video that is playing</returns>
    double Time()
    {
        return videoPlayer.time;
    }


    /// <summary>
    /// Gets the length of the video that is playing
    /// </summary>
    /// <returns>A ulong, the duration of the current video</returns>
    ulong Duration()
    {
        return videoPlayer.frameCount / (ulong)videoPlayer.frameRate;
    }


    /// <summary>
    /// Returns the time of the video as a value between 0-1
    /// </summary>
    /// <returns>A double, a value between 0-1 which represents the current time the video is at</returns>
    double NTime()
    {
        return Time() / Duration();
    }
}
