using UnityEngine;
using System.Collections;

public class Obstacle : MonoBehaviour {

	public Sprite[] sprites;

	public void Restart(){
		var renderer = GetComponent<SpriteRenderer> ();
		renderer.sprite = sprites[Random.Range(0, sprites.Length)];
	}
	public void Shutdown(){

	}
}
