using UnityEngine;
using System.Collections;

public class Damage: MonoBehaviour
{
    //attached to bullets from different types
    //affects both player and enemyes
    //destroyes bullets


    GameObject HM;
    HeartManagment heartManager;

   

    void Awake()
    {

        HM = GameObject.FindGameObjectWithTag("MainCamera");
        heartManager = HM.GetComponent<HeartManagment>();
    }


    void OnTriggerEnter2D(Collider2D collision)
    {
        //incoming bullet from aliens
        if(collision.gameObject.tag == "colliderForBullets" && gameObject.tag!="bullet")
        {
            heartManager.Hide();
            Destroy(gameObject);
            
            
        }
        else if(collision.gameObject.tag == "Ground")
            //destroying fired bullets from aliens
        {
            Destroy(gameObject);

        }
        else if(collision.gameObject.tag == "Enemy" && gameObject.tag!="bulletFromEnemy")
        {
            //incoming bullets from player
            Destroy(gameObject);
        }
    }
    
}