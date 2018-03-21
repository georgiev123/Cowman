using UnityEngine;
using System.Collections;

public class CactusDamage: MonoBehaviour
{
    //attached to cactus

    public int damage = 10;

    GameObject player;
    Health playerHealth;

    GameObject HM;
    HeartManagment heartManager;


    void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        playerHealth = player.GetComponent<Health>();

        HM = GameObject.FindGameObjectWithTag("MainCamera");
        heartManager = HM.GetComponent<HeartManagment>();
    }



    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject == player)
        {
            heartManager.Hide();
        }
    }
  
 }
   
