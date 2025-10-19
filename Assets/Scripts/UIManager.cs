using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public GameObject pauseUI;

    public void OnGameRestart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void OnGamePause()
    {
        pauseUI.SetActive(true);
    }

    public void OnGameResume()
    {
        pauseUI.SetActive(false);
    }

    public void OnGameExit()
    {
        #if UNITY_STANDALONE
                    Application.Quit();
        #endif

        #if UNITY_EDITOR
                    UnityEditor.EditorApplication.isPlaying = false;
        #endif
    }
}
