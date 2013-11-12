using UnityEngine;
using System.Collections;

public class ChangeLight : MonoBehaviour 
{
	public GameObject innerLight;
	
	void Update()
	{
		if(Input.GetKeyDown(KeyCode.Space))
		{
			innerLight.gameObject.light.spotAngle -=10f;
		}
	}
}
