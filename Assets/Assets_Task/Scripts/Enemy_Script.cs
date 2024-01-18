using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Script : MonoBehaviour
{
    public float speed = 2000.0f;
    private Rigidbody enemyRb;
    private GameObject player;

    private GameObject ob;
    public bool isTagAssign;
    public  bool IsPlayerDestroid;
    
    // Start is called before the first frame update
    void Start()
    {
        enemyRb = GetComponent<Rigidbody>();
        player = GameObject.FindWithTag("Player");

    }

    // Update is called once per frame
    void Update()
    {
        player = GameObject.FindWithTag("Player");
        if (player.transform.position.y > -1)
        {
            Vector3 lookDirection = (player.transform.position - transform.position).normalized;
            enemyRb.AddForce(lookDirection * speed);
        }

        if (player.transform.position.y < -1.5)
        {
            enemyRb.velocity = Vector3.zero;
            Destroy(player);
            PlayerRespawner.isPlayerDestroid = true;

        }
       

        if (isTagAssign)
        {
            if (ob.transform.position.y < -0.9)
            {
                IsPlayerDestroid= true;
                transform.localScale = new Vector3(transform.localScale.x * 1.5f, transform.localScale.y * 1.5f, transform.localScale.z * 1.5f);
                Debug.Log(transform.localScale);

                Destroy(ob);

            isTagAssign = false;
            }
        }


        if (player.transform.position.y < -2 && IsPlayerDestroid)
        {
           // PlayerRespawner.PlayerRespawn();
            IsPlayerDestroid = false;
        }

        if (transform.position.y <-2)
        {
            Destroy(gameObject);
        }

      
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag != "Ground")
        {
            isTagAssign = true;
            string obTag = collision.gameObject.tag;
            ob = GameObject.FindWithTag(obTag);

            
        }

        

    }
}
