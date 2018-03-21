using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooting: MonoBehaviour
{
    //attached to alien
    public int damage = 10;

    public Transform posToShootFrom;
    public GameObject projectile;

    public Vector2 velocity = new Vector2(0, 0);

    GameObject player;
    Health playerHealth;

    public bool inRange=false;
    public float timeBetweenAttacks = 0.5f;
    float timer;

    
    void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        playerHealth = player.GetComponent<Health>();

        posToShootFrom = transform.Find("posToShootFrom");
        if(posToShootFrom == null)
        {
            Debug.Log("no such object");
        }
    }





    void Update()
    {
        

        timer += Time.deltaTime;
        if(timer >= timeBetweenAttacks && inRange)
        {
            timer = 0;
            Shooting();
        }

    }


    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            inRange = true;


        }
    }


    void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            inRange = false;

        }
    }




    public void Shooting()
    {
        
        Vector2 shoot = new Vector2(posToShootFrom.position.x, posToShootFrom.position.y);

        GameObject obj = Instantiate(projectile, shoot, Quaternion.identity);

        obj.GetComponent<Rigidbody2D>().velocity = new Vector2(velocity.x, velocity.y);

        Destroy(obj, 2f);

    }

}