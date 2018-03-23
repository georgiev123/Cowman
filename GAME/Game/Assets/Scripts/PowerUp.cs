using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour {

    Vector2 upBound;
    Vector2 downtBound;
    Vector2 speed=new Vector2(0,1);
    int dir = 1;

    GameObject cameraInsatnce;
    HeartManagment heartManager;

    void Awake()
    {

        cameraInsatnce = GameObject.FindGameObjectWithTag("MainCamera");
        heartManager = cameraInsatnce.GetComponent<HeartManagment>();
        upBound = new Vector2(transform.position.x , transform.position.y+1);
        downtBound = new Vector2(transform.position.x , transform.position.y-1);
        

    }
    void Move()
    {

        if (transform.position.y >= upBound.y)
        {
            dir = -1;
        }
        else if (transform.position.y <= downtBound.y)
        {
            dir = 1;

        }
        transform.Translate(speed * dir * Time.deltaTime);
    }

    void Update()
    {
        Move();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag=="colliderForBullets")
        {
            if (heartManager.currentHeartToHide < heartManager.maxHearts)
            {
                heartManager.ShowOne();
                Destroy(gameObject);
            }
        }
    }
}


