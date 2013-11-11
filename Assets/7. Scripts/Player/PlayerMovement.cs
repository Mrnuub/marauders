using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{
	public int playerID;
	private PlayerObject player;
	
	public float turnSmoothing = 15f;
	public float speedDampTime = 0.1f;
	
	private Animator anim;
	private HashIDs hash;
	
	void Awake()
	{
		player = new PlayerObject(playerID);
		anim = GetComponent<Animator>();
		hash = GameObject.FindGameObjectWithTag(Tags.GameController).GetComponent<HashIDs>();
	}
	void Update()
	{
		
	}
	
	void FixedUpdate()
	{
		
		float h = 0;
		float v = 0;
		
		if(tag.Equals("Player"))
		{
			h = Input.GetAxis("Horizontal");
			v = Input.GetAxis("Vertical");	
		}
		 
		
		//float h = player.getHorizontalMovement();
		//float v = player.getVerticalMovement();
		
		MovementManagement(h, v);
	}
	
	void MovementManagement (float horizontal, float vertical)
	{
		if (horizontal != 0f || vertical != 0f)
		{
			Rotating(horizontal, vertical);
			anim.SetFloat(hash.speedFloat, 5.5f, speedDampTime, Time.deltaTime);
		}
		else
		{
			anim.SetFloat(hash.speedFloat, 0);
		}
	}
	
	void Rotating (float horizontal, float vertical)
	{
		Vector3 targetDirection = new Vector3(horizontal, 0f, vertical);
		if (targetDirection.sqrMagnitude != 0)
		{
			Quaternion targetRotation = Quaternion.LookRotation(targetDirection, Vector3.up);
			Quaternion newRotation = Quaternion.Lerp(rigidbody.rotation, targetRotation, turnSmoothing * Time.deltaTime);
			
			rigidbody.MoveRotation(newRotation);
		}
	}
}