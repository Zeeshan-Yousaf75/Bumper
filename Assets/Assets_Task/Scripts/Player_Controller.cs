using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Controller : MonoBehaviour
{
    private Rigidbody rb;
    public float horizontalInput;
    public float verticalInput;

   
    private GameObject ob;
    public bool isTagAssign;
    public static bool IsEnemyDestroid;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
      
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");


        if (horizontalInput > 0)
        {
            rb.AddForce(Vector3.right * 600 * Time.deltaTime);
        }
        else if (horizontalInput < 0)
        {
            rb.AddForce(Vector3.left * 600 * Time.deltaTime);
        }

        if (verticalInput > 0)
        {
            rb.AddForce(Vector3.forward * 600 * Time.deltaTime);
        }
        else if (verticalInput < 0)
        {
            rb.AddForce(Vector3.back * 600 * Time.deltaTime);
        }




        //Scalling player
        if (isTagAssign)
        {
            if (ob.transform.position.y < -1)
            {
                transform.localScale = new Vector3(transform.localScale.x * 1.5f, transform.localScale.y * 1.5f, transform.localScale.z * 1.5f);
               
                Destroy(ob);

                isTagAssign = false;
            }


        }


    }



    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag != "Ground")
        {
            isTagAssign = true;
            string obTag = collision.gameObject.tag;
            Debug.Log(obTag);
            ob = GameObject.FindWithTag(obTag);


        }



    }
}

    
