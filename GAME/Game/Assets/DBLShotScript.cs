using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DBLShotScript : MonoBehaviour {

	public GameObject image;
	void OnMouseOver(){
		image.SetActive(true);
	}
	void OnMouseExit(){
		image.SetActive (false);
	}
}
