using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
	
	private float speed =10f;
	private Rigidbody playerRb;
	private float zBound =6;
	// Start is called before the first frame update
	void Start()
	{
		playerRb=GetComponent<Rigidbody>();
	}

	// Update is called once per frame
	void Update()
	{
		MovePlayer();
		ConstarinPlayerPosition();
		
	}
	
	
	
	//moves player with arrow key
	void MovePlayer()
	{
		float horizontalInput=Input.GetAxis("Horizontal");
		float verticalInput=Input.GetAxis("Vertical");
		
		playerRb.AddForce(Vector3.forward * speed * verticalInput);
		playerRb.AddForce(Vector3.right * speed * horizontalInput);
	}
	
	// prenvent the player from leaving the top or botton of screen
	void ConstarinPlayerPosition()
	{
		if(transform.position.z < -zBound)
	{
		transform.position =new Vector3(transform.position.x, transform.position.y, -zBound);
		
	}
	
	if(transform.position.z < zBound)
	{
		transform.position =new Vector3(transform.position.x, transform.position.y, zBound);
		
	}
}

}





