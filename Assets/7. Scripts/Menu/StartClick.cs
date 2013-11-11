using UnityEngine;
using System.Collections;

public class StartClick : MonoBehaviour 
{
	public Texture textureStart;
	public Texture textureGuide;
	
	void OnGUI () {
		if (GUI.Button (new Rect (200,100,250,100), "Start")) {
			Application.LoadLevel(1);
		}
		if (GUI.Button (new Rect (200,200,250,100), "Guide")) {
			Application.LoadLevel(2);	
		}
	}
}
