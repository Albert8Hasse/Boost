using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class click : MonoBehaviour {

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {
    }

    public void enter()
    {
        Invoke("enternext", 0.5f);
}


    private void enternext()
    {
        SceneManager.LoadScene(0);
    }
}



