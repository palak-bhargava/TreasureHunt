using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonClickEvents : MonoBehaviour
{

    public void QuitGame ( ) {
        Application.Quit ( );
    }

    public void StartGame ( ) {
        SceneManager.LoadScene ( "Game_Screen" );
    }
}
