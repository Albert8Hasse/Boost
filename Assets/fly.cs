using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class fly : MonoBehaviour {
    Rigidbody rigidBody;
    AudioSource audio;
    [SerializeField] float speed = 200f;
    [SerializeField] int life;
    [SerializeField] float upp = 50f;
    [SerializeField]float storeSpeed=0;
    float uper = 2f;
    // Use this for initialization
    void Start () {
        rigidBody = GetComponent<Rigidbody>();
        audio = GetComponent<AudioSource>();
        life = 5;
	}
	
	// Update is called once per frame
	void Update () {
        //print(rigidBody.velocity);
        Up();
        rotate();
        storeSpeed = rigidBody.velocity.y;
        Reset();
        if (life < 0)
        { SceneManager.LoadScene(1); }
	}


    private void Reset()
    {
        if (Input.GetKey(KeyCode.R))
            { transform.position = new Vector3(1, 3.94f, -10);
            transform.rotation=new Quaternion(0, 0, 0, 0);
            rigidBody.velocity = new Vector3(0, 0, 0);
        }
        


    }
    private void OnCollisionEnter(Collision collision)
    {
        switch (collision.gameObject.tag) { 
          case "die":
                {
                print("Dead");
                    transform.position = new Vector3(1, 3.94f, -10);
                    transform.rotation = new Quaternion(0, 0, 0, 0);
                    life--;
                    print(life);
                    break; }
          case "ground":
               {
                
                    if (Mathf.Abs(storeSpeed) > 10)
                        rigidBody.velocity = new Vector3(0, -1 * storeSpeed, 0);
                    else
                        rigidBody.velocity = new Vector3(0,0, 0);
                 
                 
                   break; }
                 
      }
    }

    private void rotate()
    {
        rigidBody.freezeRotation = true;
       
        float velocity = speed * Time.deltaTime;
        if (Input.GetKey(KeyCode.Space))
        { velocity = 1; }

        if (Input.GetKey(KeyCode.A))
        { transform.Rotate(velocity*Vector3.forward); }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(velocity*Vector3.back);
        }
        rigidBody.freezeRotation = false;
    }
    private void Up()
    {
        upp = 50;
        uper = 2f;
        if (Input.GetKey(KeyCode.Space))
        { upp = 30; uper = 0.7f;
        print("lower");}
        

        if (Input.GetKey(KeyCode.W))
        {  
            rigidBody.AddRelativeForce(upp * Vector3.up);
            if (!audio.isPlaying)
                audio.Play();


        }
        
       else  if (Input.GetMouseButton(0))
        {
            rigidBody.velocity=new Vector3(0,rigidBody.velocity.y+uper,0);
            if (!audio.isPlaying)
                audio.Play();
           
        }
        else
        {
            audio.Stop();
        }

        
        rigidBody.velocity = new Vector3(rigidBody.velocity.x, rigidBody.velocity.y - 0.5f, rigidBody.velocity.z);
    }
    
       


      
          
    
}
