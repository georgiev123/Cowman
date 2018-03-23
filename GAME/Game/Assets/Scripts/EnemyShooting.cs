using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooting: MonoBehaviour{
    //attached to shooting enemies

    public float correctionX;
    public float correctionY;
    public float correctionZ;
    public float scale;

    Transform posToShootFrom;
    public GameObject projectile;

    public Vector2 velocity = new Vector2(0, 0);

    GameObject player;
    Health playerHealth;

    bool inRange=false;
    public float timeBetweenAttacks;
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




    void Shooting()
    {
        
        Vector2 shoot = new Vector2(posToShootFrom.position.x, posToShootFrom.position.y);

        GameObject obj = Instantiate(projectile, shoot, Quaternion.identity);


        if (scale == 1)
        {
            obj.transform.eulerAngles = new Vector3(0, 0, 0);
        }
        else if (scale == -1)
        {
            obj.transform.eulerAngles = new Vector3(correctionX, correctionY, correctionZ);
        }

        obj.GetComponent<Rigidbody2D>().velocity = new Vector2(velocity.x*scale, velocity.y);
        

        Destroy(obj, 2f);

    }

}