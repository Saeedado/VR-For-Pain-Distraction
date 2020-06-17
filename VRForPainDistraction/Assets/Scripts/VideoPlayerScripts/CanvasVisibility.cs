using UnityEngine;

public class CanvasVisibility : MonoBehaviour
{
    public GameObject canvas;
    bool isEnabled = true;
    public OVRInput.Button canvasSwitch;

    /// <summary>
    /// Update is called every frame
    /// If canvasSwitch button is pressed
    /// the canvas is toggled
    /// disabled if it is enabled vise versa
    /// </summary>
    void Update()
    {

        if (OVRInput.GetDown(canvasSwitch) && isEnabled)
        {
            DisableCanvas();
        }
        else if (OVRInput.GetDown(canvasSwitch) && !isEnabled)
        {
            EnableCanvas();
        }
    }


    /// <summary>
    /// Disables User Interface
    /// </summary>
    void DisableCanvas()
    {
        isEnabled = false;
        canvas.SetActive(isEnabled);

    }

    /// <summary>
    /// Enables User Interface
    /// </summary>
    void EnableCanvas()
    {
        isEnabled = true;
        canvas.SetActive(isEnabled);

    }
}