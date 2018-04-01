using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UpgradeMenuButtons : MonoBehaviour {

	public void Resume() {
		string sceneName = PlayerPrefs.GetString("lastLoadedScene");
		SceneManager.LoadScene(sceneName);
	}
}