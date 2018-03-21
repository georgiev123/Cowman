using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LiveManager : MonoBehaviour {

    public static LiveManager LM;

    public Transform PlayerPrefabs;

    public Transform WhereToSpawn;

    

	void Start ()
    {

        if(LM == null)
        {

            LM = GameObject.FindGameObjectWithTag("LM").GetComponent<LiveManager>();

        }
		
	}
	
    public void Respawn(GameObject player)
    {

        //Instantiate(PlayerPrefabs, WhereToSpawn.position, WhereToSpawn.rotation);
        player.transform.position = WhereToSpawn.position;


       
    }

    public static void killPlayer(GameObject player)
    {

       // Destroy(player);

        LM.Respawn(player);

    }
    
}
