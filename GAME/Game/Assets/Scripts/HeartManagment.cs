using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartManagment: MonoBehaviour
{
    //attached to camera
    //universal controller of player's life and heart display

    GameObject player;
    Health playerHealth;


    GameObject[] toDisable;

    public int maxHearts=3;

    public int currentHeartToHide;

    void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        playerHealth = player.GetComponent<Health>();
        currentHeartToHide = maxHearts;
        toDisable= GameObject.FindGameObjectsWithTag("Heart");


    }



    public void Hide()
    {
        Debug.Log("taking damage");
        toDisable[currentHeartToHide-1].SetActive(false);
        currentHeartToHide--;

        if(currentHeartToHide <= 0)
        {
            playerHealth.Respawn();
            
            
        }

    }

    public void Show()
    {
        currentHeartToHide = maxHearts;

        for(int i = 0; i < maxHearts; i++)
        {
            toDisable[i].SetActive(true);
        }
    }
    public void ShowOne()
    {
        if (currentHeartToHide < maxHearts)
        {
            currentHeartToHide++;
            toDisable[currentHeartToHide-1].SetActive(true);
        }
    }

}