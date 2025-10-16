using UnityEngine;

public class TimeResetter : MonoBehaviour
{
    private void Awake()
    {
        // Ensure the game is running at normal speed when the scene starts
        Time.timeScale = 1f;
    }
}
    