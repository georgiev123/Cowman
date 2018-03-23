using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class Health: MonoBehaviour
{   //attached to player
    //accesed only if player needs to die imediately or to respawn


    public Transform WhereToSpawn;

    GameObject HM;
    HeartManagment heartManager;

    void Awake()
    {
        HM = GameObject.FindGameObjectWithTag("MainCamera");
        heartManager = HM.GetComponent<HeartManagment>();
    }

    public void Respawn()
    {
		SceneManager.LoadScene (4);
    }



}
