//using UnityEngine;
//using UnityEngine.SceneManagement; // For scene management functions

//public class ButtonManager : MonoBehaviour
//{
//    public GameObject pausePanel;       // Reference to the pause panel GameObject
//    public GameObject settingsPanel;    // Reference to the settings panel GameObject
//    public GameObject guidePanel;       // Reference to the guide panel GameObject
//    public GameObject quitConfirmationPanel; // Reference to the quit confirmation panel GameObject

//    private bool isPaused = false; // Flag to check if the game is paused

//    private void Start()
//    {
//        // Ensure all panels are hidden at the start
//        if (pausePanel != null) pausePanel.SetActive(false);
//        if (settingsPanel != null) settingsPanel.SetActive(false);
//        if (guidePanel != null) guidePanel.SetActive(false);
//        if (quitConfirmationPanel != null) quitConfirmationPanel.SetActive(false);
//    }

//    public void TogglePause()
//    {
//        isPaused = !isPaused;

//        if (isPaused)
//        {
//            // Pause the game and show the pause panel
//            Time.timeScale = 0f; // Freeze the game
//            if (pausePanel != null)
//            {
//                pausePanel.SetActive(true);
//            }
//        }
//        else
//        {
//            // Resume the game and hide the pause panel
//            Time.timeScale = 1f; // Resume the game
//            if (pausePanel != null)
//            {
//                pausePanel.SetActive(false);
//            }
//        }
//    }

//    public void RestartGame()
//    {
//        Debug.Log("Restarting the game...");
//        Time.timeScale = 1f; // Ensure time is running normally
//        SceneManager.LoadScene(SceneManager.GetActiveScene().name); // Restart the current scene
//    }



//    public void OpenSettings()
//    {
//        // Show the settings panel
//        if (settingsPanel != null)
//        {
//            settingsPanel.SetActive(true);
//        }
//    }

//    public void CloseSettings()
//    {
//        // Hide the settings panel
//        if (settingsPanel != null)
//        {
//            settingsPanel.SetActive(false);
//        }
//    }

//    public void OpenGuide()
//    {
//        // Show the guide panel
//        if (guidePanel != null)
//        {
//            guidePanel.SetActive(true);
//        }
//    }

//    public void CloseGuide()
//    {
//        // Hide the guide panel
//        if (guidePanel != null)
//        {
//            guidePanel.SetActive(false);
//        }
//    }

//    public void ShowQuitConfirmation()
//    {
//        // Show the quit confirmation panel
//        if (quitConfirmationPanel != null)
//        {
//            quitConfirmationPanel.SetActive(true);
//        }
//    }

//    public void HideQuitConfirmation()
//    {
//        // Hide the quit confirmation panel
//        if (quitConfirmationPanel != null)
//        {
//            quitConfirmationPanel.SetActive(false);
//        }
//    }

//    public void QuitGame()
//    {
//        Debug.Log("Quitting the game.");
//        Application.Quit();
//    }
//}




//using UnityEngine;
//using UnityEngine.SceneManagement; // For scene management functions

//public class ButtonManager : MonoBehaviour
//{
//    public GameObject pausePanel;       // Reference to the pause panel GameObject
//    public GameObject settingsPanel;    // Reference to the settings panel GameObject
//    public GameObject guidePanel;       // Reference to the guide panel GameObject
//    public GameObject quitConfirmationPanel; // Reference to the quit confirmation panel GameObject

//    private bool isPaused = false; // Flag to check if the game is paused

//    private void Start()
//    {
//        // Ensure all panels are hidden at the start
//        if (pausePanel != null) pausePanel.SetActive(false);
//        if (settingsPanel != null) settingsPanel.SetActive(false);
//        if (guidePanel != null) guidePanel.SetActive(false);
//        if (quitConfirmationPanel != null) quitConfirmationPanel.SetActive(false);
//    }

//    public void TogglePause()
//    {
//        isPaused = !isPaused;

//        if (isPaused)
//        {
//            // Pause the game and show the pause panel
//            Time.timeScale = 0f; // Freeze the game
//            if (pausePanel != null)
//            {
//                pausePanel.SetActive(true);
//            }
//        }
//        else
//        {
//            // Resume the game and hide the pause panel
//            Time.timeScale = 1f; // Resume the game
//            if (pausePanel != null)
//            {
//                pausePanel.SetActive(false);
//            }
//        }
//    }

//    public void RestartGame()
//    {
//        Debug.Log("Restarting the game...");
//        Time.timeScale = 1f; // Ensure time is running normally
//        SceneManager.LoadScene(SceneManager.GetActiveScene().name); // Restart the current scene
//    }

//    public void OpenSettings()
//    {
//        // Show the settings panel
//        if (settingsPanel != null)
//        {
//            settingsPanel.SetActive(true);
//        }
//    }

//    public void CloseSettings()
//    {
//        // Hide the settings panel
//        if (settingsPanel != null)
//        {
//            settingsPanel.SetActive(false);
//        }
//    }

