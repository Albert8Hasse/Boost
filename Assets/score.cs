using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class score: MonoBehaviour
{
    TextMesh myText;
    public float pts;
    // Use this for initialization
    void Start()
    {
        myText = GetComponent<TextMesh>();
        pts = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        GameObject thePlayer = GameObject.Find("Scores");
        score pts_script = thePlayer.GetComponent<score>();

        string toprint =  pts+" ";
        myText.text = toprint;
    }
}
