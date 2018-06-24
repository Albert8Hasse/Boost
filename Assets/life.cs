using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class life : MonoBehaviour {
    TextMesh myText;
    fly pigFly;
    GameObject thePlayer;
    // Use this for initialization
    void Start () {
        myText = GetComponent<TextMesh>();
      
    }
	
	// Update is called once per frame
	void Update () {
        thePlayer = GameObject.Find("Pig");
        pigFly = thePlayer.GetComponent<fly>();
        string toprint = "You have " +pigFly.life + " lives left";
        myText.text = toprint;
	}
}
