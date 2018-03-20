using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour {


    GameObject player;
    Health playerHealth;




    void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        playerHealth = player.GetComponent<Health>();
    }




    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag=="colliderForBullets")
        {
            playerHealth.Respawn();
        }
    }
}

