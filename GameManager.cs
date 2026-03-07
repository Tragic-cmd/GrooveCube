using UnityEngine;
using UnityEngine.SceneManagement; // Used to change to a different scene or reload the scene we are already on.

public class GameManager : MonoBehaviour
{

    bool gameHasEnded = false;

    public float restartDelay = 1f;

    public GameObject completeLevelUI;
    public GameObject settingsMenuUI;

    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true);
    }

    // End the game
    public void EndGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("Game over.");
            Invoke("Restart", restartDelay);
        }
    }

    // Pause the game
    void Update()
    {
        if (Input.GetKeyDown("escape"))
        {
            Time.timeScale = 0;
            settingsMenuUI.SetActive(true);
        }
    }

    // Resume the game
    public void ResumeLevel()
    {
        settingsMenuUI.SetActive(false);
        Time.timeScale = 1;
    }

    // Restart the game
    public void Restart()
    {
        settingsMenuUI.SetActive(false);
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
