using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{

    [SerializeField] float firerate;

    



    private float timeToFire;
    private Transform firePoint;
    private Transform instance;
    public float scale;

 
    public GameObject bullet;
    [SerializeField] Vector2 velocity;

    void Awake()
    {
        firePoint = transform.Find("firePoint");
        if (firePoint == null)
        {
            Debug.LogError("no such ojcect");
        }
        //instance = GameObject.FindGameObjectWithTag("Player").transform;
    }




    void Update()
    {
        
        scale = transform.localScale.x;

        if (firerate == 0)
        {
            if (Input.GetButtonDown("Fire1"))
            {
                Shoot();
            }
        }
        else if (firerate != 0)
        {
            if (Input.GetButton("Fire1") && Time.time > timeToFire)
            {
                timeToFire = Time.time + 1 / firerate;
                Shoot();
            }
        }

    }

    void Shoot()

    {
        Vector2 shootingPosition = new Vector2(firePoint.position.x, firePoint.position.y);

        GameObject obj = Instantiate(bullet, shootingPosition,Quaternion.identity);
        if (scale == 1)
        {
            obj.transform.eulerAngles = new Vector3(0, 0, 0);
        }
        else if (scale == -1)
        {
            obj.transform.eulerAngles = new Vector3(0, -180, 0);
        }

        obj.GetComponent<Rigidbody2D>().velocity = new Vector2(velocity.x * scale, velocity.y);

        Destroy(obj, 2.5f);

    }



}