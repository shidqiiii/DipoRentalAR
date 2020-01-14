using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rigging : MonoBehaviour
{
     public void Paketmini(){
		Application.LoadLevel("paketmini");
	}

    public void Paketstandar(){
		Application.LoadLevel("paketstandar");
	}

    public void Paketbesar(){
		Application.LoadLevel("paketbesar");
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
