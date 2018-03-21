using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathZone : MonoBehaviour {
    //kills the player if he falls beyound certain level

    GameObject player;
    Health playerHealth;




    void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        playerHealth = player.GetComponent<Health>();
    }

    void Update ()
    {
		
        if(transform.position.y<-3)
        {

           playerHealth.Respawn();

        }

	}

    
}
