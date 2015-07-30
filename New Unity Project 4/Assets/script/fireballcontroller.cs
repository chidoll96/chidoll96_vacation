using UnityEngine;
using System.Collections;

public class fireballcontroller : MonoBehaviour {
	public float speed;
	public playercontroller player;
	public GameObject enemyDeathEffect;
	public int pointsforkill;
	public int damagetogive;
	// Use this for initialization
	void Start () {
		player = FindObjectOfType<playercontroller> ();
	}
	// Update is called once per frame
	void Update () {
		GetComponent<Rigidbody2D> ().velocity = new Vector2 (speed, GetComponent<Rigidbody2D> ().velocity.y);         
	}
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Obstacles") {

			//Destroy(other.gameObject);
			//scoremanager.AddPoints(pointsforkill);
			other.GetComponent<EnemyHealthManager>().givedamage(damagetogive);
		}
		Destroy (gameObject);
	}
}
