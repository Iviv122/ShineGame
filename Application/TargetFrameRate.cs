using UnityEngine;

public class targetFrameRate : MonoBehaviour
{
    void Start()
    {
        // Limit framerate to cinematic 24fps.
        QualitySettings.vSyncCount = 0; // Set vSyncCount to 0 so that using .targetFrameRate is enabled.
        Application.targetFrameRate = 121;
    }
}