//    public void OpenGuide()
//    {
//        // Show the guide panel
//        if (guidePanel != null)
//        {
//            guidePanel.SetActive(true);
//        }
//    }

//    public void CloseGuide()
//    {
//        // Hide the guide panel
//        if (guidePanel != null)
//        {
//            guidePanel.SetActive(false);
//        }
//    }

//    public void ShowQuitConfirmation()
//    {
//        // Show the quit confirmation panel
//        if (quitConfirmationPanel != null)
//        {
//            quitConfirmationPanel.SetActive(true);
//        }
//    }

//    public void HideQuitConfirmation()
//    {
//        // Hide the quit confirmation panel
//        if (quitConfirmationPanel != null)
//        {
//            quitConfirmationPanel.SetActive(false);
//        }
//    }

//    public void QuitGame()
//    {
//        Debug.Log("Quitting the game.");
//        Application.Quit();
//    }

//    // New Feature: Load a specific scene
//    public void LoadScene(string sceneName)
//    {
//        Debug.Log("Loading scene: " + sceneName);
//        Time.timeScale = 1f; // Ensure time is running normally
//        SceneManager.LoadScene(sceneName); // Load the specified scene
//    }
//}




//using UnityEngine;
//using UnityEngine.SceneManagement; // For scene management functions
//using TMPro; // For handling TextMeshPro

//public class ButtonManager : MonoBehaviour
//{
//    public GameObject pausePanel;       // Reference to the pause panel GameObject
//    public GameObject settingsPanel;    // Reference to the settings panel GameObject
//    public GameObject guidePanel;       // Reference to the guide panel GameObject
//    public GameObject quitConfirmationPanel; // Reference to the quit confirmation panel GameObject
//    public GameObject scorePanel;       // Reference to the score panel GameObject
//    public TextMeshProUGUI scoreText;   // Reference to the TextMeshPro score text

//    private bool isPaused = false; // Flag to check if the game is paused

//    private void Start()
//    {
//        // Ensure all panels are hidden at the start
//        if (pausePanel != null) pausePanel.SetActive(false);
//        if (settingsPanel != null) settingsPanel.SetActive(false);
//        if (guidePanel != null) guidePanel.SetActive(false);
//        if (quitConfirmationPanel != null) quitConfirmationPanel.SetActive(false);
//        if (scorePanel != null) scorePanel.SetActive(false);

//        // Ensure the score text has an event listener if needed
//        if (scoreText != null)
//        {
//            var scoreTextButton = scoreText.GetComponent<UnityEngine.UI.Button>();
//            if (scoreTextButton != null)
//            {
//                scoreTextButton.onClick.AddListener(OpenScorePanel);
//            }
//        }
//    }

//    public void TogglePause()
//    {
//        isPaused = !isPaused;

//        if (isPaused)
//        {
//            // Pause the game and show the pause panel
//            Time.timeScale = 0f; // Freeze the game
//            if (pausePanel != null)
//            {
//                pausePanel.SetActive(true);
//            }
//        }
//        else
//        {
//            // Resume the game and hide the pause panel
//            Time.timeScale = 1f; // Resume the game
//            if (pausePanel != null)
//            {
//                pausePanel.SetActive(false);
//            }
//        }
//    }

//    public void ResumeGame(GameObject currentPanel)
//    {
//        // Resume the game and hide the current panel
//        isPaused = false;
//        Time.timeScale = 1f; // Resume the game
//        if (currentPanel != null)
//        {
//            currentPanel.SetActive(false);
//        }
//    }


//    public void RestartGame()
//    {
//        Debug.Log("Restarting the game...");
//        Time.timeScale = 1f; // Ensure time is running normally
//        SceneManager.LoadScene(SceneManager.GetActiveScene().name); // Restart the current scene
//    }

//    public void OpenSettings()
//    {
//        // Show the settings panel
//        if (settingsPanel != null)
//        {
//            settingsPanel.SetActive(true);
//        }
//    }

//    public void CloseSettings()
//    {
//        // Hide the settings panel
//        if (settingsPanel != null)
//        {
//            settingsPanel.SetActive(false);
//        }
//    }

//    public void OpenGuide()
//    {
//        // Show the guide panel
//        if (guidePanel != null)
//        {
//            guidePanel.SetActive(true);
//        }
//    }

//    public void CloseGuide()
//    {
//        // Hide the guide panel
//        if (guidePanel != null)
//        {
//            guidePanel.SetActive(false);
//        }
//    }

//    public void ShowQuitConfirmation()
//    {
//        // Show the quit confirmation panel
//        if (quitConfirmationPanel != null)
//        {
//            quitConfirmationPanel.SetActive(true);
//        }
//    }

//    public void HideQuitConfirmation()
//    {
//        // Hide the quit confirmation panel
//        if (quitConfirmationPanel != null)
//        {
//            quitConfirmationPanel.SetActive(false);
//        }
//    }

//    public void QuitGame()
//    {
//        Debug.Log("Quitting the game.");
//        Application.Quit();
//    }

