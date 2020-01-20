using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class micwireless_nav : MonoBehaviour
{
    // Start is called before the first frame update
    public void GoBack()
    {
        Application.LoadLevel("menu_retail");
    }
	
	public void GoPrev(){
		 Application.LoadLevel("kabel10");
	}
	
	public void GoNext(){
		 Application.LoadLevel("micwired");
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
