using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Lifemanager : MonoBehaviour {
	public int maxplayerhealth;
	public static int playerhealth;
	Text text;
	private LevelManager levelmanager;
	// Use this for initialization
	void Start () {
		text = GetComponent<Text> ();
		playerhealth = maxplayerhealth;
		levelmanager = FindObjectOfType<LevelManager> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (playerhealth <= 0) {
			Application.LoadLevel (2);
			return;
		}
		text.text = "" + playerhealth;
	
	}
	public static void hurtplayer(int damageTogive)
	{
		playerhealth -= damageTogive;
	}
	public void Fullhealth()
	{
		playerhealth = maxplayerhealth;
	}
}
