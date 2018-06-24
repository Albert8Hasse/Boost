using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_Move : MonoBehaviour {
    float height; 
	void Start () {
        height = 10;
		
	}
	
	// Update is called once per frame
	void Update () {
        GameObject thePlayer = GameObject.Find("Pig");
        Transform piggy = thePlayer.GetComponent<Transform>();
        height = piggy.position.y;
        height = 26 + 0.85f * (height - 26f);
        transform.position = new Vector3(9, height, -91);

    }
}
