using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pause : MonoBehaviour {
    public bool isPause;
    [SerializeField] private GameObject pausePanel;
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        

    }
    


    public void interact()
    {
        if (isPause)
        {
            defreeze();
            isPause = false;
        }
        else

        {
            isPause = true;
            freeze();
        }

    }


    private void freeze()
    {
        Time.timeScale = 0;
     //   pausePanel.SetActive(true);
        //Disable scripts that still work while timescale is set to 0
    }


    private void defreeze()
    {
        Time.timeScale = 1;
       // pausePanel.SetActive(false);
        //enable the scripts again
    }

}
