using UnityEngine;
using System.Collections;

public class IntroScript : MonoBehaviour {
	public bool isQuit = false;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame changes
	void Update () {

	}

	void OnMouseEnter(){
		renderer.material.color = Color.red;
	}

	void OnMouseExit(){
		renderer.material.color = Color.white;
	}

	void OnMouseDown(){
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit hit;
		if (Physics.Raycast (ray, out hit, 100)) {

			if (hit.transform.gameObject.name.Equals ("Exit")) {
				Application.Quit();
			} else if (hit.transform.gameObject.name.Equals ("Play")) {
				Application.LoadLevel(1); 
				//Make sure that level "1" is located in your build settings. You can also change the 1 with a name of your scene.
			}

		}

	}
}
