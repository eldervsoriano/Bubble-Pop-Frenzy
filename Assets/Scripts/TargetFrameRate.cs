using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetFrameRate : MonoBehaviour

{
    private void Start()
    {
        // Lock the frame rate to 60 FPS
        Application.targetFrameRate = 60;

        // Disable VSync for better control over frame rate
        QualitySettings.vSyncCount = 0;
    }
}
