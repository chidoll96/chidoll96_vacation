using UnityEngine;
using System.Collections;

public class background : MonoBehaviour {


	public int texturesize =300;
	// Use this for initialization
	void Start () {
	
		var newWidth = Mathf.Ceil (Screen.width / (texturesize * PixelPerfectCamera.scale));
		var newHeight = Mathf.Ceil (Screen.height / (texturesize * PixelPerfectCamera.scale));

		transform.localScale = new Vector3 (newWidth * texturesize, newHeight * texturesize, 1);

		GetComponent<Renderer> ().material.mainTextureScale = new Vector3 (newWidth, newHeight, 1);
	}


}
