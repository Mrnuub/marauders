using UnityEngine;
using System.Collections;

public class ConfigScript {	
	
	private static string gameMode = string.Empty;
	private static string sceneName = "";
	
	public enum GameModes
	{
		TeamDeathMatch,
		KingOfTheHill,
		CaptureTheFlag,
		FreeForAll,
		DarkRoom
	}
	
	public enum SceneNames
	{
		Level1,
		Level2,
		Level3,
		Level4,
		Level5
	}

	public static void setActiveGameMode(GameModes _mode)
	{
		gameMode = _mode.ToString();
	}
	
	public static void setActiveSceneName(SceneNames _scene)
	{
		sceneName = _scene.ToString();
	}
	
	public static string getActiveGameMode()
	{
		return gameMode;
	}

	public static string getActiveSceneName()
	{
		return sceneName;
	}
}