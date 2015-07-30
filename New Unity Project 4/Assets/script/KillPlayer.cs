using UnityEngine;
using System.Collections;


public class KillPlayer : MonoBehaviour {

	public LevelManager levelmanager;
	public int damagetogive;
	// Use this for initialization
	void Start () {
		levelmanager = FindObjectOfType<LevelManager> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.name=="player"){

			levelmanager.respawnplayer();
			Lifemanager.hurtplayer(damagetogive);
			Destroy(gameObject);

}
	}
}
