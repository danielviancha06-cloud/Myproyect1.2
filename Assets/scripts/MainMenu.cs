using Unity.VectorGraphics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject optionsMenu;
    public GameObject mainMenu;

    public void OpenOpyionsPanel()

    {
        mainMenu.SetActive(false);
        mainMenu.SetActive(true);
    }

    public void OpenMainMenuPanel()

    {
        mainMenu.SetActive(false);
        mainMenu.SetActive(true);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void playGeme()
    {
        SceneManager.LoadScene("object");
    }

}

