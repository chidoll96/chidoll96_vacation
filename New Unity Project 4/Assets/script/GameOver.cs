using UnityEngine;
using System.Collections;

public class GameOver : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	void OnGUI(){
		GUI.contentColor = Color.yellow;
		if(GUI.Button (new Rect(Screen.width/2-50,Screen.height/2 +150,100,40),"Retry?")){
			Application.LoadLevel(1);
	}
		if(GUI.Button (new Rect(Screen.width/2-50,Screen.height/2 +200,100,40),"Quit")){
			Application.Quit();
		}
}
}
