using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class retail : MonoBehaviour
{
	public void Cajon(){
		Application.LoadLevel("cajon");
	}

    public void Converter(){
		Application.LoadLevel("convertvgahdmi");
	}

    public void Hdmi(){
		Application.LoadLevel("hdmi");
	}
	
	public void Drone(){
		Application.LoadLevel("drone");
	}

    public void GitarAkustik(){
		Application.LoadLevel("gitarakustik");
	}

    public void HeadsetHT(){
		Application.LoadLevel("headsetht");
	}
	
	public void Ht(){
		Application.LoadLevel("ht");
	}

    public void Kabel10(){
		Application.LoadLevel("kabel10");
	}

    public void karpet(){
		Application.LoadLevel("karpet");
	}
	
	public void Genset(){
		Application.LoadLevel("genset");
	}

    public void Lighting2bar(){
		Application.LoadLevel("lighting2bar");
	}

    public void MicWired(){
		Application.LoadLevel("micwired");
	}
	
	public void MicWireless(){
		Application.LoadLevel("micwireless");
	}

    public void Podium(){
		Application.LoadLevel("podium");
	}

    public void Pointer(){
		Application.LoadLevel("pointer");
	}
	
	public void Proyektor1(){
		Application.LoadLevel("proyektor1");
	}

    public void Proyektor2(){
		Application.LoadLevel("proyektor2");
	}

    public void ScreenProyektor(){
		Application.LoadLevel("screenproyektor");
	}

     public void SpeakerPortable(){
		Application.LoadLevel("speakerportable");
	}
	
	public void StandingMic(){
		Application.LoadLevel("standingmic");
	}

    public void Toa(){
		Application.LoadLevel("toa");
	}

    public void TVLed(){
		Application.LoadLevel("tvled");
	}
	
	public void Vga(){
		Application.LoadLevel("vga");
	}

    public void VGASplitter(){
		Application.LoadLevel("vgasplitter");
	}

    public void KursiFutura(){
		Application.LoadLevel("kursifutura");
	}
	
	public void KursiLipat(){
		Application.LoadLevel("kursilipat");
	}

    public void SmokeGun(){
		Application.LoadLevel("smokegun");
	}

    public void SofamejaVIP(){
		Application.LoadLevel("sofamejavip");
	}
	
	public void SpeakerAktif(){
		Application.LoadLevel("speakeraktif");
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
