using UnityEngine;
using System.Collections;

public class Jump : MonoBehaviour {

	public float jumpSpeed = 240f;
	private Rigidbody2D body2d;
	private InputState inputState;
	public Transform groundCheck;
	public float groundCheckRadius;
	public LayerMask whatisground;
	private bool grounded;
	public bool doublejumped;

	void Awake(){
		body2d = GetComponent<Rigidbody2D> ();
		inputState = GetComponent<InputState> ();
	}
	void FixedUpdate(){
		grounded = Physics2D.OverlapCircle (groundCheck.position, groundCheckRadius, whatisground);
	}
	// Update is called once per frame
	void Update () {
		if (grounded)
			doublejumped = false;
		if(grounded &&inputState.actionButton){
			body2d.velocity = new Vector2(0,jumpSpeed);
	}
		if(!doublejumped &&!grounded &&inputState.actionButton){
			body2d.velocity = new Vector2(0,jumpSpeed);
			doublejumped = true;
		}
	}

}