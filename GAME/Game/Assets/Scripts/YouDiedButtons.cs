using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class YouDiedButtons : MonoBehaviour {
	
	private  string PreviousScene ;

	public void TryAgain(){
		string sceneName = PlayerPrefs.GetString("lastLoadedScene");
		SceneManager.LoadScene(sceneName);
	}
	public void Back_to_Levels(){
		SceneManager.LoadScene("LevelMenu");
	}
	public void QuitMainMenu(){
		SceneManager.LoadScene("MainMenuScene");
	}
}