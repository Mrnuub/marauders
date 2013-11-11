using UnityEngine;
using System.Collections;

public class GuideClick : MonoBehaviour 
{	
	void OnGUI () {
		if (GUI.Button (new Rect (200,100,250,100), "Hellowwaaa")) {
			
		}
		if (GUI.Button (new Rect (200,250,250,100), "Back")) {
			Application.LoadLevel(0);
		}
	}
}
