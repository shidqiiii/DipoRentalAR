using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class allinone : MonoBehaviour
{
    public void PaketMurah()
    {
        Application.LoadLevel("paket_murah");
    }

    public void PaketHemat()
    {
        Application.LoadLevel("paket_hemat");
    }

    public void PaketOKE()
    {
        Application.LoadLevel("paket_oke");
    }

    public void GoBack()
    {
        Application.LoadLevel("menupaket");
    }

    // Update is called once per frame
    void Update()
    {
        // Make sure user is on Android platform
        if (Application.platform == RuntimePlatform.Android)
        {

            // Check if Back was pressed this frame
            if (Input.GetKeyDown(KeyCode.Escape))
            {

                // Quit the application
                Application.LoadLevel("menupaket");
            }
        }
    }
}
