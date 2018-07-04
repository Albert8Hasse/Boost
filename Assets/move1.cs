﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move1 : MonoBehaviour
{  
    Rigidbody rigidBody;
    private Vector3 speed;
    private int score;
    private bool isColision;
    // Use this for initialization
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
        var uw = new Vector3(-20, 0, 0);
        rigidBody.velocity = uw;
        score = 0;
        speed = new Vector3(-20, 0, 0);
        isColision = false;
    }

    // Update is called once per frame
    void Update()
    {
        GameObject thePlayer = GameObject.Find("Scores");
        score pts_script = thePlayer.GetComponent<score>();
         if (score >= 60)
            speed = new Vector3(-35, 0, 0);
        else if (score >= 40)
            speed = new Vector3(-30, 0, 0);
        else if (score >= 20)
            speed = new Vector3(-25, 0, 0);
        rigidBody.velocity = speed;
        ifrenew();


    }

    private void OnCollisionEnter(Collision collision)
    {
        
        switch (collision.gameObject.tag)
        {
            case "Player":
                {
                    if (!isColision)
                    {
                        isColision = true;
                        var uw = new Vector3(0, 0, 0);
                        rigidBody.velocity = uw;
                        Destroy(transform.gameObject, 0.1f);
                    }
                    


                    break;
                }
            case "Untagged":
                {
                    Destroy(transform.gameObject, 0.1f);



                    break;
                }
            

        }
    }



    private void ifrenew()
    {   if (transform.position.x < -50)
        {
           GameObject thePlayer = GameObject.Find("Scores");
            score pts_script = thePlayer.GetComponent<score>();
            pts_script.pts += 0.5f;
            score++;
            Destroy(transform.gameObject, 0.1f);
            renew();
           


        }
    }


    private void renew()
    {
        float y = Random.Range(10f, 30f);
        transform.position = new Vector3(100, y, -7);
        rigidBody.velocity = speed;

    }

}
  

