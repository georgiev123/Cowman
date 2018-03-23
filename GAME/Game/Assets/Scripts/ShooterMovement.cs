using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShooterMovement : MonoBehaviour {


    GameObject player;
   
    public bool detected;
    public float enemyScale;



    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");

    }
    private void Update()
    {
        if (detected)
        {
            
            if (transform.position.x <= player.transform.position.x)
            {
                transform.eulerAngles = new Vector3(0, 0, 0);
                GetComponent<EnemyShooting>().scale=1;


            }
            else if (transform.position.x >= player.transform.position.x)
            {

                transform.eulerAngles = new Vector3(0, -180, 0);
                GetComponent<EnemyShooting>().scale = -1;
            }
        }
        
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
           detected = true;


        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            detected = false;


        }
    }

   
}
