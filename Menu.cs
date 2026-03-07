using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{

    public GameObject settingsMenuUI;
    public GameObject levelsMenuUI;
    public void LevelsMenu()
    {
        settingsMenuUI.SetActive(false);
        levelsMenuUI.SetActive(true);
    }
    public void CloseLevelsMenu()
    {
        levelsMenuUI.SetActive(false);
        settingsMenuUI.SetActive(true);
    }

    public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void BackToMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Main Menu");
    }

    public void Level1()
    {
        SceneManager.LoadScene("Level 1");
    }

    public void Level2()
    {
        SceneManager.LoadScene("Level 2");
    }

    public void Level3()
    {
        SceneManager.LoadScene("Level 3");
    }

    public void Level4()
    {
        SceneManager.LoadScene("Level 4");
    }

    public void Level5()
    {
        SceneManager.LoadScene("Level 5");
    }

    public void Level6()
    {
        SceneManager.LoadScene("Level 6");
    }

    public void Level7()
    {
        SceneManager.LoadScene("Level 7");
    }

    public void Level8()
    {
        SceneManager.LoadScene("Level 8");
    }

    public void Level9()
    {
        SceneManager.LoadScene("Level 9");
    }

    public void Level10()
    {
        SceneManager.LoadScene("Level 10");
    }

    public void Level11()
    {
        SceneManager.LoadScene("Level 11");
    }

    public void Level12()
    {
        SceneManager.LoadScene("Level 12");
    }

    public void Level13()
    {
        SceneManager.LoadScene("Level 13");
    }

    public void Level14()
    {
        SceneManager.LoadScene("Level 14");
    }

    public void Level15()
    {
        SceneManager.LoadScene("Level 15");
    }

    public void Level16()
    {
        SceneManager.LoadScene("Level 16");
    }

    public void Level17()
    {
        SceneManager.LoadScene("Level 17");
    }

    public void Level18()
    {
        SceneManager.LoadScene("Level 18");
    }
}
