using UnityEngine;
using System.Collections;

public class LevelClick : MonoBehaviour 
{
	public Texture textureStart;

	private Rect recLevel1 = new Rect(75, 75, 75, 75);
	private Rect recLevel2 = new Rect(150, 75, 75, 75);
	private Rect recLevel3 = new Rect(225, 75, 75, 75);
	private Rect recLevel4 = new Rect(300, 75, 75, 75);
	private Rect recLevel5 = new Rect(375, 75, 75, 75);
	private Rect recLevel6 = new Rect(450, 75, 75, 75);
	private Rect recLevel7 = new Rect(75, 150, 75, 75);
	private Rect recLevel8 = new Rect(150, 150, 75, 75);
	private Rect recLevel9 = new Rect(225, 150, 75, 75);
	private Rect recLevel10 = new Rect(300, 150, 75, 75);
	private Rect recLevel11 = new Rect(375, 150, 75, 75);
	private Rect recLevel12 = new Rect(450, 150, 75, 75);
	
	private Rect modus1 = new Rect(75, 250, 150, 75);
	private Rect modus2 = new Rect(225, 250, 150, 75);
	private Rect modus3 = new Rect(375, 250, 150, 75);
	private Rect modus4 = new Rect(75, 325, 150, 75);
	private Rect modus5 = new Rect(225, 325, 150, 75);
	private Rect modus6 = new Rect(375, 325, 150, 75);
	
	void OnGUI () {
		LevelButtons();
		ModusButtons();
		
		if (GUI.Button (new Rect (250,450,100,50), "Start Game")) {	
			Application.LoadLevel(ConfigScript.getActiveSceneName());
		}
		
		if (GUI.Button (new Rect (625,75,100,50), "Back")) {
			Application.LoadLevel(0);
		}
	}
	
	void LevelButtons()
	{
		if (GUI.Button (recLevel1, "Level 1")) {
			Debug.Log ("Level1");
			ConfigScript.setActiveSceneName(ConfigScript.SceneNames.Level1);
		}
		if (GUI.Button (recLevel2, "Level 2")) {
			Debug.Log ("Level2");
			ConfigScript.setActiveSceneName(ConfigScript.SceneNames.Level2);
		}
		if (GUI.Button (recLevel3, "Level 3")) {
			Debug.Log ("Level3");
			ConfigScript.setActiveSceneName(ConfigScript.SceneNames.Level3);
		}
		if (GUI.Button (recLevel4, "Level 4")) {
			Debug.Log ("Level4");
			ConfigScript.setActiveSceneName(ConfigScript.SceneNames.Level4);
		}
		if (GUI.Button (recLevel5, "Level 5")) {
			Debug.Log ("Level5");
			ConfigScript.setActiveSceneName(ConfigScript.SceneNames.Level5);
		}
		if (GUI.Button (recLevel6, "Level 6")) {
			Debug.Log ("Level6");
		}
		if (GUI.Button (recLevel7, "Level 7")) {
			Debug.Log ("Level7");
		}
		if (GUI.Button (recLevel8, "Level 8")) {
			Debug.Log ("Level8");
		}
	}
	
	void ModusButtons()
	{
		if (GUI.Button (modus1, "Team Deathmatch")) {
			Debug.Log ("Team Deathmatch");
			ConfigScript.setActiveGameMode(ConfigScript.GameModes.TeamDeathMatch);
		}
		if (GUI.Button (modus2, "Capture The Flag")) {
			Debug.Log ("Capture The Flag");
			ConfigScript.setActiveGameMode(ConfigScript.GameModes.CaptureTheFlag);
		}
		if (GUI.Button (modus3, "King of the Hill")) {
			Debug.Log ("King of the Hill");
			ConfigScript.setActiveGameMode(ConfigScript.GameModes.KingOfTheHill);
		}
		if (GUI.Button (modus4, "Free for all")) {
			Debug.Log ("Free for all");
			ConfigScript.setActiveGameMode(ConfigScript.GameModes.FreeForAll);
		}
		if (GUI.Button (modus5, "DarkRoom")) {
			Debug.Log ("DarkRoom");
			ConfigScript.setActiveGameMode(ConfigScript.GameModes.DarkRoom);
		}
		if (GUI.Button (modus6, "Team Modus 2")) {
			Debug.Log ("Team Modus 2");
		}
	}
}
