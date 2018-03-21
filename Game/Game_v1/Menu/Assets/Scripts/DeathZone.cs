using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathZone : MonoBehaviour {

    public Transform WhereToSpawn;

    void Update ()
    {
		
        if(transform.position.y<0)
        {

            Respawn();

        }

	}

    void Respawn()
    {
        gameObject.transform.position = WhereToSpawn.position;
    }
}
