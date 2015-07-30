using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {
	public GameObject currentcheckpoint;
	public playercontroller player;
	// Use this for initialization
	void Start () {
		player = FindObjectOfType<playercontroller> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void respawnplayer()
	{
		Debug.Log ("player respawn");
		player.transform.position = currentcheckpoint.transform.position;
}
}
