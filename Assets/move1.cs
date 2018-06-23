using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move1 : MonoBehaviour
{  
    Rigidbody rigidBody;
    // Use this for initialization
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
        var uw = new Vector3(-20, 0, 0);
        rigidBody.velocity = uw;

    }

    // Update is called once per frame
    void Update()
    {

        ifrenew();

    }

    private void OnCollisionEnter(Collision collision)
    {
        
        switch (collision.gameObject.tag)
        {
            case "Player":
                {
                    var uw = new Vector3(0, 0, 0);
                    rigidBody.velocity = uw;
                    Invoke("renew", 1f);


                    break;
                }
            

        }
    }



    private void ifrenew()
    {   if (transform.position.x < -50)
        {
            renew();


        }
    }


    private void renew()
    {
        float y = Random.Range(7.5f, 30f);
        transform.position = new Vector3(100, y, -7);
        var uw = new Vector3(-20, 0, 0);
        rigidBody.velocity = uw;
    }

}
  

