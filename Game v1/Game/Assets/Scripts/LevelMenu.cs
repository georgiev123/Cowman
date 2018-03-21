using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class LevelMenu : MonoBehaviour {
	public void TutorialStarter() {
		Debug.Log ("Tutorial");
        Time.timeScale = 1f;
        SceneManager.LoadScene (2);
	}
	public void Level1_Starter() {
		Debug.Log ("Level1");
        Time.timeScale = 1f;
        SceneManager.LoadScene (3);
	}
	public void Level2_Starter() {
		Debug.Log ("Level 2");
        Time.timeScale = 1f;
        SceneManager.LoadScene (-1);
	}
	public void Level3_Starter(){
		Debug.Log ("Level 3");
        Time.timeScale = 1f;
        SceneManager.LoadScene (-1);
	}
	public void Level4_Starter(){
		Debug.Log ("Level 4");
        Time.timeScale = 1f;
        SceneManager.LoadScene (-1);
	}
	public void Level5_Starter(){
		Debug.Log ("Level 5");
        Time.timeScale = 1f;
        SceneManager.LoadScene (-1);
	}
}
