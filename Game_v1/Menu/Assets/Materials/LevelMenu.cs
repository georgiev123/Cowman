using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class LevelMenu : MonoBehaviour {
	public void TutorialStarter() {
		Debug.Log ("Tutorial");
		SceneManager.LoadScene (2);
	}
	public void Level1_Starter() {
		Debug.Log ("Level1");
		SceneManager.LoadScene (-1);
	}
	public void Level2_Starter() {
		Debug.Log ("Level 2");
		SceneManager.LoadScene (-1);
	}
	public void Level3_Starter(){
		Debug.Log ("Level 3");
		SceneManager.LoadScene (-1);
	}
	public void Level4_Starter(){
		Debug.Log ("Level 4");
		SceneManager.LoadScene (-1);
	}
	public void Level5_Starter(){
		Debug.Log ("Level 5");
		SceneManager.LoadScene (-1);
	}
}
