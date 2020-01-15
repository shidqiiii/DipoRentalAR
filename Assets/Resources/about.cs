using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class about : MonoBehaviour
{
    // Start is called before the first frame update
    public void GoToVisiMisi(){
		Application.LoadLevel("visimisi");
	}

    public void GoToSpecialist(){
		Application.LoadLevel("specialist");
	}
	
	public void GoBack(){
		Application.LoadLevel("mainmenu");
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
