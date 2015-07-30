using UnityEngine;
using System.Collections;

public class HurtEnemy : MonoBehaviour {
	public int damagetogive;
	public float bounceOnenemy;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Obstacles"){
			other.GetComponent<EnemyHealthManager> ().givedamage (damagetogive);
		transform.parent.GetComponent<Rigidbody2D>().velocity = new Vector2(transform.parent.GetComponent<Rigidbody2D>().velocity.x,bounceOnenemy);
	}
}
}
