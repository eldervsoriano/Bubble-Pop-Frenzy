////using UnityEngine;
////using TMPro; // Import TextMeshPro namespace

////public class ScoreManager : MonoBehaviour
////{
////    public TextMeshProUGUI scoreTextMeshPro; // Reference to the TextMeshProUGUI component
////    private int score = 0;

////    // Increment the score and update the display
////    public void AddScore(int points)
////    {
////        score += points;
////        scoreTextMeshPro.text = score.ToString(); // Only display the numeric score
////    }
////}


//using UnityEngine;
//using TMPro; // Import TextMeshPro namespace

//public class ScoreManager : MonoBehaviour
//{
//    public TextMeshProUGUI scoreTextMeshPro; // Reference to the TextMeshProUGUI component
//    public TextMeshProUGUI bestScoreTextMeshPro; // Reference to the TextMeshProUGUI for displaying the best score
//    private int score = 0;
//    private int bestScore = 0;

//    private void Start()
//    {
//        // Load the best score from PlayerPrefs
//        bestScore = PlayerPrefs.GetInt("BestScore", 0);
//        UpdateBestScoreText();
//    }

//    // Increment the score and update the display
//    public void AddScore(int points)
//    {
//        score += points;
//        scoreTextMeshPro.text = score.ToString(); // Only display the numeric score

//        // Check if the current score exceeds the best score
//        if (score > bestScore)
//        {
//            bestScore = score;
//            PlayerPrefs.SetInt("BestScore", bestScore); // Save the best score
//            UpdateBestScoreText();
//        }
//    }

//    private void UpdateBestScoreText()
//    {
//        // Update the best score display
//        if (bestScoreTextMeshPro != null)
//        {
//            bestScoreTextMeshPro.text = bestScore.ToString();
//        }
//    }

//    private void OnDestroy()
//    {
//        // Save the best score when this script is destroyed
//        PlayerPrefs.Save();
//    }
//}



using UnityEngine;
using TMPro; // Import TextMeshPro namespace

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI scoreTextMeshPro; // Reference to the first TextMeshProUGUI component
    public TextMeshProUGUI scoreTextMeshProPanel2; // Reference to the second TextMeshProUGUI component for another panel
    public TextMeshProUGUI bestScoreTextMeshPro; // Reference to the TextMeshProUGUI for displaying the best score

    private int score = 0;
    private int bestScore = 0;

    private void Start()
    {
        // Load the best score from PlayerPrefs
        bestScore = PlayerPrefs.GetInt("BestScore", 0);
        UpdateBestScoreText();
    }

    // Increment the score and update the display
    public void AddScore(int points)
    {
        score += points;
        UpdateScoreText();

        // Check if the current score exceeds the best score
        if (score > bestScore)
        {
            bestScore = score;
            PlayerPrefs.SetInt("BestScore", bestScore); // Save the best score
            UpdateBestScoreText();
        }
    }

    private void UpdateScoreText()
    {
        // Update both score displays
        if (scoreTextMeshPro != null)
        {
            scoreTextMeshPro.text = score.ToString();
        }
        if (scoreTextMeshProPanel2 != null)
        {
            scoreTextMeshProPanel2.text = score.ToString();
        }
    }

    private void UpdateBestScoreText()
    {
        // Update the best score display
        if (bestScoreTextMeshPro != null)
        {
            bestScoreTextMeshPro.text = bestScore.ToString();
        }
    }

    private void OnDestroy()
    {
        // Save the best score when this script is destroyed
        PlayerPrefs.Save();
    }
}









//using UnityEngine;
//using TMPro; // Import TextMeshPro namespace

//public class ScoreManager : MonoBehaviour
//{
//    public TextMeshProUGUI scoreTextMeshPro; // Reference to the TextMeshProUGUI component
//    public TextMeshProUGUI bestScoreTextMeshPro; // Reference to the TextMeshProUGUI for displaying the best score
//    public TextMeshProUGUI gameOverScoreTextMeshPro; // Reference to the TextMeshProUGUI for displaying the current score in the Game Over panel
//    private int score = 0;
//    private int bestScore = 0;

//    private void Start()
//    {
//        // Load the best score from PlayerPrefs
//        bestScore = PlayerPrefs.GetInt("BestScore", 0);
//        UpdateBestScoreText();
//    }

