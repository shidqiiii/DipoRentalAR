using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menupaket : MonoBehaviour
{
    // Start is called before the first frame update
    public void GoToSound(){
		Application.LoadLevel("menu_sound");
	}

    public void GoToLighting(){
		Application.LoadLevel("menu_lighting");
	}

    public void GoToMultimedia(){
		Application.LoadLevel("menu_multimedia");
	}

    public void GoToRigging(){
		Application.LoadLevel("menu_riggingstage");
	}

    public void GoToTenda(){
		Application.LoadLevel("menu_tenda");
	}

    public void GoToRetail(){
		Application.LoadLevel("menu_retail");
	}

    public void GoBack(){
		Application.LoadLevel("mainmenu");
	}

    public void GoToAll()
    {
        Application.LoadLevel("menu_all");
    }
    

	void Update()
	{
    // Make sure user is on Android platform
    if (Application.platform == RuntimePlatform.Android) {
        
        // Check if Back was pressed this frame
        if (Input.GetKeyDown(KeyCode.Escape)) {
            
            // Quit the application
            Application.LoadLevel("mainmenu");
        }
    }
	}
}
