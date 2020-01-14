using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class multimedia : MonoBehaviour
{
    public void PaketPremium(){
		Application.LoadLevel("paketpremium");
	}

    public void PaketGold(){
		Application.LoadLevel("paketgold");
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
