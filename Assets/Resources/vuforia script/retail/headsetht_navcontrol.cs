using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class headsetht_navcontrol : MonoBehaviour
{
    public void GoBack()
    {
        Application.LoadLevel("menu_retail");
    }
	
	public void GoPrev(){
		 Application.LoadLevel("ht");
	}
	
	public void GoNext(){
		 Application.LoadLevel("toa");
	}

    void Update()
    {
        // Make sure user is on Android platform
        if (Application.platform == RuntimePlatform.Android)
        {

            // Check if Back was pressed this frame
            if (Input.GetKeyDown(KeyCode.Escape))
            {

                // Quit the application
                Application.LoadLevel("menu_lighting");
            }
        }
    }
}
