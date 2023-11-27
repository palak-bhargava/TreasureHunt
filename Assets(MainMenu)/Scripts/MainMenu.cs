using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void ExitButton()
    {
        Application.Quit();
        Debug.Log("Game Quit");
    }

    public void PlayGame()
    {
       // SceneManager.LoadScene("PUT_THE_NAME_OF_THE_GAME_SCENE_HERE_");
    }

    public void OptionsButton()
    {
        SceneManager.LoadScene("Options");
    }

    public void BackButton()
    {
        SceneManager.LoadScene("MainMenu");
    }

    
}
