using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move2 : MonoBehaviour
{
    Rigidbody rigidBody;
    // Use this for initialization
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        var uw = new Vector3(-10, 0, 0);
        rigidBody.velocity = uw;

        renew();

    }

    private void renew()
    {
        if (transform.position.x < -37)
        {

            transform.position = new Vector3(42f, transform.position.y, transform.position.z);


        }
    }

}