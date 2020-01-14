using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menu : MonoBehaviour
{
    // Start is called before the first frame update
    public void GoToPilihPaket(){
		Application.LoadLevel("menupaket");
	}

    public void GoToAboutUs(){
		Application.LoadLevel("aboutus");
	}

	public void ExitApplication(){
		Application.Quit ();
	}
	
	void Update()
	{
    // Make sure user is on Android platform
    if (Application.platform == RuntimePlatform.Android) {
        
        // Check if Back was pressed this frame
        if (Input.GetKeyDown(KeyCode.Escape)) {
            
            // Quit the application
            Application.Quit ();
        }
    }
	}
}
