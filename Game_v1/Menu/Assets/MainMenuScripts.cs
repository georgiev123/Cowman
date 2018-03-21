using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScripts : MonoBehaviour {
    public void StartFunc()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(1);
    }
    public void QuitFunc()
    {
        Time.timeScale = 1f;
        Debug.Log("MemeReview");
        Application.Quit();
    }
}
