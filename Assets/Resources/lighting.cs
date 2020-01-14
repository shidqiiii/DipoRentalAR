using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lighting : MonoBehaviour
{
     // Start is called before the first frame update
   public void PaketLighting1(){
		Application.LoadLevel("paketlighting1");
	}

    public void PaketLighting2(){
		Application.LoadLevel("paketlighting2");
	}

    public void PaketLighting3(){
		Application.LoadLevel("paketlighting3");
	}

    public void PaketLighting4(){
		Application.LoadLevel("paketlighting4");
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
