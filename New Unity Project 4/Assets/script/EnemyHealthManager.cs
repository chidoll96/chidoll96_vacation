using UnityEngine;
using System.Collections;

public class EnemyHealthManager : MonoBehaviour {

	public int enemyHealth;
	public int pointsonDeath;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	if (enemyHealth <= 0) {
			Destroy(gameObject);
			scoremanager.AddPoints(pointsonDeath);
		}
	}

	public void givedamage(int damagetogive)
	{
		enemyHealth -= damagetogive;
	}
}
