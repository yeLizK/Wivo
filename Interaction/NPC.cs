using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : Interactable {

	public string[] dialog;
	public string name;
	//public Animator mAnimator;
	public bool startAnim = false;

	public override void Interact(){
		startAnim = true;
		DialogSystem.Instance.AddNewDialog (dialog,name);
		//mAnimator.SetBool ("startAnim", startAnim);
		Debug.Log ("Interacting NPC");
	}
}