//    // Increment the score and update the display
//    public void AddScore(int points)
//    {
//        score += points;
//        scoreTextMeshPro.text = score.ToString(); // Only display the numeric score

//        // Check if the current score exceeds the best score
//        if (score > bestScore)
//        {
//            bestScore = score;
//            PlayerPrefs.SetInt("BestScore", bestScore); // Save the best score
//            UpdateBestScoreText();
//        }
//    }

//    public void ShowGameOverScore()
//    {
//        // Update the current score on the Game Over panel
//        if (gameOverScoreTextMeshPro != null)
//        {
//            gameOverScoreTextMeshPro.text = "Score: " + score.ToString();
//        }
//    }

//    private void UpdateBestScoreText()
//    {
//        // Update the best score display
//        if (bestScoreTextMeshPro != null)
//        {
//            bestScoreTextMeshPro.text = "Best: " + bestScore.ToString();
//        }
//    }

//    private void OnDestroy()
//    {
//        // Save the best score when this script is destroyed
//        PlayerPrefs.Save();
//    }
//}



//using UnityEngine;
//using TMPro; // Import TextMeshPro namespace

//public class ScoreManager : MonoBehaviour
//{
//    [Header("UI References")]
//    public TextMeshProUGUI scoreTextMeshPro; // In-game score display
//    public TextMeshProUGUI bestScoreTextMeshPro; // Best score display
//    public TextMeshProUGUI gameOverScoreTextMeshPro; // Game Over panel current score display

//    [Header("Game Scores")]
//    private int score = 0; // Current score
//    private int bestScore = 0; // Best score

//    private void Start()
//    {
//        // Load the best score from PlayerPrefs at the start of the game
//        bestScore = PlayerPrefs.GetInt("BestScore", 0);
//        UpdateBestScoreText();
//    }

//    /// <summary>
//    /// Adds points to the current score and updates the score display.
//    /// </summary>
//    /// <param name="points">Points to add to the current score.</param>
//    public void AddScore(int points)
//    {
//        score += points;
//        UpdateScoreText();

//        // Check if the new score is a high score
//        if (score > bestScore)
//        {
//            bestScore = score;
//            PlayerPrefs.SetInt("BestScore", bestScore); // Save the new best score
//            UpdateBestScoreText();
//        }
//    }

//    /// <summary>
//    /// Displays the current score on the Game Over panel.
//    /// </summary>
//    public void ShowGameOverScore()
//    {
//        if (gameOverScoreTextMeshPro != null)
//        {
//            gameOverScoreTextMeshPro.text = $"Current Score: {score}";
//        }
//        else
//        {
//            Debug.LogWarning("Game Over Score TextMeshPro is not assigned!");
//        }
//    }

//    /// <summary>
//    /// Activates the Game Over panel and updates the Game Over score display.
//    /// </summary>
//    /// <param name="gameOverPanel">The Game Over panel GameObject.</param>
//    public void TriggerGameOver(GameObject gameOverPanel)
//    {
//        ShowGameOverScore(); // Update the score before showing the panel

//        if (gameOverPanel != null)
//        {
//            gameOverPanel.SetActive(true);
//        }
//        else
//        {
//            Debug.LogWarning("Game Over panel is not assigned!");
//        }
//    }

//    /// <summary>
//    /// Updates the in-game score display.
//    /// </summary>
//    private void UpdateScoreText()
//    {
//        if (scoreTextMeshPro != null)
//        {
//            scoreTextMeshPro.text = score.ToString();
//        }
//        else
//        {
//            Debug.LogWarning("Score TextMeshPro is not assigned!");
//        }
//    }

//    /// <summary>
//    /// Updates the best score display.
//    /// </summary>
//    private void UpdateBestScoreText()
//    {
//        if (bestScoreTextMeshPro != null)
//        {
//            bestScoreTextMeshPro.text = $"Best: {bestScore}";
//        }
//        else
//        {
//            Debug.LogWarning("Best Score TextMeshPro is not assigned!");
//        }
//    }

//    private void OnDestroy()
//    {
//        // Save PlayerPrefs when the script or game object is destroyed
//        PlayerPrefs.Save();
//    }
//}
