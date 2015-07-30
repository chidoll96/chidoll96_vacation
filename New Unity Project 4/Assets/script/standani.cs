using UnityEngine;
using System.Collections;

public class standani : MonoBehaviour {
	private Animator animator;
	private InputState inputState;
	
	void Awake(){
		animator = GetComponent<Animator> ();
		inputState = GetComponent<InputState> ();
	}

	void Update () {

		var standing = false;

		if (inputState.absVelX == 0 && inputState.absVelY <inputState.standingThreshold)
			standing = true;

		animator.SetBool ("Standing", standing);
	}
}

