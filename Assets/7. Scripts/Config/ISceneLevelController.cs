using UnityEngine;
using System.Collections;

public interface ISceneLevelController {
	void setupGameMode();
	void updateGameMode();
	void setupTeamDeathMatch();
	void updateTeamDeathMatch();
	void setupKingOfTheHill();
	void updateKingOfTheHill();
	void setupFreeForAll();
	void updateFreeForAll();
	void setupCaptureTheFlag();
	void updateCaptureTheFlag();
	void setupDarkRoom();
	void updateDarkRoom();
}
