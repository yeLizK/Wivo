﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Interactable : MonoBehaviour {

	[HideInInspector]
	public NavMeshAgent playerAgent;
	private bool hasInteracted;

	public virtual void MoveToInteraction(NavMeshAgent playerAgent){
		Debug.Log ("Came to Interactable");
		hasInteracted = false;
		this.playerAgent = playerAgent;
		playerAgent.stoppingDistance = 2f;
		playerAgent.destination = this.transform.position;


	}

	void Update(){
		if(!hasInteracted && playerAgent != null && !playerAgent.pathPending){
			if(playerAgent.remainingDistance <= playerAgent.stoppingDistance)
			{
				Interact ();
				hasInteracted = true;
			}
		}
	}

	public virtual void Interact(){
		Debug.Log ("Main base interaction");
	} 
}
