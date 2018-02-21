using System.Collections;
using System.Collections.Generic;
using UnityEngine.AI;
using UnityEngine;
using UnityEngine.EventSystems;


public class PlayerMovement : MonoBehaviour {
	
	public Animator mAnimator;

	private NavMeshAgent mNavMeshAgent;
	private bool mWalking = false;


	void Start(){
		mNavMeshAgent = GetComponent<NavMeshAgent> ();
	}

	void Update(){
		Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
		RaycastHit hit;

		if(Input.GetMouseButtonDown (0)){
			if(Physics.Raycast(ray,out hit,Mathf.Infinity)){
				Debug.Log ("Running");
				GameObject interactedObject = hit.collider.gameObject;
				if (interactedObject.tag == "Interactable") {
					Debug.Log ("Finded INteractable");
					interactedObject.GetComponent <Interactable> ().MoveToInteraction (mNavMeshAgent);
				} else {
					mNavMeshAgent.destination = hit.point;
				}
			}
		}

		if(mNavMeshAgent.remainingDistance <= mNavMeshAgent.stoppingDistance){
			mWalking = false;
		}else{
			mWalking = true;
		}
	
		mAnimator.SetBool ("walking", mWalking);
	}
}
