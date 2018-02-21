using System.Collections.Generic;
using UnityEngine;

public class CameraCon : MonoBehaviour {

	public float xPos;
	public float yPos;
	public float zPos;

	public float desPos = 4.597996f;

	void FixedUpdate(){
		
		xPos = transform.position.x;
		yPos = transform.position.y;
		zPos = transform.position.z;

		if (yPos != desPos){
			StopOnY (xPos, yPos, zPos);
		}
	}

	private void StopOnY(float x, float y,float z){
		transform.position = new Vector3 (xPos,desPos,zPos);
	}
}
