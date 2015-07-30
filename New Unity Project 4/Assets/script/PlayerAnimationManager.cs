using UnityEngine;
using System.Collections;

public class PlayerAnimationManager : MonoBehaviour {
	private Animator animator;
	private InputState inputState;

	void Awake(){
		animator = GetComponent<Animator> ();
		inputState = GetComponent<InputState> ();
	}
	// Update is called once per frame
	void Update () {
		var running = true;
		var standing = false;
		if (inputState.absVelY !=0)
			running = false;
		if (inputState.absVelX == 0 && inputState.absVelY > inputState.standingThreshold)
			standing = true;
		animator.SetBool("Running",running);
		animator.SetBool ("Standing", standing);
	}
}
