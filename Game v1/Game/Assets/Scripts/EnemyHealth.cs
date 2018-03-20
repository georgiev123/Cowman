using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour {
    //attached to enemy
    //controlls enemy's health

    public int health=2;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "bullet")
        {
            health--;
        }
    }

    void Update()
    {
        if(health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
