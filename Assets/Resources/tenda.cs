using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tenda : MonoBehaviour
{
   // Start is called before the first frame update
   public void PaketA(){
		Application.LoadLevel("paketa");
	}

    public void PaketB(){
		Application.LoadLevel("paketb");
	}

    public void PaketC(){
		Application.LoadLevel("paketc");
	}

    public void PaketD(){
		Application.LoadLevel("paketd");
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
