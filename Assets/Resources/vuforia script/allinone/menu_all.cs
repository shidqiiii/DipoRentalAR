using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menu_all : MonoBehaviour
{
 public void GoBack()
    {
        Application.LoadLevel("menu_all");
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
                Application.LoadLevel("menu_all");
            }
        }
    }
}
