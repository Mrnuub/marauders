using UnityEngine;
using System.Collections;

public class UnderGroundPlayer : MonoBehaviour 
{
	private GameObject underground_player;
	private GameObject player;
	
	void Awake()
	{
		underground_player = GameObject.Find("underground_player");
		player = GameObject.FindGameObjectWithTag("Player");
	}
	
	void Update()
	{
		//underground_player.light.transform.position = player.transform.position;
	}
}