//    // New Feature: Open Score Panel
//    public void OpenScorePanel()
//    {
//        if (scorePanel != null)
//        {
//            scorePanel.SetActive(true);
//        }
//    }

//    public void CloseScorePanel()
//    {
//        if (scorePanel != null)
//        {
//            scorePanel.SetActive(false);
//        }
//    }

//    // New Feature: Load a specific scene
//    public void LoadScene(string sceneName)
//    {
//        Debug.Log("Loading scene: " + sceneName);
//        Time.timeScale = 1f; // Ensure time is running normally
//        SceneManager.LoadScene(sceneName); // Load the specified scene
//    }
//}


using UnityEngine;
using UnityEngine.SceneManagement; // For scene management functions
using TMPro; // For handling TextMeshPro

public class ButtonManager : MonoBehaviour
{
    public GameObject pausePanel;       // Reference to the pause panel GameObject
    public GameObject settingsPanel;    // Reference to the settings panel GameObject
    public GameObject guidePanel;       // Reference to the guide panel GameObject
    public GameObject quitConfirmationPanel; // Reference to the quit confirmation panel GameObject
    public GameObject scorePanel;       // Reference to the score panel GameObject
    public TextMeshProUGUI scoreText;   // Reference to the TextMeshPro score text

    private bool isPaused = false; // Flag to check if the game is paused

    private void Start()
    {
        // Ensure all panels are hidden at the start
        if (pausePanel != null) pausePanel.SetActive(false);
        if (settingsPanel != null) settingsPanel.SetActive(false);
        if (guidePanel != null) guidePanel.SetActive(false);
        if (quitConfirmationPanel != null) quitConfirmationPanel.SetActive(false);
        if (scorePanel != null) scorePanel.SetActive(false);

        // Ensure the score text has an event listener if needed
        if (scoreText != null)
        {
            var scoreTextButton = scoreText.GetComponent<UnityEngine.UI.Button>();
            if (scoreTextButton != null)
            {
                scoreTextButton.onClick.AddListener(OpenScorePanel);
            }
        }
    }

    public void TogglePause()
    {
        isPaused = !isPaused;

        if (isPaused)
        {
            // Pause the game and show the pause panel
            Time.timeScale = 0f; // Freeze the game
            if (pausePanel != null)
            {
                pausePanel.SetActive(true);
            }
        }
        else
        {
            // Resume the game and hide the pause panel
            Time.timeScale = 1f; // Resume the game
            if (pausePanel != null)
            {
                pausePanel.SetActive(false);
            }
        }
    }

    public void ResumeGame(GameObject currentPanel)
    {
        // Resume the game and hide the current panel
        isPaused = false;
        Time.timeScale = 1f; // Resume the game
        if (currentPanel != null)
        {
            currentPanel.SetActive(false);
        }
    }

    // New Feature: Resume game and close specific panel
    public void ResumeGameWithPanel(GameObject panelToClose)
    {
        // Resume the game and close the specified panel
        isPaused = false;
        Time.timeScale = 1f; // Resume the game
        if (panelToClose != null)
        {
            panelToClose.SetActive(false);
        }
    }

    public void RestartGame()
    {
        Debug.Log("Restarting the game...");
        Time.timeScale = 1f; // Ensure time is running normally
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); // Restart the current scene
    }

    public void OpenSettings()
    {
        // Show the settings panel
        if (settingsPanel != null)
        {
            settingsPanel.SetActive(true);
        }
    }

    public void CloseSettings()
    {
        // Hide the settings panel
        if (settingsPanel != null)
        {
            settingsPanel.SetActive(false);
        }
    }

    public void OpenGuide()
    {
        // Show the guide panel
        if (guidePanel != null)
        {
            guidePanel.SetActive(true);
        }
    }

    public void CloseGuide()
    {
        // Hide the guide panel
        if (guidePanel != null)
        {
            guidePanel.SetActive(false);
        }
    }

    public void ShowQuitConfirmation()
    {
        // Show the quit confirmation panel
        if (quitConfirmationPanel != null)
        {
            quitConfirmationPanel.SetActive(true);
        }
    }

    public void HideQuitConfirmation()
    {
        // Hide the quit confirmation panel
        if (quitConfirmationPanel != null)
        {
            quitConfirmationPanel.SetActive(false);
        }
    }

    public void QuitGame()
    {
        Debug.Log("Quitting the game.");
        Application.Quit();
    }

    // New Feature: Open Score Panel
    public void OpenScorePanel()
    {
        if (scorePanel != null)
        {
            scorePanel.SetActive(true);
        }
    }

    public void CloseScorePanel()
    {
        if (scorePanel != null)
        {
            scorePanel.SetActive(false);
        }
    }

    // New Feature: Load a specific scene
    public void LoadScene(string sceneName)
    {
        Debug.Log("Loading scene: " + sceneName);
        Time.timeScale = 1f; // Ensure time is running normally
        SceneManager.LoadScene(sceneName); // Load the specified scene
    }
}