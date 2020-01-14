using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sound : MonoBehaviour
{
    // Start is called before the first frame update
   public void PaketSound1(){
		Application.LoadLevel("paketsound1");
	}

    public void PaketSound2(){
		Application.LoadLevel("paketsound2");
	}

    public void PaketSound3(){
		Application.LoadLevel("paketsound3");
	}

    public void PaketSound4(){
		Application.LoadLevel("paketsound4");
	}

     public void GoBack(){
		Application.LoadLevel("menupaket");
	}

    // Update is called once per frame
    void Update()
	{
    // Make sure user is on Android platform
    if (Application.platform == RuntimePlatform.Android) {
        
        // Check if Back was pressed this frame
        if (Input.GetKeyDown(KeyCode.Escape)) {
            
            // Quit the application
            Application.LoadLevel("menupaket");
        }
    }
	}
}
