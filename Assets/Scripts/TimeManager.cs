//using UnityEngine;
//using UnityEngine.SceneManagement; // For loading the Game Over scene
//using TMPro; // For using TextMeshPro

//public class TimerManager : MonoBehaviour
//{
//    public TextMeshProUGUI timerTextMeshPro; // Reference to the TextMeshProUGUI for displaying the timer
//    public float initialTime = 60f; // Starting time in seconds
//    private float currentTime; // Remaining time

//    private void Start()
//    {
//        // Initialize the timer
//        currentTime = initialTime;
//        UpdateTimerText();
//    }

//    private void Update()
//    {
//        // Reduce the timer as the game progresses
//        currentTime -= Time.deltaTime;

//        // Update the timer text
//        UpdateTimerText();

//        // Check if time has run out
//        if (currentTime <= 0f)
//        {
//            currentTime = 0f; // Clamp to 0
//            GameOver(); // Trigger game over logic
//        }
//    }

//    public void AddTime(float timeToAdd)
//    {
//        // Add time to the timer
//        currentTime += timeToAdd;
//        UpdateTimerText();
//    }

//    private void UpdateTimerText()
//    {
//        // Format and update the timer text
//        timerTextMeshPro.text = $"{currentTime:F1}s"; // Display time with one decimal
//    }

//    private void GameOver()
//    {
//        Debug.Log("Game Over! Time ran out.");
//        // Load the Game Over scene (replace "GameOverScene" with your actual scene name)
//        SceneManager.LoadScene("GameOverScene");
//    }
//}



//using UnityEngine;
//using UnityEngine.SceneManagement; // Corrected namespace for SceneManager
//using TMPro; // For using TextMeshPro

//public class TimerManager : MonoBehaviour
//{
//    public TextMeshProUGUI timerTextMeshPro; // Reference to the TextMeshProUGUI for displaying the timer
//    public float initialTime = 60f; // Starting time in seconds
//    private float currentTime; // Remaining time
//    public float decayRate = 0.05f; // Rate at which the time decreases progressively
//    public float maxDecayMultiplier = 2f; // Maximum multiplier for the decay rate

//    private void Start()
//    {
//        // Initialize the timer
//        currentTime = initialTime;
//        UpdateTimerText();
//    }

//    private void Update()
//    {
//        // Reduce the timer as the game progresses, with controlled progressive decay
//        float decayMultiplier = Mathf.Min(1 + (initialTime - currentTime) * decayRate, maxDecayMultiplier);
//        currentTime -= Time.deltaTime * decayMultiplier;

//        // Update the timer text
//        UpdateTimerText();

//        // Check if time has run out
//        if (currentTime <= 0f)
//        {
//            currentTime = 0f; // Clamp to 0
//            GameOver(); // Trigger game over logic
//        }
//    }

//    public void AddTime(float timeToAdd)
//    {
//        // Add time to the timer
//        currentTime += timeToAdd;
//        UpdateTimerText();
//    }

//    private void UpdateTimerText()
//    {
//        // Format and update the timer text
//        timerTextMeshPro.text = $"{currentTime:F1}s"; // Display time with one decimal
//    }

//    private void GameOver()
//    {
//        Debug.Log("Game Over! Time ran out.");
//        // Load the Game Over scene (replace "GameOverScene" with your actual scene name)
//        SceneManager.LoadScene("GameOverScene");
//    }
//}


//using UnityEngine;
//using TMPro; // For using TextMeshPro

//public class TimerManager : MonoBehaviour
//{
//    public TextMeshProUGUI timerTextMeshPro; // Reference to the TextMeshProUGUI for displaying the timer
//    public float initialTime = 60f; // Starting time in seconds
//    private float currentTime; // Remaining time
//    public float decayRate = 0.05f; // Rate at which the time decreases progressively
//    public float maxDecayMultiplier = 2f; // Maximum multiplier for the decay rate
//    public GameObject gameOverPanel; // Reference to the Game Over panel

//    private void Start()
//    {
//        // Initialize the timer
//        currentTime = initialTime;
//        UpdateTimerText();

//        // Ensure the Game Over panel is hidden at the start
//        if (gameOverPanel != null)
//        {
//            gameOverPanel.SetActive(false);
//        }
//    }

//    private void Update()
//    {
//        // Reduce the timer as the game progresses, with controlled progressive decay
//        float decayMultiplier = Mathf.Min(1 + (initialTime - currentTime) * decayRate, maxDecayMultiplier);
//        currentTime -= Time.deltaTime * decayMultiplier;

//        // Update the timer text
//        UpdateTimerText();

//        // Check if time has run out
//        if (currentTime <= 0f)
//        {
//            currentTime = 0f; // Clamp to 0
//            GameOver(); // Trigger game over logic
//        }
//    }

//    public void AddTime(float timeToAdd)
//    {
//        // Add time to the timer
//        currentTime += timeToAdd;
//        UpdateTimerText();
//    }

//    private void UpdateTimerText()
//    {
//        // Format and update the timer text
//        timerTextMeshPro.text = $"{currentTime:F1}s"; // Display time with one decimal
//    }

//    private void GameOver()
//    {
//        Debug.Log("Game Over! Time ran out.");

//        // Pause the game and show the Game Over panel
//        Time.timeScale = 0f; // Freeze the game
//        if (gameOverPanel != null)
//        {
//            gameOverPanel.SetActive(true);
//        }
//    }
//}




using UnityEngine;
using TMPro; // For using TextMeshPro

public class TimerManager : MonoBehaviour
{
    public TextMeshProUGUI timerTextMeshPro; // Reference to the TextMeshProUGUI for displaying the timer
    public float initialTime = 60f; // Starting time in seconds
    private float currentTime; // Remaining time
    public float decayRate = 0.05f; // Rate at which the time decreases progressively
    public float maxDecayMultiplier = 2f; // Maximum multiplier for the decay rate
    public GameObject gameOverPanel; // Reference to the Game Over panel

    private float elapsedTime = 0f; // Tracks total elapsed time for decay calculation

    private void Start()
    {
        // Initialize the timer
        currentTime = initialTime;
        UpdateTimerText();

        // Ensure the Game Over panel is hidden at the start
        if (gameOverPanel != null)
        {
            gameOverPanel.SetActive(false);
        }
    }

    private void Update()
    {
        // Increase elapsed time
        elapsedTime += Time.deltaTime;

        // Calculate the decay multiplier based on elapsed time
        float decayMultiplier = Mathf.Min(1 + elapsedTime * decayRate, maxDecayMultiplier);

        // Reduce the timer
        currentTime -= Time.deltaTime * decayMultiplier;

        // Update the timer text
        UpdateTimerText();

        // Check if time has run out
        if (currentTime <= 0f)
        {
            currentTime = 0f; // Clamp to 0
            GameOver(); // Trigger game over logic
        }
    }

    public void AddTime(float timeToAdd)
    {
        // Add time to the timer
        currentTime += timeToAdd;
        UpdateTimerText();
    }

    private void UpdateTimerText()
    {
        // Format and update the timer text
        timerTextMeshPro.text = $"{currentTime:F1}s"; // Display time with one decimal
    }

    private void GameOver()
    {
        Debug.Log("Game Over! Time ran out.");

        // Pause the game and show the Game Over panel
        Time.timeScale = 0f; // Freeze the game
        if (gameOverPanel != null)
        {
            gameOverPanel.SetActive(true);
        }
    }
}



