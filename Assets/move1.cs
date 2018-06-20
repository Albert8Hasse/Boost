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

    }

    // Update is called once per frame
    void Update()
    { var uw = new Vector3(-20, 0, 0);
        rigidBody.velocity = uw;

        renew();

    }

    private void renew()
    {   if (transform.position.x < -37)
        {
            float y = Random.Range(7.5f, 50f);
            transform.position = new Vector3(50, y, -7);


        }
    }

}
  

