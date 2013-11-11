using UnityEngine;
using System.Collections;

public class PlayerObject : MonoBehaviour  {
	
	private int playerID;
	
	public PlayerObject(int _playerID)
	{
		this.playerID = _playerID;
	}
	
	public float getHorizontalMovement()
	{
		return Input.GetAxis("360_pl" + playerID +"_Horizontal");
	}
	
	public float getVerticalMovement()
	{
		return Input.GetAxis("360_pl" + playerID +"_Vertical");
	}
}
