using UnityEngine;
using System.Collections;

public class IntroScript : MonoBehaviour {
	public Texture2D beginSplash;

	[HideInInspector]
	public IntroScript gameDataRef;

	// Use this for initialization
	void Start () {
		//gameDataRef = GetComponent<IntroScript> ();
		//GUI.DrawTexture (new Rect (0, 0, Screen.width, Screen.height), this.gameDataRef.beginSplash, ScaleMode.ScaleToFit);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
