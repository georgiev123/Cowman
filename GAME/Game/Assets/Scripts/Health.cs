using UnityEngine;
using UnityEngine.UI;
using System.Collections;

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
        gameObject.transform.position = WhereToSpawn.position;
        heartManager.Show();
    }



}
