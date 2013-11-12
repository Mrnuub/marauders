using UnityEngine;
using System.Collections;

public class CaptureTheFlag : MonoBehaviour 
{
	private float timeCapture = 5f;
	private float resetCapture = 5f;
	private string playerCaptured = "";
	
	private bool playerOneInArea = false;
	private bool playerTwoInArea = false;
	public GUIText text;
	public GUIText captured;
	
	void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.tag == "Player")
		{
			playerOneInArea = true;
		}
		else if(other.gameObject.tag == "Player2")
		{
			playerTwoInArea = true;
		}
	}
	
	void OnTriggerStay(Collider other)
	{
		if(playerOneInArea && playerTwoInArea)
		{
			return;
		}
		
		if(other.gameObject.tag == "Player" || other.gameObject.tag == "Player2")
		{
			text.text = "Counter: " + timeCapture;
			timeCapture -= Time.deltaTime;
			Debug.Log(timeCapture);
			
			if(timeCapture <= 0)
			{
				captured.text = "Captured by: " + other.gameObject.tag;
				Debug.Log("Point captured");
				timeCapture = resetCapture;
				playerCaptured = other.gameObject.tag;
			}
		}
	}
	
	void OnTriggerExit(Collider other) 
	{
		if(other.gameObject.tag == "Player")
		{
			playerOneInArea = false;
			captured.text = "";
		}
		else if(other.gameObject.tag == "Player2")
		{
			playerTwoInArea = false;
			captured.text = "";
		}
		
        timeCapture = resetCapture;
		text.text = "Counter: " + resetCapture;
    }

}
