using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class smokegun_nav : MonoBehaviour
{
   public void GoBack()
    {
        Application.LoadLevel("menu_retail");
    }
	
	public void GoPrev(){
		 Application.LoadLevel("cajon");
	}
	
	public void GoNext(){
		 Application.LoadLevel("podium");
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
