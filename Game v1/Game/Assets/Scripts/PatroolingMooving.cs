using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatroolingMooving : MonoBehaviour {
    //attached to patrool

    public GameObject player;
    bool needToMove;
    public Vector2 speed;

    void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");

    }


    void OnCollisionStay2D(Collider2D collision)
    {

        if(collision.gameObject == player)
        {
            needToMove = true;
        }
        else
        {
            needToMove = false;
        }

    }

    void Update()
    {

        if(needToMove)
        {
            transform.Translate(player.transform.position*Time.deltaTime);
        }


    }
}
