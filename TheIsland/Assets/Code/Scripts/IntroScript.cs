using UnityEngine;
using System.Collections;

public class IntroScript : MonoBehaviour {
	public bool isQuit = false;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseEnter(){
		renderer.material.color = Color.red;
	}

	void OnMouseExit(){
		renderer.material.color = Color.white;
	}

	void OnMouseDown(){
		if (isQuit) {
			Debug.Log("On quit");
			Application.Quit ();
		} else {
			// Application.LoadLevel(1); Make sure that level "1" is located in your build settings. You can also change the 1 with a name of your scene.
		}

	}
}
