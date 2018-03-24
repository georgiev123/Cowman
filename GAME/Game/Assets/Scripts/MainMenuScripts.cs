using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScripts : MonoBehaviour {
    public void StartFunc()
    {
        SceneManager.LoadScene("LevelMenu");
    }
    public void QuitFunc()
    {
        Application.Quit();
    }
}
