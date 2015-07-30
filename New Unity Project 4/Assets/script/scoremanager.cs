using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class scoremanager : MonoBehaviour {
	public static int score;
	Text text;
	// Use this for initialization
	void Start () {
		text = GetComponent<Text> ();
		score = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if (score < 0)
			score = 0;
		text.text = "" + score;
	}
	public static void AddPoints (int pointstoadd)
	{
		score += pointstoadd;
	}
	public static void reset()
	{
		score = 0;
	}

}
