using UnityEngine;
using System.Collections;

public class LevelOneController : MonoBehaviour, ISceneLevelController {
	
	public GameObject flag;
	
	void Awake() {
		setupGameMode();
	}
	
	void Start () {
		
	}
	
	void Update () {
		updateGameMode();
	}
	
	#region ISceneLevelController implementation
	public void setupGameMode ()
	{
		if(ConfigScript.getActiveGameMode().Equals(ConfigScript.GameModes.CaptureTheFlag.ToString()))
		{
			setupCaptureTheFlag();
		}
		else if(ConfigScript.getActiveGameMode().Equals(ConfigScript.GameModes.DarkRoom.ToString()))
		{
			setupDarkRoom();
		}
		else if(ConfigScript.getActiveGameMode().Equals(ConfigScript.GameModes.FreeForAll.ToString()))
		{
			setupFreeForAll();
		}
		else if(ConfigScript.getActiveGameMode().Equals(ConfigScript.GameModes.KingOfTheHill.ToString()))
		{
			setupKingOfTheHill();
		}
		else if(ConfigScript.getActiveGameMode().Equals(ConfigScript.GameModes.TeamDeathMatch.ToString()))
		{
			setupTeamDeathMatch();
		}
	}

	public void updateGameMode ()
	{
		if(ConfigScript.getActiveGameMode().Equals(ConfigScript.GameModes.CaptureTheFlag.ToString()))
		{
			updateCaptureTheFlag();
		}
		else if(ConfigScript.getActiveGameMode().Equals(ConfigScript.GameModes.DarkRoom.ToString()))
		{
			updateDarkRoom();
		}
		else if(ConfigScript.getActiveGameMode().Equals(ConfigScript.GameModes.FreeForAll.ToString()))
		{
			updateFreeForAll();
		}
		else if(ConfigScript.getActiveGameMode().Equals(ConfigScript.GameModes.KingOfTheHill.ToString()))
		{
			updateKingOfTheHill();
		}
		else if(ConfigScript.getActiveGameMode().Equals(ConfigScript.GameModes.TeamDeathMatch.ToString()))
		{
			updateTeamDeathMatch();
		}
	}
	
	public void setupTeamDeathMatch ()
	{
		Debug.Log("setupTeamDeathMatch");
	}

	public void updateTeamDeathMatch ()
	{
		Debug.Log("updateTeamDeathMatch");
	}

	public void setupKingOfTheHill ()
	{
		Debug.Log("setupKingOfTheHill");
	}

	public void updateKingOfTheHill ()
	{
		Debug.Log("updateKingOfTheHill");
	}

	public void setupFreeForAll ()
	{
		Debug.Log("setupFreeForAll");
	}

	public void updateFreeForAll ()
	{
		Debug.Log("updateFreeForAll");
	}

	public void setupCaptureTheFlag ()
	{
		Instantiate(flag, new Vector3(-0.2f, -2.9f, 3.4f), new Quaternion(0f, 0f, 0f, 0f));
		Instantiate(flag, new Vector3(-0.3f, -2.9f, -2.4f), new Quaternion(0f, 0f, 0f, 0f));
		Debug.Log("setupCaptureTheFlag");
	}

	public void updateCaptureTheFlag ()
	{
		Debug.Log("updateCaptureTheFlag");
	}

	public void setupDarkRoom ()
	{
		Debug.Log("setupDarkRoom");
	}

	public void updateDarkRoom ()
	{
		Debug.Log("updateDarkRoom");
	}
	#endregion
}
