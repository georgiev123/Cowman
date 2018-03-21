using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{

    [SerializeField] float firerate;

    public int damage = 43;



    private float timeToFire;
    private Transform firePoint;
    private Transform instance;
    public float scale;

    Vector2 offset = new Vector2(0, 0);
    public GameObject bullet;
    [SerializeField] Vector2 velocity;

    void Awake()
    {
        firePoint = transform.Find("firePoint");
        if (firePoint == null)
        {
            Debug.LogError("no such ojcect");
        }

    }




    void Update()
    {
        instance = GameObject.FindGameObjectWithTag("Player").transform;
        scale = instance.localScale.x;

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
        obj.GetComponent<Rigidbody2D>().velocity = new Vector2(velocity.x * scale, velocity.y);
        Destroy(obj, 2.5f);

    }



}