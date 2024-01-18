using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRespawner : MonoBehaviour
{
    
 public GameObject player;
    public static bool isPlayerDestroid;


    private void Start()
    {
        
      //  player = GameObject.FindGameObjectWithTag("Player");
    }


    private void Update()
    {
       // player = GameObject.FindGameObjectWithTag("Player");
        if ( isPlayerDestroid )
        {
            PlayerRespawn();
            isPlayerDestroid = false;
        }
    }
    public void PlayerRespawn()
    {
      Instantiate(player,player.transform.position,player.transform.rotation);
        
    }

}
