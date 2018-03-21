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
    public float timeBetweenAttacks = 3f;
    float timer=0;

    
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





    void FixedUpdate()
    {

        if (inRange)
        { 
            timer += Time.deltaTime;
            if (timer >= timeBetweenAttacks)
            {

                Shooting();
                timer = 0;
            }
        }
    }


    void OnTriggerStay2D(Collider2D collision)
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

        obj.transform.eulerAngles = new Vector3(0, 0, -90);

        obj.GetComponent<Rigidbody2D>().velocity = new Vector2(velocity.x, velocity.y);
        

        Destroy(obj, 2f);

    }

}