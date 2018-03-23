using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class YouDiedButtons : MonoBehaviour {
	public void TryAgain(){
		Time.timeScale = 1f;
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
	}
	public void Back_to_Levels(){
		Time.timeScale = 1f;
		SceneManager.LoadScene(1);
	}
	public void QuitMainMenu(){
		Time.timeScale = 1f;
		SceneManager.LoadScene(0);
	}
}