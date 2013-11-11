using UnityEngine;
using System.Collections;

public class DestroyCubeTest : MonoBehaviour
{
	
	void Update () 
	{
		if (Input.GetKeyDown(KeyCode.Space))
		{
			Destroy(this.gameObject.GetComponent<CameraTracking>());
		}
		
		if (Input.GetKeyDown(KeyCode.LeftControl))
		{
			this.gameObject.AddComponent("CameraTracking");
		}
	}
}
