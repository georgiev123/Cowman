using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatroolingMooving : MonoBehaviour {
    //attached to patrool

    GameObject player;
    public bool needToMove;
    
    public float speed;

    

    void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        
        
    }


    void OnTriggerStay2D(Collider2D collision)
    {

        if (collision.gameObject == player)
        {
            needToMove = true;


        }
        
       


    }
     void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject == player)
        {
            needToMove = false;
           

        }
    }

    void Update()
    {
        GetComponent<Animator>().SetBool("move", needToMove);

        if (needToMove)
        {
            move();
        }
    }

    void move()
    {
        if (transform.position.x <= player.transform.position.x)
        {
            
            transform.eulerAngles = new Vector3(0, 0, 0);
        }
        else if (transform.position.x >= player.transform.position.x)
        {
            
            transform.eulerAngles=new Vector3(0,-180,0);
        }
        
   
        transform.Translate(speed* Vector2.right*Time.deltaTime);
    }
    
}
